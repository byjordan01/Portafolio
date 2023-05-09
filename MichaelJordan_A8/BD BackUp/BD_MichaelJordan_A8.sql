create database MichaelJordan_A8

use MichaelJordan_A8

create table Identificacion
(Cedula varchar(12) primary key,
Nombre varchar(15),
Apellido varchar(15),
Fecha_Nacimiento date,
Profesion varchar(20)
)

insert into Identificacion values
('1-111-1111', 'Antonio', 'Garcia', '1937-10-27', 'Periodista'),
('2-222-2222', 'Maria', 'Martinez', '1951-06-26', 'Abogada'),
('3-333-3333', 'Jose', 'Lopez', '1952-10-16', 'Ingeniero'),
('4-444-4444', 'Maria Carmen', 'Sanchez', '1954-09-30', 'Bióloga'),
('5-555-5555', 'Francisco', 'Gonzalez', '1956-09-20', 'Matemático'),
('6-666-6666', 'Josefa', 'Gomez', '1957-06-26', 'Arquitecta'),
('7-777-7777', 'Juan', 'Fernandez', '1959-02-15', 'Químico'),
('8-888-8888', 'Isabel', 'Moreno', '1959-05-19', 'Electricista'),
('9-999-9999', 'Manuel', 'Jimenez', '1959-10-07', 'Médico Cirujano'),
('10-101-1010', 'Pedro', 'Perez', '1960-07-19', 'Historiador'),
('11-111-1111', 'Carmen', 'Rodriguez', '1962-06-15', 'Socióloga')
---------------------------------------------------


--PA Insertar
---------------------------------------------------
create proc pa_Identificacion_Insertar(
@Ced as varchar(12),
@Nom as varchar(15),
@Ap as varchar(15),
@Fecha as date,
@Prof as varchar(20)
)
as
insert into Identificacion (Cedula, Nombre, Apellido, Fecha_Nacimiento, Profesion)
values(@Ced, @Nom, @Ap, @Fecha, @Prof)
---------------------------------------------------


--PA Consultar
---------------------------------------------------
create proc pa_Identificacion_Consultar(
@Ced as varchar(12) )
as 
select * from Identificacion where Cedula= @Ced
---------------------------------------------------


--PA Actualizar
---------------------------------------------------
create proc pa_Identificacion_Actualizar(
@Ced as varchar(12),
@Nom as varchar(15),
@Ap as varchar(15),
@Fecha as date,
@Prof as varchar(15)
)
as
update Identificacion set Cedula=@Ced, Nombre=@Nom, Apellido=@Ap, 
Fecha_Nacimiento=@Fecha, Profesion=@Prof where Cedula=@Ced
---------------------------------------------------


--PA Eliminar
---------------------------------------------------
create proc pa_Identificacion_Eliminar(
@Ced as varchar(12))
as
delete from Identificacion where Cedula=@Ced