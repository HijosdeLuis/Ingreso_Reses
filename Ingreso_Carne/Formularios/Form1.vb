Imports System.Data.SqlClient

Public Class Pesaje
    Dim resultado As Boolean
    Dim mensaje As String
    Dim tr As SqlTransaction
    Dim val1 As New Class1
    Dim val2 As New FormCristal
    Public ds As DataSet
    Public dt As DataTable
    Private RptReporteIngresos As Object
    Dim total As Integer


    Public Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim fecha As Date = Now()
        Dim Cod_barra As String = Val(txtCodBarra.Text)
        Dim kilos As Integer = Val(txtKilos.Text)
        If val1.Valiingre(Cod_barra, kilos) Then
            If val1.ValiCodBarra(Cod_barra) Then
                val1.Grabar(Cod_barra, kilos)
                val1.vaciar(DataGridView1)
                val1.Vertodos(DataGridView1, fecha, total)
                SumaDelDia.Text = total & " Kilos"
                val1.LipiarTextBox(txtCodBarra.Text, txtKilos.Text)
                txtCodBarra.Focus()
                TextBox1.Text = fecha.ToString("dd/MM/yyyy")
            Else
                val1.LipiarTextBox(txtCodBarra.Text, txtKilos.Text)
            End If
        End If
    End Sub


    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtCodBarra.Select()
        Dim fecha As Date
        If fecha = Nothing Then
            fecha = Now()
            TextBox1.Text = fecha.ToString("dd/MM/yyyy")
        End If
        val1.Vertodos(DataGridView1, fecha, total)
        SumaDelDia.Text = total & " Kilos"
    End Sub


    Public Sub BtnReporteDelDia_Click(sender As Object, e As EventArgs) Handles BtnReporteDelDia.Click
        Dim fecha As Date = Now()
        val2.MostrarReporte(fecha)
        Dim frmReporteingreso As New FormCristal
        frmReporteingreso.Param1 = fecha
        frmReporteingreso.MostrarReporte(fecha)
        frmReporteingreso.Show()
    End Sub

    Public Sub BtnConsultaPorFecha_Click(sender As Object, e As EventArgs) Handles BtnConsultaPorFecha.Click
        Dim verFecha As Date = DateTimePicker1.Text
        val2.MostrarReporte(verFecha)
        Dim frmReporteingreso As New FormCristal
        frmReporteingreso.Param1 = verFecha
        frmReporteingreso.MostrarReporte(verFecha)
        frmReporteingreso.Show()
    End Sub


    Public Sub txtKilos_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKilos.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGrabar_Click(sender, e)
        End If
    End Sub




    Public Sub ConsultarSegunFecha_Click(sender As Object, e As EventArgs) Handles ConsultarSegunFecha.Click
        Dim fecha As Date = DateTimePicker1.Text
        val1.vaciar(DataGridView1)
        val1.Vertodos(DataGridView1, fecha, total)
        SumaDelDia.Text = total & " Kilos"
        TextBox1.Text = fecha
    End Sub

    Private Sub SumaDelDia_Click(sender As Object, e As EventArgs) Handles SumaDelDia.Click

    End Sub
End Class
