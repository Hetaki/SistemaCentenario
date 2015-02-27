Public Class Compra

    Private _compID As Integer
    Public Property compID() As Integer
        Get
            Return _compID
        End Get
        Set(ByVal value As Integer)
            _compID = value
        End Set
    End Property


    Private _compTotal As Decimal
    Public Property compTotal() As Decimal
        Get
            Return _compTotal
        End Get
        Set(ByVal value As Decimal)
            _compTotal = value
        End Set
    End Property

    Private _compfecha As Date
    Public Property compfecha() As Date
        Get
            Return _compfecha
        End Get
        Set(ByVal value As Date)
            _compfecha = value
        End Set
    End Property

    Private _compCondicionPag As String
    Public Property compCondicionPag() As String
        Get
            Return _compCondicionPag
        End Get
        Set(ByVal value As String)
            _compCondicionPag = value
        End Set
    End Property


    Private _compNumeroFactura As String
    Public Property compNumeroFactura() As String
        Get
            Return _compNumeroFactura
        End Get
        Set(ByVal value As String)
            _compNumeroFactura = value
        End Set
    End Property

    Private _provID As Integer
    Public Property provID() As Integer
        Get
            Return _provID
        End Get
        Set(ByVal value As Integer)
            _provID = value
        End Set
    End Property


End Class
