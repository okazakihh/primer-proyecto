create database cobros
use cobros
go
create table Datos
(
Cedula int not null,
Nombre varchar(30) not null,
Apellido varchar(30)not null,
Fecha date not null,
Valor int not null,
);

select *from Datos