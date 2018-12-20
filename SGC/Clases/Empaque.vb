Public Class Empaque
    Public Property empaqueid As Int32
    Public Property nombre As String
    Public Property activo As Boolean

    Public Sub New()
    End Sub

    Public Sub New(empaqueid As Integer, nombre As String, activo As Boolean)
        Me.empaqueid = empaqueid
        Me.nombre = nombre
        Me.activo = activo
    End Sub

    Public Sub New(nombre As String, activo As Boolean)
        Me.nombre = nombre
        Me.activo = activo
    End Sub

    Public Function obtenerEmpaque(ids As Int32) As Empaque
        Dim obj As New Empaque
        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("empaque", "*", "empaqueid = " & ids)

        While reader.Read
            obj.empaqueid = reader("empaqueid")
            obj.nombre = reader("nombre")
            obj.activo = 1

        End While

        Return obj

    End Function

    Public Overrides Function toString() As String
        Return nombre
    End Function

End Class
