Public Class Boleta
    Private _codBol As Integer
    Public Property codBol() As Integer
        Get
            Return _codBol
        End Get
        Set(ByVal value As Integer)
            _codBol = value
        End Set
    End Property
    Private _total As Decimal
    Public Property total() As String
        Get
            Return _total
        End Get
        Set(ByVal value As String)
            _total = value
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
    Private _codCli As Integer
    Public Property codCli() As String
        Get
            Return _codCli
        End Get
        Set(ByVal value As String)
            _codCli = value
        End Set
    End Property

End Class
