Public Class frmColeccion_album_new
    Private Sub frmColeccion_album_new_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = appNameFrm + Me.Text
        Me.Icon = My.Resources.sgc_ico

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objAlbum As New Album
        Dim tip As New Tipo
        Dim usr As New Usuario

        objAlbum.coleccion = New Coleccion()
        objAlbum.coleccion.creacion = dtpCreacion.Value.Date
        objAlbum.coleccion.nombre = txtNombre.Text.Trim
        objAlbum.coleccion.tipo = tip.obtenerTipoporId(gTipoId)
        objAlbum.coleccion.usuario = usr.obtenerUsuario(gUserId)

        Dim complete, cover As Boolean
        complete = False
        cover = False

        If chkbCompletado.Checked = True Then
            complete = True
        End If

        If chkbTapa.Checked = True Then
            cover = True
        End If

        objAlbum.coleccion.completado = complete
        objAlbum.tapadura = cover
        objAlbum.normalmin = nudNormalmin.Value
        objAlbum.normalmax = nudNormalmax.Value
        objAlbum.especialprefijo = txtPrefijo.Text
        objAlbum.especialmin = nudEspecialmin.Value
        objAlbum.especialmax = nudEspecialmax.Value

        If objAlbum.agregarAlbum(objAlbum) > 0 Then
            MsgBox("Coleccion agregada")
        Else
            MsgBox("Problema al agregar coleccion")
        End If

    End Sub

    Private Sub nudNormalmax_ValueChanged(sender As Object, e As EventArgs) Handles nudNormalmax.ValueChanged
        If nudNormalmax.Value < nudNormalmin.Value Then
            nudNormalmax.Value = nudNormalmin.Value
        End If

    End Sub

    Private Sub nudEspecialmax_ValueChanged(sender As Object, e As EventArgs) Handles nudEspecialmax.ValueChanged
        If nudEspecialmax.Value < nudEspecialmin.Value Then
            nudEspecialmax.Value = nudEspecialmin.Value
        End If

    End Sub


End Class