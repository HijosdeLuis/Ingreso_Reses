Imports System.Data.SqlClient

Public Class Form1
    Dim resultado As Boolean
    Dim mensaje As String
    Dim tr As SqlTransaction
    Dim val1 As New Class1
    Dim val2 As New FormCristal
    Public ds As DataSet
    Public dt As DataTable
    Private RptReporteIngresos As Object

    Public Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim Cod_barra As String = txtCodBarra.Text
        Dim kilos As Double = txtKilos.Text
        val1.Grabar(Cod_barra, kilos)
        val1.vaciar(DataGridView1)
        val1.Vertodos(DataGridView1)
        txtCodBarra.Text = ""
        txtKilos.Text = ""
        txtCodBarra.Focus()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        val1.Vertodos(DataGridView1)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim hoy As Date = Now()

        val2.MostrarReporte(hoy)

        Dim frmReporteingreso As New FormCristal
        frmReporteingreso.Param1 = hoy

        frmReporteingreso.MostrarReporte(hoy)
        frmReporteingreso.Show()

        'Dim da As SqlDataAdapter
        'ds = New DataSet("DsReporteIngresos")
        'Try

        '    SQL = "exec dbo.ingresos_res '" & hoy & "'  "
        '    'SQL = "exec TC_ReporteTareas '" & CENTROCOSTO & "'" ','" & FechaHasta & "'"
        '    'ds.Clear()
        '    da = New SqlDataAdapter(SQL, conn)
        '    da.Fill(ds, "Tabla")
        '    dt = ds.Tables("Tabla")

        '    Dim objReporte As New RptReporteIngresos

        '    objReporte.SetDataSource(dt)
        '    objReporte.SetParameterValue("@FechaDesde", hoy)
        '    'objReporte.SetParameterValue("@FechaHasta", FechaHasta)
        '    'objReporte.SetParameterValue("@IdCentroCosto", CentroCosto)

        '    'objReporte.PrintOptions.PrinterName = nomImpresora
        '    'Imprimimos el reporte
        '    'sale por impresora
        '    'objReporte.PrintToPrinter(1, False, 0, 0)
        '    'Instanciamos el origen del reporte

        '    'sale por pantalla
        '    Me.RptReporteIngresos.ReportSource = objReporte

        'Catch ex As Exception
        '    'Dim resp = GrabarLogOperaciones("ERROR N° " & Err.Number, "DESCRIPCION: " & Err.Description, "ERROR")
        '    MessageBox.Show("Error N° " & Err.Number & ", DESCRIPCION: " & Err.Description,
        '                "SISTEMAS AEC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConsultaPorFecha.Click
        Dim verFecha As DateTime = DateTimePicker1.Text
        val2.MostrarReporte(verFecha)

        Dim frmReporteingreso As New FormCristal
        frmReporteingreso.Param1 = verFecha

        frmReporteingreso.MostrarReporte(verFecha)
        frmReporteingreso.Show()
    End Sub
End Class
