<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloForm
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
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.DescripcionLabel = New System.Windows.Forms.Label()
        Me.IdText = New System.Windows.Forms.TextBox()
        Me.DescripcionText = New System.Windows.Forms.TextBox()
        Me.IdRubroText = New System.Windows.Forms.TextBox()
        Me.IdRubroLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(153, 109)
        Me.AceptarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(101, 40)
        Me.AceptarButton.TabIndex = 0
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(284, 109)
        Me.CancelarButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(100, 40)
        Me.CancelarButton.TabIndex = 1
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.IdLabel.Location = New System.Drawing.Point(13, 16)
        Me.IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(31, 25)
        Me.IdLabel.TabIndex = 2
        Me.IdLabel.Text = "ID"
        '
        'DescripcionLabel
        '
        Me.DescripcionLabel.AutoSize = True
        Me.DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DescripcionLabel.Location = New System.Drawing.Point(13, 46)
        Me.DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DescripcionLabel.Name = "DescripcionLabel"
        Me.DescripcionLabel.Size = New System.Drawing.Size(114, 25)
        Me.DescripcionLabel.TabIndex = 3
        Me.DescripcionLabel.Text = "Descripción"
        '
        'IdText
        '
        Me.IdText.Enabled = False
        Me.IdText.Location = New System.Drawing.Point(153, 16)
        Me.IdText.Margin = New System.Windows.Forms.Padding(4)
        Me.IdText.Name = "IdText"
        Me.IdText.Size = New System.Drawing.Size(231, 22)
        Me.IdText.TabIndex = 4
        '
        'DescripcionText
        '
        Me.DescripcionText.Location = New System.Drawing.Point(153, 46)
        Me.DescripcionText.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripcionText.Name = "DescripcionText"
        Me.DescripcionText.Size = New System.Drawing.Size(231, 22)
        Me.DescripcionText.TabIndex = 5
        '
        'IdRubroText
        '
        Me.IdRubroText.Location = New System.Drawing.Point(153, 79)
        Me.IdRubroText.Margin = New System.Windows.Forms.Padding(4)
        Me.IdRubroText.Name = "IdRubroText"
        Me.IdRubroText.Size = New System.Drawing.Size(231, 22)
        Me.IdRubroText.TabIndex = 6
        '
        'IdRubroLabel
        '
        Me.IdRubroLabel.AutoSize = True
        Me.IdRubroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.IdRubroLabel.Location = New System.Drawing.Point(13, 75)
        Me.IdRubroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IdRubroLabel.Name = "IdRubroLabel"
        Me.IdRubroLabel.Size = New System.Drawing.Size(88, 25)
        Me.IdRubroLabel.TabIndex = 7
        Me.IdRubroLabel.Text = "ID Rubro"
        '
        'ArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 164)
        Me.Controls.Add(Me.IdRubroLabel)
        Me.Controls.Add(Me.IdRubroText)
        Me.Controls.Add(Me.DescripcionText)
        Me.Controls.Add(Me.IdText)
        Me.Controls.Add(Me.DescripcionLabel)
        Me.Controls.Add(Me.IdLabel)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ArticuloForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AceptarButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents IdLabel As Label
    Friend WithEvents DescripcionLabel As Label
    Friend WithEvents IdText As TextBox
    Friend WithEvents DescripcionText As TextBox
    Friend WithEvents IdRubroText As TextBox
    Friend WithEvents IdRubroLabel As Label
End Class
