<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmEMPLEADO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmEMPLEADO))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.lbApellido = New System.Windows.Forms.Label()
        Me.lbDUI = New System.Windows.Forms.Label()
        Me.tbDUI = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.lbSexo = New System.Windows.Forms.Label()
        Me.lbCargopEmpleado = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.cbNombreCargo = New System.Windows.Forms.ComboBox()
        Me.dgDatos = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnActualizarEmpleado = New System.Windows.Forms.Button()
        Me.btnMostrarDatos = New System.Windows.Forms.Button()
        Me.lbEmpleado = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 121)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(431, 121)
        Me.tbApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(288, 22)
        Me.tbApellido.TabIndex = 24
        Me.tbApellido.Text = "Digite su apellido"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(431, 78)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(288, 22)
        Me.tbNombre.TabIndex = 23
        Me.tbNombre.Text = "Digite su nombre."
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(431, 192)
        Me.tbTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(288, 22)
        Me.tbTelefono.TabIndex = 22
        Me.tbTelefono.Text = "Digite su telefono..."
        '
        'lbApellido
        '
        Me.lbApellido.AutoSize = True
        Me.lbApellido.BackColor = System.Drawing.Color.White
        Me.lbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApellido.Location = New System.Drawing.Point(272, 124)
        Me.lbApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbApellido.Name = "lbApellido"
        Me.lbApellido.Size = New System.Drawing.Size(83, 17)
        Me.lbApellido.TabIndex = 21
        Me.lbApellido.Text = "APELLIDO"
        '
        'lbDUI
        '
        Me.lbDUI.AutoSize = True
        Me.lbDUI.BackColor = System.Drawing.Color.White
        Me.lbDUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDUI.Location = New System.Drawing.Point(272, 157)
        Me.lbDUI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbDUI.Name = "lbDUI"
        Me.lbDUI.Size = New System.Drawing.Size(34, 17)
        Me.lbDUI.TabIndex = 20
        Me.lbDUI.Text = "DUI"
        '
        'tbDUI
        '
        Me.tbDUI.Location = New System.Drawing.Point(431, 158)
        Me.tbDUI.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDUI.Name = "tbDUI"
        Me.tbDUI.Size = New System.Drawing.Size(288, 22)
        Me.tbDUI.TabIndex = 19
        Me.tbDUI.Text = "Digite DUI."
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.BackColor = System.Drawing.Color.White
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(274, 81)
        Me.lbNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(74, 17)
        Me.lbNombre.TabIndex = 18
        Me.lbNombre.Text = "NOMBRE"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.BackColor = System.Drawing.Color.White
        Me.lbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTelefono.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTelefono.Location = New System.Drawing.Point(271, 190)
        Me.lbTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(91, 17)
        Me.lbTelefono.TabIndex = 17
        Me.lbTelefono.Text = "TELEFONO"
        '
        'lbSexo
        '
        Me.lbSexo.AutoSize = True
        Me.lbSexo.BackColor = System.Drawing.Color.White
        Me.lbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSexo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbSexo.Location = New System.Drawing.Point(271, 239)
        Me.lbSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSexo.Name = "lbSexo"
        Me.lbSexo.Size = New System.Drawing.Size(74, 17)
        Me.lbSexo.TabIndex = 25
        Me.lbSexo.Text = "GENERO"
        '
        'lbCargopEmpleado
        '
        Me.lbCargopEmpleado.AutoSize = True
        Me.lbCargopEmpleado.BackColor = System.Drawing.Color.White
        Me.lbCargopEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCargopEmpleado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCargopEmpleado.Location = New System.Drawing.Point(271, 279)
        Me.lbCargopEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCargopEmpleado.Name = "lbCargopEmpleado"
        Me.lbCargopEmpleado.Size = New System.Drawing.Size(63, 17)
        Me.lbCargopEmpleado.TabIndex = 27
        Me.lbCargopEmpleado.Text = "CARGO"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"ACTIVO.", "INACTIVO."})
        Me.cbEstado.Location = New System.Drawing.Point(431, 311)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(288, 24)
        Me.cbEstado.TabIndex = 32
        Me.cbEstado.Text = "Seleccione estado."
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.BackColor = System.Drawing.Color.White
        Me.lbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.Location = New System.Drawing.Point(272, 316)
        Me.lbEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(71, 17)
        Me.lbEstado.TabIndex = 31
        Me.lbEstado.Text = "ESTADO"
        '
        'cbSexo
        '
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cbSexo.Location = New System.Drawing.Point(431, 234)
        Me.cbSexo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(288, 24)
        Me.cbSexo.TabIndex = 33
        Me.cbSexo.Text = "Seleccione el genero."
        '
        'cbNombreCargo
        '
        Me.cbNombreCargo.FormattingEnabled = True
        Me.cbNombreCargo.Items.AddRange(New Object() {"GERENTE.", "CAGERO.", "VENDEDRO."})
        Me.cbNombreCargo.Location = New System.Drawing.Point(431, 274)
        Me.cbNombreCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbNombreCargo.Name = "cbNombreCargo"
        Me.cbNombreCargo.Size = New System.Drawing.Size(288, 24)
        Me.cbNombreCargo.TabIndex = 34
        Me.cbNombreCargo.Text = "Seleccione el cargo."
        '
        'dgDatos
        '
        Me.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatos.Location = New System.Drawing.Point(757, 78)
        Me.dgDatos.Name = "dgDatos"
        Me.dgDatos.RowHeadersWidth = 51
        Me.dgDatos.RowTemplate.Height = 24
        Me.dgDatos.Size = New System.Drawing.Size(556, 257)
        Me.dgDatos.TabIndex = 35
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(1200, 485)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(113, 41)
        Me.btnCerrar.TabIndex = 38
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnActualizarEmpleado
        '
        Me.btnActualizarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEmpleado.Location = New System.Drawing.Point(362, 365)
        Me.btnActualizarEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizarEmpleado.Name = "btnActualizarEmpleado"
        Me.btnActualizarEmpleado.Size = New System.Drawing.Size(113, 41)
        Me.btnActualizarEmpleado.TabIndex = 37
        Me.btnActualizarEmpleado.Text = "ACTUALIZAR"
        Me.btnActualizarEmpleado.UseVisualStyleBackColor = False
        '
        'btnMostrarDatos
        '
        Me.btnMostrarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMostrarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarDatos.Location = New System.Drawing.Point(951, 365)
        Me.btnMostrarDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(178, 41)
        Me.btnMostrarDatos.TabIndex = 39
        Me.btnMostrarDatos.Text = "MOSTRAR DATOS"
        Me.btnMostrarDatos.UseVisualStyleBackColor = False
        '
        'lbEmpleado
        '
        Me.lbEmpleado.AutoSize = True
        Me.lbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmpleado.ForeColor = System.Drawing.Color.Transparent
        Me.lbEmpleado.Location = New System.Drawing.Point(599, 18)
        Me.lbEmpleado.Name = "lbEmpleado"
        Me.lbEmpleado.Size = New System.Drawing.Size(131, 25)
        Me.lbEmpleado.TabIndex = 43
        Me.lbEmpleado.Text = "EMPLEADO"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(501, 365)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(113, 41)
        Me.btnGuardar.TabIndex = 44
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'fmEMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1372, 567)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lbEmpleado)
        Me.Controls.Add(Me.btnMostrarDatos)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnActualizarEmpleado)
        Me.Controls.Add(Me.dgDatos)
        Me.Controls.Add(Me.cbNombreCargo)
        Me.Controls.Add(Me.cbSexo)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.lbCargopEmpleado)
        Me.Controls.Add(Me.lbSexo)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbTelefono)
        Me.Controls.Add(Me.lbApellido)
        Me.Controls.Add(Me.lbDUI)
        Me.Controls.Add(Me.tbDUI)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbTelefono)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fmEMPLEADO"
        Me.Text = "J P O SHOES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lbApellido As Label
    Friend WithEvents lbDUI As Label
    Friend WithEvents tbDUI As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents lbSexo As Label
    Friend WithEvents lbCargopEmpleado As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents cbNombreCargo As ComboBox
    Friend WithEvents dgDatos As DataGridView
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnActualizarEmpleado As Button
    Friend WithEvents btnMostrarDatos As Button
    Friend WithEvents lbEmpleado As Label
    Friend WithEvents btnGuardar As Button
End Class
