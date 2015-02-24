use bdCentenario
----------- [INSERCIONES] -------------

----------- [INSERTAR CLIENTE] -------------
If object_id('InsertarCliente') is not null
drop proc   InsertarCliente
go
 Create proc InsertarCliente
 @cliDNI as char(10),
 @cliRUC as char(10),
 @cliNomAp as varchar(50),
 @cliCEl as char(11),
 @cliTelf as char(12),
 @cliDir as varchar(50),
 @cliDirRef as varchar(50)
 as
 Insert into Cliente(cliDNI,cliRUC,cliNomAp,cliCEl,cliTelf,cliDir,cliDirRef) values(@cliDNI,@cliRUC,@cliNomAp,@cliCEl,@cliTelf,@cliDir,@cliDirRef)
 go
 ----------- [INSERTAR PRODUCTO] -------------
 If object_id('InsertarProducto') is not null
drop proc   InsertarProducto
go
 Create proc InsertarProducto
 @fechaIng as date,
 @prodID as int,
 @prodNom as varchar(50),
 @prodStock as decimal(18,0),
 @prodPreCom as decimal(18,0),
 @prodPreVen as decimal(18,0),
 @ubicacion as varchar(50),
 @catID as int
 as
 Insert into Producto(fechaIngreso,prodID,prodNom,prodStock,prodPreCom,prodPreVen,ubicacion,catID) values(@fechaIng,@prodID,@prodNom,@prodStock,@prodPreCom,@prodPreVen,@ubicacion,@catID)

 go
  ----------- [INSERTAR PROVEEDOR] -------------
If object_id('InsertarProveedor') is not null
drop proc   InsertarProveedor
go
 Create proc InsertarProveedor
 @provRuc as char(10),
 @provDNI as varchar(50),
 @provNom as varchar(50),
 @provDir as varchar(50),
 @provTelf as char(12),
 @provCorreo as varchar(50)
 as
 Insert into Proveedor(provRuc,provDNI,provNom,provDir,provTelf,provCorreo) values(@provRuc,@provDNI,@provNom,@provDir,@provTelf,@provCorreo)
 go

    ----------- [INSERTAR CATEGORIA] -------------

If object_id('InsertarCategoria') is not null
drop proc   InsertarCategoria
go
Create proc InsertarCategoria
@catDesc as varchar(70)
as
INSERT INTO [Categoria] ([catDesc]) VALUES (@catDesc)
go

----------- [INSERTAR BOLETA] -------------
If object_id('InsertarBoleta') is not null
drop proc   InsertarBoleta
go
Create proc InsertarBoleta
@bolID as int,
@bolTotal as decimal(18,0),
@bolFecha as date,
@cliID as int
as
DECLARE @estado as varchar(50) = 'Por Guardar'
Insert into Boleta(bolID,bolTotal,bolFecha,estado,cliID) values(@bolID,@bolTotal,@bolFecha,@estado,@cliID)
go


----------- [INSERTAR DETALLE BOLETA] -------------
If object_id('InsertarDetalle_Boleta') is not null
drop proc   InsertarDetalle_Boleta
go
Create proc InsertarDetalle_Boleta
@bolID as int,
@prodID as int,
@cantidad as decimal(18,0),
@punit as decimal(18,0)
as
Insert into Detalle_Boleta(bolID,prodID,cantidad,punit) values(@bolID,@prodID,@cantidad,@punit)
go


----------- [INSERTAR FACTURA] -------------
If object_id('InsertarFactura') is not null
drop proc   InsertarFactura
go
Create proc InsertarFactura
@facID as int,
@facSubtotal as decimal(18,0),
@facIGV as decimal(18,0),
@facFecha as date,
@cliID as int
as
Insert into Factura(facID,facSubtotal,facIGV,facFecha,cliID) values(@facID,@facSubtotal,@facIGV,@facFecha,@cliID)
go

----------- [INSERTAR DETALLE FACTURA] -------------
If object_id('InsertarDetalle_Factura') is not null
drop proc   InsertarDetalle_Factura
go
Create proc InsertarDetalle_Factura
@facID as int,
@prodID as int,
@Cant as decimal(18,0),
@punit as decimal(18,0)
as
Insert into Detalle_Factura(facID,prodID,Cant,punit) values(@facID,@prodID,@Cant,@punit)
go

