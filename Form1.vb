Imports System.Data.SqlClient

Public Class fmUSUARIO
    Dim conexion As New SqlConnection("Data Source=WIN-D1G80T8LMD0\SQLEXPRESS;Initial Catalog=ProyectoPrograII;Integrated Security=True")

    Private Sub fmUSUARIO_load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSeleccion()
    End Sub

    Sub CargarSeleccion()
        Dim fmUSUARIO = "Select * From USUARIO Order By UsuarioId"
        Dim da As New SqlDataAdapter(fmUSUARIO, conexion)
        Dim dt = New DataTable
        da.Fill(dt)
        tbNombreUsuario.DataBindings.Add("Text", dt, "Nombre")
        tbNombreUsuario.Tag = "UsuarioId"

    End Sub

    Private Sub tbNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles tbNombreUsuario.TextChanged
        Try
            If tbNombreUsuario.ToString <> "" Then

                'Dim fmUSUARIO = "Select * From EMPLEADO
                '            Where EmpleadoId =" + cbxTIPOUSUARIO.SelectedValue.ToString + ""
                Dim fmUSUARIO = "SELECT U.UsuarioId, U.NombreUsuario, U.Clave, E.Nombre, E.Apellido, C.NombreCargo, T.Estado
                FROM USUARIO U 
                JOIN EMPLEADO E ON E.EmpleadoId = U.EmpleadoId cbNombreUsuario
                JOIN CARGO C ON C.CargoId = U.CargoId 
                JOIN ESTADO T ON T.EstadoId = U.EstadoId Where IdUsuario =" + tbNombreUsuario.ToString + ""

                Dim da As New SqlDataAdapter(fmUSUARIO, conexion)
                Dim dt As New DataTable
                da.Fill(dt)

                For Each fila As DataRow In dt.Rows
                    tbNombreUsuario.Text = fila("NombreUsuario").ToString()
                    tbClave.Text = fila("Clave").ToString()
                    tbNombre.Text = fila("Nombre").ToString()
                    tbApellido.Text = fila("Apellido").ToString()
                    cbNombreCargo.Text = fila("NombreCargo").ToString()
                    cbEstado.Text = fila("Estado").ToString()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim mensajeError = ""
        If tbNombre.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Nombre"
        End If
        If tbApellido.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Apellido"
        End If
        If tbClave.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Clave"
        End If
        If tbNombreUsuario.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Usuario"
        End If

        Try
            Dim consulta = "Update Empleado 
                            set Nombre ='" & tbNombre.Text & "', 
                            Apellido = '" & tbApellido.Text & "'
                            Clave = '" & tbClave.Text & "'
                            Where UsuarioId =" & tbNombreUsuario.ToString & ";"
            Dim comando As New SqlCommand(consulta, conexion)
            conexion.Open()
            Dim leer = comando.ExecuteReader()
            leer.Close()
            MsgBox("Se ha actualizado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CargarSeleccion()
        tbNombreUsuario.Text = ""
        tbClave.Text = ""
        tbNombre.Text = ""
        tbApellido.Text = ""
        cbNombreCargo.Text = ""
        cbEstado.Text = ""
    End Sub

    Private Sub btnSiguente_Click(sender As Object, e As EventArgs) Handles btnSiguente.Click
        Dim frm As New fmUSUARIO()
        frm.Show()
    End Sub

End Class
