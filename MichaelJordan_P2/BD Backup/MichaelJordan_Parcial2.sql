create database Nota_Estudiante

use Nota_Estudiante

create table DatosGenerales(
codestu varchar(2) primary key not null,
cedula varchar(11) not null,
nombre varchar(15) not null,
apellido varchar(15) not null
)

create table NotasDeExamenes(
codnotas varchar(2) constraint NotasDeExamnes_codnotas_fk foreign key(codnotas) references DatosGenerales(codestu),
parcial_1 int,
parcial_2 int,
parcial_3 int
)

insert into DatosGenerales values
--(codestu, cedula, nombre, apellido)
('1', '1-111-1111', 'Carlos', 'Perez'),
('2', '2-222-2222', 'Ana', 'Gonzales'),
('3', '9-475-2358', 'Sara', 'Fernandez')

insert into NotasDeExamenes values
--(codnotas, parcial_1, parcial_2, parcial_3)
('1', '100', '100', '100'),
('2', '95', '84', '73'),
('3', '91', '88', '79')

select DatosGenerales.codestu, DatosGenerales.cedula, 
DatosGenerales.nombre, DatosGenerales.apellido, NotasDeExamenes.parcial_1, 
NotasDeExamenes.parcial_2, NotasDeExamenes.parcial_3
from DatosGenerales inner join NotasDeExamenes on DatosGenerales.codestu = NotasDeExamenes.codnotas


select DatosGenerales.codestu, DatosGenerales.cedula, DatosGenerales.nombre, DatosGenerales.apellido,
NotasDeExamenes.parcial_1, NotasDeExamenes.parcial_2, NotasDeExamenes.parcial_3
from DatosGenerales inner join NotasDeExamenes on DatosGenerales.codestu = NotasDeExamenes.codnotas
where codestu = '1'


select * from DatosGenerales
select * from NotasDeExamenes

drop table NotasDeExamenes, DatosGenerales