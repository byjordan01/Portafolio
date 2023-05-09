create database Gab_Abogado_MichaelJordan_Proyecto2

use Gab_Abogado_MichaelJordan_Proyecto2

--Creacion de las Tablas Procurador, Cliente, Asunto

create table Procurador(
codprocurador varchar(4) primary key not null,
nombre varchar(50) not null,
DNI varchar(11) not null,
direccion varchar(50) not null,
telefono varchar(9) not null
)

create table Cliente(
codcliente varchar(4) primary key not null,
nombre varchar(50) not null,
DNI varchar(11) not null,
direccion varchar(50) not null,
telefono varchar(9) not null
)

create table Asunto(
idcliente varchar(4) not null constraint Asunto_idcliente_fk foreign key(idcliente) references Cliente(codcliente),
descripcion varchar(50) not null,
fecha_inicio varchar(9) not null,
fecha_finalizacion varchar(9) not null,
estado varchar(15) not null,
idprocurador varchar(4) not null constraint Asunto_idprocurador_fk foreign key(idprocurador) references Procurador(codprocurador)
)


--Los insert a las tablas

insert into Procurador values 
--(codprocurador, nombre, DNI,  direccion, telefono)
('20', 'Patricia del Rosario', '7-456-879', 'Calle Leonardo da Vinci, 7, 41092.', '6325-7415'),
('25', 'Jorge de la Cruz', '8-574-621', 'Calle San Carlos entre Gacel y Horrutinier.', '7562-5789'),
('30', 'María del Carmen', '9-781-1420', 'Calle Serrano Galvache, 56.','8951-4576'),
('35', 'Juan de Dios', '4-576-213', 'Calle La Laja, 1 - una calle paralela al paseo.', '1246-7534'),
('40', 'María de los Ángeles', '5-716-2036', 'Calle Las Ninfas No. 18, esquina con Los Helios.', '3478-5920')

insert into Cliente values
--(codcliente, nombre, DNI, direccion, telefono)
('1', 'Gabriel del Cristo', '3-145-8710', 'Calle de Velázquez, 80 Madrid.', '2014-6870'),
('2', 'Juana de la Santísima Cruz', '2-478-0478', 'Calle 12 entre 51 y 53.', '0348-9540'),
('3', 'Tatiana de las Mercedes', '1-025-7041', 'Calle Puerta de Granada, 19, 18690.', '9719-0179'),
('4', 'Sara del Mar', '0-124-8921', 'Calle Luis de Morales, 2.', '0147-8601'),
('5', 'Carlos Stark', '9-874-5203', 'Avenida Miraflores', '6598-6369')

insert into Asunto values
--(idcliente, descripcion, fecha_inicio, fecha_finalizacion, estado, idprocurador)
('1', 'Incumplimiento de Contrato', '2005-1-30', '2005-6-2', 'archivado', '20'),
('2', 'Pago de Pension', '2006-2-19', '2009-7-11', 'archivado', '25'),
('3', 'Divorcio', '2012-3-8', '', 'en tramite', '35'),
('4', 'Falla Penal', '2015-4-2', '2020-9-15', 'archivado', '20'),
('5', 'Despido Injustificado', '2017-5-5', '', 'en tramite', '25')



select * from Procurador
select * from Cliente
select * from Asunto

--Inner join a las talbas Cliente, Asunto y Procurador

select  Cliente.nombre, Cliente.DNI, Cliente.telefono, Cliente.direccion, Cliente.codcliente, Asunto.idcliente, 
Asunto.descripcion, Asunto.estado, Asunto.fecha_inicio, Asunto.fecha_finalizacion, Asunto.idprocurador, 
Procurador.codprocurador, Procurador.nombre,  Procurador.DNI, Procurador.telefono, Procurador.direccion
from Cliente inner join Asunto on Cliente.codcliente = Asunto.idcliente 
			 inner join Procurador on Asunto.idprocurador = Procurador.codprocurador

--inner join para verificar los datos a los que el codprocurado esta asociado
select Procurador.codprocurador, Procurador.nombre, Procurador.DNI, Asunto.descripcion,
Asunto.idcliente, Cliente.nombre, Cliente.DNI, Asunto.estado, Asunto.fecha_inicio, Asunto.fecha_finalizacion
from Procurador inner join Asunto on Procurador.codprocurador = Asunto.idprocurador
			 inner join Cliente on Asunto.idcliente = Cliente.codcliente
			 where codprocurador = '25'

--ejemplo del update para visual studio
update Asunto
set fecha_finalizacion = '2012-4-10'
where idcliente= '3'
select * from Asunto

update Asunto
set estado = 'en tramite'
where idcliente= '3'
select * from Asunto