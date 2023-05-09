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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnDGV = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.Yellow
        Me.btnReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.ForeColor = System.Drawing.Color.Blue
        Me.btnReiniciar.Location = New System.Drawing.Point(749, 570)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(182, 56)
        Me.btnReiniciar.TabIndex = 72
        Me.btnReiniciar.Text = "Reabrir BD"
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        Me.DGV.Location = New System.Drawing.Point(15, 294)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1318, 232)
        Me.DGV.TabIndex = 73
        '
        'btnDGV
        '
        Me.btnDGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDGV.ForeColor = System.Drawing.Color.White
        Me.btnDGV.Location = New System.Drawing.Point(425, 570)
        Me.btnDGV.Name = "btnDGV"
        Me.btnDGV.Size = New System.Drawing.Size(230, 56)
        Me.btnDGV.TabIndex = 76
        Me.btnDGV.Text = "Mostrar Todo"
        Me.btnDGV.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 77
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActualizarDatosToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'ActualizarDatosToolStripMenuItem
        '
        Me.ActualizarDatosToolStripMenuItem.Name = "ActualizarDatosToolStripMenuItem"
        Me.ActualizarDatosToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ActualizarDatosToolStripMenuItem.Text = "Actualizar Datos"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre del Cliente"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "DNI"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "Telefóno"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Dirección"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Codigo del Cliente"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "ID Cliente"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "Descripción"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "Estado"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 75
        '
        'Column9
        '
        Me.Column9.HeaderText = "Fecha de Inicio"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Fecha de Finalización"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "ID Procurador"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 75
        '
        'Column12
        '
        Me.Column12.HeaderText = "Codigo del Procurador"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 75
        '
        'Column13
        '
        Me.Column13.HeaderText = "Nombre del Procurador"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 150
        '
        'Column14
        '
        Me.Column14.HeaderText = "DNI"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 75
        '
        'Column15
        '
        Me.Column15.HeaderText = "Telefóno"
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 75
        '
        'Column16
        '
        Me.Column16.HeaderText = "Dirección"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(371, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(758, 55)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Ver toda la Información de la BD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1300, 108)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(500, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(524, 23)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "En esta sección podras ver todos los datos referente al"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1237, 625)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(121, 56)
        Me.btnSalir.TabIndex = 81
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 693)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDGV)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Buscar Información"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnDGV As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
End Class
