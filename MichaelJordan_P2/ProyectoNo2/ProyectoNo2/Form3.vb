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
        r = MessageBox.Show("Seguro que deseas volver abrir la conexion a la BD?", "Reabir Conexion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If r = vbYes Then
            DGV.Rows.Clear()
            DGV2.Rows.Clear()
            ob_conexion.Open()
        End If
    End Sub

    Private Sub btnBuscarCodProcurador_Click(sender As Object, e As EventArgs) Handles btnBuscarCodProcurador.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand
        Dim data As SqlClient.SqlDataReader

        Try
            smt = "select Procurador.codprocurador, Procurador.nombre, Procurador.DNI, Asunto.descripcion,
                    Asunto.idcliente, Cliente.nombre, Cliente.DNI, Asunto.estado, Asunto.fecha_inicio, Asunto.fecha_finalizacion
                    from Procurador inner join Asunto on Procurador.codprocurador = Asunto.idprocurador
			                        inner join Cliente on Asunto.idcliente = Cliente.codcliente
                                     where codprocurador ='" & txtCodProcurador.Text & "'"

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
                             data.GetString(9)
                            )
            End While
            MsgBox("Se ha realizado la consulta con exito!!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnCodProcurador_Click(sender As Object, e As EventArgs) Handles btnCodProcurador.Click
        txtCodProcurador.Clear()
    End Sub

    Private Sub btnActualizar_Fecha_F_Click(sender As Object, e As EventArgs) Handles btnActualizar_Fecha_F.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "Update Asunto set fecha_finalizacion ='" & txtF_Finalizacion.Text & "' where idcliente ='" & txtIdCliente1.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se actualizaron los datos, verifica la BD", "Actualizado!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnActualizarEstado_Click(sender As Object, e As EventArgs) Handles btnActualizarEstado.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand

        Try
            smt = "Update Asunto set estado ='" & txtEstado.Text & "' where idcliente ='" & txtIdCliente1.Text & "'"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se actualizaron los datos, verifica la BD", "Actualizado!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnAsunto_Click(sender As Object, e As EventArgs) Handles btnAsunto.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand
        Dim data As SqlClient.SqlDataReader

        Try
            smt = "Select * from Asunto"
            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader()
            While (data.Read())
                DGV2.Rows.Add(data.GetString(0),
                             data.GetString(1),
                             data.GetString(2),
                             data.GetString(3),
                             data.GetString(4),
                             data.GetString(5)
                            )
            End While
            MsgBox("Se ha realizado la consulta con exito!!")
            MessageBox.Show("Presiona el boton Reabir BD, para realizar otra operación", "Reabir la conexion a la BD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ups ha ocurrido un error para Consultar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ob_conexion.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtF_Finalizacion.Clear()
        txtIdCliente1.Clear()
        txtEstado.Clear()
        txtIdCliente2.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class