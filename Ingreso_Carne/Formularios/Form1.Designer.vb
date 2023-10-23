<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pesaje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.txtKilos = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.LbTituloPrincipal = New System.Windows.Forms.Label()
        Me.BtnReporteDelDia = New System.Windows.Forms.Button()
        Me.LbTituloSobreLaGrilla = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnConsultaPorFecha = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LbEligeLaFecha = New System.Windows.Forms.Label()
        Me.ConsultarSegunFecha = New System.Windows.Forms.Button()
        Me.TxtMuestraLaFechaDeLaGrilla = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SumaDelDia = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_barra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kilos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Barras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kilos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'txtCodBarra
        '
        Me.txtCodBarra.Location = New System.Drawing.Point(193, 63)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(167, 29)
        Me.txtCodBarra.TabIndex = 3
        '
        'txtKilos
        '
        Me.txtKilos.Location = New System.Drawing.Point(193, 132)
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.Size = New System.Drawing.Size(167, 29)
        Me.txtKilos.TabIndex = 4
        '
        'btnGrabar
        '
        Me.btnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGrabar.Location = New System.Drawing.Point(452, 63)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(112, 35)
        Me.btnGrabar.TabIndex = 5
        Me.btnGrabar.Text = "Guardar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'LbTituloPrincipal
        '
        Me.LbTituloPrincipal.AutoSize = True
        Me.LbTituloPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloPrincipal.Location = New System.Drawing.Point(441, 31)
        Me.LbTituloPrincipal.Name = "LbTituloPrincipal"
        Me.LbTituloPrincipal.Size = New System.Drawing.Size(353, 29)
        Me.LbTituloPrincipal.TabIndex = 6
        Me.LbTituloPrincipal.Text = "Registro de ingreso de carne"
        '
        'BtnReporteDelDia
        '
        Me.BtnReporteDelDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporteDelDia.Location = New System.Drawing.Point(452, 130)
        Me.BtnReporteDelDia.Name = "BtnReporteDelDia"
        Me.BtnReporteDelDia.Size = New System.Drawing.Size(112, 35)
        Me.BtnReporteDelDia.TabIndex = 7
        Me.BtnReporteDelDia.TabStop = False
        Me.BtnReporteDelDia.Text = "Reporte"
        Me.BtnReporteDelDia.UseVisualStyleBackColor = True
        '
        'LbTituloSobreLaGrilla
        '
        Me.LbTituloSobreLaGrilla.AutoSize = True
        Me.LbTituloSobreLaGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTituloSobreLaGrilla.Location = New System.Drawing.Point(764, 124)
        Me.LbTituloSobreLaGrilla.Name = "LbTituloSobreLaGrilla"
        Me.LbTituloSobreLaGrilla.Size = New System.Drawing.Size(197, 25)
        Me.LbTituloSobreLaGrilla.TabIndex = 9
        Me.LbTituloSobreLaGrilla.Text = "Ingresos del Dia :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(41, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(282, 24)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.TabStop = False
        '
        'BtnConsultaPorFecha
        '
        Me.BtnConsultaPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultaPorFecha.Location = New System.Drawing.Point(452, 133)
        Me.BtnConsultaPorFecha.Name = "BtnConsultaPorFecha"
        Me.BtnConsultaPorFecha.Size = New System.Drawing.Size(112, 35)
        Me.BtnConsultaPorFecha.TabIndex = 12
        Me.BtnConsultaPorFecha.TabStop = False
        Me.BtnConsultaPorFecha.Text = "Reporte"
        Me.BtnConsultaPorFecha.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.LbEligeLaFecha)
        Me.GroupBox1.Controls.Add(Me.ConsultarSegunFecha)
        Me.GroupBox1.Controls.Add(Me.BtnConsultaPorFecha)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(48, 401)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 216)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar reportes por fecha"
        '
        'LbEligeLaFecha
        '
        Me.LbEligeLaFecha.AutoSize = True
        Me.LbEligeLaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEligeLaFecha.Location = New System.Drawing.Point(37, 47)
        Me.LbEligeLaFecha.Name = "LbEligeLaFecha"
        Me.LbEligeLaFecha.Size = New System.Drawing.Size(112, 24)
        Me.LbEligeLaFecha.TabIndex = 14
        Me.LbEligeLaFecha.Text = "Elige Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ConsultarSegunFecha
        '
        Me.ConsultarSegunFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultarSegunFecha.Location = New System.Drawing.Point(452, 65)
        Me.ConsultarSegunFecha.Name = "ConsultarSegunFecha"
        Me.ConsultarSegunFecha.Size = New System.Drawing.Size(112, 35)
        Me.ConsultarSegunFecha.TabIndex = 13
        Me.ConsultarSegunFecha.TabStop = False
        Me.ConsultarSegunFecha.Text = "Consultar"
        Me.ConsultarSegunFecha.UseVisualStyleBackColor = True
        '
        'TxtMuestraLaFechaDeLaGrilla
        '
        Me.TxtMuestraLaFechaDeLaGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMuestraLaFechaDeLaGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestraLaFechaDeLaGrilla.Location = New System.Drawing.Point(985, 124)
        Me.TxtMuestraLaFechaDeLaGrilla.MaximumSize = New System.Drawing.Size(1000, 800)
        Me.TxtMuestraLaFechaDeLaGrilla.Name = "TxtMuestraLaFechaDeLaGrilla"
        Me.TxtMuestraLaFechaDeLaGrilla.ReadOnly = True
        Me.TxtMuestraLaFechaDeLaGrilla.Size = New System.Drawing.Size(142, 24)
        Me.TxtMuestraLaFechaDeLaGrilla.TabIndex = 14
        Me.TxtMuestraLaFechaDeLaGrilla.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCodBarra)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtKilos)
        Me.GroupBox2.Controls.Add(Me.btnGrabar)
        Me.GroupBox2.Controls.Add(Me.BtnReporteDelDia)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(48, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 213)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registrar Ingresos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(775, 649)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total :"
        '
        'SumaDelDia
        '
        Me.SumaDelDia.AutoSize = True
        Me.SumaDelDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumaDelDia.Location = New System.Drawing.Point(849, 653)
        Me.SumaDelDia.Name = "SumaDelDia"
        Me.SumaDelDia.Size = New System.Drawing.Size(140, 20)
        Me.SumaDelDia.TabIndex = 17
        Me.SumaDelDia.Text = "MuestraLaSuma"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Cod_barra, Me.kilos, Me.borrar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(728, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 26
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(614, 445)
        Me.DataGridView1.TabIndex = 18
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.id.FillWeight = 300.0!
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 56
        '
        'Cod_barra
        '
        Me.Cod_barra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cod_barra.FillWeight = 333.0!
        Me.Cod_barra.HeaderText = "Codigo de barra"
        Me.Cod_barra.Name = "Cod_barra"
        Me.Cod_barra.ReadOnly = True
        Me.Cod_barra.Width = 255
        '
        'kilos
        '
        Me.kilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.kilos.FillWeight = 145.736!
        Me.kilos.HeaderText = "kilos"
        Me.kilos.Name = "kilos"
        Me.kilos.ReadOnly = True
        Me.kilos.Width = 166
        '
        'borrar
        '
        Me.borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.borrar.FillWeight = 90.38114!
        Me.borrar.HeaderText = "Borrar"
        Me.borrar.Name = "borrar"
        Me.borrar.ReadOnly = True
        Me.borrar.Width = 150
        '
        'Pesaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 781)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SumaDelDia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtMuestraLaFechaDeLaGrilla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbTituloSobreLaGrilla)
        Me.Controls.Add(Me.LbTituloPrincipal)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Pesaje"
        Me.Text = "Pesaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodBarra As TextBox
    Friend WithEvents txtKilos As TextBox
    Friend WithEvents btnGrabar As Button
    Friend WithEvents LbTituloPrincipal As Label
    Friend WithEvents BtnReporteDelDia As Button
    Friend WithEvents LbTituloSobreLaGrilla As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnConsultaPorFecha As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ConsultarSegunFecha As Button
    Friend WithEvents TxtMuestraLaFechaDeLaGrilla As TextBox
    Friend WithEvents LbEligeLaFecha As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SumaDelDia As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Cod_barra As DataGridViewTextBoxColumn
    Friend WithEvents kilos As DataGridViewTextBoxColumn
    Friend WithEvents borrar As DataGridViewTextBoxColumn
End Class
