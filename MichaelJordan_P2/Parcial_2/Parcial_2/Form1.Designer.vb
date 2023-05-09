<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NuevoE = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCodEstuNota = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.txtExamenF = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtParcial3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtParcial2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtParcial1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGrid = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodEstu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnEstudiante = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(1106, 48)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(129, 50)
        Me.btnReiniciar.TabIndex = 0
        Me.btnReiniciar.Text = "REABRIR BD"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DGV.Enabled = False
        Me.DGV.Location = New System.Drawing.Point(12, 286)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(741, 165)
        Me.DGV.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo del Estudiante"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cedula"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Apellido"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Parcial 1"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Parcial 2"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Parcial 3"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'NuevoE
        '
        Me.NuevoE.Location = New System.Drawing.Point(884, 170)
        Me.NuevoE.Name = "NuevoE"
        Me.NuevoE.Size = New System.Drawing.Size(92, 60)
        Me.NuevoE.TabIndex = 6
        Me.NuevoE.Text = "Nuevo Estudiante"
        Me.NuevoE.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodEstuNota)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnNotas)
        Me.GroupBox2.Controls.Add(Me.txtExamenF)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtParcial3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtParcial2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtParcial1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(430, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 238)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Notas de Examenes"
        '
        'txtCodEstuNota
        '
        Me.txtCodEstuNota.Location = New System.Drawing.Point(151, 33)
        Me.txtCodEstuNota.Name = "txtCodEstuNota"
        Me.txtCodEstuNota.Size = New System.Drawing.Size(100, 20)
        Me.txtCodEstuNota.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "CODIGO DE ESTUDIANTE"
        '
        'btnNotas
        '
        Me.btnNotas.Location = New System.Drawing.Point(275, 98)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(75, 46)
        Me.btnNotas.TabIndex = 5
        Me.btnNotas.Text = "Registrar Notas"
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'txtExamenF
        '
        Me.txtExamenF.Location = New System.Drawing.Point(73, 179)
        Me.txtExamenF.Name = "txtExamenF"
        Me.txtExamenF.Size = New System.Drawing.Size(100, 20)
        Me.txtExamenF.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "EXM FINAL"
        '
        'txtParcial3
        '
        Me.txtParcial3.Location = New System.Drawing.Point(73, 143)
        Me.txtParcial3.Name = "txtParcial3"
        Me.txtParcial3.Size = New System.Drawing.Size(100, 20)
        Me.txtParcial3.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PARCIAL 2"
        '
        'txtParcial2
        '
        Me.txtParcial2.Location = New System.Drawing.Point(73, 109)
        Me.txtParcial2.Name = "txtParcial2"
        Me.txtParcial2.Size = New System.Drawing.Size(100, 20)
        Me.txtParcial2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "PARCIAL 3"
        '
        'txtParcial1
        '
        Me.txtParcial1.Location = New System.Drawing.Point(73, 76)
        Me.txtParcial1.Name = "txtParcial1"
        Me.txtParcial1.Size = New System.Drawing.Size(100, 20)
        Me.txtParcial1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PARCIAL 1"
        '
        'btnGrid
        '
        Me.btnGrid.Location = New System.Drawing.Point(860, 86)
        Me.btnGrid.Name = "btnGrid"
        Me.btnGrid.Size = New System.Drawing.Size(116, 53)
        Me.btnGrid.TabIndex = 2
        Me.btnGrid.Text = "Mostrar Tabla"
        Me.btnGrid.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodEstu)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnEstudiante)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCedula)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 238)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'txtCodEstu
        '
        Me.txtCodEstu.Location = New System.Drawing.Point(27, 55)
        Me.txtCodEstu.Name = "txtCodEstu"
        Me.txtCodEstu.Size = New System.Drawing.Size(100, 20)
        Me.txtCodEstu.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "CODIGO DE ESTUDIANTE"
        '
        'btnEstudiante
        '
        Me.btnEstudiante.Location = New System.Drawing.Point(230, 92)
        Me.btnEstudiante.Name = "btnEstudiante"
        Me.btnEstudiante.Size = New System.Drawing.Size(75, 52)
        Me.btnEstudiante.TabIndex = 4
        Me.btnEstudiante.Text = "Registrar Estudiante"
        Me.btnEstudiante.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(84, 186)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDO"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 143)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CEDULA"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(84, 98)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE"
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9, Me.Column10})
        Me.DGV2.Location = New System.Drawing.Point(748, 286)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(342, 165)
        Me.DGV2.TabIndex = 8
        '
        'Column8
        '
        Me.Column8.HeaderText = "Promedio Parciales"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Examen Final"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Calificacion Final"
        Me.Column10.Name = "Column10"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1302, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarDatosToolStripMenuItem, Me.ActualizarDatosToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'BuscarDatosToolStripMenuItem
        '
        Me.BuscarDatosToolStripMenuItem.Name = "BuscarDatosToolStripMenuItem"
        Me.BuscarDatosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BuscarDatosToolStripMenuItem.Text = "Buscar Datos"
        '
        'ActualizarDatosToolStripMenuItem
        '
        Me.ActualizarDatosToolStripMenuItem.Name = "ActualizarDatosToolStripMenuItem"
        Me.ActualizarDatosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ActualizarDatosToolStripMenuItem.Text = "Actualizar Datos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(976, 424)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 484)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.btnGrid)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.NuevoE)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReiniciar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents NuevoE As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGrid As Button
    Friend WithEvents txtExamenF As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtParcial3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtParcial2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtParcial1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNotas As Button
    Friend WithEvents btnEstudiante As Button
    Friend WithEvents txtCodEstu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodEstuNota As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label10 As Label
End Class
