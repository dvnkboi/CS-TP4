drop trigger if exists calc_moyenne_insert;
go
create trigger calc_moyenne_insert
on note
after insert, update as
begin
  
  declare @code_fil varchar(255);
  declare @niveau int;
  declare @fil_id int;
  declare @elv_id int;
  declare @val_moy float;
  declare @code_elv varchar(255);
  begin
    Select TOP (1) @code_elv = code_elv from INSERTED;

    select
      @code_fil = e.code_fil,
      @niveau = e.niveau,
      @fil_id = f.id,
      @elv_id = e.id
    from
      eleve e,
      filiere f
    where (
      e.code = @code_elv
      and f.code = e.code_fil
    );

    select @val_moy = avg(n.note)
    from eleve e, note n
    where e.code = @code_elv and e.code = n.code_elv
    group by e.code, e.niveau;


    IF EXISTS (SELECT 1 FROM moyenne WHERE niveau = @niveau and code_elv = @code_elv)
    BEGIN
        UPDATE m
        SET    moyenne = @val_moy
        from
            moyenne m
            where m.code_elv = @code_elv and m.niveau = @niveau;
    END
    ELSE
    BEGIN
        insert into moyenne
            select * from
                (select
                e.id,
                e.niveau,
                e.code,
                e.code_fil,
                avg(n.note) moy
                from
                eleve e,
                note n
                where e.code = @code_elv and n.code_elv = e.code
                group by e.id, e.niveau, e.code, e.code_fil
            ) moyT;
    END

    update e
    set
      e.niveau = (e.niveau + 1)
    from eleve e
    where (
      e.code = @code_elv
      and (
        select m.moyenne
        from moyenne m
        where (
          m.id = e.id
          and m.niveau = e.niveau
        )
      ) >= 12
      and (
        select count(*)
        from note n
        where n.code_elv = @code_elv
      ) = (
        select count(m.id)
        from
          matiere m,
          module mo
        where (
          m.code_mod = mo.code
          and mo.code_fil = e.code_fil
          and e.code = @code_elv
          and e.niveau = mo.niveau
        )
      )
    );
  end;
end;;

go


drop trigger if exists calc_moyenne_delete;
go
create trigger calc_moyenne_delete
on note
after delete as
begin
  
  declare @code_fil varchar(255);
  declare @niveau int;
  declare @fil_id int;
  declare @elv_id int;
  declare @val_moy float;
  declare @code_elv varchar(255);
  begin
    Select TOP (1) @code_elv = code_elv from DELETED;

    select
      @code_fil = e.code_fil,
      @niveau = e.niveau,
      @fil_id = f.id,
      @elv_id = e.id
    from
      eleve e,
      filiere f
    where (
      e.code = @code_elv
      and f.code = e.code_fil
    );

    select @val_moy = avg(n.note)
    from eleve e, note n
    where e.code = @code_elv and e.code = n.code_elv
    group by e.code, e.niveau;


    IF EXISTS (SELECT 1 FROM moyenne WHERE niveau = @niveau and code_elv = @code_elv)
    BEGIN
        UPDATE m
        SET    moyenne = @val_moy
        from
            moyenne m
            where m.code_elv = @code_elv and m.niveau = @niveau;
    END
    ELSE
    BEGIN
        insert into moyenne
            select * from
                (select
                e.id,
                e.niveau,
                e.code,
                e.code_fil,
                avg(n.note) moy
                from
                eleve e,
                note n
                where e.code = @code_elv and n.code_elv = e.code
                group by e.id, e.niveau, e.code, e.code_fil
            ) moyT;
    END

    update e
    set
      e.niveau = (e.niveau + 1)
    from eleve e
    where (
      e.code = @code_elv
      and (
        select m.moyenne
        from moyenne m
        where (
          m.id = e.id
          and m.niveau = e.niveau
        )
      ) >= 12
      and (
        select count(*)
        from note n
        where n.code_elv = @code_elv
      ) = (
        select count(m.id)
        from
          matiere m,
          module mo
        where (
          m.code_mod = mo.code
          and mo.code_fil = e.code_fil
          and e.code = @code_elv
          and e.niveau = mo.niveau
        )
      )
    );
  end;
end;;

go