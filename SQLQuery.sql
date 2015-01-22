CREATE DATABASE DBPELICULAS

CREATE TABLE TB_PELICULAS
(
	Id		int identity(1,1)	not null,
	Codigo  nvarchar(100) not null,
	Nombre  nvarchar(100) not null,
	Descripcion nvarchar(100) null,
	FechaCreacion date,
	Imagen nvarchar(100),
	constraint PK_Id primary key (Id)
)

create procedure insertar 
(
	@codigo nvarchar,
	@nombre nvarchar(100),
	@descripcion nvarchar(100),
	@fechaCreacion date
	
)
AS
Insert into TB_PELICULAS (Codigo, Nombre, Descripcion, FechaCreacion, Imagen)
values(@codigo, @nombre, @descripcion, @fechaCreacion, null)

create procedure actualizar
(
	@id int,
	@imagen nvarchar(100)
)
AS
Update TB_PELICULAS set imagen = @imagen where id = @id










