Public Class DataDto
    Private id As Integer
    Private name As String
    Private kana As String
    Private age As Integer
    Private address As String
    Private tel As Integer

    Public Property IdSg() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property NameSg() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property KanaSg() As String
        Get
            Return kana
        End Get
        Set(value As String)
            kana = value
        End Set
    End Property

    Public Property AgeSg() As Integer
        Get
            Return age
        End Get
        Set(value As Integer)
            age = value
        End Set
    End Property

    Public Property AddressSg() As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property

    Public Property TelSg() As Integer
        Get
            Return tel
        End Get
        Set(value As Integer)
            tel = value
        End Set
    End Property
End Class
