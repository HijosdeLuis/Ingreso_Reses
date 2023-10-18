
Imports System.Data.SqlClient


Public Class Class1
    Dim resultado As Boolean
    Dim mensaje As String
    Dim transa As SqlTransaction
    Dim resul2 As DataTable
    Dim tr As SqlTransaction
    Dim hoy As Date = Now()
    Public Sub Vertodos(ByRef dgv As DataGridView)
        libSql.AbrirConexion(resultado, mensaje)

        SQL = "SELECT  cod_barra, kilos FROM Ingreso_carne 
where fecha ='" & hoy & "'
order by id desc "

        libSql.Consulta(SQL, resul2, transa, resultado, mensaje)

        If resul2.Rows.Count > 0 Then
            For Each row As DataRow In resul2.Rows
                dgv.Rows.Add(row.Item("cod_barra"), row.Item("kilos"))
            Next
        Else
            MessageBox.Show("No se conectó")
        End If
    End Sub


    Public Sub Grabar(ByVal Cod_barra As String, ByVal kilos As Integer)
        Dim fecha As Date = Now()
        Dim resul1 As String

        SQL = "INSERT INTO [Ingreso_carne]
           ([fecha]
           ,[cod_barra]
           ,[kilos])
       VALUES
           (
            '" & fecha & "'
           ,'" & Cod_barra & "'
           ,'" & kilos & "')"

        libSql.Ejecutar(SQL, True, resul1, tr, resultado, mensaje)
    End Sub

    Public Sub vaciar(ByVal Dgv As DataGridView)
        Dgv.Rows.Clear()
    End Sub

End Class
