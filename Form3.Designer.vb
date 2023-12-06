<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmPROVEEDOR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmPROVEEDOR))
        Me.tbNomEmpresa = New System.Windows.Forms.TextBox()
        Me.lbNomUsuario = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.tbRepresentante = New System.Windows.Forms.TextBox()
        Me.lbRepresentante = New System.Windows.Forms.Label()
        Me.lbDepartamento = New System.Windows.Forms.Label()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMostrarDatos = New System.Windows.Forms.Button()
        Me.DgProveedor = New System.Windows.Forms.DataGridView()
        Me.lbProveedor = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbNomEmpresa
        '
        Me.tbNomEmpresa.Location = New System.Drawing.Point(501, 89)
        Me.tbNomEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNomEmpresa.Name = "tbNomEmpresa"
        Me.tbNomEmpresa.Size = New System.Drawing.Size(288, 22)
        Me.tbNomEmpresa.TabIndex = 16
        Me.tbNomEmpresa.Text = "Digite nombre."
        '
        'lbNomUsuario
        '
        Me.lbNomUsuario.AutoSize = True
        Me.lbNomUsuario.BackColor = System.Drawing.Color.White
        Me.lbNomUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbNomUsuario.Location = New System.Drawing.Point(342, 94)
        Me.lbNomUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNomUsuario.Name = "lbNomUsuario"
        Me.lbNomUsuario.Size = New System.Drawing.Size(152, 17)
        Me.lbNomUsuario.TabIndex = 15
        Me.lbNomUsuario.Text = "NOMBRE EMPRESA"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(501, 297)
        Me.tbDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(288, 22)
        Me.tbDireccion.TabIndex = 18
        Me.tbDireccion.Text = "Digite la direccion."
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.BackColor = System.Drawing.Color.White
        Me.lbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDireccion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbDireccion.Location = New System.Drawing.Point(342, 299)
        Me.lbDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(91, 17)
        Me.lbDireccion.TabIndex = 17
        Me.lbDireccion.Text = "DIRECCION"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(502, 244)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(288, 22)
        Me.tbEmail.TabIndex = 20
        Me.tbEmail.Text = "Digite e-mail."
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.BackColor = System.Drawing.Color.White
        Me.lbEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbEmail.Location = New System.Drawing.Point(342, 245)
        Me.lbEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(53, 17)
        Me.lbEmail.TabIndex = 19
        Me.lbEmail.Text = "EMAIL"
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(501, 188)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(288, 22)
        Me.tbTelefono.TabIndex = 22
        Me.tbTelefono.Text = "Digite telefono."
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.BackColor = System.Drawing.Color.White
        Me.lbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTelefono.Location = New System.Drawing.Point(342, 193)
        Me.lbTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(91, 17)
        Me.lbTelefono.TabIndex = 21
        Me.lbTelefono.Text = "TELEFONO"
        '
        'tbRepresentante
        '
        Me.tbRepresentante.Location = New System.Drawing.Point(501, 138)
        Me.tbRepresentante.Margin = New System.Windows.Forms.Padding(4)
        Me.tbRepresentante.Name = "tbRepresentante"
        Me.tbRepresentante.Size = New System.Drawing.Size(288, 22)
        Me.tbRepresentante.TabIndex = 24
        Me.tbRepresentante.Text = "Digite nombre."
        '
        'lbRepresentante
        '
        Me.lbRepresentante.AutoSize = True
        Me.lbRepresentante.BackColor = System.Drawing.Color.White
        Me.lbRepresentante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRepresentante.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbRepresentante.Location = New System.Drawing.Point(342, 143)
        Me.lbRepresentante.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRepresentante.Name = "lbRepresentante"
        Me.lbRepresentante.Size = New System.Drawing.Size(142, 17)
        Me.lbRepresentante.TabIndex = 23
        Me.lbRepresentante.Text = "REPRESENTANTE"
        '
        'lbDepartamento
        '
        Me.lbDepartamento.AutoSize = True
        Me.lbDepartamento.BackColor = System.Drawing.Color.White
        Me.lbDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDepartamento.Location = New System.Drawing.Point(342, 349)
        Me.lbDepartamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDepartamento.Name = "lbDepartamento"
        Me.lbDepartamento.Size = New System.Drawing.Size(135, 17)
        Me.lbDepartamento.TabIndex = 26
        Me.lbDepartamento.Text = "DEPARTAMENTO"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Items.AddRange(New Object() {"San Salvador. ", "San Miguel.", "Sonsonate.", "Usulután.", "Ahuchapán.", "Cabañas.", "La Paz.", "La Union.", "Morazan.", "Chalatenango.", "Santa Ana.", "Cuscatlán.", "San Vicente.", "La Libertad.", ""})
        Me.cbDepartamento.Location = New System.Drawing.Point(502, 349)
        Me.cbDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(288, 24)
        Me.cbDepartamento.TabIndex = 25
        Me.cbDepartamento.Text = "Seleccione departamento."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 138)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(435, 404)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(113, 41)
        Me.btnActualizar.TabIndex = 28
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(1290, 494)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(113, 41)
        Me.btnCerrar.TabIndex = 39
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnMostrarDatos
        '
        Me.btnMostrarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMostrarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarDatos.Location = New System.Drawing.Point(1016, 404)
        Me.btnMostrarDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(178, 41)
        Me.btnMostrarDatos.TabIndex = 40
        Me.btnMostrarDatos.Text = "MOSTRAR DATOS"
        Me.btnMostrarDatos.UseVisualStyleBackColor = False
        '
        'DgProveedor
        '
        Me.DgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProveedor.Location = New System.Drawing.Point(834, 89)
        Me.DgProveedor.Name = "DgProveedor"
        Me.DgProveedor.RowHeadersWidth = 51
        Me.DgProveedor.RowTemplate.Height = 24
        Me.DgProveedor.Size = New System.Drawing.Size(505, 284)
        Me.DgProveedor.TabIndex = 41
        '
        'lbProveedor
        '
        Me.lbProveedor.AutoSize = True
        Me.lbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProveedor.ForeColor = System.Drawing.Color.Transparent
        Me.lbProveedor.Location = New System.Drawing.Point(468, 20)
        Me.lbProveedor.Name = "lbProveedor"
        Me.lbProveedor.Size = New System.Drawing.Size(146, 25)
        Me.lbProveedor.TabIndex = 42
        Me.lbProveedor.Text = "PROVEEDOR"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(572, 404)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(113, 41)
        Me.btnGuardar.TabIndex = 43
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'fmPROVEEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1446, 566)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lbProveedor)
        Me.Controls.Add(Me.DgProveedor)
        Me.Controls.Add(Me.btnMostrarDatos)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbDepartamento)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.tbRepresentante)
        Me.Controls.Add(Me.lbRepresentante)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.lbTelefono)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.lbEmail)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.lbDireccion)
        Me.Controls.Add(Me.tbNomEmpresa)
        Me.Controls.Add(Me.lbNomUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmPROVEEDOR"
        Me.Text = "J P O  SHOES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNomEmpresa As TextBox
    Friend WithEvents lbNomUsuario As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents lbDireccion As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents lbEmail As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lbTelefono As Label
    Friend WithEvents tbRepresentante As TextBox
    Friend WithEvents lbRepresentante As Label
    Friend WithEvents lbDepartamento As Label
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMostrarDatos As Button
    Friend WithEvents DgProveedor As DataGridView
    Friend WithEvents lbProveedor As Label
    Friend WithEvents btnGuardar As Button
End Class
