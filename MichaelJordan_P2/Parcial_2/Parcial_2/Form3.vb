Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form3
    Private ob_conexion As SqlConnection
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "UPDATE DatosGenerales SET cedula='" & txtCedula.Text & "',nombre='" & txtNombre.Text &
                "', apellido='" & txtApellido.Text & "' WHERE codestu='" & txtCodEstu.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se actualizaron los datos, verifica la BD", "Actualizado!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operacion", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnModificarNotas_Click(sender As Object, e As EventArgs) Handles btnModificarNotas.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "UPDATE NotasDeExamenes SET parcial_1='" & txtParcial_1.Text & "',parcial_2='" & txtParcial_2.Text &
                "',parcial_3='" & txtParcial_3.Text & "' WHERE codnotas='" & txtCodNotas.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se actualizaron los datos, verifica la BD", "Actualizado!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operacion", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Dim r As String
        r = MessageBox.Show("Seguro que deseas volver abrir la conexion a la BD?", "Reabir Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If r = vbYes Then
            txtCodEstu.Clear()
            txtCedula.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtParcial_1.Clear()
            txtParcial_2.Clear()
            txtParcial_3.Clear()
            ob_conexion.Open()
        End If
    End Sub
End Class