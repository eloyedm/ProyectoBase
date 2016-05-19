<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Movimientos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfechaf = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTarjeta = New System.Windows.Forms.TextBox()
        Me.dgridReporteMov = New System.Windows.Forms.DataGridView()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarjetaVales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgridReporteMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(458, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtpfechaf
        '
        Me.dtpfechaf.CustomFormat = "yyyy-MM--dd"
        Me.dtpfechaf.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaf.Location = New System.Drawing.Point(461, 165)
        Me.dtpfechaf.Name = "dtpfechaf"
        Me.dtpfechaf.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechaf.TabIndex = 3
        '
        'dtpfechai
        '
        Me.dtpfechai.CustomFormat = "yyyy-MM-dd"
        Me.dtpfechai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechai.Location = New System.Drawing.Point(57, 165)
        Me.dtpfechai.Name = "dtpfechai"
        Me.dtpfechai.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechai.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(0, -3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(723, 78)
        Me.Label3.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(13, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 31)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Crono-Vales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Número de tarjeta"
        '
        'txtTarjeta
        '
        Me.txtTarjeta.Location = New System.Drawing.Point(250, 107)
        Me.txtTarjeta.MaxLength = 16
        Me.txtTarjeta.Name = "txtTarjeta"
        Me.txtTarjeta.Size = New System.Drawing.Size(205, 22)
        Me.txtTarjeta.TabIndex = 1
        '
        'dgridReporteMov
        '
        Me.dgridReporteMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridReporteMov.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fecha, Me.monto, Me.tarjetaVales})
        Me.dgridReporteMov.Location = New System.Drawing.Point(57, 264)
        Me.dgridReporteMov.Name = "dgridReporteMov"
        Me.dgridReporteMov.RowTemplate.Height = 24
        Me.dgridReporteMov.Size = New System.Drawing.Size(604, 181)
        Me.dgridReporteMov.TabIndex = 21
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGenerar.Location = New System.Drawing.Point(561, 229)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 28)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "Fecha del movimiento"
        Me.fecha.MaxInputLength = 10
        Me.fecha.Name = "fecha"
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        Me.monto.HeaderText = "Monto"
        Me.monto.Name = "monto"
        '
        'tarjetaVales
        '
        Me.tarjetaVales.DataPropertyName = "tarjetaVales"
        Me.tarjetaVales.HeaderText = "tarjeta"
        Me.tarjetaVales.Name = "tarjetaVales"
        Me.tarjetaVales.Visible = False
        '
        'frm_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 457)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.dgridReporteMov)
        Me.Controls.Add(Me.txtTarjeta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfechaf)
        Me.Controls.Add(Me.dtpfechai)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_Movimientos"
        Me.Text = "Movimientos"
        CType(Me.dgridReporteMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaf As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents dgridReporteMov As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tarjetaVales As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
