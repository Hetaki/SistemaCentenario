Public Class Cliente
    Private _codCli As Integer
    Public Property codCli() As Integer
        Get
            Return _codCli
        End Get
        Set(ByVal value As Integer)
            _codCli = value
        End Set
    End Property

    Private _dni As String
    Public Property dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal value As String)
            _dni = value
        End Set
    End Property
    Private _ruc As String
    Public Property ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
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
    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property
    Private _telefono As String
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Private _celular As String
    Public Property celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property
    Private _refencia As String
    Public Property referencia() As String
        Get
            Return _refencia
        End Get
        Set(ByVal value As String)
            _refencia = value
        End Set
    End Property

End Class
