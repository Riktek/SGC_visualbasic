Public Class frmRegistro

    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = appNameFrm + "Registro"
        Me.Icon = My.Resources.sgc_ico
        AcceptButton = btnRegistro


    End Sub

    Private Sub linkIngresar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkIngresar.LinkClicked
        Me.Close()


    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim obj = New Usuario

        If txtNombre.TextLength <= 0 Or txtApellido.TextLength <= 0 Or txtUser.TextLength <= 0 Or txtPass.TextLength <= 0 Then
            MsgBox("Los campos no pueden estar vacios.")
        Else
            If Not obj.buscarUser(txtUser.Text) Then
                If obj.agregarUsuario(New Usuario(txtNombre.Text, txtApellido.Text, txtUser.Text, txtPass.Text)) > 0 Then
                    MsgBox("Usuario registrado con exito.")
                Else
                    MsgBox("Error al registrar usuario")
                End If
            Else
                MsgBox("Correo ya existe")
            End If
        End If

    End Sub
End Class