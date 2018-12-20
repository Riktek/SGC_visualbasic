Public Class Tipo
    Public Property tipoid As Int32
    Public Property nombre As String
    Public Property descripcion As String
    Public Property activo As Boolean

    Public Sub New()
    End Sub

    Public Sub New(tipoid As Integer, nombre As String, descripcion As String)
        Me.tipoid = tipoid
        Me.nombre = nombre
        Me.descripcion = descripcion
    End Sub

    Public Function obtenerTipoporId(ids As Int32) As Tipo
        Dim obj As New Tipo
        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("tipo", "*", "tipoid = " & ids)
        While reader.Read
            obj.tipoid = reader("tipoid")
            obj.nombre = reader("nombre")
            obj.descripcion = reader("descripcion")
            obj.activo = 1

        End While

        Return obj
    End Function

    Public Function obtenerTipos() As List(Of Tipo)
        Dim listObjs As New List(Of Tipo)

        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("tipo", "*", "activo = 1")

        While reader.Read
            listObjs.Add(New Tipo(reader("tipoid"), reader("nombre"), reader("descripcion")))
        End While

        Return listObjs
    End Function

    Public Overrides Function toString() As String
        Return nombre
    End Function

End Class
