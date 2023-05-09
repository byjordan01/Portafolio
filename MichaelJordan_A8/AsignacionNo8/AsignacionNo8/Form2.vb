Imports System.Data
Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient.SqlCommand
Imports System.Data.SqlClient.SqlDataReader
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private ob_conexion As SqlConnection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuario, psw, BD, servidor As String

        Try
            servidor = "DESKTOP-J1PMQRG\MSSQLSERVER01"
            usuario = "MichaelJordanA8"
            psw = "mja8"
            BD = "MichaelJordan_A8"
            ob_conexion = New SqlClient.SqlConnection
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" '
            ob_conexion.Open()
            MsgBox("El servidor y la BD se conecto exitosamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    <Obsolete>
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cmd As SqlClient.SqlCommand
        cmd = New SqlClient.SqlCommand("Identificacion", ob_conexion)

        cmd.CommandText = "pa_Identificacion_Insertar"

        cmd.CommandType = System.Data.CommandType.StoredProcedure

        cmd.Parameters.Add("@Ced", txtCedula.Text)
        cmd.Parameters.Add("@Nom", txtNombre.Text)
        cmd.Parameters.Add("@Ap", txtApellido.Text)
        cmd.Parameters.Add("@Fecha", txtFecha.Text)
        cmd.Parameters.Add("@Prof", txtProfesion.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Se han insertado los registros mediante el Procedimiento Almacenado", "Registro Insertado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    <Obsolete>
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim cmd As SqlClient.SqlCommand
        cmd = New SqlClient.SqlCommand("Identificacion", ob_conexion)
        Dim data As SqlClient.SqlDataReader

        Try
            cmd.CommandText = "pa_Identificacion_Consultar"

            cmd.CommandType = System.Data.CommandType.StoredProcedure

            cmd.Parameters.Add("@Ced", txtCedula.Text)
            data = cmd.ExecuteReader()
            data.Read()
            txtCedula.Text = data("Cedula")
            txtNombre.Text = data("Nombre")
            txtApellido.Text = data("Apellido")
            txtFecha.Text = data("Fecha_Nacimiento")
            txtProfesion.Text = data("Profesion")

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Se ha consultado el registro mediante el Procedimiento Almacenado", "Registro Consultado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            MessageBox.Show("Si deseas agregar, eliminar, actualizar o consultar otro registro." & vbCrLf &
            vbCrLf & "Deberas salir de la aplicacion Procedimientos Almacenados" & vbCrLf &
            "Mediante el boton Salir del PA", "Realizar otro registro.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    <Obsolete>
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim cmd As SqlClient.SqlCommand
        cmd = New SqlClient.SqlCommand("Identificacion", ob_conexion)

        cmd.CommandText = "pa_Identificacion_Actualizar"

        cmd.CommandType = System.Data.CommandType.StoredProcedure

        cmd.Parameters.Add("@Ced", txtCedula.Text)
        cmd.Parameters.Add("@Nom", txtNombre.Text)
        cmd.Parameters.Add("@Ap", txtApellido.Text)
        cmd.Parameters.Add("@Fecha", txtFecha.Text)
        cmd.Parameters.Add("@Prof", txtProfesion.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Se han actualizado los registros mediante el Procedimiento Almacenado, Verifica la BD", "Registro Actualizado!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub

    <Obsolete>
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As SqlClient.SqlCommand
        cmd = New SqlClient.SqlCommand("Identificacion", ob_conexion)

        cmd.CommandText = "pa_Identificacion_Eliminar"

        cmd.CommandType = System.Data.CommandType.StoredProcedure

        cmd.Parameters.Add("@Ced", txtCedula.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Se ha eliminado el registro mediante el Procedimiento Almacenado", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        MsgBox("Se limpiaron los espacios de textos")
        txtCedula.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtFecha.Clear()
        txtProfesion.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class