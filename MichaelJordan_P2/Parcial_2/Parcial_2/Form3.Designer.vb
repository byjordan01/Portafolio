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
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtParcial_1 = New System.Windows.Forms.TextBox()
        Me.txtParcial_2 = New System.Windows.Forms.TextBox()
        Me.txtParcial_3 = New System.Windows.Forms.TextBox()
        Me.txtCodEstu = New System.Windows.Forms.TextBox()
        Me.txtCodNotas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnModificarNotas = New System.Windows.Forms.Button()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actualizar Datos"
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(129, 170)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(100, 20)
        Me.txtCedula.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(269, 170)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(96, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(402, 170)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtParcial_1
        '
        Me.txtParcial_1.Location = New System.Drawing.Point(142, 328)
        Me.txtParcial_1.Name = "txtParcial_1"
        Me.txtParcial_1.Size = New System.Drawing.Size(87, 20)
        Me.txtParcial_1.TabIndex = 4
        '
        'txtParcial_2
        '
        Me.txtParcial_2.Location = New System.Drawing.Point(269, 328)
        Me.txtParcial_2.Name = "txtParcial_2"
        Me.txtParcial_2.Size = New System.Drawing.Size(100, 20)
        Me.txtParcial_2.TabIndex = 5
        '
        'txtParcial_3
        '
        Me.txtParcial_3.Location = New System.Drawing.Point(402, 328)
        Me.txtParcial_3.Name = "txtParcial_3"
        Me.txtParcial_3.Size = New System.Drawing.Size(100, 20)
        Me.txtParcial_3.TabIndex = 6
        '
        'txtCodEstu
        '
        Me.txtCodEstu.Location = New System.Drawing.Point(222, 99)
        Me.txtCodEstu.Name = "txtCodEstu"
        Me.txtCodEstu.Size = New System.Drawing.Size(100, 20)
        Me.txtCodEstu.TabIndex = 7
        '
        'txtCodNotas
        '
        Me.txtCodNotas.Location = New System.Drawing.Point(235, 263)
        Me.txtCodNotas.Name = "txtCodNotas"
        Me.txtCodNotas.Size = New System.Drawing.Size(100, 20)
        Me.txtCodNotas.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(436, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Parcial 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(297, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Parcial 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(423, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Parcial 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Escribe Codigo del Estudiante: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Cod Estudiante"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(262, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Cod Estudiante"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 263)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Vuelva a repetir el Codigo del Estudiante"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(560, 147)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(129, 43)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "Modificar Nombres"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnModificarNotas
        '
        Me.btnModificarNotas.Location = New System.Drawing.Point(560, 312)
        Me.btnModificarNotas.Name = "btnModificarNotas"
        Me.btnModificarNotas.Size = New System.Drawing.Size(122, 36)
        Me.btnModificarNotas.TabIndex = 22
        Me.btnModificarNotas.Text = "Modificar Notas"
        Me.btnModificarNotas.UseVisualStyleBackColor = True
        '
        'btnReiniciar
        '
        Me.btnReiniciar.Location = New System.Drawing.Point(674, 40)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(75, 46)
        Me.btnReiniciar.TabIndex = 23
        Me.btnReiniciar.Text = "REABRIR BD"
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.btnModificarNotas)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodNotas)
        Me.Controls.Add(Me.txtCodEstu)
        Me.Controls.Add(Me.txtParcial_3)
        Me.Controls.Add(Me.txtParcial_2)
        Me.Controls.Add(Me.txtParcial_1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtParcial_1 As TextBox
    Friend WithEvents txtParcial_2 As TextBox
    Friend WithEvents txtParcial_3 As TextBox
    Friend WithEvents txtCodEstu As TextBox
    Friend WithEvents txtCodNotas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnModificarNotas As Button
    Friend WithEvents btnReiniciar As Button
End Class