----------- [INSERTAR PEDIDO] -------------
If object_id('InsertarPedido') is not null
drop proc   InsertarPedido
go
Create proc InsertarPedido
@pedID as int,
@pedTotal as decimal(18,0),
@pedFecha as date,
@cliID as int
as
Insert into Pedido(pedID,pedTotal,pedFecha,cliID) values(@pedID,@pedTotal,@pedFecha,@cliID)
go


----------- [INSERTAR DETALLE PEDIDO] -------------
If object_id('InsertarDetalle_Pedido') is not null
drop proc   InsertarDetalle_Pedido
go
Create proc InsertarDetalle_Pedido
@prodID as int,
@cantidad as decimal(18,0),
@punit as decimal(18,0)
as
Insert into Detalle_Pedido(prodID,cantidad,punit) values(@prodID,@cantidad,@punit)
go




 ----------- [INSERTAR USUARIO] -------------
   

If object_id('InsertarUsuario') is not null
drop proc   InsertarUsuario
go
Create proc InsertarUsuario
@usuID as int,
@usuDNI as char(10),
@usuNomAp as varchar(50),
@usuCorreo as varchar(50),
@usuCel as char(10),
@nick as varchar(50),
@password as varchar(50),
@carID as int
as
Insert into Usuario(usuID,usuDNI,usuNomAp,usuCorreo,usuCel,nick,password,carID) values(@usuID,@usuDNI,@usuNomAp,@usuCorreo,@usuCel,@nick,@password,@carID)
go

 if OBJECT_ID('validaUsuario') is not null
	drop proc validaUsuario
go
create proc validaUsuario
@usuario VARCHAR(100),
@password VARCHAR(100)
as

select * from Usuario where [nick] = @usuario and [password] = @password
go

----------- [MODIFICACIONES] -------------

----------- [MODIFICAR CLIENTE] -------------

If object_id('modificarCliente') is not null
drop proc   modificarCliente
go
Create proc modificarCliente
@cliDNI as char(10),
@cliRUC as char(10),
@cliNomAp as varchar(50),
@cliCEl as char(11),
@cliTelf as char(12),
@cliDir as varchar(50),
@cliDirRef as varchar(50),
@cliID as int
as
Update Cliente set cliDNI= @cliDNI,cliRUC= @cliRUC,cliNomAp= @cliNomAp,cliCEl= @cliCEl,cliTelf= @cliTelf,cliDir= @cliDir,cliDirRef= @cliDirRef Where cliID= @cliID
go

----------- [MODIFICAR PRODUCTO] -------------
If object_id('modificarProducto') is not null
drop proc   modificarProducto
go
Create proc modificarProducto
@fechaIng as date,
@prodNom as varchar(50),
@prodStock as decimal(18,0),
@prodPreCom as decimal(18,0),
@prodPreVen as decimal(18,0),
@ubicacion as varchar(50),
@catID as int,
@prodID as int
as
Update Producto set fechaIngreso = @fechaIng, prodNom= @prodNom,prodStock= @prodStock,prodPreCom= @prodPreCom,prodPreVen= @prodPreVen,ubicacion= @ubicacion,catID= @catID Where prodID= @prodID
go

----------- [MODIFICAR PROVEEDOR] -------------
If object_id('modificarProveedor') IS NOT NULL
drop proc   modificarProveedor
go
Create proc modificarProveedor
@provRuc as char(10),
@provDNI as varchar(50),
@provNom as varchar(50),
@provDir as varchar(50),
@provTelf as char(14),
@provCorreo as varchar(50),
@provID as int
as
Update Proveedor set provRuc= @provRuc,provDNI= @provDNI,provNom= @provNom,provDir= @provDir,provTelf= @provTelf,provCorreo= @provCorreo Where provID= @provID
go

----------- [MODIFICAR USUARIO] -------------
If object_id('modificarUsuario') is not null
drop proc   modificarUsuario
go
Create proc modificarUsuario
@usuDNI as char(10),
@usuNomAp as varchar(50),
@usuCorreo as varchar(50),
@usuCel as char(10),
@nick as varchar(50),
@password as varchar(50),
@carID as int,
@usuID as int
as
Update Usuario set usuDNI= @usuDNI,usuNomAp= @usuNomAp,usuCorreo= @usuCorreo,usuCel= @usuCel,nick= @nick,password= @password,carID= @carID Where usuID= @usuID
go


