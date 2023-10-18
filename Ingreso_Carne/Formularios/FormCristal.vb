Imports System.Data.SqlClient
Public Class FormCristal
    Public ds As DataSet
    Public dt As DataTable
    Public Param1 As String
    Public Sub MostrarReporte(ByVal hoy As DateTime)

        'Dim hoy As Date = Now()



        Dim da As SqlDataAdapter
        ds = New DataSet("DsReporteIngresos")
        Try

            SQL = "exec dbo.ingresos_res '" & hoy & "'  "
            'SQL = "exec TC_ReporteTareas '" & CENTROCOSTO & "'" ','" & FechaHasta & "'"
            'ds.Clear()
            da = New SqlDataAdapter(SQL, conn)
            da.Fill(ds, "Tabla")
            dt = ds.Tables("Tabla")

            Dim objReporte As New RptReporteIngresos

            objReporte.SetDataSource(dt)
            objReporte.SetParameterValue("@Param1", hoy)
            'objReporte.SetParameterValue("@FechaHasta", FechaHasta)
            'objReporte.SetParameterValue("@IdCentroCosto", CentroCosto)

            'objReporte.PrintOptions.PrinterName = nomImpresora
            'Imprimimos el reporte
            'sale por impresora
            'objReporte.PrintToPrinter(1, False, 0, 0)
            'Instanciamos el origen del reporte

            'sale por pantalla
            Me.CrystalReportViewer1.ReportSource = objReporte

        Catch ex As Exception
            'Dim resp = GrabarLogOperaciones("ERROR N° " & Err.Number, "DESCRIPCION: " & Err.Description, "ERROR")
            MessageBox.Show("Error N° " & Err.Number & ", DESCRIPCION: " & Err.Description,
                        "SISTEMAS AEC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class