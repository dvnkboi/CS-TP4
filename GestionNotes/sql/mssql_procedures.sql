drop PROCEDURE if exists insert_eleve;
drop PROCEDURE if exists update_eleve;
drop procedure if exists delete_eleve;

GO
Create PROCEDURE insert_eleve
    @id int,
    @code varchar(255),
    @nom varchar(255),
    @prenom varchar(255),
    @niveau varchar(255),
    @code_fil varchar(255)
AS 
    Begin
      INSERT INTO
        eleve
      VALUES(@id, @code, @nom, @prenom, @niveau, @code_fil)
    end
GO

GO
Create PROCEDURE update_eleve
  @id int,
  @code varchar(255),
  @nom varchar(255),
  @prenom varchar(255),
  @niveau varchar(255),
  @code_fil varchar(255)
AS
    BEGIN
      UPDATE
        e
      SET
        e.code = @code,
        e.nom = @nom,
        e.prenom = @prenom,
        e.niveau = @niveau,
        e.code_fil = @code_fil
      FROM eleve e
      WHERE
        e.id = @id;
    end 
GO

GO
Create PROCEDURE delete_eleve @id int 
AS
    BEGIN
      delete e 
        from eleve e
      where
        e.id = @id;
    end
GO