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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtProfesion = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(170, 354)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(106, 36)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(541, 354)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(105, 36)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(409, 354)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(109, 37)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(291, 354)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(98, 36)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(222, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Profesion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(175, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(423, 37)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Procedimiento Almacenados"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtCedula.Location = New System.Drawing.Point(386, 105)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(123, 26)
        Me.txtCedula.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNombre.Location = New System.Drawing.Point(386, 151)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(123, 26)
        Me.txtNombre.TabIndex = 12
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtApellido.Location = New System.Drawing.Point(386, 196)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(123, 26)
        Me.txtApellido.TabIndex = 13
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtFecha.Location = New System.Drawing.Point(386, 242)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(123, 26)
        Me.txtFecha.TabIndex = 14
        '
        'txtProfesion
        '
        Me.txtProfesion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesion.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtProfesion.Location = New System.Drawing.Point(386, 285)
        Me.txtProfesion.Name = "txtProfesion"
        Me.txtProfesion.Size = New System.Drawing.Size(123, 26)
        Me.txtProfesion.TabIndex = 15
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(577, 165)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(142, 36)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "Clr Espacios"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(577, 244)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(142, 37)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir del PA"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtProfesion)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtProfesion As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class