----------- [CONSULTAS] -------------	

----------- [CONSULTAR CATEGORIA] -------------	
If object_id('ConsultarCategoria')is not null
drop proc   ConsultarCategoria
go
Create proc ConsultarCategoria
as 
Select * from Categoria
go 

----------- [CONSULTAR CARGO] -------------
If object_id('ConsultarCargo')is not null
drop proc   ConsultarCargo
go
Create proc ConsultarCargo
as 
Select * from Cargo
go 


----------- [CONSULTAR CLIENTE] -------------
If object_id('ConsultarCliente')is not null
drop proc  ConsultarCliente
go
Create proc ConsultarCliente
as 
Select * from Cliente
go 



----------- [CONSULTAR PRODUCTO] -------------
If object_id('ConsultarProducto')is not null
drop proc   ConsultarProducto
go
Create proc ConsultarProducto
as 
Select * from Producto
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

If object_id('aumentar_stock')is not null
drop proc   aumentar_stock
go
Create proc aumentar_stock
@prodID as integer,
@cantidad as decimal (18,2)
as 
update producto set prodStock=prodStock+@cantidad where prodID=@prodID
go

If object_id('disminuir_stock')is not null
drop proc   disminuir_stock
go
Create proc disminuir_stock
@prodID as integer,
@cantidad as decimal (18,2)
as 
update producto set prodStock=prodStock-@cantidad where prodID=@prodID
go


----------- [CONSULTAR USUARIO] -------------
If object_id('ConsultarUsuario')is not null
drop proc   ConsultarUsuario
go
Create proc ConsultarUsuario
as 
Select * from Usuario
go 

----------- [CONSULTAR PROVEEDOR] -------------
If object_id('ConsultarProveedor')is not null
drop proc   ConsultarProveedor
go
Create proc ConsultarProveedor
as 
Select * from Proveedor
go 

----------- [CONSULTAR BOLETA] -------------
If object_id('ConsultarBoleta')is not null
drop proc   ConsultarBoleta
go
Create proc ConsultarBoleta
as 
Select b.bolID,c.cliNomAp,c.cliDir,b.bolFecha,b.bolTotal,b.estado from Boleta b join Cliente c on b.cliID = c.cliID
go 


----------- [CONSULTAR DETALLE - BOLETA] -------------
If object_id('ConsultarDetalle_Boleta')is not null
drop proc   ConsultarDetalle_Boleta
go
Create proc ConsultarDetalle_Boleta
@bolID as int
as 
Select db.bolID,p.prodID,p.prodNom,db.cantidad,db.punit from Detalle_Boleta db join Producto p on db.prodID=p.prodID where db.bolID =@bolID
go


----------- [CONSULTAR FACTURA] -------------
If object_id('ConsultarFactura')is not null
drop proc   ConsultarFactura
go
Create proc ConsultarFactura
as 
Select * from Factura
go 

----------- [CONSULTAR DETALLE - FACTURA] -------------
If object_id('ConsultarDetalle_Factura')is not null
drop proc   ConsultarDetalle_Factura
go
Create proc ConsultarDetalle_Factura
@facID as int
as 
Select prodID,Cant,punit from Detalle_Factura where facID =@facID
go


----------- [CONSULTAR PEDIDO] -------------
If object_id('ConsultarPedido')is not null
drop proc   ConsultarPedido
go
Create proc ConsultarPedido
as 
Select * from Pedido
go 

----------- [CONSULTAR DETALLE - PEDIDO] -------------
If object_id('ConsultarDetalle_Pedido')is not null
drop proc   ConsultarDetalle_Pedido
go
Create proc ConsultarDetalle_Pedido
@pedID as int
as 
Select prodID,cantidad,punit from Detalle_Pedido where pedID =@pedID
go


----------- [ELIMINACIONES] -------------	

----------- [ELIMINAR CLIENTE] -------------
If object_id('EliminarCliente') is not null
drop proc   EliminarCliente
go
Create proc EliminarCliente
@cliID as int
as
Delete Cliente from Cliente Where cliID =@cliID
go

----------- [ELIMINAR PRODUCTO] -------------
If object_id('EliminarProducto') is not null
drop proc   EliminarProducto
go
Create proc EliminarProducto
@prodID as int
as
Delete Producto from Producto Where prodID =@prodID
go

