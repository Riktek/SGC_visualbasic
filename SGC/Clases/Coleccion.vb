Imports System.Data.SQLite
Imports SGC

Public Class Coleccion
    Public Property coleccionid As Int32
    Public Property nombre As String
    Public Property creacion As Date
    Public Property completado As Boolean
    Public Property activo As Boolean

    'FK
    Public Overridable Property usuario As Usuario
    Public Overridable Property tipo As Tipo

    Public Sub New()
    End Sub

    Public Sub New(coleccionid As Integer, nombre As String, creacion As Date, completado As Boolean, activo As Boolean, usuario As Usuario, tipo As Tipo)
        Me.coleccionid = coleccionid
        Me.nombre = nombre
        Me.creacion = creacion
        Me.completado = completado
        Me.activo = activo
        Me.usuario = usuario
        Me.tipo = tipo
    End Sub

    Public Sub New(nombre As String, creacion As Date, completado As Boolean, activo As Boolean, usuario As Usuario, tipo As Tipo)
        Me.nombre = nombre
        Me.creacion = creacion
        Me.completado = completado
        Me.activo = activo
        Me.usuario = usuario
        Me.tipo = tipo
    End Sub

    Public Function obtenerIdColeccion(nombre As String) As Int32
        Dim resultado As Int32

        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("coleccion", "coleccionid", "usuario = " & gUserId & " AND tipo = " & gTipoId & " AND nombre = '" & nombre.Trim & "'")

        While reader.Read
            resultado = reader("coleccionid")
        End While

        Return resultado
    End Function

    Public Function obtenerColecciones(idusr As Int32, Optional completo As Int32 = 0) As List(Of Coleccion)
        Dim listObjs As New List(Of Coleccion)
        Dim col As New Coleccion
        Dim usr As New Usuario
        Dim tip As New Tipo

        Dim db = New DBmanager(base)
        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("coleccion", "*", "usuario = " & idusr)

        Dim fecha As Date

        While reader.Read
            fecha = reader("creacion")
            listObjs.Add(New Coleccion(reader("nombre"), fecha, reader("completado"), reader("activo"),
                                       usr.obtenerUsuario(CInt(reader("usuario"))), tip.obtenerTipoporId(CInt(reader("tipo")))))
        End While

        Return listObjs
    End Function

    Public Function obtenerColeccionesFiltradas(idusr As Int32, Optional buscar As String = "", Optional completo As Int32 = 0) As List(Of Coleccion)
        Dim listObjs As New List(Of Coleccion)
        Dim col As New Coleccion
        Dim usr As New Usuario
        Dim tip As New Tipo

        Dim db = New DBmanager(base)

        Dim where As String = "usuario = " & idusr

        If Not buscar.Trim.Equals("") Then
            where = where & " AND nombre LIKE '%" & buscar & "%'"
        End If

        If completo = 1 Then
            where = where & " AND completado = 1"
        End If

        Dim reader As SQLite.SQLiteDataReader = db.GetRecords("coleccion", "*", where)

        While reader.Read
            listObjs.Add(New Coleccion(reader("nombre"), reader("creacion"), reader("completado"), reader("activo"),
                                       usr.obtenerUsuario(CInt(reader("usuario"))), tip.obtenerTipoporId(CInt(reader("tipo")))))
        End While

        Return listObjs
    End Function

    Public Function agregarColeccion(obj As Coleccion) As Int32
        Dim resultado As Int32 = 0
        Dim db As New DBmanager(base)

        Dim values As String

        values = gUserId
        values = values & "," & gTipoId
        values = values & ",'" & obj.nombre & "'"
        values = values & ",'" & Format(obj.creacion, "yyyy-MM-dd") & "'"
        values = values & "," & obj.completado

        If db.InsertRecord("coleccion", "usuario, tipo, nombre, creacion, completado", values) > 0 Then
            resultado = 1

        End If

        Return resultado

    End Function

    Public Overrides Function toString() As String
        Return nombre
    End Function

    'Public Shared Widening Operator CType(v As SQLiteDataReader) As Coleccion
    '    Throw New NotImplementedException()
    'End Operator
End Class
