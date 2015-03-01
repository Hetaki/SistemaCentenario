use master
go
if DB_ID('bdCentenario') is not null
	drop database bdCentenario
go
create database bdCentenario
go
use bdCentenario
go
------ [TABLA CARGO] --------
if OBJECT_ID('Cargo') is not null
	drop table Cargo
go
create table Cargo (
[carID] int IDENTITY(1,1) NOT NULL primary key ,
[carDes] VARCHAR(60) NULL,
)
go
------ [TABLA USUARIO] --------
if OBJECT_ID('Usuario') is not null
	drop table Usuario
go
create table Usuario (
[usuID] int IDENTITY(1,1) NOT NULL primary key,
[usuDNI] CHAR(8) NULL,
[usuNomAp] VARCHAR(100) NULL,
[usuCorreo] VARCHAR(100) NULL,
[usuCel] CHAR(11) NULL,
[nick] VARCHAR(50) NULL,
[password] VARCHAR(50) NULL,
[carID] INT NOT NULL references Cargo
)
go
insert into Usuario values('47318623','Jason Fuentes Caldas','cfaj92@gmail.com','944647208','jAdmin','architec!##/150992',1)
select * from Usuario

------ [TABLA CLIENTE] --------
if OBJECT_ID('Cliente') is not null
	drop table Cliente
go
create table Cliente (
[cliID] int IDENTITY(1,1) NOT NULL primary key,
[cliDNI] CHAR(8) NULL,
[cliRUC] CHAR(14) NULL,
[cliNomAp] VARCHAR(100) NULL,
[cliCEl] CHAR(11) NULL,
[cliTelf] CHAR(15) NULL,
[cliDir] VARCHAR(70) NULL,
[cliDirRef] VARCHAR(70) NULL
)
go
------ [TABLA PROVEEDOR] --------
if OBJECT_ID('Proveedor') is not null
	drop table Proveedor
go
create table Proveedor (
[provID] int IDENTITY(1,1) NOT NULL primary key,
[provRuc] CHAR(14) NULL,
[provDNI] CHAR(8) NULL,
[provNom] VARCHAR(100) NULL,
[provDir] VARCHAR(100) NULL,
[provTelf] CHAR(14) NULL,
[provCorreo] VARCHAR(70) NULL
)
go
------ [TABLA CATEGORIA] --------
if OBJECT_ID('Categoria') is not null
	drop table Categoria
go
create table Categoria (
[catID] int IDENTITY(10,1) NOT NULL primary key,
[catDesc] VARCHAR(70) NULL,
)
go
------ [TABLA PRODUCTO] --------
if OBJECT_ID('Producto') is not null
	drop table Producto
go
create table Producto (
[prodID] INT NOT NULL primary key,
[prodNom] VARCHAR(100) NULL,
[prodStock] DECIMAL NULL,
[prodPreCom] DECIMAL NULL,
[prodPreVen] DECIMAL NULL,
[ubicacion] varchar(90) null,
[fechaIngreso] date null,
[catID] INT NOT NULL references Categoria
)
go
------ [TABLA FACTURA] --------
if OBJECT_ID('Factura') is not null
	drop table Factura
go
create table Factura (
[facID] INT NOT NULL primary key,
[facSubtotal] DECIMAL NULL,
[facIGV] DECIMAL NULL,
[facFecha] DATE NULL,
[cliID] INT NOT NULL references Cliente
)
go
------ [TABLA BOLETA] --------
if OBJECT_ID('Boleta') is not null
	drop table Boleta
go
create table Boleta (
[bolID] INT NOT NULL primary key,
[bolTotal] DECIMAL NULL,
[bolFecha] DATE NULL,
[estado] varchar(35) NULL,
[cliID] INT NOT NULL references Cliente
)
go
------ [TABLA PEDIDO] --------
if OBJECT_ID('Pedido') is not null
	drop table Pedido
go
create table Pedido (
[pedID] INT NOT NULL PRIMARY KEY,
[pedTotal] DECIMAL NULL,
[pedFecha] DATE NULL,
[cliID] INT NOT NULL references Cliente
)
go
------ [TABLA COMPRA] --------
if OBJECT_ID('Compra') is not null
	drop table Compra
go
create table Compra (
[compID] INT NOT NULL PRIMARY KEY,
[compTotal] DECIMAL NULL,
[compFecha] date null,
[compCondicionPag] VARCHAR(45) NULL,
[compNumeroFactura] varchar(15) null,
[provID] INT NOT NULL references Proveedor
)
go

------ [TABLA DETALLE-COMPRA] --------
if OBJECT_ID('Detalle_Compra') is not null
	drop table Detalle_Compra
go
create table Detalle_Compra (
[compID] INT NOT NULL references Compra,
[prodID] INT NOT NULL references Producto,
[dCompUnit] VARCHAR(45) NULL,
[dComCantidad] DECIMAL NULL,
[dComDescuento] DECIMAL NULL,
[dComUnidad] VARCHAR(45) NULL,
primary key ([prodID],[compID])
)
go
------ [TABLA DETALLE-FACTURA] --------
if OBJECT_ID('Detalle_Factura') is not null
	drop table Detalle_Factura
go
create table Detalle_Factura (
[facID] INT NOT NULL references Factura,
[prodID] INT NOT NULL references Producto,
[Cant] DECIMAL NULL,
[punit] DECIMAL NULL,
primary key ([prodID],[facID])
)
go
------ [TABLA DETALLE-BOLETA] --------
if OBJECT_ID('Detalle_Boleta') is not null
	drop table Detalle_Boleta
go
create table Detalle_Boleta (
[bolID] INT NOT NULL references Boleta,
[prodID] INT NOT NULL references Producto,
[cantidad] DECIMAL NULL,
[punit] DECIMAL NULL,
primary key ([prodID],[bolID])
)
go
------ [TABLA DETALLE-PEDIDO] --------
if OBJECT_ID('Detalle_Pedido') is not null
	drop table Detalle_Pedido
go
create table Detalle_Pedido (
[pedID] INT NOT NULL references Pedido,
[prodID] INT NOT NULL references Producto,
[cantidad] DECIMAL NULL,
[punit] DECIMAL NULL,
primary key ([prodID],[pedID])
)
go



------------ [INGRESO DE DATOS] --------------------

------------ [DATOS DE CATEGORIA] --------------------
INSERT INTO [Categoria] ([catDesc]) VALUES 
	('conexionCPVC'),
	('conexionPVC'),
	('conexion galvanizada'),
	('conexion bronce'),
	('Lampas'),
	('Ocres'),
	('Lijas'),
	('Pegamentos'),
	('articulos de ferreteria'),
	('calaminas')
GO

------------ [DATOS DE CARGO] --------------------
INSERT INTO [Cargo]([carDes]) VALUES
           ('Administrador'),
		   ('Supervisor'),
		   ('Vendedor')
GO



