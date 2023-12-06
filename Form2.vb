Imports System.Data.SqlClient
Public Class fmEMPLEADO
    Dim conexion As New SqlConnection("Data Source=WIN-D1G80T8LMD0\SQLEXPRESS;Initial Catalog=ProyectoPrograII;Integrated Security=True")

    Private Sub fmEMPLEADO_load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInformacion()
    End Sub

    Sub CargarInformacion()
        Dim fmEMPLEADO = "Select * From EMPLEADO Order By EmpleadoId"
        Dim da As New SqlDataAdapter(fmEMPLEADO, conexion)
        Dim dt = New DataTable
        da.Fill(dt)
        tbNombre.DataBindings.Add("Text", dt, "Nombre")
        tbNombre.Tag = "EmpleadoId"
    End Sub

    Private Sub tbNombreEmpleado_TextChanged(sender As Object, e As EventArgs) Handles tbNombre.TextChanged
        Try
            If tbNombre.ToString <> "" Then
                Dim fmEmpleado = "Select E.EmpleadoId, E.Nombre, E.Apellido, E.DUI, E.Telefono, E.Sexo,  C.NombreCargo, T.Estado
                From EMPLEADO E
                Join CARGO C On C.CargoId = E.CargoId
                Join ESTADO T On T.EstadoId = E.EstadoId =" + tbNombre.ToString + ""

                Dim da As New SqlDataAdapter(fmEmpleado, conexion)
                Dim dt As New DataTable
                da.Fill(dt)

                For Each fila As DataRow In dt.Rows
                    tbNombre.Text = fila("NombreUsuario").ToString()
                    tbApellido.Text = fila("Clave").ToString()
                    tbDUI.Text = fila("Nombre").ToString()
                    tbTelefono.Text = fila("Apellido").ToString()
                    cbSexo.Text = fila("NombreCargo").ToString()
                    cbNombreCargo.Text = fila("NombreCargo").ToString()
                    cbEstado.Text = fila("Estado").ToString()

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnActualizarEmpleado_Click(sender As Object, e As EventArgs) Handles btnActualizarEmpleado.Click
        Dim mensajeError = ""
        If tbNombre.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Nombre"
        End If
        If tbApellido.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Apellido"
        End If
        If tbDUI.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el DUI"
        End If
        If tbTelefono.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Telefono"
        End If
        If cbSexo.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Genero"
        End If
        If cbNombreCargo.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Cargo"
        End If
        If cbEstado.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Estado"
        End If

        Try
            Dim fmEMPLEADO = "Update Empleado 
                            set Nombre ='" & tbNombre.Text & "', 
                            Apellido = '" & tbApellido.Text & "'
                            DUI = '" & tbDUI.Text & "'
                            Telefono = '" & tbTelefono.Text & "'
                            Where EmpleadoId =" & tbNombre.ToString & ";"
            Dim comando As New SqlCommand(fmEMPLEADO, conexion)
            conexion.Open()
            Dim leer = comando.ExecuteReader()
            leer.Close()
            MsgBox("Se ha actualizado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CargarInformacion()
        tbNombre.Text = ""
        tbApellido.Text = ""
        tbDUI.Text = ""
        tbTelefono.Text = ""
        cbSexo.Text = ""
        cbNombreCargo.Text = ""
        cbEstado.Text = ""
    End Sub

    Sub MostrarDatos()
        Try
            Dim fmEMPLEADO As String = "E.Nombre, E.Apellido, E.DUI, E.Telefono, E.Sexo,  C.NombreCargo, T.Estado
                From EMPLEADO E
                Join CARGO C On C.CargoId = E.CargoId
                Join ESTADO T On T.EstadoId = E.EstadoId "
            Dim da As New SqlDataAdapter(fmEMPLEADO, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "EMPLEADO")
            dgDatos.DataSource = ds.Tables("EMPLEADO")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrarDatos_Click(sender As Object, e As EventArgs) Handles btnMostrarDatos.Click
        MostrarDatos()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim mensajeError = ""

        Try
            Dim query As String = "INSERT INTO EMPLEADO (Nombre, Apellido, DUI, Telefono, Sexo, CargoId, EstadoId) " &
                                  "VALUES (@Nombre, @Apellido, @DUI, @Telefono, @Sexo, @CargoId, @EstadoId);"

            Using comando As New SqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@Nombre", tbNombre.Text)
                comando.Parameters.AddWithValue("@Apellido", tbApellido.Text)
                comando.Parameters.AddWithValue("@DUI", tbDUI.Text)
                comando.Parameters.AddWithValue("@Telefono", tbTelefono.Text)
                comando.Parameters.AddWithValue("@Sexo", cbSexo.Text) ' Asegúrate de que el ComboBox tenga el ValueMember adecuado
                comando.Parameters.AddWithValue("@CargoId", cbNombreCargo.Text) ' Reemplaza ObtenerIdCargo() con la lógica para obtener el CargoId
                comando.Parameters.AddWithValue("@EstadoId", cbEstado.Text) ' Reemplaza ObtenerIdEstado() con la lógica para obtener el EstadoId

                conexion.Open()
                comando.ExecuteNonQuery()

                MsgBox("Datos guardados correctamente en la base de datos.")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

        CargarInformacion()
        MostrarDatos()
    End Sub
End Class