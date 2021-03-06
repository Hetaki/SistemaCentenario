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
@compTotal as decimal(18,2),
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
@dCompUnit as decimal(18,2),
@dComDescuento as decimal (18,2)
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
b.bolID,c.cliNomAp,c.cliDir, b.bolFecha, db.prodID,p.prodNom, db.cantidad,db.punit , 
 (db.cantidad * db.punit ) as total
from 
boleta b inner join Detalle_Boleta db on b.bolID = db.bolID inner join Producto p on
 db.prodID=p.prodID inner join Cliente c on b.cliID=c.cliID
 where b.cliID  = @clienteID 
 go

If object_id('Consulta_Factura_Cliente')is not null
drop proc   Consulta_Factura_Cliente
go
Create proc Consulta_Factura_Cliente
@clienteID as int 
as
Select 
f.facID,c.cliNomAp,c.cliDir, f.facFecha, df.prodID,p.prodNom, df.Cant,df.punit , 
  ((df.Cant * df.punit)+((df.Cant * df.punit)* 0.18 )) as total
from 
factura f inner join Detalle_Factura df on f.facID = df.facID inner join Producto p on
 df.prodID=p.prodID inner join Cliente c on f.cliID=c.cliID
 where f.cliID  = @clienteID 
 go

If object_id('Consulta_Pedido_Cliente')is not null
drop proc   Consulta_Pedido_Cliente
go
Create proc Consulta_Pedido_Cliente
@clienteID as int 
as
Select 
pd.pedID,c.cliNomAp,c.cliDir, pd.pedFecha, dp.prodID,p.prodNom, dp.cantidad,dp.punit , 
 (dp.cantidad * dp.punit ) as total
from 
Pedido pd inner join Detalle_Pedido dp on pd.pedID = dp.pedID inner join Producto p on
 dp.prodID=p.prodID inner join Cliente c on pd.cliID=c.cliID
 where pd.cliID  = @clienteID 
 go


 If object_id('Consulta_Compra_Proveedor')is not null
drop proc   Consulta_Compra_Proveedor
go
Create proc Consulta_Compra_Proveedor
@proveedorID as int 
as
Select 
pv.provID, pv.provNom, pv.provTelf, pv.provRuc, pv.provDNI,
c.compID, c.compFecha, dc.prodID,p.prodNom, dc.dComCantidad,dc.dCompUnit , dc.dComDescuento, 
 ((dc.dComCantidad * dc.dCompUnit)- dc.dComDescuento  ) as total
from 
 compra c  inner join Detalle_Compra dc on c.compID = dc.compID inner join Producto p on
 dc.prodID=p.prodID inner join Proveedor pv on c.provID  = pv.provID
where  pv.provID = @proveedorID
 go
 
  If object_id('Reporte_Venta_Fecha')is not null
drop proc   Reporte_Venta_Fecha
go
Create proc Reporte_Venta_Fecha
@desde as date,
@hasta as date
as
SELECT dbo.Boleta.bolID, sum(dbo.Boleta.bolTotal),  dbo.Pedido.pedID, sum(dbo.Pedido.pedTotal),dbo.Factura.facID, sum(dbo.Factura.facSubtotal)
FROM dbo.Boleta CROSS JOIN
  dbo.Factura CROSS JOIN
  dbo.Pedido
  where dbo.boleta.bolFecha between @desde and @hasta  and dbo.Pedido.pedFecha between @desde and @hasta and dbo.Factura.facFecha between @desde and @hasta 
  group by 
cube ( dbo.Boleta.bolID , dbo.Pedido.pedID , dbo.Factura.facID )
  go

If object_id('Reporte_Boleta_Fecha')is not null
drop proc   Reporte_Boleta_Fecha
go
Create proc Reporte_Boleta_Fecha
@desde as date,
@hasta as date
as
SELECT b.bolID, b.bolTotal
from boleta b
where b.bolFecha between @desde and @hasta 
go
If object_id('Reporte_Factura_Fecha')is not null
drop proc   Reporte_Factura_Fecha
go
Create proc Reporte_Factura_Fecha
@desde as date,
@hasta as date
as
SELECT f.facID , f.facSubtotal 
from Factura f
where f.facFecha  between @desde and @hasta 
go
If object_id('Reporte_pedido_Fecha')is not null
drop proc   Reporte_pedido_Fecha
go
Create proc Reporte_pedido_Fecha
@desde as date,
@hasta as date
as
SELECT p.pedID, p.pedTotal 
from Pedido p
where p.pedFecha  between @desde and @hasta 
go
If object_id('Reporte_Compra_Fecha')is not null
drop proc   Reporte_Compra_Fecha
go
Create proc Reporte_Compra_Fecha
@desde as date,
@hasta as date
as
SELECT  c.compID,c.compTotal
from Compra c
where c.compFecha  between @desde and @hasta 
GO
---Reportes de ventas por fechas 

If object_id('SP_ReporteBoletaFecha')is not null
drop proc   SP_ReporteBoletaFecha
go
Create proc SP_ReporteBoletaFecha
@desde as date,
@hasta as date
as
Select 
b.bolID,c.cliNomAp, b.bolFecha, db.prodID,p.prodNom, db.cantidad,db.punit , 
 (db.cantidad * db.punit ) as total
from Boleta b inner join Cliente c 
on b.cliID  = c.cliID inner join Detalle_Boleta  db
on db.bolID  = b.bolID  inner join producto p
on p.prodID = db.prodID 
where b.bolFecha   between @desde and @hasta  
 go

 If object_id('SP_ReporteFacturaFecha')is not null
drop proc   SP_ReporteFacturaFecha
go
Create proc SP_ReporteFacturaFecha
@desde as date,
@hasta as date
as
select
f.facID,c.cliNomAp, f.facFecha, df.prodID,p.prodNom, df.Cant,df.punit , 
 ((df.Cant * df.punit)+((df.Cant * df.punit)* 0.18 )) as total
from 
factura f inner join Detalle_Factura df on 
f.facID = df.facID inner join Producto p on
 df.prodID=p.prodID inner join Cliente c on 
 f.cliID=c.cliID
where f.facFecha  between @desde and @hasta  
 go

 If object_id('SP_ReportePedidoFecha')is not null
drop proc   SP_ReportePedidoFecha
go
Create proc SP_ReportePedidoFecha
@desde as date,
@hasta as date
as
Select 
pd.pedID,c.cliNomAp, pd.pedFecha, dp.prodID,p.prodNom, dp.cantidad,dp.punit , 
 (dp.cantidad * dp.punit ) as total
from 
Pedido pd inner join Detalle_Pedido dp on pd.pedID = dp.pedID inner join Producto p on
 dp.prodID=p.prodID inner join Cliente c on pd.cliID=c.cliID
where pd.pedFecha  between @desde and @hasta  
 go

----Insertando super usuario
insert into Usuario values ('47318623','Jason Fuentes Caldas', 'cfaj92@gmail.com','944747208','admin','admin',1)


