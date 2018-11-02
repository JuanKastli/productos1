Public Class RubroForm


    Dim operacion_ As String
    Dim MiRubro As New RubroClass

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)

            indice_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        If operacion_ <> "Agregar" Then
            MiRubro.Id = CInt(IdText.Text)
        End If

        MiRubro.Descripcion = DescripcionText.Text

        Select Case operacion_

            Case "Agregar"
                RubroList.InsertarRubro(MiRubro)

            Case "Modificar"
                RubroList.ActualizarRubro(MiRubro)

            Case "Eliminar"
                RubroList.EliminarRubro(MiRubro)

        End Select

        Me.Close()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

End Class