----------- [ELIMINAR USUARIO] -------------
If object_id('EliminarUsuario') is not null
drop proc   EliminarUsuario
go
Create proc EliminarUsuario
@usuID as int
as
Delete Usuario from Usuario Where usuID =@usuID
go

----------- [ELIMINAR PROVEEDOR] -------------
If object_id('EliminarProveedor') is not null
drop proc   EliminarProveedor
go
Create proc EliminarProveedor
@provID as int
as
Delete Proveedor from Proveedor Where provID =@provID
go


----------- [BUSQUEDAS] -------------	

----------- [BUSCAR CLIENTE] -------------
If object_id('BuscarClientexDNI')is not null
drop proc   BuscarClientexDNI
go
Create proc BuscarClientexDNI
@cliDNI as CHAR(8)
as
Select * from Cliente where cliDNI =@cliDNI	
go

If object_id('BuscarClientexRUC')is not null
drop proc   BuscarClientexRUC
go
Create proc BuscarClientexRUC
@cliRUC as CHAR(14)
as
Select * from Cliente where cliRUC =@cliRUC	
go

----------- [BUSCAR PRODUCTO] -------------
If object_id('BuscarProducto')is not null
drop proc   BuscarProducto
go
Create proc BuscarProducto
@prodID as int
as 
Select * from Producto where prodID =@prodID
go 

----------- [BUSCAR PRODUCTO x CATEGORIA] -------------
If object_id('BuscarProductoxCategoria')is not null
drop proc  BuscarProductoxCategoria
go
Create proc BuscarProductoxCategoria
@catID as int
as 
declare @cod int = 1
if exists (select * from Producto where catID = @catID)
	begin
	set @cod += 1
	if @cod <10
		select cast(@catID as char(2))+replicate(0,3)+cast(@cod as char(4))
	else if @cod<100
		select cast(@catID as char(2))+replicate(0,2)+cast(@cod as char(4))
	else if @cod<1000
		select cast(@catID as char(2))+replicate(0,1)+cast(@cod as char(4))
	else
		select cast(@catID as char(2))+cast(@cod as char(4))	
	end
else
	select cast(@catID as char(2))+replicate(0,3)+cast(@cod as char(4))
go 
----------- [BUSCAR PROVEEDOR] -------------
If object_id('BuscarProveedor')is not null
drop proc   BuscarProveedor
go
Create proc BuscarProveedor
@provID as int
as 
Select * from Proveedor where provID =@provID
go 


----------------- [REPORTE - BOLETA] -----------------------------
If object_id('ReporteBoleta')is not null
drop proc   ReporteBoleta
go
Create proc ReporteBoleta
@bolID as int
as
SELECT        dbo.Cliente.cliID, dbo.Boleta.bolID, dbo.Producto.prodID, dbo.Detalle_Boleta.cantidad, dbo.Detalle_Boleta.punit, dbo.Cliente.cliNomAp, dbo.Cliente.cliDir, 
                         dbo.Cliente.cliDirRef, dbo.Boleta.bolTotal, dbo.Boleta.bolFecha, dbo.Producto.prodNom
FROM            dbo.Boleta INNER JOIN
                         dbo.Cliente ON dbo.Boleta.cliID = dbo.Cliente.cliID INNER JOIN
                         dbo.Detalle_Boleta ON dbo.Boleta.bolID = dbo.Detalle_Boleta.bolID INNER JOIN
                         dbo.Producto ON dbo.Detalle_Boleta.prodID = dbo.Producto.prodID
WHERE  dbo.Boleta.bolID = @bolID
go



--------------------- [GENERAR CODIGO] ---------------------
If object_id('generaCodigoBoleta') is not null
drop proc   generaCodigoBoleta
go
Create proc generaCodigoBoleta
as
if not exists (select * from Boleta)
	select 0
else
select top 1 bolID from Boleta order by 1 desc
go

If object_id('generaCodigoFactura') is not null
drop proc   generaCodigoFactura
go
Create proc generaCodigoFactura
as
if not exists (select * from Factura)
	select 0
else
select top 1 facID from Factura order by 1 desc
go

If object_id('generaCodigoPedido') is not null
drop proc   generaCodigoPedido
go
Create proc generaCodigoPedido
as
if not exists (select * from Pedido)
	select 0
else
select top 1 pedID from Pedido order by 1 desc
go