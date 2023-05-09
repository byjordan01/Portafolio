Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Private ob_conexion As SqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario, psw, BD, servidor As String

        Try
            servidor = "DESKTOP-J1PMQRG\MSSQLSERVER01"
            usuario = "MichaelJordanP2"
            psw = "mjp2"
            BD = "Nota_Estudiante"
            ob_conexion = New SqlClient.SqlConnection
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" '
            ob_conexion.Open()
            MsgBox("El servidor y la BD se conecto exitosamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEstudiante_Click(sender As Object, e As EventArgs) Handles btnEstudiante.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "INSERT INTO DatosGenerales (codestu, cedula, nombre, apellido) VALUES('" & txtCodEstu.Text &
            "','" & txtCedula.Text & "','" & txtNombre.Text & "','" & txtApellido.Text & "')"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Se ha insertado el estuandiante con exito!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "INSERT INTO NotasDeExamenes (codnotas, parcial_1, parcial_2, parcial_3) VALUES('" & txtCodEstuNota.Text &
            "','" & txtParcial1.Text & "','" & txtParcial2.Text & "','" & txtParcial3.Text & "')"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Se ha insertado las notas con exito!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnGrid_Click(sender As Object, e As EventArgs) Handles btnGrid.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand
        Dim data As SqlClient.SqlDataReader
        Try
            smt = "select DatosGenerales.codestu, DatosGenerales.cedula, 
                DatosGenerales.nombre, DatosGenerales.apellido, NotasDeExamenes.parcial_1, 
                NotasDeExamenes.parcial_2, NotasDeExamenes.parcial_3
                from DatosGenerales inner join NotasDeExamenes on DatosGenerales.codestu = NotasDeExamenes.codnotas
                    where codestu = '" & txtCodEstu.Text & "'"

            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader()
            While (data.Read())
                DGV.Rows.Add(data.GetString(0),
                             data.GetString(1),
                             data.GetString(2),
                             data.GetString(3),
                             data.GetInt32(4),
                             data.GetInt32(5),
                             data.GetInt32(6))
            End While

            'DGV2
            Dim parcial1 As Integer
            Dim parcial2 As Integer
            Dim parcial3 As Integer
            Dim promparcial As Integer
            Dim examfinal As Integer
            Dim total As Double
            Dim calfinal As String
            parcial1 = Val(txtParcial1.Text)
            parcial2 = Val(txtParcial2.Text)
            parcial3 = Val(txtParcial3.Text)
            examfinal = Val(txtExamenF.Text) * 0.4

            promparcial = (((parcial1 + parcial2 + parcial3) / 3) * 0.6)
            total = promparcial + examfinal

            If total >= 90.5 Or total = 100 Then
                calfinal = "A"
            ElseIf total >= 80.6 Or total = 90.5 Then
                calfinal = "B"
            ElseIf total >= 70.6 Or total = 80.5 Then
                calfinal = "C"
            ElseIf total >= 60.6 Or total = 70.5 Then
                calfinal = "D"
            ElseIf total <= 60.6 Then
                calfinal = "F"
            End If
            DGV2.Rows.Add(promparcial, examfinal, calfinal)

            MsgBox("Se ha realizado la consulta con exito!!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Dim r As String
        r = MessageBox.Show("Seguro que deseas volver abrir la conexion a la BD?", "Reabir Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If r = vbYes Then
            txtCodEstuNota.Text = txtCodEstu.Text
            ob_conexion.Open()
        End If
    End Sub

    Private Sub BuscarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarDatosToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ActualizarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub NuevoE_Click(sender As Object, e As EventArgs) Handles NuevoE.Click
        txtCodEstu.Clear()
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCodEstuNota.Clear()
        txtParcial1.Clear()
        txtParcial2.Clear()
        txtParcial3.Clear()
        txtExamenF.Clear()
    End Sub
End Class
