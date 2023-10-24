Imports System.Data.SqlClient

Public Class Class1
    Dim resultado As Boolean
    Dim mensaje As String
    Dim transa As SqlTransaction
    Dim resul2 As DataTable
    Dim tr As SqlTransaction
    'Dim hoy As Date = Now()
    Public Sub Vertodos(ByRef dgv As DataGridView, ByVal fecha As Date, ByRef total As Integer)
        libSql.AbrirConexion(resultado, mensaje)
        SQL = "SELECT  cod_barra, kilos,id FROM Ingreso_carne 
         where fecha ='" & fecha & "'
         order by id desc "
        libSql.Consulta(SQL, resul2, transa, resultado, mensaje)


        If resul2.Rows.Count > 0 Then
            For Each row As DataRow In resul2.Rows
                dgv.Rows.Add(row.Item("id"), row.Item("cod_barra"), row.Item("kilos"))

            Next

        End If
        SQL = "select SUM(kilos) as total 
        from [NotasDePedido].[dbo].[Ingreso_carne]
        where fecha = '" & fecha & "' "

        libSql.Consulta(SQL, resul2, transa, resultado, mensaje)
        If resul2 IsNot Nothing AndAlso resul2.Rows.Count > 0 AndAlso resul2.Rows(0)("total") IsNot DBNull.Value Then
            total = resul2.Rows(0)("total")
        Else
            total = 0
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

    Public Function ValiCodBarra(Cod_barra)
        Dim fecha As DateTime = Now()
        SQL = "SELECT cod_barra FROM Ingreso_carne WHERE fecha = '" & fecha & "' "
        libSql.Consulta(SQL, resul2, transa, resultado, mensaje)
        If resul2.Rows.Count > 0 Then
            For Each row As DataRow In resul2.Rows
                If row.Item("cod_barra").ToString() = Cod_barra.ToString() Then
                    Dim respuesta As String
                    respuesta = MsgBox("Codigo '" & Cod_barra & "' ya ingresado  ¿Desea volver a ingresarlo ?", vbYesNo, " ATENCIÓN !!")
                    If respuesta = vbYes Then
                        Return True
                    Else
                        Return False
                    End If
                    Return False
                End If
            Next
        End If
        Return True
    End Function


    Public Function Valiingre(ByVal Cod_barra As String, ByVal kilos As String) As Boolean
        If kilos = 0 Or Cod_barra = 0 Then
            MessageBox.Show("Debe ingresar Codigo de Barra válido y Kilos válidos")
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub LipiarTextBox(ByRef txtCodBarra As String, ByRef txtKilos As String)
        txtCodBarra = ""
        txtKilos = ""
    End Sub
    Public Sub EliminarRegistro(ByVal id As String, ByRef fecha As Date)
        Dim resul3 As String



        SQL = "SELECT fecha
     FROM [NotasDePedido].[dbo].[Ingreso_carne] where id =  '" & id & "'"
        libSql.Consulta(SQL, resul2, transa, resultado, mensaje)

        If resul2.Rows.Count > 0 Then
            fecha = Convert.ToDateTime(resul2.Rows(0)("fecha"))

        End If

        SQL = "DELETE FROM [NotasDePedido].[dbo].[Ingreso_carne]
      WHERE id =  '" & id & "'   "

        libSql.Ejecutar(SQL, False, resul3, tr, resultado, mensaje)


    End Sub

End Class
