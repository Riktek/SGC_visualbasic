Imports SGC

Public Class Album
    Public Property albumid As Int32
    Public Property tapadura As Boolean
    Public Property normalmin As Integer
    Public Property normalmax As Integer
    Public Property especialprefijo As String
    Public Property especialmin As Integer
    Public Property especialmax As Integer

    'FK
    Public Overridable Property coleccion As Coleccion

    Public Sub New()
    End Sub

    Public Sub New(albumid As Integer, tapadura As Boolean, normalmin As Integer, normalmax As Integer, especialprefijo As String, especialmin As Integer, especialmax As Integer, coleccion As Coleccion)
        Me.albumid = albumid
        Me.tapadura = tapadura
        Me.normalmin = normalmin
        Me.normalmax = normalmax
        Me.especialprefijo = especialprefijo
        Me.especialmin = especialmin
        Me.especialmax = especialmax
        Me.coleccion = coleccion
    End Sub

    Public Sub New(tapadura As Boolean, normalmin As Integer, normalmax As Integer, especialprefijo As String, especialmin As Integer, especialmax As Integer, coleccion As Coleccion)
        Me.tapadura = tapadura
        Me.normalmin = normalmin
        Me.normalmax = normalmax
        Me.especialprefijo = especialprefijo
        Me.especialmin = especialmin
        Me.especialmax = especialmax
        Me.coleccion = coleccion
    End Sub

    Public Function agregarAlbum(obj As Album) As Int32
        Dim resultado As Int32 = 0
        Dim db As New DBmanager(base)

        Dim values As String

        values = gUserId
        values = values & "," & gTipoId
        values = values & ",'" & obj.coleccion.nombre & "'"
        values = values & ",'" & Format(obj.coleccion.creacion, "yyyy-MM-dd") & "'"
        values = values & "," & obj.coleccion.completado

        If db.InsertRecord("coleccion", "usuario, tipo, nombre, creacion, completado", values) > 0 Then
            values = "" & coleccion.obtenerIdColeccion(coleccion.nombre)
            values = values & "," & obj.tapadura
            values = values & "," & obj.normalmin
            values = values & "," & obj.normalmax
            values = values & ",'" & obj.especialprefijo & "'"
            values = values & "," & obj.especialmin
            values = values & "," & obj.especialmax
            If db.InsertRecord("album", "coleccion,tapadura,normalmin,normalmax,especialprefijo,especialmin,especialmax", values) > 0 Then
                resultado = 1
            End If
        End If

        Return resultado

    End Function
End Class
