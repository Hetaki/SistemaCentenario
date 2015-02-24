Public Class DetallePedido
    Private _idPed As Integer
    Public Property idPed() As Integer
        Get
            Return _idPed
        End Get
        Set(ByVal value As Integer)
            _idPed = value
        End Set
    End Property
    Private _idProd As Integer
    Public Property idProd() As Integer
        Get
            Return _idProd
        End Get
        Set(ByVal value As Integer)
            _idProd = value
        End Set
    End Property
    Private _cantidad As Decimal
    Public Property cantidad() As Decimal
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Decimal)
            _cantidad = value
        End Set
    End Property
    Private _precioU As Decimal
    Public Property precioU() As Decimal
        Get
            Return _precioU
        End Get
        Set(ByVal value As Decimal)
            _precioU = value
        End Set
    End Property
End Class
