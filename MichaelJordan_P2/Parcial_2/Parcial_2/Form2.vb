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
            BD = "Nota_Estudiante"
            ob_conexion = New SqlClient.SqlConnection
            ob_conexion.ConnectionString = "server=" & servidor & ";" & "database=" & BD & ";" & "user id=" & usuario & ";" & "Password=" & psw & ";" '
            ob_conexion.Open()
            MsgBox("El servidor y la BD se conecto exitosamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim smt As String
        Dim cmd As SqlClient.SqlCommand
        Dim data As SqlClient.SqlDataReader

        Try
            smt = "select DatosGenerales.codestu, DatosGenerales.cedula, DatosGenerales.nombre, DatosGenerales.apellido,
                    NotasDeExamenes.parcial_1, NotasDeExamenes.parcial_2, NotasDeExamenes.parcial_3
                    from DatosGenerales 
                inner join NotasDeExamenes on DatosGenerales.codestu = NotasDeExamenes.codnotas where codestu = '" & txtCodEstu.Text & "'"

            cmd = New SqlClient.SqlCommand(smt, ob_conexion)
            data = cmd.ExecuteReader()
            While (data.Read())
                DGV.Rows.Add(data.GetString(0),
                             data.GetString(1),
                             data.GetString(2),
                             data.GetString(3),
                             data.GetInt32(4),
                             data.GetInt32(5),
                             data.GetInt32(6)
                            )
            End While
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
            DGV.Rows.Clear()
            txtCodEstu.Clear()
            ob_conexion.Open()
        End If
    End Sub

    Private Sub ActualizarDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarDatosToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class