use bdCentenario
go
----------- [INSERTAR DETALLE COMPRA] -------------
If object_id('InsertarDetalle_Compra') is not null
drop proc   InsertarDetalle_Compra
go

----------- [INSERTAR COMPRA] -------------
If object_id('InsertarCompra') is not null
drop proc InsertarCompra
go
Create proc InsertarCompra
@compID as int,
@compTotal as decimal(18,0),
@compFecha as date,
@compCondicionPag as varchar(50),
@compNumeroFactura as varchar(15) ,
@provID as int
as
Insert into Compra(compID,compTotal,compFecha,compCondicionPag,compNumeroFactura,provID) values(@compID,@compTotal, @compFecha, @compCondicionPag,@compNumeroFactura,@provID )
go

---------------INsera detalle compra---
If object_id('InsertarDetalle_Compra') is not null
drop proc InsertarDetalle_Compra
go
Create proc InsertarDetalle_Compra
@compID as int,
@prodID as int,
@dComCantidad as decimal(18,0),
@dCompUnit as decimal(18,0),
@dComDescuento as decimal (18,0)
as
Insert into Detalle_Compra(compID,prodID,dComCantidad,dCompUnit,dComDescuento) values(@compID,@prodID,@dComCantidad,@dCompUnit,@dComDescuento)
go



----------- [BUSCAR CLIENTE] -------------
If object_id('BuscarProveedorxDNI')is not null
drop proc   BuscarProveedorxDNI
go
Create proc BuscarProveedorxDNI
@provDNI as varCHAR(8)
as
Select * from Proveedor where provDNI =@provDNI
go

If object_id('BuscarProveedorxRUC')is not null
drop proc   BuscarProveedorxRUC
go
Create proc BuscarProveedorxRUC
@ProvRUC as CHAR(14)
as
Select * from Proveedor where provRuc =@ProvRUC	
go


If object_id('generaCodigoCompra') is not null
drop proc   generaCodigoCompra
go
Create proc generaCodigoCompra
as
if not exists (select * from Compra )
	select 0
else
select top 1 compID  from Compra order by 1 desc
go

If object_id('ConsultarProductoxCat_Nom')is not null
drop proc   ConsultarProductoxCat_Nom
go
Create proc ConsultarProductoxCat_Nom
@catID as int,
@prodNom as varchar(70)
as 
Select * from Producto where catID = @catID and prodNom like @prodNom + '%'
go

If object_id('ConsultarCompra')is not null
drop proc   ConsultarCompra
go
Create proc ConsultarCompra
as 
Select c.compID,c.compTotal, c.compFecha, c.compCondicionPag, c.compNumeroFactura, c.provID from Compra c join Proveedor p on p.provID = c.provID
go 

----------- [CONSULTAR DETALLE - BOLETA] -------------
If object_id('ConsultarDetalle_Compra')is not null
drop proc   ConsultarDetalle_Compra
go
Create proc ConsultarDetalle_Compra
@comID as int
as 
Select dc.compID, dc.prodID, dc.dComCantidad, dc.dCompUnit, dc.dComDescuento from Detalle_Compra dc join Producto p on dc.prodID=p.prodID where dc.compID =@comID
go

If object_id('Consulta_Boleta_Cliente')is not null
drop proc   Consulta_Boleta_Cliente
go
Create proc Consulta_Boleta_Cliente
@clienteID as int 
as
Select 
b.bolID, b.bolFecha, db.prodID,p.prodNom, db.cantidad,db.punit , 
 (db.cantidad * db.punit ) as total
from 
boleta b inner join Detalle_Boleta db on b.bolID = db.bolID inner join Producto p on
 db.prodID=p.prodID 
 where cliID  = @clienteID 
 go



