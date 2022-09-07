create database BancoFundido$GGAL
go
use BancoFundido$GGAL
go

create table Tipocuentas(
id_tc int not null,
nombre varchar(50) not null,
constraint pk_TipoCuentas primary key (id_tc))

create table Clientes(
nro_cliente int identity(1,1) not null,
dni int not null,
nombre varchar(50) not null,
apellido varchar(80) not null,
constraint pk_Clientes primary key (nro_cliente))

create table Cuentas(
cbu int not null,
saldo decimal(10,2) not null,
id_tc int not null,
ultimoMovimiento datetime,
nro_cliente int not null,
constraint pk_Cuentas primary key (cbu),
constraint fk_Cuentas_TipoCuentas foreign key (id_tc)
	references TipoCuentas(id_tc),
constraint fk_Cuentas_Clientes foreign key (nro_cliente)
	references Clientes(nro_cliente))




insert into Tipocuentas
Values(0, 'Corriente'),
(1,'Caja de ahorro'),
(2,'Cuenta sueldo'),
(3,'Cuenta seguridad social')

insert into Clientes
Values(38724378,'Juan','Cremona'),
(39235641,'Lautaro','Correa'),
(40802463,'Agostina','Acosta'),
(39536492,'Sofia','Chiaraviglio')




------------------------------------


create procedure buscar_cliente
@dni int,
@nro_cliente int output ,
@nombre nvarchar(100) output,
@apellido nvarchar(100) output
as
set @nro_cliente = (select nro_cliente
from Clientes
where @dni = dni)
set @nombre = (select nombre
from Clientes
where @dni = dni)
set @apellido = (select apellido
from Clientes
where @dni = dni)

declare @n int, @nom nvarchar(100), @ape nvarchar(100)
exec buscar_cliente 38724378, @n output, @nom output, @ape output 
select @n as jaja_cliente, @nom as jaja_nombre, @ape as jaja_apellido



----------------------------------------------
create procedure cargar_combo
as
begin
select *
from Tipocuentas
end


---------------------------------------------

create proc cuentas_cliente_nuevo
@dni int,
@nombre nvarchar(30),
@apellido nvarchar(60),
@posicion int output
as
begin
insert into Clientes
values(@dni,@nombre,@apellido)
set @posicion = (
select top 1 nro_cliente
from Clientes
order by nro_cliente desc)
end
-------------------

create proc cliente_nuevo_suscuentas
@cbu int,
@saldo decimal(10,2),
@tipoDeCuenta int,
@ultimoMov Datetime,
@nroCliente int
as
begin
insert into Cuentas
values(@cbu,@saldo,@tipoDeCuenta,@ultimoMov,@nroCliente)
end
---------------------------------

create procedure buscar_nrocliente_existente
@dni int,
@nro_cliente int output
as
begin
set @nro_cliente = (
select nro_cliente
from Clientes
where @dni = dni)
end

select * from cuentas


-------------------------------------------
create procedure buscarCuentas
@nroCliente int
as
begin
select *
from Cuentas
where nro_cliente = @nroCliente
end

---------------------------

create procedure eliminarCuenta
@cbu int
as
begin
delete Cuentas
where cbu = @cbu
end
