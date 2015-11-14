Public Class Movie

    Private _Code As String
    Public Property Code As String
        Get
            Return _Code
        End Get
        Set(ByVal value As String)
            _Code = value
        End Set
    End Property

    Private _Nom As String
    Public Property Nom As String
        Get
            Return _Nom
        End Get
        Set(ByVal value As String)
            _Nom = value
        End Set
    End Property

    Private _DateSortie As String
    Public Property DateSortie As String
        Get
            Return _DateSortie
        End Get
        Set(ByVal value As String)
            _DateSortie = value
        End Set
    End Property

    Private _Realisateur As String
    Public Property Realisateur As String
        Get
            Return _Realisateur
        End Get
        Set(ByVal value As String)
            _Realisateur = value
        End Set
    End Property

    Private _Genre1 As String
    Public Property Genre1 As String
        Get
            Return _Genre1
        End Get
        Set(ByVal value As String)
            _Genre1 = value
        End Set
    End Property

    Private _Genre2 As String
    Public Property Genre2 As String
        Get
            Return _Genre2
        End Get
        Set(ByVal value As String)
            _Genre2 = value
        End Set
    End Property

    Private _Acteurs As String
    Public Property Acteurs As String
        Get
            Return _Acteurs
        End Get
        Set(ByVal value As String)
            _Acteurs = value
        End Set
    End Property

    Private _Synopsis As String
    Public Property Synopsis As String
        Get
            Return _Synopsis
        End Get
        Set(ByVal value As String)
            _Synopsis = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal Code As String, ByVal Nom As String, ByVal DateSortie As String, ByVal Realisateur As String, ByVal Genre1 As String, ByVal Genre2 As String, ByVal Acteurs As String, ByVal Synopsis As String)
        _Code = Code
        _Nom = Nom
        _DateSortie = DateSortie
        _Realisateur = Realisateur
        _Genre1 = Genre1
        _Genre2 = Genre2
        _Acteurs = Acteurs
        _Synopsis = Synopsis
    End Sub

    Public Sub New(ByVal Code As String, ByVal Nom As String, ByVal DateSortie As String)
        _Code = Code
        _Nom = Nom
        _DateSortie = DateSortie
    End Sub

    Public Sub Update(ByVal Code As String, ByVal Nom As String, ByVal DateSortie As String, ByVal Realisateur As String, ByVal Genre1 As String, ByVal Genre2 As String, ByVal Acteurs As String, ByVal Synopsis As String)
        _Code = Code
        _Nom = Nom
        _DateSortie = DateSortie
        _Realisateur = Realisateur
        _Genre1 = Genre1
        _Genre2 = Genre2
        _Acteurs = Acteurs
        _Synopsis = Synopsis
    End Sub

    'Je surcharge le ToString
    Public Overrides Function ToString() As String
        Return _Nom + " (" + _DateSortie + ")"
    End Function
End Class
