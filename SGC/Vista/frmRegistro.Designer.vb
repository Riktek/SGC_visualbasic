<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linkIngresar = New System.Windows.Forms.LinkLabel()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.grpPersonalData = New System.Windows.Forms.GroupBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.grpLoginData = New System.Windows.Forms.GroupBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonalData.SuspendLayout()
        Me.grpLoginData.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(524, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'linkIngresar
        '
        Me.linkIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.linkIngresar.AutoSize = True
        Me.linkIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkIngresar.Location = New System.Drawing.Point(235, 457)
        Me.linkIngresar.Name = "linkIngresar"
        Me.linkIngresar.Size = New System.Drawing.Size(71, 13)
        Me.linkIngresar.TabIndex = 2
        Me.linkIngresar.TabStop = True
        Me.linkIngresar.Text = "INGRESAR"
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(321, 384)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistro.TabIndex = 3
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(51, 29)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'grpPersonalData
        '
        Me.grpPersonalData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpPersonalData.Controls.Add(Me.txtApellido)
        Me.grpPersonalData.Controls.Add(Me.txtNombre)
        Me.grpPersonalData.Controls.Add(Me.lblApellido)
        Me.grpPersonalData.Controls.Add(Me.lblNombre)
        Me.grpPersonalData.Location = New System.Drawing.Point(118, 160)
        Me.grpPersonalData.Name = "grpPersonalData"
        Me.grpPersonalData.Size = New System.Drawing.Size(297, 100)
        Me.grpPersonalData.TabIndex = 5
        Me.grpPersonalData.TabStop = False
        Me.grpPersonalData.Text = "Personal"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(110, 57)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(168, 20)
        Me.txtApellido.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(110, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 20)
        Me.txtNombre.TabIndex = 6
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(51, 60)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 5
        Me.lblApellido.Text = "Apellido"
        '
        'grpLoginData
        '
        Me.grpLoginData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpLoginData.Controls.Add(Me.txtPass)
        Me.grpLoginData.Controls.Add(Me.txtUser)
        Me.grpLoginData.Controls.Add(Me.lblPass)
        Me.grpLoginData.Controls.Add(Me.lblUser)
        Me.grpLoginData.Location = New System.Drawing.Point(118, 266)
        Me.grpLoginData.Name = "grpLoginData"
        Me.grpLoginData.Size = New System.Drawing.Size(297, 100)
        Me.grpLoginData.TabIndex = 6
        Me.grpLoginData.TabStop = False
        Me.grpLoginData.Text = "Login"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(110, 60)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(168, 20)
        Me.txtPass.TabIndex = 3
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(110, 31)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(168, 20)
        Me.txtUser.TabIndex = 2
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(39, 63)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 13)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Contraseña"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(17, 34)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(83, 13)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "Usuario (Correo)"
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Location = New System.Drawing.Point(138, 384)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmRegistro
        '
        Me.AcceptButton = Me.btnRegistro
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(524, 479)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grpLoginData)
        Me.Controls.Add(Me.grpPersonalData)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.linkIngresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonalData.ResumeLayout(False)
        Me.grpPersonalData.PerformLayout()
        Me.grpLoginData.ResumeLayout(False)
        Me.grpLoginData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents linkIngresar As LinkLabel
    Friend WithEvents btnRegistro As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents grpPersonalData As GroupBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellido As Label
    Friend WithEvents grpLoginData As GroupBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents btnCerrar As Button
End Class
