Public Class frmTipo
    Private Sub frmTipo_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargarCbTipos()
    End Sub

    Private Sub cargarCbTipos()
        Dim obj As New Tipo()

        For Each item In obj.obtenerTipos()
            cbTipos.Items.Add(item)
        Next
    End Sub


End Class