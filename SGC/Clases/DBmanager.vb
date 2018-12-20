Imports System.Data.SQLite

Public Class DBmanager
    Private _connection As SQLiteConnection

    Public Sub New(database As String)
        Connect(database)
    End Sub

    Public Sub Connect(database As String)
        Try
            _connection = New SQLiteConnection("data source=" + database + ";version=3")
            _connection.Open()
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
            _connection = Nothing

        End Try

    End Sub

    'SELECT
    Public Function GetRecords(table As String,
                               Optional fields As String = "*",
                               Optional where As String = "",
                               Optional order As String = "") As SQLiteDataReader

        Dim query As String = "SELECT " & fields & " FROM " & table

        If where <> "" Then
            query = query & " WHERE " & where
        End If

        If order <> "" Then
            query = query & " ORDER BY " & order
        End If

        Try
            Dim cmd As New SQLiteCommand(query, _connection)
            Return cmd.ExecuteReader
        Catch ex As Exception
            MsgBox("Error SELECT: " + ex.Message)
            _connection = Nothing
        End Try

        Return Nothing

    End Function

    'INSERT
    Public Function InsertRecord(table As String,
                            fields As String,
                            values As String) As Int32
        Dim resultado As Int32 = 0
        Dim query As String = "INSERT INTO " & table & "(" & fields & ") VALUES(" & values & ")"

        Try
            Dim cmd As New SQLiteCommand(query, _connection)
            cmd.ExecuteNonQuery()
            resultado = 1
        Catch ex As Exception
            MsgBox("Error INSERT: " + ex.Message)
            _connection = Nothing

        End Try
        Return resultado

    End Function

    'UPDATE
    Public Function UpdateRecord(table As String,
                                 field As String,
                                 value As Object,
                                 condition As String) As Int32
        Dim resultado As Int32 = 0
        Dim query As String = "UPDATE " & table & " SET " & field & "='" & value & "' WHERE " & condition

        Try
            Dim cmd As New SQLiteCommand(query, _connection)
            cmd.ExecuteNonQuery()
            resultado = 1
        Catch ex As Exception
            MsgBox("Error UPDATE: " + ex.Message)
            _connection = Nothing

        End Try
        Return resultado
    End Function


    'DELETE
    Public Function DeleteRecord(table As String,
                                 condition As String) As Int32
        Dim resultado As Int32 = 0
        Dim query As String = "DELETE FROM " & table & " WHERE " & condition

        Try
            Dim cmd As New SQLiteCommand(query, _connection)
            cmd.ExecuteNonQuery()
            resultado = 1
        Catch ex As Exception
            MsgBox("Error DELETE: " + ex.Message)
            _connection = Nothing

        End Try
        Return resultado
    End Function

End Class
