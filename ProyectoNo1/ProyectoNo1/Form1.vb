Imports System.Threading

Public Class Form1
    Dim canTA As Integer
    Dim canTB As Integer
    Dim tubo As Integer

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Timer1TanqueA_Incrementar.Start()
    End Sub

    Private Sub btnDesaguar_Click(sender As Object, e As EventArgs) Handles btnDesaguar.Click
        'El boton desaguar vaciara los tanques, proceso como el de iniciar

        '**Si Selecciona el boton Terminar Todo y luego desea vaciarlo con el boton Desaguar**
        '**debera seleccionar el boton Resetear ya que contiene una logica diferente**

        If canTA = Nothing Then
            MsgBox("Debes seleccionar el botono 'Resetear'")
        Else
            Timer2TanqueB_Disminuir.Start()
            If canTB = 151 Then
                Timer1TanqueA_Disminuir.Start()
            End If
        End If
    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Dim si As String
        si = MessageBox.Show("Estas seguro que deseas terminar el llenado por completo?", "Terminar Llenado", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If si = DialogResult.Yes Then
            'Al seleccionar Terminar Todo, se llenaran los tanques
            ProgressBarTanqueA.Increment(1)
            TanqueV2.Height = 0 - ProgressBarTanqueA.Maximum * 1
            TuberiaV.Height = 0 - ProgressBarTuberia.Maximum * 1
            TanqueV4.Height = 0 - ProgressBarTanqueB.Maximum * 1

            CantidadTanqueA_Incrementar.Text = 180
            CantidadTanqueB_Incrementar.Text = 180
            CantidadTuberia_Incrementar.Text = 10
        End If
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        Dim si As String
        si = MessageBox.Show("Estas seguro que deseas vaciar los tanques?", "Vaciar Depositos", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If si = DialogResult.Yes Then
            'Al seleccionar Vaciar Todo, se vaciaran los tanques
            ProgressBarTanqueA.Increment(1)
            TanqueV2.Height = 180 - ProgressBarTanqueA.Minimum * 1
            TuberiaV.Height = 20 - ProgressBarTuberia.Minimum * 1
            TanqueV4.Height = 180 - ProgressBarTanqueB.Minimum * 1

            CantidadTanqueA_Incrementar.Text = 0
            CantidadTanqueA_Disminuir.Text = 0

            CantidadTanqueB_Incrementar.Text = 0
            CantidadTanqueB_Disminuir.Text = 0

            CantidadTuberia_Incrementar.Text = 0
            CantidadTuberia_Disminuir.Text = 0
        End If
    End Sub

    '--*Tiempo Incrementando
    'TanqueA Incrementando
    Private Sub Timer1TanqueA_Incrementar_Tick(sender As Object, e As EventArgs) Handles Timer1TanqueA_Incrementar.Tick
        ProgressBarTanqueA.Increment(1)
        TanqueV2.Height = 180 - ProgressBarTanqueA.Maximum * 1

        CantidadTanqueA_Incrementar.Text = canTA
        ProgressBarTanqueA.Maximum = canTA
        canTA = canTA + 1
        If canTA = 121 Then
            Timer1TanqueA_Incrementar.Stop()
        End If

        '*Tuberia*
        If canTA = 113 Then
            Timer3Tuberia_Incrementar.Start()
        End If
        '-----------------------

        If canTA = 121 Then
            Timer2TanqueB_Incrementar.Start()
        End If

        If canTA = 141 Then
            Timer2TanqueB_Incrementar.Start()
        End If

        If canTA = 181 Then
            Timer1TanqueA_Incrementar.Stop()
        End If
    End Sub

    'TanqueB Incrementando
    Private Sub Timer2TanqueB_Incrementar_Tick(sender As Object, e As EventArgs) Handles Timer2TanqueB_Incrementar.Tick
        ProgressBarTanqueB.Increment(1)
        TanqueV4.Height = 180 - ProgressBarTanqueB.Maximum * 1

        CantidadTanqueB_Incrementar.Text = canTB
        ProgressBarTanqueB.Maximum = canTB
        canTB = canTB + 1

        If canTB = 111 Then
            Timer1TanqueA_Incrementar.Start()
        End If

        If canTB = 89 Then
            Timer3Tuberia_Incrementar.Start()
        End If

        If canTB = 181 Then
            Timer2TanqueB_Incrementar.Stop()
        End If
    End Sub

    'Tuberia Incrementando
    Private Sub Timer3Tuberia_Incrementar_Tick(sender As Object, e As EventArgs) Handles Timer3Tuberia_Incrementar.Tick
        ProgressBarTuberia.Increment(1)
        TuberiaV.Height = 20 - ProgressBarTuberia.Maximum * 1

        CantidadTuberia_Incrementar.Text = tubo
        ProgressBarTuberia.Maximum = tubo
        tubo = tubo + 1
        If tubo = 12 Then
            Timer3Tuberia_Incrementar.Stop()
        End If

        If tubo = 16 Then
            Timer1TanqueA_Incrementar.Start()
        End If

        If tubo = 16 Then
            Timer2TanqueB_Incrementar.Start()
        End If

        If tubo = 21 Then
            Timer3Tuberia_Incrementar.Stop()
        End If
    End Sub


    '--*Tiempo Disminuyendo
    'TanqueA Disminuyendo
    Private Sub Timer1TanqueA_Disminuir_Tick(sender As Object, e As EventArgs) Handles Timer1TanqueA_Disminuir.Tick
        'para disminuir
        ProgressBarTanqueA.Increment(-1)
        TanqueV2.Height = 180 - ProgressBarTanqueA.Minimum * 1

        CantidadTanqueA_Disminuir.Text = canTA
        ProgressBarTanqueA.Minimum = canTA

        canTA = canTA - 1

        If canTA = 0 Then
            Timer1TanqueA_Disminuir.Stop()
        End If

        If canTA = 131 Then
            Timer3Tuberia_Disminuir.Start()
        End If
    End Sub

    'TanqueB Disminuyendo
    Private Sub Timer2TanqueB_Disminuir_Tick(sender As Object, e As EventArgs) Handles Timer2TanqueB_Disminuir.Tick
        ProgressBarTanqueB.Increment(-1)
        TanqueV4.Height = 180 - ProgressBarTanqueB.Minimum * 1

        ProgressBarTanqueB.Minimum = canTB
        CantidadTanqueB_Disminuir.Text = canTB
        canTB = canTB - 1

        If canTB = 146 Then
            Timer1TanqueA_Disminuir.Start()
        End If

        If canTB = 0 Then
            Timer2TanqueB_Disminuir.Stop()
        End If
    End Sub

    'Tuberia Disminuyendo
    Private Sub Timer3Tuberia_Disminuir_Tick(sender As Object, e As EventArgs) Handles Timer3Tuberia_Disminuir.Tick
        ProgressBarTuberia.Increment(-1)
        TuberiaV.Height = 20 - ProgressBarTuberia.Minimum * 1

        ProgressBarTuberia.Minimum = tubo

        CantidadTuberia_Disminuir.Text = tubo
        tubo = tubo - 1

        If tubo = 0 Then
            Timer3Tuberia_Disminuir.Stop()
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As String
        opcion = MessageBox.Show("Salir de la Aplicacion", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnResetear_Click(sender As Object, e As EventArgs) Handles btnResetear.Click
        Dim si As String
        si = MessageBox.Show("Desea reiniciar?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If si = DialogResult.Yes Then
            CantidadTanqueA_Incrementar.Text = 0
            CantidadTanqueA_Disminuir.Text = 0

            CantidadTanqueB_Incrementar.Text = 0
            CantidadTuberia_Incrementar.Text = 0

            CantidadTanqueB_Disminuir.Text = 0
            CantidadTuberia_Disminuir.Text = 0

            CantidadTanqueA_Incrementar.Text = canTA

            canTA = canTA + 1
            If canTA = 121 Then
                Timer1TanqueA_Incrementar.Stop()
            End If

            'Tuberia
            If canTA = 113 Then
                Timer3Tuberia_Incrementar.Start()
            End If
            '-----------------------

            If canTA = 121 Then
                Timer2TanqueB_Incrementar.Start()
            End If

            If canTA = 141 Then
                Timer2TanqueB_Incrementar.Start()
            End If

            If canTA = 181 Then
                Timer1TanqueA_Incrementar.Stop()
            End If
        End If
    End Sub
End Class
