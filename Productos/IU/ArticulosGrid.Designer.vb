<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticulosGrid
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArticulosGrid))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Agregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Modificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Salir = New System.Windows.Forms.ToolStripButton()
        Me.Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ArticuloCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Filtrar = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRubroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArticulosCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.Agregar, Me.ToolStripSeparator1, Me.Modificar, Me.ToolStripSeparator4, Me.Salir, Me.Eliminar, Me.ToolStripSeparator5, Me.ArticuloCombo, Me.ToolStripSeparator3, Me.Filtrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(811, 55)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'Agregar
        '
        Me.Agregar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Agregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Agregar.Image = CType(resources.GetObject("Agregar.Image"), System.Drawing.Image)
        Me.Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 52)
        Me.Agregar.Text = "Agregar"
        Me.Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'Modificar
        '
        Me.Modificar.AutoSize = False
        Me.Modificar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Modificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Modificar.Image = CType(resources.GetObject("Modificar.Image"), System.Drawing.Image)
        Me.Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(85, 52)
        Me.Modificar.Text = "Modificar"
        Me.Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 55)
        '
        'Salir
        '
        Me.Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Salir.AutoSize = False
        Me.Salir.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(46, 52)
        Me.Salir.Text = "Salir"
        Me.Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Eliminar
        '
        Me.Eliminar.AutoSize = False
        Me.Eliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Eliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
        Me.Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 52)
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 55)
        '
        'ArticuloCombo
        '
        Me.ArticuloCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ArticuloCombo.IntegralHeight = False
        Me.ArticuloCombo.Name = "ArticuloCombo"
        Me.ArticuloCombo.Size = New System.Drawing.Size(399, 55)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 55)
        '
        'Filtrar
        '
        Me.Filtrar.AutoSize = False
        Me.Filtrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Filtrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Filtrar.Image = CType(resources.GetObject("Filtrar.Image"), System.Drawing.Image)
        Me.Filtrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Filtrar.Name = "Filtrar"
        Me.Filtrar.Size = New System.Drawing.Size(54, 52)
        Me.Filtrar.Text = "Filtro"
        Me.Filtrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.IdRubroDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ArticulosCollectionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 55)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(811, 300)
        Me.DataGridView1.TabIndex = 7
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdRubroDataGridViewTextBoxColumn
        '
        Me.IdRubroDataGridViewTextBoxColumn.DataPropertyName = "IdRubro"
        Me.IdRubroDataGridViewTextBoxColumn.HeaderText = "IdRubro"
        Me.IdRubroDataGridViewTextBoxColumn.Name = "IdRubroDataGridViewTextBoxColumn"
        Me.IdRubroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArticulosCollectionBindingSource
        '
        Me.ArticulosCollectionBindingSource.DataSource = GetType(WindowsApplication2.ArticulosCollection)
        '
        'ArticulosGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 355)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ArticulosGrid"
        Me.Text = "ArticulosGrid"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Agregar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Modificar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Salir As ToolStripButton
    Friend WithEvents Eliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ArticuloCombo As ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Filtrar As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRubroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArticulosCollectionBindingSource As BindingSource
End Class
