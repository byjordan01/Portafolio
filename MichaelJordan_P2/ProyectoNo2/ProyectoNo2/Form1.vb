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
            BD = "Gab_Abogado_MichaelJordan_Proyecto2"
            ob_conexion = New SqlClient.SqlConnection
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" '
            ob_conexion.Open()
            MsgBox("El servidor y la BD se conecto exitosamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnInsertar_Procurador_Click(sender As Object, e As EventArgs) Handles btnInsertar_Procurador.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "INSERT INTO Procurador (codprocurador, nombre, DNI,  direccion, telefono) VALUES('" & txtCodProcurador.Text &
            "','" & txtNombre_Procurador.Text & "','" & txtDNI_Procurador.Text & "','" & txtDireccion_Procurador.Text & "','" &
            txtTelefono_Procurador.Text & "')"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Se ha insertado con exito!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnInserta_Cliente_Click(sender As Object, e As EventArgs) Handles btnInserta_Cliente.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "INSERT INTO Cliente (codcliente, nombre, DNI, direccion, telefono) VALUES('" & txtCodCliente.Text &
            "','" & txtNombre_Cliente.Text & "','" & txtDNI_Cliente.Text & "','" & txtDireccion_Cliente.Text & "','" & txtTelefono_Cliente.Text & "')"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Se ha insertado con exito!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnInsertar_Asunto_Click(sender As Object, e As EventArgs) Handles btnInsertar_Asunto.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "INSERT INTO Asunto (idcliente, descripcion, fecha_inicio, fecha_finalizacion, estado, idprocurador) VALUES('" & txtIdCliente.Text &
            "','" & txtDescripcion.Text & "','" & txtF_Inicio.Text & "','" & txtF_Finalizacion.Text & "','" &
            txtEstado.Text & "','" & txtCodProcurador.Text & "')"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Se ha insertado con exito!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub BuscarInformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarInformaciónToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ActualizarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Dim r As String
        txtIdProcurador.Text = txtCodProcurador.Text
        txtIdCliente.Text = txtCodCliente.Text
        r = MessageBox.Show("Seguro que deseas volver abrir la conexion a la BD?", "Reabir Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If r = vbYes Then
            ob_conexion.Open()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
