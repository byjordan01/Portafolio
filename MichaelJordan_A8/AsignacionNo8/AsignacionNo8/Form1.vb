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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "INSERT INTO Identificacion (Cedula,Nombre,Apellido,Fecha_Nacimiento,Profesion) VALUES('" & txtCedula.Text &
            "','" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtFecha.Text & "','" & txtProfesion.Text & "')"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MsgBox("Se ha insertado con exito!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operacion", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)  'MsgBox(ex.Message)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand
        Dim data As SqlClient.SqlDataReader

        Try
            smt = "SELECT * FROM Identificacion WHERE Cedula='" & txtCedula.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader()
            data.Read()
            txtCedula.Text = data("Cedula")
            txtNombre.Text = data("Nombre")
            txtApellido.Text = data("Apellido")
            txtFecha.Text = data("Fecha_Nacimiento")
            txtProfesion.Text = data("Profesion")
            MsgBox("Se ha realizado la consulta con exito!!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operacion", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "UPDATE Identificacion SET Cedula='" & txtCedula.Text & "',Nombre='" & txtNombre.Text & "',Apellido='" & txtApellido.Text &
                "',Fecha_Nacimiento='" & Val(txtFecha.Text) & "',Profesion='" & txtProfesion.Text & "' WHERE Cedula='" & txtCedula.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se actualizaron los datos, verifica la BD", "Actualizado!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operacion", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As SqlClient.SqlCommand
        Dim smt As String
        Dim resp As String
        Try
            smt = "DELETE FROM Identificacion WHERE Cedula='" & txtCedula.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            resp = MessageBox.Show("Seguro que deseas eliminar este datos?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = vbYes Then
                cmd.ExecuteNonQuery()
                MessageBox.Show("Se ha eliminado el registro", "Registro Eliminado!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operacion", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Dim r As String
        r = MessageBox.Show("Seguro que deseas volver abrir la conexion a la BD?", "Reabir Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If r = vbYes Then
            txtCedula.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtFecha.Clear()
            txtProfesion.Clear()
            ob_conexion.Open()
        End If
    End Sub

    Private Sub PocedimientoAlmacenadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PocedimientoAlmacenadoToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
