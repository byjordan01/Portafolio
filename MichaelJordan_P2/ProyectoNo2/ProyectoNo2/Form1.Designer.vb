<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodProcurador = New System.Windows.Forms.TextBox()
        Me.txtDNI_Procurador = New System.Windows.Forms.TextBox()
        Me.txtNombre_Procurador = New System.Windows.Forms.TextBox()
        Me.txtDireccion_Procurador = New System.Windows.Forms.TextBox()
        Me.txtTelefono_Procurador = New System.Windows.Forms.TextBox()
        Me.btnInsertar_Procurador = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtF_Inicio = New System.Windows.Forms.TextBox()
        Me.txtF_Finalizacion = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtIdProcurador = New System.Windows.Forms.TextBox()
        Me.btnInsertar_Asunto = New System.Windows.Forms.Button()
        Me.btnInserta_Cliente = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDNI_Cliente = New System.Windows.Forms.TextBox()
        Me.txtNombre_Cliente = New System.Windows.Forms.TextBox()
        Me.txtDireccion_Cliente = New System.Windows.Forms.TextBox()
        Me.txtTelefono_Cliente = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarInformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(567, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procurador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(110, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código de Procurador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(752, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(933, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefóno"
        '
        'txtCodProcurador
        '
        Me.txtCodProcurador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProcurador.Location = New System.Drawing.Point(139, 214)
        Me.txtCodProcurador.Name = "txtCodProcurador"
        Me.txtCodProcurador.Size = New System.Drawing.Size(119, 26)
        Me.txtCodProcurador.TabIndex = 6
        '
        'txtDNI_Procurador
        '
        Me.txtDNI_Procurador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI_Procurador.Location = New System.Drawing.Point(550, 214)
        Me.txtDNI_Procurador.Name = "txtDNI_Procurador"
        Me.txtDNI_Procurador.Size = New System.Drawing.Size(125, 26)
        Me.txtDNI_Procurador.TabIndex = 7
        '
        'txtNombre_Procurador
        '
        Me.txtNombre_Procurador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_Procurador.Location = New System.Drawing.Point(335, 214)
        Me.txtNombre_Procurador.Name = "txtNombre_Procurador"
        Me.txtNombre_Procurador.Size = New System.Drawing.Size(147, 26)
        Me.txtNombre_Procurador.TabIndex = 8
        '
        'txtDireccion_Procurador
        '
        Me.txtDireccion_Procurador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion_Procurador.Location = New System.Drawing.Point(719, 214)
        Me.txtDireccion_Procurador.Name = "txtDireccion_Procurador"
        Me.txtDireccion_Procurador.Size = New System.Drawing.Size(160, 26)
        Me.txtDireccion_Procurador.TabIndex = 9
        '
        'txtTelefono_Procurador
        '
        Me.txtTelefono_Procurador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono_Procurador.Location = New System.Drawing.Point(919, 214)
        Me.txtTelefono_Procurador.Name = "txtTelefono_Procurador"
        Me.txtTelefono_Procurador.Size = New System.Drawing.Size(124, 26)
        Me.txtTelefono_Procurador.TabIndex = 10
        '
        'btnInsertar_Procurador
        '
        Me.btnInsertar_Procurador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar_Procurador.Location = New System.Drawing.Point(1135, 191)
        Me.btnInsertar_Procurador.Name = "btnInsertar_Procurador"
        Me.btnInsertar_Procurador.Size = New System.Drawing.Size(121, 59)
        Me.btnInsertar_Procurador.TabIndex = 11
        Me.btnInsertar_Procurador.Text = "Insertar Procurador"
        Me.btnInsertar_Procurador.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(596, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 42)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Asunto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(113, 515)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ID Cliente"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(438, 515)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha de Inicio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(588, 515)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Fecha de Finalización"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(801, 515)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 18)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(933, 515)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 18)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "ID Procurador"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.ForeColor = System.Drawing.Color.Blue
        Me.txtIdCliente.Location = New System.Drawing.Point(100, 555)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(125, 26)
        Me.txtIdCliente.TabIndex = 18
        '
        'txtF_Inicio
        '
        Me.txtF_Inicio.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF_Inicio.Location = New System.Drawing.Point(441, 555)
        Me.txtF_Inicio.Name = "txtF_Inicio"
        Me.txtF_Inicio.Size = New System.Drawing.Size(125, 26)
        Me.txtF_Inicio.TabIndex = 19
        '
        'txtF_Finalizacion
        '
        Me.txtF_Finalizacion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtF_Finalizacion.Location = New System.Drawing.Point(603, 551)
        Me.txtF_Finalizacion.Name = "txtF_Finalizacion"
        Me.txtF_Finalizacion.Size = New System.Drawing.Size(124, 26)
        Me.txtF_Finalizacion.TabIndex = 20
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(765, 551)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(124, 26)
        Me.txtEstado.TabIndex = 21
        '
        'txtIdProcurador
        '
        Me.txtIdProcurador.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProcurador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtIdProcurador.Location = New System.Drawing.Point(923, 551)
        Me.txtIdProcurador.Name = "txtIdProcurador"
        Me.txtIdProcurador.ReadOnly = True
        Me.txtIdProcurador.Size = New System.Drawing.Size(124, 26)
        Me.txtIdProcurador.TabIndex = 22
        '
        'btnInsertar_Asunto
        '
        Me.btnInsertar_Asunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertar_Asunto.Location = New System.Drawing.Point(1135, 515)
        Me.btnInsertar_Asunto.Name = "btnInsertar_Asunto"
        Me.btnInsertar_Asunto.Size = New System.Drawing.Size(121, 62)
        Me.btnInsertar_Asunto.TabIndex = 23
        Me.btnInsertar_Asunto.Text = "Insertar Asunto"
        Me.btnInsertar_Asunto.UseVisualStyleBackColor = True
        '
        'btnInserta_Cliente
        '
        Me.btnInserta_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserta_Cliente.Location = New System.Drawing.Point(1135, 336)
        Me.btnInserta_Cliente.Name = "btnInserta_Cliente"
        Me.btnInserta_Cliente.Size = New System.Drawing.Size(121, 67)
        Me.btnInserta_Cliente.TabIndex = 24
        Me.btnInserta_Cliente.Text = "Insertar Cliente"
        Me.btnInserta_Cliente.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 27.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(596, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(142, 42)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Cliente"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(600, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 18)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "DNI"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(385, 336)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 18)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Nombre"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(752, 336)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 18)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Dirección"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(933, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 18)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Telefóno"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(113, 336)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 18)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Código del Cliente"
        '
        'txtDNI_Cliente
        '
        Me.txtDNI_Cliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI_Cliente.Location = New System.Drawing.Point(550, 377)
        Me.txtDNI_Cliente.Name = "txtDNI_Cliente"
        Me.txtDNI_Cliente.Size = New System.Drawing.Size(125, 26)
        Me.txtDNI_Cliente.TabIndex = 31
        '
        'txtNombre_Cliente
        '
        Me.txtNombre_Cliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_Cliente.Location = New System.Drawing.Point(335, 377)
        Me.txtNombre_Cliente.Name = "txtNombre_Cliente"
        Me.txtNombre_Cliente.Size = New System.Drawing.Size(147, 26)
        Me.txtNombre_Cliente.TabIndex = 32
        '
        'txtDireccion_Cliente
        '
        Me.txtDireccion_Cliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion_Cliente.Location = New System.Drawing.Point(719, 377)
        Me.txtDireccion_Cliente.Name = "txtDireccion_Cliente"
        Me.txtDireccion_Cliente.Size = New System.Drawing.Size(160, 26)
        Me.txtDireccion_Cliente.TabIndex = 33
        '
        'txtTelefono_Cliente
        '
        Me.txtTelefono_Cliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono_Cliente.Location = New System.Drawing.Point(919, 377)
        Me.txtTelefono_Cliente.Name = "txtTelefono_Cliente"
        Me.txtTelefono_Cliente.Size = New System.Drawing.Size(124, 26)
        Me.txtTelefono_Cliente.TabIndex = 34
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(133, 377)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(125, 26)
        Me.txtCodCliente.TabIndex = 35
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1364, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenúToolStripMenuItem
        '
        Me.MenúToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarInformaciónToolStripMenuItem, Me.ActualizarDatosToolStripMenuItem})
        Me.MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        Me.MenúToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenúToolStripMenuItem.Text = "Menú"
        '
        'BuscarInformaciónToolStripMenuItem
        '
        Me.BuscarInformaciónToolStripMenuItem.Name = "BuscarInformaciónToolStripMenuItem"
        Me.BuscarInformaciónToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BuscarInformaciónToolStripMenuItem.Text = "Buscar Información"
        '
        'ActualizarDatosToolStripMenuItem
        '
        Me.ActualizarDatosToolStripMenuItem.Name = "ActualizarDatosToolStripMenuItem"
        Me.ActualizarDatosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ActualizarDatosToolStripMenuItem.Text = "Actualizar Datos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(285, 515)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 18)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(273, 555)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(125, 26)
        Me.txtDescripcion.TabIndex = 38
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.Color.Yellow
        Me.btnReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciar.ForeColor = System.Drawing.Color.Blue
        Me.btnReiniciar.Location = New System.Drawing.Point(1177, 105)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(164, 68)
        Me.btnReiniciar.TabIndex = 39
        Me.btnReiniciar.Text = "Reabrir BD"
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Arial", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(460, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(429, 55)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Insertar los Datos"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1156, 617)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(185, 78)
        Me.btnSalir.TabIndex = 41
        Me.btnSalir.Text = "Salir del Programa"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.txtTelefono_Cliente)
        Me.Controls.Add(Me.txtDireccion_Cliente)
        Me.Controls.Add(Me.txtNombre_Cliente)
        Me.Controls.Add(Me.txtDNI_Cliente)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnInserta_Cliente)
        Me.Controls.Add(Me.btnInsertar_Asunto)
        Me.Controls.Add(Me.txtIdProcurador)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtF_Finalizacion)
        Me.Controls.Add(Me.txtF_Inicio)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnInsertar_Procurador)
        Me.Controls.Add(Me.txtTelefono_Procurador)
        Me.Controls.Add(Me.txtDireccion_Procurador)
        Me.Controls.Add(Me.txtNombre_Procurador)
        Me.Controls.Add(Me.txtDNI_Procurador)
        Me.Controls.Add(Me.txtCodProcurador)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodProcurador As TextBox
    Friend WithEvents txtDNI_Procurador As TextBox
    Friend WithEvents txtNombre_Procurador As TextBox
    Friend WithEvents txtDireccion_Procurador As TextBox
    Friend WithEvents txtTelefono_Procurador As TextBox
    Friend WithEvents btnInsertar_Procurador As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtF_Inicio As TextBox
    Friend WithEvents txtF_Finalizacion As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtIdProcurador As TextBox
    Friend WithEvents btnInsertar_Asunto As Button
    Friend WithEvents btnInserta_Cliente As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtDNI_Cliente As TextBox
    Friend WithEvents txtNombre_Cliente As TextBox
    Friend WithEvents txtDireccion_Cliente As TextBox
    Friend WithEvents txtTelefono_Cliente As TextBox
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarInformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label19 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents btnSalir As Button
End Class
