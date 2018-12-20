Public Class frmLogin


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = appNameFrm + Me.Text
        Me.Icon = My.Resources.sgc_ico
        AcceptButton = btnIngresar

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim obj = New Usuario()

        If obj.existeUser(txtUser.Text, txtPass.Text) Then
            gUserId = obj.obtenerIdUsuario(txtUser.Text, txtPass.Text)
            obj = obj.obtenerUsuario(gUserId)

            frmColecciones.Show()
            Me.Close()

            'MsgBox("ID: " & obj.toString)
        Else
            MsgBox("No existe usuario")

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub linkRegistrate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRegistrate.LinkClicked
        frmRegistro.ShowDialog()

    End Sub
End Class
