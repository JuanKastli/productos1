Public Class MenuForm
    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click
        End
    End Sub

    Private Sub RubrosButton_Click(sender As Object, e As EventArgs) Handles RubrosButton.Click

        ToolStrip1.Enabled = False

        Dim gridRubro As New RubrosGrid

        gridRubro.MdiParent = Me

        gridRubro.Show()

    End Sub

    Private Sub ArticulosButton_Click(sender As Object, e As EventArgs) Handles ArticulosButton.Click

        ToolStrip1.Enabled = False

        Dim gridArticulo As New ArticulosGrid

        gridArticulo.MdiParent = Me

        gridArticulo.Show()

    End Sub

End Class