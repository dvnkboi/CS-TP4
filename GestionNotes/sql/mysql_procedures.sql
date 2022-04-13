drop PROCEDURE if exists insert_eleve;
DELIMITER $$ 
Create PROCEDURE insert_eleve(
    IN id int,
    IN code varchar(255),
    IN nom varchar(255),
    IN prenom varchar(255),
    IN niveau varchar(255),
    IN code_fil varchar(255)
  ) 
BEGIN
  INSERT INTO
    eleve
  VALUES(id, code, nom, prenom, niveau, code_fil);
end $$ 
DELIMITER ;

drop PROCEDURE if exists update_eleve;

DELIMITER $$ 
Create PROCEDURE update_eleve(
  IN id int,
  IN code varchar(255),
  IN nom varchar(255),
  IN prenom varchar(255),
  IN niveau varchar(255),
  IN code_fil varchar(255)
) 
BEGIN
  UPDATE
    eleve e
  SET
    code = code,
    nom = nom,
    prenom = prenom,
    niveau = niveau,
    code_fil = code_fil
  WHERE
    e.id = id;
end $$ 
DELIMITER ;

drop procedure if exists delete_eleve;
DELIMITER $$ 
Create PROCEDURE delete_eleve(IN id int) BEGIN
  delete from
    eleve e
  where
    e.id = id;
end $$ 
DELIMITER ;