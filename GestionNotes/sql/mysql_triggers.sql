drop trigger if exists calc_moyenne_insert;
DELIMITER $$

CREATE TRIGGER calc_moyenne_insert AFTER insert on note FOR EACH ROW
BEGIN
  DECLARE code_fil varchar(255);
  DECLARE niveau integer;
  DECLARE fil_id integer;
  DECLARE elv_id integer;
  select code_fil, niveau, f.id, e.id into @code_fil, @niveau, @fil_id, @elv_id from eleve e, filiere f where e.code = new.code_elv and f.code = e.code_fil;

  INSERT INTO moyenne(id, niveau,code_elv, code_fil, moyenne) 
  select * from (
    select e.id, e.niveau, new.code_elv, e.code_fil, avg(n.note) as moy
    from eleve e, note n
    where e.code = new.code_elv
    and n.code_elv = e.code
    group by e.code, e.niveau) as moyT
  ON DUPLICATE KEY UPDATE moyenne = moyT.moy;
   
  UPDATE eleve e 
    SET e.niveau = e.niveau + 1 
    WHERE e.code = new.code_elv 
    and (select m.moyenne FROM moyenne m WHERE m.id = e.id and m.niveau = e.niveau) >= 12 
    and (SELECT count(*) FROM note WHERE code_elv = new.code_elv) = (SELECT count(m.id) from matiere m,module mo where m.code_mod = mo.code and mo.code_fil = e.code_fil and e.code = new.code_elv and e.niveau = mo.niveau);

END $$
DELIMITER ;


drop trigger if exists calc_moyenne_update;
DELIMITER $$

CREATE TRIGGER calc_moyenne_update AFTER update on note FOR EACH ROW
BEGIN
  DECLARE code_fil varchar(255);
  DECLARE niveau integer;
  DECLARE fil_id integer;
  DECLARE elv_id integer;
  select code_fil, niveau, f.id, e.id into @code_fil, @niveau, @fil_id, @elv_id from eleve e, filiere f where e.code = new.code_elv and f.code = e.code_fil;

  INSERT INTO moyenne(id, niveau,code_elv, code_fil, moyenne) 
  select * from (
    select e.id, e.niveau, new.code_elv, e.code_fil, avg(n.note) as moy
    from eleve e, note n
    where e.code = new.code_elv
    and n.code_elv = e.code
    group by e.code, e.niveau) as moyT
  ON DUPLICATE KEY UPDATE moyenne = moyT.moy;
   
  UPDATE eleve e 
    SET e.niveau = e.niveau + 1 
    WHERE e.code = new.code_elv 
    and (select m.moyenne FROM moyenne m WHERE m.id = e.id and m.niveau = e.niveau) >= 12 
    and (SELECT count(*) FROM note WHERE code_elv = new.code_elv) = (SELECT count(m.id) from matiere m,module mo where m.code_mod = mo.code and mo.code_fil = e.code_fil and e.code = new.code_elv and e.niveau = mo.niveau);

END $$
DELIMITER ;


drop trigger if exists calc_moyenne_delete;
DELIMITER $$

CREATE TRIGGER calc_moyenne_delete AFTER delete on note FOR EACH ROW
BEGIN
  DECLARE code_fil varchar(255);
  DECLARE niveau integer;
  DECLARE fil_id integer;
  DECLARE elv_id integer;
  select code_fil, niveau, f.id, e.id into @code_fil, @niveau, @fil_id, @elv_id from eleve e, filiere f where e.code = old.code_elv and f.code = e.code_fil;

  INSERT INTO moyenne(id, niveau,code_elv, code_fil, moyenne) 
  select * from (
    select e.id, e.niveau, old.code_elv, e.code_fil, avg(n.note) as moy
    from eleve e, note n
    where e.code = old.code_elv
    and n.code_elv = e.code
    group by e.code, e.niveau) as moyT
  ON DUPLICATE KEY UPDATE moyenne = moyT.moy;
   
  UPDATE eleve e 
    SET e.niveau = e.niveau + 1 
    WHERE e.code = old.code_elv 
    and (select m.moyenne FROM moyenne m WHERE m.id = e.id and m.niveau = e.niveau) >= 12 
    and (SELECT count(*) FROM note WHERE code_elv = old.code_elv) = (SELECT count(m.id) from matiere m,module mo where m.code_mod = mo.code and mo.code_fil = e.code_fil and e.code = old.code_elv and e.niveau = mo.niveau);

END $$
DELIMITER ;