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

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        Dim r As String
        DGV.Rows.Clear()
        r = MessageBox.Show("Seguro que deseas volver abrir la conexion a la BD?", "Reabir Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If r = vbYes Then

            ob_conexion.Open()
        End If
    End Sub

    Private Sub btnDGV_Click(sender As Object, e As EventArgs) Handles btnDGV.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand
        Dim data As SqlClient.SqlDataReader

        Try
            smt = "select  Cliente.nombre, Cliente.DNI, Cliente.telefono, Cliente.direccion, Cliente.codcliente, Asunto.idcliente, 
                    Asunto.descripcion, Asunto.estado, Asunto.fecha_inicio, Asunto.fecha_finalizacion, Asunto.idprocurador, 
                    Procurador.codprocurador, Procurador.nombre,  Procurador.DNI, Procurador.telefono, Procurador.direccion
                    from Cliente inner join Asunto on Cliente.codcliente = Asunto.idcliente 
			                     inner join Procurador on Asunto.idprocurador = Procurador.codprocurador"

            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader()
            While (data.Read())
                DGV.Rows.Add(data.GetString(0),
                             data.GetString(1),
                             data.GetString(2),
                             data.GetString(3),
                             data.GetString(4),
                             data.GetString(5),
                             data.GetString(6),
                             data.GetString(7),
                             data.GetString(8),
                             data.GetString(9),
                             data.GetString(10),
                             data.GetString(11),
                             data.GetString(12),
                             data.GetString(13),
                             data.GetString(14),
                             data.GetString(15)
                            )
            End While
            MsgBox("Se ha realizado la consulta con exito!!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub ActualizarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class