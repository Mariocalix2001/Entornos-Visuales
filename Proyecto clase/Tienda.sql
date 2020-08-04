create database TiendaIIIP;

use TiendaIIIP;

create table usuario(
idUsuario int primary key not null,
nombre varchar(25) not null,
apellido varchar(25) not null,
nombreUsuario nvarchar(25) not null,
psw varchar(25) not null,
rol varchar(15) not null,
estado char(20) not null,
correo nvarchar(50) not null
);

select * from usuario;

--------- PROCEDIMIENTOS ALMACENADOS ------------------------
create procedure insertarUsuario 
	@idUsuario int, @nombre varchar(25),
	@apellido varchar(25), @userName nvarchar(25),
	@psw varchar(25), @rol char(15), @estado char(20), 
	@correo varchar(50)
	as begin
		if exists (select nombreUsuario from usuario where nombreUsuario=@userName and estado='activo')
		raiserror ('Ya existe un registro con ese usuario, porfavor ingrese uno nuevo',16,1)
		else
		insert into usuario values(@idUsuario, @nombre, @apellido, @userName,@psw, @rol, @estado, @correo) 
	end

execute insertarUsuario 1,'Hugo','Murillo','hmurillo','123','admin','activo','hmurillo464@hotmail.com'
execute insertarUsuario 2,'Oscar','Orellana','OscarO','456','dise�ador','activo','oscarO123@hotmail.com'


------------UPDATE-------------------------------------
create procedure modificarUsuario
       -- dejamos valores modificables y el ID
       @idUsuario as int, @nombre as varchar(25), @apellido as varchar(25), @userName as varchar(25), @psw as nvarchar(25), @rol as varchar(15), @correo as nvarchar(50)
       as begin
	   if exists(select nombreUsuario, idUsuario, estado from usuario where (nombreUsuario = @userName and idUsuario=@idUsuario and estado = 'activo'))
	   raiserror('Usuario esta en uso, utilizar otro por favor',16,1)
	   else
	   update usuario set nombre = @nombre, apellido = @apellido, psw = @psw, rol = @rol, correo = @correo
	   where idUsuario = @idUsuario
end

-- Como encriptar una base de datos y conectar a visual y agregar correo despues de rol

-------DELETE------------------------------------------
create procedure eliminarUsuario
@idUsuario int,@rol varchar(15)
as begin
      if exists (select nombreUsuario from usuario where @rol = 'admin')
	    raiserror('El usuario Admin no puede ser eliminado',16,1)
	   else
	   update usuario set estado = 'eliminado'
	   where idUsuario = @idUsuario and rol <> 'admin'
end


----------BUSCAR USUARIO --------------------------
create procedure buscarUsuario
@UserName varchar(25)
as
select CONCAT(nombre,' ',apellido) as 'Nombre Completo',nombreUsuario as 'Usuario',rol as 'Rol',estado as 'Estado',correo as 'Correo'
From usuario
where nombreUsuario like '%' +@UserName+ '%'