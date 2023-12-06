<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmUSUARIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmUSUARIO))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbNomUsuario = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.cbNombreCargo = New System.Windows.Forms.ComboBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnSiguente = New System.Windows.Forms.Button()
        Me.lbClave = New System.Windows.Forms.Label()
        Me.lbCargo = New System.Windows.Forms.Label()
        Me.lbApellido = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.tbClave = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(213, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbNomUsuario
        '
        Me.lbNomUsuario.AutoSize = True
        Me.lbNomUsuario.BackColor = System.Drawing.Color.White
        Me.lbNomUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNomUsuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbNomUsuario.Location = New System.Drawing.Point(110, 223)
        Me.lbNomUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNomUsuario.Name = "lbNomUsuario"
        Me.lbNomUsuario.Size = New System.Drawing.Size(77, 17)
        Me.lbNomUsuario.TabIndex = 1
        Me.lbNomUsuario.Text = "USUARIO"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.BackColor = System.Drawing.Color.White
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(109, 293)
        Me.lbNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(74, 17)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "NOMBRE"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.BackColor = System.Drawing.Color.White
        Me.lbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstado.Location = New System.Drawing.Point(109, 411)
        Me.lbEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(71, 17)
        Me.lbEstado.TabIndex = 3
        Me.lbEstado.Text = "ESTADO"
        '
        'cbNombreCargo
        '
        Me.cbNombreCargo.FormattingEnabled = True
        Me.cbNombreCargo.Items.AddRange(New Object() {"GERENTE.", "CAJERO.", "VENDEDOR."})
        Me.cbNombreCargo.Location = New System.Drawing.Point(269, 366)
        Me.cbNombreCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbNombreCargo.Name = "cbNombreCargo"
        Me.cbNombreCargo.Size = New System.Drawing.Size(288, 24)
        Me.cbNombreCargo.TabIndex = 4
        Me.cbNombreCargo.Text = "Seleccione..."
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(269, 293)
        Me.tbNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(288, 22)
        Me.tbNombre.TabIndex = 5
        Me.tbNombre.Text = "Digite su nombre..."
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(119, 517)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(113, 41)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnSiguente
        '
        Me.btnSiguente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSiguente.Location = New System.Drawing.Point(381, 517)
        Me.btnSiguente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguente.Name = "btnSiguente"
        Me.btnSiguente.Size = New System.Drawing.Size(113, 41)
        Me.btnSiguente.TabIndex = 8
        Me.btnSiguente.Text = "SIGUIENTE"
        Me.btnSiguente.UseVisualStyleBackColor = False
        '
        'lbClave
        '
        Me.lbClave.AutoSize = True
        Me.lbClave.BackColor = System.Drawing.Color.White
        Me.lbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClave.Location = New System.Drawing.Point(110, 261)
        Me.lbClave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbClave.Name = "lbClave"
        Me.lbClave.Size = New System.Drawing.Size(57, 17)
        Me.lbClave.TabIndex = 9
        Me.lbClave.Text = "CLAVE"
        '
        'lbCargo
        '
        Me.lbCargo.AutoSize = True
        Me.lbCargo.BackColor = System.Drawing.Color.White
        Me.lbCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCargo.Location = New System.Drawing.Point(109, 368)
        Me.lbCargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(63, 17)
        Me.lbCargo.TabIndex = 11
        Me.lbCargo.Text = "CARGO"
        '
        'lbApellido
        '
        Me.lbApellido.AutoSize = True
        Me.lbApellido.BackColor = System.Drawing.Color.White
        Me.lbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbApellido.Location = New System.Drawing.Point(110, 327)
        Me.lbApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbApellido.Name = "lbApellido"
        Me.lbApellido.Size = New System.Drawing.Size(83, 17)
        Me.lbApellido.TabIndex = 12
        Me.lbApellido.Text = "APELLIDO"
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(269, 327)
        Me.tbApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(288, 22)
        Me.tbApellido.TabIndex = 13
        Me.tbApellido.Text = "Digite su apellido..."
        '
        'tbNombreUsuario
        '
        Me.tbNombreUsuario.Location = New System.Drawing.Point(269, 218)
        Me.tbNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.tbNombreUsuario.Name = "tbNombreUsuario"
        Me.tbNombreUsuario.Size = New System.Drawing.Size(288, 22)
        Me.tbNombreUsuario.TabIndex = 14
        Me.tbNombreUsuario.Text = "Digite su usuario.."
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"ACTIVO.", "INACTIVO."})
        Me.cbEstado.Location = New System.Drawing.Point(269, 409)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(288, 24)
        Me.cbEstado.TabIndex = 15
        Me.cbEstado.Text = "Seleccione..."
        '
        'tbClave
        '
        Me.tbClave.Location = New System.Drawing.Point(269, 256)
        Me.tbClave.Margin = New System.Windows.Forms.Padding(4)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(288, 22)
        Me.tbClave.TabIndex = 16
        Me.tbClave.Text = "Digite su clave..."
        '
        'fmUSUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(639, 604)
        Me.Controls.Add(Me.tbClave)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.tbNombreUsuario)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.lbApellido)
        Me.Controls.Add(Me.lbCargo)
        Me.Controls.Add(Me.lbClave)
        Me.Controls.Add(Me.btnSiguente)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.cbNombreCargo)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbNomUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fmUSUARIO"
        Me.Text = "J P O  SHOES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbEstado As Label
    Friend WithEvents cbNombreCargo As ComboBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnSiguente As Button
    Friend WithEvents lbNomUsuario As Label
    Friend WithEvents lbClave As Label
    Friend WithEvents lbCargo As Label
    Friend WithEvents lbApellido As Label
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbNombreUsuario As TextBox
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents tbClave As TextBox
End Class
