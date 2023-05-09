<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodEstu = New System.Windows.Forms.TextBox()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column7
        '
        Me.Column7.HeaderText = "Parcial 3"
        Me.Column7.Name = "Column7"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Parcial 2"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Parcial 1"
        Me.Column5.Name = "Column5"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Apellido"
        Me.Column4.Name = "Column4"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cedula"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo del Estudiante"
        Me.Column1.Name = "Column1"
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DGV.Location = New System.Drawing.Point(194, 127)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(743, 150)
        Me.DGV.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(970, 204)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 43)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(592, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar Estudiante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Escriba Codigo del Estudiante:"
        '
        'txtCodEstu
        '
        Me.txtCodEstu.Location = New System.Drawing.Point(595, 74)
        Me.txtCodEstu.Name = "txtCodEstu"
        Me.txtCodEstu.Size = New System.Drawing.Size(100, 20)
        Me.txtCodEstu.TabIndex = 4
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(1005, 81)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(122, 65)
        Me.btnReiniciar.TabIndex = 5
        Me.btnReiniciar.Text = "REABIR BD"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(967, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1230, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarDatosToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ActualizarDatosToolStripMenuItem
        '
        Me.ActualizarDatosToolStripMenuItem.Name = "ActualizarDatosToolStripMenuItem"
        Me.ActualizarDatosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ActualizarDatosToolStripMenuItem.Text = "Actualizar Datos"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.txtCodEstu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodEstu As TextBox
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarDatosToolStripMenuItem As ToolStripMenuItem
End Class
