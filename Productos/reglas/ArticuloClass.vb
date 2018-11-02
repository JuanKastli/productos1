Public Class ArticuloClass
    Dim Id_ As Integer
    Dim Descripcion_ As String
    Dim IdRubro_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_

        End Get
        Set(ByVal value As Integer)

            Id_ = value

        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Descripcion_

        End Get
        Set(ByVal value As String)

            Descripcion_ = value

        End Set
    End Property

    Public Property IdRubro() As Integer
        Get
            Return IdRubro_

        End Get
        Set(ByVal value As Integer)

            IdRubro_ = value

        End Set
    End Property
End Class
