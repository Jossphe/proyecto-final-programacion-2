Imports System.Data.SqlClient

Public Class fmPROVEEDOR
    Dim conexion As New SqlConnection("Data Source=WIN-D1G80T8LMD0\SQLEXPRESS;Initial Catalog=ProyectoPrograII;Integrated Security=True")

    Private Sub fmPROVEEDOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerInformacion()
    End Sub

    Sub ObtenerInformacion()
        Dim fmPROVEEDOR = "Select * From EMPLEADO Order By EmpleadoId"
        Dim da As New SqlDataAdapter(fmPROVEEDOR, conexion)
        Dim dt = New DataTable
        da.Fill(dt)
        tbNomEmpresa.DataBindings.Add("Text", dt, "Nombre")
        tbNomEmpresa.Tag = "EmpleadoId"
    End Sub

    Private Sub tbNomEmpresa_TextChanged(sender As Object, e As EventArgs) Handles tbNomEmpresa.TextChanged
        Try
            If tbNomEmpresa.ToString <> "" Then
                Dim fmPROVEEDOR = "SELECT P.ProveedorId, P.NomEmpresa, P.Representante, P.Telefono, P.Email, P.Direccion, D.Departamento
                FROM PROVEEDOR P
                JOIN DEPARTAMENTO D ON P.DepartamentoId = D.DepartamentoId;" + tbNomEmpresa.ToString + ""

                Dim da As New SqlDataAdapter(fmPROVEEDOR, conexion)
                Dim dt As New DataTable
                da.Fill(dt)

                For Each fila As DataRow In dt.Rows
                    tbNomEmpresa.Text = fila("NomEmpresa").ToString()
                    tbRepresentante.Text = fila("Representante").ToString()
                    tbTelefono.Text = fila("Telefono").ToString()
                    tbEmail.Text = fila("Email").ToString()
                    tbDireccion.Text = fila("Direccion").ToString()
                    cbDepartamento.Text = fila("Departamento").ToString()

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim mensajeError = ""
        If tbNomEmpresa.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Nombre de la empresa"
        End If
        If tbRepresentante.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Nombre del Representante"
        End If
        If tbTelefono.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Telefono"
        End If
        If tbEmail.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Email"
        End If
        If tbDireccion.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar la Direccion"
        End If
        If cbDepartamento.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Departamento"
        End If


        Try
            Dim fmPROVEEDOR = "Update PROVEEDOR 
                            set NomEmpresa ='" & tbNomEmpresa.Text & "', 
                            Representante = '" & tbRepresentante.Text & "'
                            Telefono = '" & tbTelefono.Text & "'
                            Email = '" & tbEmail.Text & "'
                            Direccion = '" & tbDireccion.Text & "'
                            Departamento = '" & cbDepartamento.Text & "'
                            Where ProveedorId =" & tbNomEmpresa.ToString & ";"
            Dim comando As New SqlCommand(fmPROVEEDOR, conexion)
            conexion.Open()
            Dim leer = comando.ExecuteReader()
            leer.Close()
            MsgBox("Se ha actualizado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ObtenerInformacion()
        tbNomEmpresa.Text = ""
        tbRepresentante.Text = ""
        tbTelefono.Text = ""
        tbEmail.Text = ""
        tbDireccion.Text = ""
        cbDepartamento.Text = ""
    End Sub

    Sub MostrarDatos()
        Try
            Dim fmPROVEEDOR As String = "P.NomEmpresa, P.Representante, P.Telefono, P.Email, P.Direccion, D.Departamento
                FROM PROVEEDOR P
                JOIN DEPARTAMENTO D ON P.DepartamentoId = D.DepartamentoId"

            Dim da As New SqlDataAdapter(fmPROVEEDOR, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "PROVEEDOR")
            DgProveedor.DataSource = ds.Tables("PROVEEDOR")
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
        Try
            If String.IsNullOrEmpty(tbNomEmpresa.Text) Then
                MsgBox("Ingrese el nombre de la empresa antes de guardar.", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim consulta As String = "INSERT INTO PROVEEDOR (NomEmpresa, Representante, Telefono, Email, Direccion, DepartamentoId) " &
                                    "VALUES (@NomEmpresa, @Representante, @Telefono, @Email, @Direccion, @DepartamentoId)"

            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@NomEmpresa", tbNomEmpresa.Text)
                comando.Parameters.AddWithValue("@Representante", If(String.IsNullOrEmpty(tbRepresentante.Text), DBNull.Value, tbRepresentante.Text))
                comando.Parameters.AddWithValue("@Telefono", If(String.IsNullOrEmpty(tbTelefono.Text), DBNull.Value, tbTelefono.Text))
                comando.Parameters.AddWithValue("@Email", If(String.IsNullOrEmpty(tbEmail.Text), DBNull.Value, tbEmail.Text))
                comando.Parameters.AddWithValue("@Direccion", If(String.IsNullOrEmpty(tbDireccion.Text), DBNull.Value, tbDireccion.Text))

                Dim departamentoId As Integer
                If Integer.TryParse(cbDepartamento.SelectedValue.ToString(), departamentoId) Then
                    comando.Parameters.AddWithValue("@DepartamentoId", departamentoId)
                Else
                    comando.Parameters.AddWithValue("@DepartamentoId", DBNull.Value)
                End If
                conexion.Open()
                comando.ExecuteNonQuery()
            End Using

            MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information)

            ObtenerInformacion()
            MostrarDatos()

        Catch ex As Exception
            MsgBox("Error al intentar guardar los datos. Detalles: " & ex.Message, MsgBoxStyle.Critical)
        Finally
        End Try
    End Sub
End Class