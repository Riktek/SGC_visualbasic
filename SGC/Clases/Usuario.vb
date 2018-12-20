Public Class Usuario
    Public Property usuarioid As Int32
    Public Property nombre As String
    Public Property apellido As String
    Public Property user As String
    Public Property pass As String
    Public Property activo As Boolean

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, apellido As String, user As String, pass As String)
        Me.usuarioid = id
        Me.nombre = nombre
        Me.apellido = apellido
        Me.user = user
        Me.pass = pass
    End Sub

    Public Sub New(nombre As String, apellido As String, user As String, pass As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.user = user
        Me.pass = pass
    End Sub

    Public Function existeUser(usr As String, pas As String) As Boolean
        Dim valor As Boolean = False
        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("usuario", "*", "user = '" & usr & "' AND pass = '" & pas & "'")

        If reader.HasRows Then
            valor = True
        End If

        Return valor
    End Function

    Public Function buscarUser(usr As String) As Boolean
        Dim valor As Boolean = False
        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("usuario", "*", "user = '" & usr & "'")

        If reader.HasRows Then
            valor = True
        End If

        Return valor
    End Function

    Public Function obtenerIdUsuario(usr As String, pas As String) As Int32
        Dim valor As Int32 = 0
        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("usuario", "usuarioid", "user = '" & usr & "' AND pass = '" & pas & "'")
        While reader.Read
            valor = reader("usuarioid")

        End While

        Return valor
    End Function

    Public Function obtenerUsuario(ids As Int32) As Usuario
        Dim obj As New Usuario
        'basededatos
        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("usuario", "*", "usuarioid = " & ids)
        While reader.Read
            obj.usuarioid = reader("usuarioid")
            obj.nombre = reader("nombre")
            obj.apellido = reader("apellido")
            obj.user = reader("user")
            obj.pass = reader("pass")
            obj.activo = 1

        End While

        Return obj
    End Function

    Public Function agregarUsuario(obj As Usuario) As Int32
        Dim db = New DBmanager(base)
        Dim resultado As Int32
        Dim fields As String
        Dim values As String

        fields = "nombre"
        fields = fields & "," & "apellido"
        fields = fields & "," & "user"
        fields = fields & "," & "pass"

        values = "'" & obj.nombre & "'"
        values = values & ",'" & obj.apellido & "'"
        values = values & ",'" & obj.user & "'"
        values = values & ",'" & obj.pass & "'"

        resultado = db.InsertRecord("usuario", fields, values)

        Return resultado
    End Function

    Public Overrides Function toString() As String
        Return nombre & " " & apellido
    End Function

End Class
