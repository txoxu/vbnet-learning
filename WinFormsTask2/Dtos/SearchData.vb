Public Class SearchData
    Private nameKeyword As String
    Private dateKeyword As String
    Private ageKeyword As Integer
    Private firstNumber As Integer
    Private lastNumber As Integer

    Public Property NameData() As String
        Get
            Return nameKeyword
        End Get
        Set(value As String)
            nameKeyword = value
        End Set
    End Property

    Public Property DateData() As String
        Get
            Return dateKeyword
        End Get
        Set(value As String)
            dateKeyword = value
        End Set
    End Property

    Public Property AgeData() As Integer
        Get
            Return ageKeyword
        End Get
        Set(value As Integer)
            ageKeyword = value
        End Set
    End Property

    Public Property FirstNumData() As Integer
        Get
            Return firstNumber
        End Get
        Set(value As Integer)
            firstNumber = value
        End Set
    End Property

    Public Property LastNumData() As Integer
        Get
            Return lastNumber
        End Get
        Set(value As Integer)
            lastNumber = value
        End Set
    End Property
End Class
