Public Class frmColecciones
    Private Sub frmColecciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = appNameFrm + Me.Text
        Me.Icon = My.Resources.sgc_ico
        cargarColecciones()
    End Sub

    Private Sub cargarColecciones()
        Dim obj As New Coleccion()

        'dgvColecciones.DataSource = obj.obtenerColecciones(gUserId)

        'dgvColecciones.Columns.Add("Coleccion1", "Tipo11")
        For Each item In obj.obtenerColecciones(gUserId)
            dgvColecciones.Rows.Add(item.toString, item.tipo)
        Next
    End Sub

    Private Sub filtrarColecciones()
        Dim obj As New Coleccion()
        dgvColecciones.Rows.Clear()
        For Each item In obj.obtenerColeccionesFiltradas(gUserId, txtFiltro.Text, chkbCompletado.Checked)
            dgvColecciones.Rows.Add(item.toString, item.tipo)
        Next

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim opcion As New frmTipo

        If opcion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim obj As Tipo
            obj = opcion.cbTipos.SelectedItem
            If obj IsNot Nothing Then
                gTipoId = obj.tipoid

                cargarFormulario(gTipoId)

            Else
                'MsgBox("Nada2")
            End If

        Else
            'MsgBox("Nada1")
        End If

        filtrarColecciones()

    End Sub

    Private Sub cargarFormulario(id As Int32)
        Select Case id
            Case 1 'Album
                frmColeccion_album_new.ShowDialog()
            Case 2 'Auto Escala
                frmColeccion_auto_new.ShowDialog()
        End Select

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        filtrarColecciones()

    End Sub

    Private Sub dgvColecciones_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvColecciones.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = dgvColecciones.Rows(e.RowIndex)

        End If


    End Sub


End Class