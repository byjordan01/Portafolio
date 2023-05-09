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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBarTanqueA = New System.Windows.Forms.ProgressBar()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Timer1TanqueA_Incrementar = New System.Windows.Forms.Timer(Me.components)
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.CantidadTanqueA_Incrementar = New System.Windows.Forms.TextBox()
        Me.btnDesaguar = New System.Windows.Forms.Button()
        Me.Timer1TanqueA_Disminuir = New System.Windows.Forms.Timer(Me.components)
        Me.CantidadTanqueA_Disminuir = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Timer2TanqueB_Incrementar = New System.Windows.Forms.Timer(Me.components)
        Me.CantidadTanqueB_Incrementar = New System.Windows.Forms.TextBox()
        Me.ProgressBarTanqueB = New System.Windows.Forms.ProgressBar()
        Me.Timer3Tuberia_Incrementar = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarTuberia = New System.Windows.Forms.ProgressBar()
        Me.CantidadTuberia_Incrementar = New System.Windows.Forms.TextBox()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.btnVaciar = New System.Windows.Forms.Button()
        Me.Timer3Tuberia_Disminuir = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2TanqueB_Disminuir = New System.Windows.Forms.Timer(Me.components)
        Me.CantidadTanqueB_Disminuir = New System.Windows.Forms.TextBox()
        Me.CantidadTuberia_Disminuir = New System.Windows.Forms.TextBox()
        Me.btnResetear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TuberiaV = New System.Windows.Forms.PictureBox()
        Me.TuberiaF = New System.Windows.Forms.PictureBox()
        Me.TanqueV4 = New System.Windows.Forms.PictureBox()
        Me.TanqueF3 = New System.Windows.Forms.PictureBox()
        Me.TanqueV2 = New System.Windows.Forms.PictureBox()
        Me.TanqueF1 = New System.Windows.Forms.PictureBox()
        CType(Me.TuberiaV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TuberiaF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanqueV4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanqueF3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanqueV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TanqueF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarTanqueA
        '
        Me.ProgressBarTanqueA.Location = New System.Drawing.Point(35, 254)
        Me.ProgressBarTanqueA.Name = "ProgressBarTanqueA"
        Me.ProgressBarTanqueA.Size = New System.Drawing.Size(100, 30)
        Me.ProgressBarTanqueA.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(8, 450)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'Timer1TanqueA_Incrementar
        '
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.Lime
        Me.btnIniciar.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.ForeColor = System.Drawing.Color.Black
        Me.btnIniciar.Location = New System.Drawing.Point(173, 71)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(118, 40)
        Me.btnIniciar.TabIndex = 5
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'CantidadTanqueA_Incrementar
        '
        Me.CantidadTanqueA_Incrementar.ForeColor = System.Drawing.Color.Blue
        Me.CantidadTanqueA_Incrementar.Location = New System.Drawing.Point(240, 159)
        Me.CantidadTanqueA_Incrementar.Name = "CantidadTanqueA_Incrementar"
        Me.CantidadTanqueA_Incrementar.Size = New System.Drawing.Size(77, 20)
        Me.CantidadTanqueA_Incrementar.TabIndex = 9
        Me.CantidadTanqueA_Incrementar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDesaguar
        '
        Me.btnDesaguar.BackColor = System.Drawing.Color.Blue
        Me.btnDesaguar.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesaguar.ForeColor = System.Drawing.Color.White
        Me.btnDesaguar.Location = New System.Drawing.Point(339, 71)
        Me.btnDesaguar.Name = "btnDesaguar"
        Me.btnDesaguar.Size = New System.Drawing.Size(141, 40)
        Me.btnDesaguar.TabIndex = 11
        Me.btnDesaguar.Text = "Desaguar"
        Me.btnDesaguar.UseVisualStyleBackColor = False
        '
        'Timer1TanqueA_Disminuir
        '
        '
        'CantidadTanqueA_Disminuir
        '
        Me.CantidadTanqueA_Disminuir.ForeColor = System.Drawing.Color.Red
        Me.CantidadTanqueA_Disminuir.Location = New System.Drawing.Point(240, 371)
        Me.CantidadTanqueA_Disminuir.Name = "CantidadTanqueA_Disminuir"
        Me.CantidadTanqueA_Disminuir.Size = New System.Drawing.Size(77, 20)
        Me.CantidadTanqueA_Disminuir.TabIndex = 12
        Me.CantidadTanqueA_Disminuir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Black
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Red
        Me.btnSalir.Location = New System.Drawing.Point(667, 375)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(121, 67)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Timer2TanqueB_Incrementar
        '
        '
        'CantidadTanqueB_Incrementar
        '
        Me.CantidadTanqueB_Incrementar.ForeColor = System.Drawing.Color.Blue
        Me.CantidadTanqueB_Incrementar.Location = New System.Drawing.Point(485, 124)
        Me.CantidadTanqueB_Incrementar.Name = "CantidadTanqueB_Incrementar"
        Me.CantidadTanqueB_Incrementar.Size = New System.Drawing.Size(77, 20)
        Me.CantidadTanqueB_Incrementar.TabIndex = 14
        Me.CantidadTanqueB_Incrementar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgressBarTanqueB
        '
        Me.ProgressBarTanqueB.Location = New System.Drawing.Point(667, 254)
        Me.ProgressBarTanqueB.Name = "ProgressBarTanqueB"
        Me.ProgressBarTanqueB.Size = New System.Drawing.Size(100, 30)
        Me.ProgressBarTanqueB.TabIndex = 16
        '
        'Timer3Tuberia_Incrementar
        '
        '
        'ProgressBarTuberia
        '
        Me.ProgressBarTuberia.Location = New System.Drawing.Point(384, 300)
        Me.ProgressBarTuberia.Name = "ProgressBarTuberia"
        Me.ProgressBarTuberia.Size = New System.Drawing.Size(34, 30)
        Me.ProgressBarTuberia.TabIndex = 19
        '
        'CantidadTuberia_Incrementar
        '
        Me.CantidadTuberia_Incrementar.ForeColor = System.Drawing.Color.Blue
        Me.CantidadTuberia_Incrementar.Location = New System.Drawing.Point(384, 211)
        Me.CantidadTuberia_Incrementar.Name = "CantidadTuberia_Incrementar"
        Me.CantidadTuberia_Incrementar.Size = New System.Drawing.Size(28, 20)
        Me.CantidadTuberia_Incrementar.TabIndex = 20
        Me.CantidadTuberia_Incrementar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CantidadTuberia_Incrementar.Visible = False
        '
        'btnTerminar
        '
        Me.btnTerminar.BackColor = System.Drawing.Color.Black
        Me.btnTerminar.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.ForeColor = System.Drawing.Color.Cyan
        Me.btnTerminar.Location = New System.Drawing.Point(14, 388)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(170, 54)
        Me.btnTerminar.TabIndex = 21
        Me.btnTerminar.Text = "Terminar Todo"
        Me.btnTerminar.UseVisualStyleBackColor = False
        '
        'btnVaciar
        '
        Me.btnVaciar.BackColor = System.Drawing.Color.Silver
        Me.btnVaciar.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVaciar.ForeColor = System.Drawing.Color.Cyan
        Me.btnVaciar.Location = New System.Drawing.Point(525, 72)
        Me.btnVaciar.Name = "btnVaciar"
        Me.btnVaciar.Size = New System.Drawing.Size(138, 39)
        Me.btnVaciar.TabIndex = 22
        Me.btnVaciar.Text = "Vaciar Todo"
        Me.btnVaciar.UseVisualStyleBackColor = False
        '
        'Timer3Tuberia_Disminuir
        '
        '
        'Timer2TanqueB_Disminuir
        '
        '
        'CantidadTanqueB_Disminuir
        '
        Me.CantidadTanqueB_Disminuir.ForeColor = System.Drawing.Color.Red
        Me.CantidadTanqueB_Disminuir.Location = New System.Drawing.Point(485, 336)
        Me.CantidadTanqueB_Disminuir.Name = "CantidadTanqueB_Disminuir"
        Me.CantidadTanqueB_Disminuir.Size = New System.Drawing.Size(77, 20)
        Me.CantidadTanqueB_Disminuir.TabIndex = 23
        Me.CantidadTanqueB_Disminuir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CantidadTuberia_Disminuir
        '
        Me.CantidadTuberia_Disminuir.ForeColor = System.Drawing.Color.Red
        Me.CantidadTuberia_Disminuir.Location = New System.Drawing.Point(387, 264)
        Me.CantidadTuberia_Disminuir.Name = "CantidadTuberia_Disminuir"
        Me.CantidadTuberia_Disminuir.Size = New System.Drawing.Size(25, 20)
        Me.CantidadTuberia_Disminuir.TabIndex = 24
        Me.CantidadTuberia_Disminuir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CantidadTuberia_Disminuir.Visible = False
        '
        'btnResetear
        '
        Me.btnResetear.BackColor = System.Drawing.Color.Yellow
        Me.btnResetear.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetear.ForeColor = System.Drawing.Color.Black
        Me.btnResetear.Location = New System.Drawing.Point(14, 341)
        Me.btnResetear.Name = "btnResetear"
        Me.btnResetear.Size = New System.Drawing.Size(122, 41)
        Me.btnResetear.TabIndex = 25
        Me.btnResetear.Text = "Resetear"
        Me.btnResetear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "TanqueA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(633, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "TanqueB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(30, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(737, 34)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Simulacion de Llenado y Vacio de Depositos de Liquidos"
        '
        'TuberiaV
        '
        Me.TuberiaV.Image = Global.ProyectoNo1.My.Resources.Resources.bar_vacia
        Me.TuberiaV.Location = New System.Drawing.Point(370, 237)
        Me.TuberiaV.Name = "TuberiaV"
        Me.TuberiaV.Size = New System.Drawing.Size(58, 20)
        Me.TuberiaV.TabIndex = 18
        Me.TuberiaV.TabStop = False
        '
        'TuberiaF
        '
        Me.TuberiaF.Image = Global.ProyectoNo1.My.Resources.Resources.barojo
        Me.TuberiaF.Location = New System.Drawing.Point(370, 237)
        Me.TuberiaF.Name = "TuberiaF"
        Me.TuberiaF.Size = New System.Drawing.Size(58, 21)
        Me.TuberiaF.TabIndex = 17
        Me.TuberiaF.TabStop = False
        '
        'TanqueV4
        '
        Me.TanqueV4.BackgroundImage = Global.ProyectoNo1.My.Resources.Resources.bar_vacia
        Me.TanqueV4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TanqueV4.Location = New System.Drawing.Point(427, 150)
        Me.TanqueV4.Name = "TanqueV4"
        Me.TanqueV4.Size = New System.Drawing.Size(200, 180)
        Me.TanqueV4.TabIndex = 8
        Me.TanqueV4.TabStop = False
        '
        'TanqueF3
        '
        Me.TanqueF3.BackgroundImage = Global.ProyectoNo1.My.Resources.Resources.barojo
        Me.TanqueF3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TanqueF3.Location = New System.Drawing.Point(427, 150)
        Me.TanqueF3.Name = "TanqueF3"
        Me.TanqueF3.Size = New System.Drawing.Size(200, 180)
        Me.TanqueF3.TabIndex = 7
        Me.TanqueF3.TabStop = False
        '
        'TanqueV2
        '
        Me.TanqueV2.BackgroundImage = Global.ProyectoNo1.My.Resources.Resources.bar_vacia
        Me.TanqueV2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TanqueV2.Location = New System.Drawing.Point(173, 185)
        Me.TanqueV2.Name = "TanqueV2"
        Me.TanqueV2.Size = New System.Drawing.Size(200, 180)
        Me.TanqueV2.TabIndex = 2
        Me.TanqueV2.TabStop = False
        '
        'TanqueF1
        '
        Me.TanqueF1.BackgroundImage = Global.ProyectoNo1.My.Resources.Resources.barojo
        Me.TanqueF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TanqueF1.Location = New System.Drawing.Point(173, 185)
        Me.TanqueF1.Name = "TanqueF1"
        Me.TanqueF1.Size = New System.Drawing.Size(200, 180)
        Me.TanqueF1.TabIndex = 1
        Me.TanqueF1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnResetear)
        Me.Controls.Add(Me.CantidadTuberia_Disminuir)
        Me.Controls.Add(Me.CantidadTanqueB_Disminuir)
        Me.Controls.Add(Me.btnVaciar)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.CantidadTuberia_Incrementar)
        Me.Controls.Add(Me.ProgressBarTuberia)
        Me.Controls.Add(Me.TuberiaV)
        Me.Controls.Add(Me.TuberiaF)
        Me.Controls.Add(Me.ProgressBarTanqueB)
        Me.Controls.Add(Me.CantidadTanqueB_Incrementar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.CantidadTanqueA_Disminuir)
        Me.Controls.Add(Me.btnDesaguar)
        Me.Controls.Add(Me.CantidadTanqueA_Incrementar)
        Me.Controls.Add(Me.TanqueV4)
        Me.Controls.Add(Me.TanqueF3)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.TanqueV2)
        Me.Controls.Add(Me.TanqueF1)
        Me.Controls.Add(Me.ProgressBarTanqueA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TuberiaV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TuberiaF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanqueV4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanqueF3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanqueV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TanqueF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBarTanqueA As ProgressBar
    Friend WithEvents TanqueF1 As PictureBox
    Friend WithEvents TanqueV2 As PictureBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Timer1TanqueA_Incrementar As Timer
    Friend WithEvents btnIniciar As Button
    Friend WithEvents TanqueF3 As PictureBox
    Friend WithEvents TanqueV4 As PictureBox
    Friend WithEvents CantidadTanqueA_Incrementar As TextBox
    Friend WithEvents btnDesaguar As Button
    Friend WithEvents Timer1TanqueA_Disminuir As Timer
    Friend WithEvents CantidadTanqueA_Disminuir As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Timer2TanqueB_Incrementar As Timer
    Friend WithEvents CantidadTanqueB_Incrementar As TextBox
    Friend WithEvents ProgressBarTanqueB As ProgressBar
    Friend WithEvents TuberiaF As PictureBox
    Friend WithEvents TuberiaV As PictureBox
    Friend WithEvents Timer3Tuberia_Incrementar As Timer
    Friend WithEvents ProgressBarTuberia As ProgressBar
    Friend WithEvents CantidadTuberia_Incrementar As TextBox
    Friend WithEvents btnTerminar As Button
    Friend WithEvents btnVaciar As Button
    Friend WithEvents Timer3Tuberia_Disminuir As Timer
    Friend WithEvents Timer2TanqueB_Disminuir As Timer
    Friend WithEvents CantidadTanqueB_Disminuir As TextBox
    Friend WithEvents CantidadTuberia_Disminuir As TextBox
    Friend WithEvents btnResetear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
