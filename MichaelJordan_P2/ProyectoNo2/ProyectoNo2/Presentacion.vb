﻿Imports System.Security

Public Class Presentacion
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 1
            Label1.Text = "Cargando.. " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class