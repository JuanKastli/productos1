Public Class ArticuloForm
    Dim operacion_ As String
    Dim MiArticulo As New ArticuloClass

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
            MiArticulo.Id = CInt(IdText.Text)
        End If

        MiArticulo.Descripcion = DescripcionText.Text

        Select Case operacion_

            Case "Agregar"
                ArticuloList.InsertarArticulo(MiArticulo)

            Case "Modificar"
                ArticuloList.ActualizarArticulo(MiArticulo)

            Case "Eliminar"
                ArticuloList.EliminarArticulo(MiArticulo)

        End Select


        Me.Close()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

End Class
