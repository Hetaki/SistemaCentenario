Public Class Producto
    Private _codProd As Integer
    Public Property codPro() As Integer
        Get
            Return _codProd
        End Get
        Set(ByVal value As Integer)
            _codProd = value
        End Set
    End Property
    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _stock As Integer
    Public Property stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
        End Set
    End Property
    Private _precioCompra As Decimal
    Public Property precioCompra() As Decimal
        Get
            Return _precioCompra
        End Get
        Set(ByVal value As Decimal)
            _precioCompra = value
        End Set
    End Property
    Private _precioVenta As Decimal
    Public Property precioVenta() As Decimal
        Get
            Return _precioVenta
        End Get
        Set(ByVal value As Decimal)
            _precioVenta = value
        End Set
    End Property
    Private _ubicacion As String
    Public Property ubicacion() As String
        Get
            Return _ubicacion
        End Get
        Set(ByVal value As String)
            _ubicacion = value
        End Set
    End Property
    Private _categoria As Integer
    Public Property categoria() As Integer
        Get
            Return _categoria
        End Get
        Set(ByVal value As Integer)
            _categoria = value
        End Set
    End Property
    Private _fecha As String
    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

End Class
