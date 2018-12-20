Public Class Autoescala
    Public Property autoescalaid As Int32
    Public Property escala As String
    Public Property modelo As String
    Public Property fabricante As String
    Public Property color As String
    Public Property anio As Integer
    Public Property foto As String
    Public Property faltante As Boolean

    'FK
    Public Overridable Property empaque As Int32

    Public Sub New()
    End Sub

    Public Sub New(autoescalaid As Integer, escala As String, modelo As String, fabricante As String, color As String, anio As Integer, foto As String, faltante As Boolean, empaque As Integer)
        Me.autoescalaid = autoescalaid
        Me.escala = escala
        Me.modelo = modelo
        Me.fabricante = fabricante
        Me.color = color
        Me.anio = anio
        Me.foto = foto
        Me.faltante = faltante
        Me.empaque = empaque
    End Sub

    Public Sub New(escala As String, modelo As String, fabricante As String, color As String, anio As Integer, foto As String, faltante As Boolean, empaque As Integer)
        Me.escala = escala
        Me.modelo = modelo
        Me.fabricante = fabricante
        Me.color = color
        Me.anio = anio
        Me.foto = foto
        Me.faltante = faltante
        Me.empaque = empaque
    End Sub



End Class
