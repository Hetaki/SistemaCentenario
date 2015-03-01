Public Class Usuario
    Private _idusuario As Integer
    Public Property idusuario() As Integer
        Get
            Return _idusuario
        End Get
        Set(ByVal value As Integer)
            _idusuario = value
        End Set
    End Property
    Private _nDNI As String
    Public Property nDNI() As String
        Get
            Return _nDNI
        End Get
        Set(ByVal value As String)
            _nDNI = value
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
    Private _celular As String
    Public Property celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property
    Private _correo As String
    Public Property correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property
    Private _nomCargo As String
    Public Property nomCargo() As String
        Get
            Return _nomCargo
        End Get
        Set(ByVal value As String)
            _nomCargo = value
        End Set
    End Property

    Private _cargo As Integer
    Public Property cargo() As Integer
        Get
            Return _cargo
        End Get
        Set(ByVal value As Integer)
            _cargo = value
        End Set
    End Property
    Private _password As String
    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property
    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

End Class
