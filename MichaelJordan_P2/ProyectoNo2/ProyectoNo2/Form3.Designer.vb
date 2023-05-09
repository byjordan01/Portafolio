<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscarCodProcurador = New System.Windows.Forms.Button()
        Me.btnActualizarEstado = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodProcurador = New System.Windows.Forms.TextBox()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtF_Finalizacion = New System.Windows.Forms.TextBox()
        Me.btnAsunto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdCliente1 = New System.Windows.Forms.TextBox()
        Me.btnActualizar_Fecha_F = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCodProcurador = New System.Windows.Forms.Button()
        Me.txtIdCliente2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Olive
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(500, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actualizar Datos"
        '
        'btnBuscarCodProcurador
        '
        Me.btnBuscarCodProcurador.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscarCodProcurador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCodProcurador.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCodProcurador.Location = New System.Drawing.Point(745, 61)
        Me.btnBuscarCodProcurador.Name = "btnBuscarCodProcurador"
        Me.btnBuscarCodProcurador.Size = New System.Drawing.Size(82, 34)
        Me.btnBuscarCodProcurador.TabIndex = 2
        Me.btnBuscarCodProcurador.Text = "Buscar"
        Me.btnBuscarCodProcurador.UseVisualStyleBackColor = False
        '
        'btnActualizarEstado
        '
        Me.btnActualizarEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEstado.Location = New System.Drawing.Point(774, 423)
        Me.btnActualizarEstado.Name = "btnActualizarEstado"
        Me.btnActualizarEstado.Size = New System.Drawing.Size(160, 35)
        Me.btnActualizarEstado.TabIndex = 3
        Me.btnActualizarEstado.Text = "Actualizar Estado"
        Me.btnActualizarEstado.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DGV.Location = New System.Drawing.Point(65, 101)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1119, 150)
        Me.DGV.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(712, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Actualizar Estado"
        '
        'txtCodProcurador
        '
        Me.txtCodProcurador.BackColor = System.Drawing.Color.White
        Me.txtCodProcurador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProcurador.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodProcurador.Location = New System.Drawing.Point(545, 69)
        Me.txtCodProcurador.Name = "txtCodProcurador"
        Me.txtCodProcurador.Size = New System.Drawing.Size(100, 26)
        Me.txtCodProcurador.TabIndex = 6
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.Yellow
        Me.btnReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.ForeColor = System.Drawing.Color.Blue
        Me.btnReiniciar.Location = New System.Drawing.Point(1148, 307)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(168, 64)
        Me.btnReiniciar.TabIndex = 7
        Me.btnReiniciar.Text = "Reabrir BD"
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        Me.DGV2.GridColor = System.Drawing.Color.Cyan
        Me.DGV2.Location = New System.Drawing.Point(271, 536)
        Me.DGV2.Name = "DGV2"
        Me.DGV2.Size = New System.Drawing.Size(712, 150)
        Me.DGV2.TabIndex = 8
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEstado.Location = New System.Drawing.Point(953, 331)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 26)
        Me.txtEstado.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(160, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(425, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Actualizar Fecha de Finalización"
        '
        'txtF_Finalizacion
        '
        Me.txtF_Finalizacion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF_Finalizacion.Location = New System.Drawing.Point(394, 335)
        Me.txtF_Finalizacion.Name = "txtF_Finalizacion"
        Me.txtF_Finalizacion.Size = New System.Drawing.Size(100, 26)
        Me.txtF_Finalizacion.TabIndex = 12
        '
        'btnAsunto
        '
        Me.btnAsunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAsunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsunto.ForeColor = System.Drawing.Color.White
        Me.btnAsunto.Location = New System.Drawing.Point(1002, 553)
        Me.btnAsunto.Name = "btnAsunto"
        Me.btnAsunto.Size = New System.Drawing.Size(124, 50)
        Me.btnAsunto.TabIndex = 13
        Me.btnAsunto.Text = "Ver Asunto"
        Me.btnAsunto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(631, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Actualizar: Estado (en tramite / archivado)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(631, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Actualizar: Id Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(136, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Actualizar: Fecha de Finalizacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(136, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Actualizar: Id Cliente"
        '
        'txtIdCliente1
        '
        Me.txtIdCliente1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente1.Location = New System.Drawing.Point(304, 373)
        Me.txtIdCliente1.Name = "txtIdCliente1"
        Me.txtIdCliente1.Size = New System.Drawing.Size(100, 26)
        Me.txtIdCliente1.TabIndex = 18
        '
        'btnActualizar_Fecha_F
        '
        Me.btnActualizar_Fecha_F.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar_Fecha_F.Location = New System.Drawing.Point(180, 423)
        Me.btnActualizar_Fecha_F.Name = "btnActualizar_Fecha_F"
        Me.btnActualizar_Fecha_F.Size = New System.Drawing.Size(241, 35)
        Me.btnActualizar_Fecha_F.TabIndex = 19
        Me.btnActualizar_Fecha_F.Text = "Actualizar Fecha Finalización"
        Me.btnActualizar_Fecha_F.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Cyan
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpiar.Location = New System.Drawing.Point(528, 423)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(145, 35)
        Me.btnLimpiar.TabIndex = 20
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnCodProcurador
        '
        Me.btnCodProcurador.BackColor = System.Drawing.Color.Cyan
        Me.btnCodProcurador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCodProcurador.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCodProcurador.Location = New System.Drawing.Point(848, 61)
        Me.btnCodProcurador.Name = "btnCodProcurador"
        Me.btnCodProcurador.Size = New System.Drawing.Size(86, 34)
        Me.btnCodProcurador.TabIndex = 21
        Me.btnCodProcurador.Text = "Limpiar"
        Me.btnCodProcurador.UseVisualStyleBackColor = False
        '
        'txtIdCliente2
        '
        Me.txtIdCliente2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente2.Location = New System.Drawing.Point(799, 373)
        Me.txtIdCliente2.Name = "txtIdCliente2"
        Me.txtIdCliente2.Size = New System.Drawing.Size(100, 26)
        Me.txtIdCliente2.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(136, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(403, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Buscar datos relacionados al Codigo del Procurador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(500, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 42)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Verificar Asunto"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo del Procurador"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre del Procurador"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "DNI"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descripción"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "ID Cliente"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Nombre del Cliente"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "DNI"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Estado"
        Me.Column8.Name = "Column8"
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
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1190, 636)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(168, 64)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Column11
        '
        Me.Column11.HeaderText = "ID Cliente"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Descripción"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 150
        '
        'Column13
        '
        Me.Column13.HeaderText = "Fecha de Inicio"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Fecha de Finalización"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.HeaderText = "Estado"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.HeaderText = "ID Procurador"
        Me.Column16.Name = "Column16"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Olive
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCodProcurador)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnActualizar_Fecha_F)
        Me.Controls.Add(Me.txtIdCliente1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAsunto)
        Me.Controls.Add(Me.txtF_Finalizacion)
        Me.Controls.Add(Me.txtIdCliente2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.DGV2)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.txtCodProcurador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btnActualizarEstado)
        Me.Controls.Add(Me.btnBuscarCodProcurador)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Actualizar Datos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCodProcurador As Button
    Friend WithEvents btnActualizarEstado As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodProcurador As TextBox
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtF_Finalizacion As TextBox
    Friend WithEvents btnAsunto As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdCliente1 As TextBox
    Friend WithEvents btnActualizar_Fecha_F As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCodProcurador As Button
    Friend WithEvents txtIdCliente2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
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
    Friend WithEvents btnSalir As Button
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
End Class
