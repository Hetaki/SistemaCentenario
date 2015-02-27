Public Class DetalleComprar
    Private _compID As Integer
    Public Property compID() As Integer
        Get
            Return _compID
        End Get
        Set(ByVal value As Integer)
            _compID = value
        End Set
    End Property

    Private _prodID As Integer
    Public Property prodID() As Integer
        Get
            Return _prodID
        End Get
        Set(ByVal value As Integer)
            _prodID = value
        End Set
    End Property

    Private _dComCantidad As Decimal
    Public Property dComCantidad() As Decimal
        Get
            Return _dComCantidad
        End Get
        Set(ByVal value As Decimal)
            _dComCantidad = value
        End Set
    End Property

    Private _dCompUnit As Decimal
    Public Property dCompUnit() As Decimal
        Get
            Return _dCompUnit
        End Get
        Set(ByVal value As Decimal)
            _dCompUnit = value
        End Set
    End Property

    Private _dCompDescuento As Decimal
    Public Property dCompDescuento() As Decimal
        Get
            Return _dCompDescuento
        End Get
        Set(ByVal value As Decimal)
            _dCompDescuento = value
        End Set
    End Property


End Class
