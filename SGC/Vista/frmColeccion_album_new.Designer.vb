<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColeccion_album_new
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.chkbCompletado = New System.Windows.Forms.CheckBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpCreacion = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grpDetalles = New System.Windows.Forms.GroupBox()
        Me.chkbTapa = New System.Windows.Forms.CheckBox()
        Me.txtPrefijo = New System.Windows.Forms.TextBox()
        Me.lblPrefijo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudEspecialmax = New System.Windows.Forms.NumericUpDown()
        Me.nudEspecialmin = New System.Windows.Forms.NumericUpDown()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.nudNormalmax = New System.Windows.Forms.NumericUpDown()
        Me.nudNormalmin = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNormal = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grpDetalles.SuspendLayout()
        CType(Me.nudEspecialmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEspecialmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNormalmax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNormalmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 13)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(68, 10)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(275, 20)
        Me.txtNombre.TabIndex = 1
        '
        'chkbCompletado
        '
        Me.chkbCompletado.AutoSize = True
        Me.chkbCompletado.Location = New System.Drawing.Point(261, 46)
        Me.chkbCompletado.Name = "chkbCompletado"
        Me.chkbCompletado.Size = New System.Drawing.Size(82, 17)
        Me.chkbCompletado.TabIndex = 2
        Me.chkbCompletado.Text = "Completado"
        Me.chkbCompletado.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(20, 47)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        '
        'dtpCreacion
        '
        Me.dtpCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCreacion.Location = New System.Drawing.Point(68, 43)
        Me.dtpCreacion.Name = "dtpCreacion"
        Me.dtpCreacion.Size = New System.Drawing.Size(114, 20)
        Me.dtpCreacion.TabIndex = 4
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(268, 352)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'grpDetalles
        '
        Me.grpDetalles.Controls.Add(Me.chkbTapa)
        Me.grpDetalles.Controls.Add(Me.txtPrefijo)
        Me.grpDetalles.Controls.Add(Me.lblPrefijo)
        Me.grpDetalles.Controls.Add(Me.Label2)
        Me.grpDetalles.Controls.Add(Me.Label3)
        Me.grpDetalles.Controls.Add(Me.Label4)
        Me.grpDetalles.Controls.Add(Me.nudEspecialmax)
        Me.grpDetalles.Controls.Add(Me.nudEspecialmin)
        Me.grpDetalles.Controls.Add(Me.lblMax)
        Me.grpDetalles.Controls.Add(Me.lblMin)
        Me.grpDetalles.Controls.Add(Me.lblGuion)
        Me.grpDetalles.Controls.Add(Me.nudNormalmax)
        Me.grpDetalles.Controls.Add(Me.nudNormalmin)
        Me.grpDetalles.Controls.Add(Me.Label1)
        Me.grpDetalles.Controls.Add(Me.lblNormal)
        Me.grpDetalles.Location = New System.Drawing.Point(13, 69)
        Me.grpDetalles.Name = "grpDetalles"
        Me.grpDetalles.Size = New System.Drawing.Size(330, 277)
        Me.grpDetalles.TabIndex = 6
        Me.grpDetalles.TabStop = False
        Me.grpDetalles.Text = "Detalles"
        '
        'chkbTapa
        '
        Me.chkbTapa.AutoSize = True
        Me.chkbTapa.Location = New System.Drawing.Point(10, 28)
        Me.chkbTapa.Name = "chkbTapa"
        Me.chkbTapa.Size = New System.Drawing.Size(75, 17)
        Me.chkbTapa.TabIndex = 14
        Me.chkbTapa.Text = "Tapa dura"
        Me.chkbTapa.UseVisualStyleBackColor = True
        '
        'txtPrefijo
        '
        Me.txtPrefijo.Location = New System.Drawing.Point(146, 172)
        Me.txtPrefijo.Name = "txtPrefijo"
        Me.txtPrefijo.Size = New System.Drawing.Size(100, 20)
        Me.txtPrefijo.TabIndex = 13
        '
        'lblPrefijo
        '
        Me.lblPrefijo.AutoSize = True
        Me.lblPrefijo.Location = New System.Drawing.Point(104, 175)
        Me.lblPrefijo.Name = "lblPrefijo"
        Me.lblPrefijo.Size = New System.Drawing.Size(36, 13)
        Me.lblPrefijo.TabIndex = 12
        Me.lblPrefijo.Text = "Prefijo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Max."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Min."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "-"
        '
        'nudEspecialmax
        '
        Me.nudEspecialmax.Location = New System.Drawing.Point(204, 214)
        Me.nudEspecialmax.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudEspecialmax.Name = "nudEspecialmax"
        Me.nudEspecialmax.Size = New System.Drawing.Size(49, 20)
        Me.nudEspecialmax.TabIndex = 8
        '
        'nudEspecialmin
        '
        Me.nudEspecialmin.Location = New System.Drawing.Point(91, 214)
        Me.nudEspecialmin.Name = "nudEspecialmin"
        Me.nudEspecialmin.Size = New System.Drawing.Size(49, 20)
        Me.nudEspecialmin.TabIndex = 7
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(211, 115)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(30, 13)
        Me.lblMax.TabIndex = 6
        Me.lblMax.Text = "Max."
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(102, 115)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(27, 13)
        Me.lblMin.TabIndex = 5
        Me.lblMin.Text = "Min."
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Location = New System.Drawing.Point(167, 92)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(10, 13)
        Me.lblGuion.TabIndex = 4
        Me.lblGuion.Text = "-"
        '
        'nudNormalmax
        '
        Me.nudNormalmax.Location = New System.Drawing.Point(204, 92)
        Me.nudNormalmax.Name = "nudNormalmax"
        Me.nudNormalmax.Size = New System.Drawing.Size(49, 20)
        Me.nudNormalmax.TabIndex = 3
        '
        'nudNormalmin
        '
        Me.nudNormalmin.Location = New System.Drawing.Point(91, 92)
        Me.nudNormalmin.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudNormalmin.Name = "nudNormalmin"
        Me.nudNormalmin.Size = New System.Drawing.Size(49, 20)
        Me.nudNormalmin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rango laminas speciales"
        '
        'lblNormal
        '
        Me.lblNormal.AutoSize = True
        Me.lblNormal.Location = New System.Drawing.Point(7, 60)
        Me.lblNormal.Name = "lblNormal"
        Me.lblNormal.Size = New System.Drawing.Size(122, 13)
        Me.lblNormal.TabIndex = 0
        Me.lblNormal.Text = "Rango laminas normales"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(15, 352)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmColeccion_album_new
        '
        Me.AcceptButton = Me.btnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(355, 387)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grpDetalles)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtpCreacion)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.chkbCompletado)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColeccion_album_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Album - Nueva"
        Me.grpDetalles.ResumeLayout(False)
        Me.grpDetalles.PerformLayout()
        CType(Me.nudEspecialmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEspecialmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNormalmax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNormalmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents chkbCompletado As CheckBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpCreacion As DateTimePicker
    Friend WithEvents btnAgregar As Button
    Friend WithEvents grpDetalles As GroupBox
    Friend WithEvents txtPrefijo As TextBox
    Friend WithEvents lblPrefijo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nudEspecialmax As NumericUpDown
    Friend WithEvents nudEspecialmin As NumericUpDown
    Friend WithEvents lblMax As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblGuion As Label
    Friend WithEvents nudNormalmax As NumericUpDown
    Friend WithEvents nudNormalmin As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNormal As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents chkbTapa As CheckBox
End Class
