<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RubroForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DescripcionText = New System.Windows.Forms.TextBox()
        Me.IdText = New System.Windows.Forms.TextBox()
        Me.DescripcionLabel = New System.Windows.Forms.Label()
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DescripcionText
        '
        Me.DescripcionText.Location = New System.Drawing.Point(123, 40)
        Me.DescripcionText.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripcionText.Name = "DescripcionText"
        Me.DescripcionText.Size = New System.Drawing.Size(231, 22)
        Me.DescripcionText.TabIndex = 11
        '
        'IdText
        '
        Me.IdText.Location = New System.Drawing.Point(123, 10)
        Me.IdText.Margin = New System.Windows.Forms.Padding(4)
        Me.IdText.Name = "IdText"
        Me.IdText.Size = New System.Drawing.Size(231, 22)
        Me.IdText.TabIndex = 10
        '
        'DescripcionLabel
        '
        Me.DescripcionLabel.AutoSize = True
        Me.DescripcionLabel.Location = New System.Drawing.Point(11, 43)
        Me.DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DescripcionLabel.Name = "DescripcionLabel"
        Me.DescripcionLabel.Size = New System.Drawing.Size(82, 17)
        Me.DescripcionLabel.TabIndex = 9
        Me.DescripcionLabel.Text = "Descripcion"
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Location = New System.Drawing.Point(11, 13)
        Me.IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(21, 17)
        Me.IdLabel.TabIndex = 8
        Me.IdLabel.Text = "ID"
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(254, 92)
        Me.CancelarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(100, 40)
        Me.CancelarButton.TabIndex = 7
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(123, 92)
        Me.AceptarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(101, 40)
        Me.AceptarButton.TabIndex = 6
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'RubroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 160)
        Me.Controls.Add(Me.DescripcionText)
        Me.Controls.Add(Me.IdText)
        Me.Controls.Add(Me.DescripcionLabel)
        Me.Controls.Add(Me.IdLabel)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RubroForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RubrosForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescripcionText As TextBox
    Friend WithEvents IdText As TextBox
    Friend WithEvents DescripcionLabel As Label
    Friend WithEvents IdLabel As Label
    Friend WithEvents CancelarButton As Button
    Friend WithEvents AceptarButton As Button
End Class
