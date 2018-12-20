Public Class frmColeccion_auto_new
    Private Sub frmColeccion_auto_new_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = appNameFrm + Me.Text
        Me.Icon = My.Resources.sgc_ico

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objCol As New Coleccion
        Dim tip As New Tipo
        Dim usr As New Usuario

        objCol.creacion = dtpCreacion.Value.Date
        objCol.nombre = txtNombre.Text.Trim
        objCol.tipo = tip.obtenerTipoporId(gTipoId)
        objCol.usuario = usr.obtenerUsuario(gUserId)

        Dim complete As Boolean
        complete = False

        If chkbCompletado.Checked = True Then
            complete = True
        End If
        objCol.completado = complete

        If objCol.agregarColeccion(objCol) > 0 Then
            MsgBox("Coleccion agregada")
        Else
            MsgBox("Problema al agregar coleccion")
        End If
    End Sub
End Class