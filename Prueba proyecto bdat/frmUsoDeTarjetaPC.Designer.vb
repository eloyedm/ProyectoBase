<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsoDeTarjetaPC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgridReporte = New System.Windows.Forms.DataGridView()
        Me.dtpfechai = New System.Windows.Forms.DateTimePicker()
        Me.dtpfechaf = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.nombreComercial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroCargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalCargos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgridReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgridReporte
        '
        Me.dgridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreComercial, Me.numeroCargos, Me.totalCargos})
        Me.dgridReporte.Location = New System.Drawing.Point(31, 157)
        Me.dgridReporte.Name = "dgridReporte"
        Me.dgridReporte.RowTemplate.Height = 24
        Me.dgridReporte.Size = New System.Drawing.Size(667, 259)
        Me.dgridReporte.TabIndex = 0
        '
        'dtpfechai
        '
        Me.dtpfechai.CustomFormat = "yyyy-MM-dd"
        Me.dtpfechai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechai.Location = New System.Drawing.Point(86, 48)
        Me.dtpfechai.Name = "dtpfechai"
        Me.dtpfechai.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechai.TabIndex = 1
        '
        'dtpfechaf
        '
        Me.dtpfechaf.CustomFormat = "yyyy-MM--dd"
        Me.dtpfechaf.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechaf.Location = New System.Drawing.Point(461, 48)
        Me.dtpfechaf.Name = "dtpfechaf"
        Me.dtpfechaf.Size = New System.Drawing.Size(200, 22)
        Me.dtpfechaf.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(458, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Fin"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGenerar.Location = New System.Drawing.Point(598, 122)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 28)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'nombreComercial
        '
        Me.nombreComercial.DataPropertyName = "nombreComercial"
        Me.nombreComercial.HeaderText = "Nombre de Comercio"
        Me.nombreComercial.Name = "nombreComercial"
        Me.nombreComercial.Width = 230
        '
        'numeroCargos
        '
        Me.numeroCargos.DataPropertyName = "numeroCargos"
        Me.numeroCargos.HeaderText = "Cantidad"
        Me.numeroCargos.Name = "numeroCargos"
        Me.numeroCargos.Width = 130
        '
        'totalCargos
        '
        Me.totalCargos.DataPropertyName = "totalCargos"
        Me.totalCargos.HeaderText = "Total de Cargos"
        Me.totalCargos.Name = "totalCargos"
        Me.totalCargos.Width = 130
        '
        'frmUsoDeTarjetaPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 433)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpfechaf)
        Me.Controls.Add(Me.dtpfechai)
        Me.Controls.Add(Me.dgridReporte)
        Me.Name = "frmUsoDeTarjetaPC"
        Me.Text = "Uso de tarjeta por comercio"
        CType(Me.dgridReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgridReporte As System.Windows.Forms.DataGridView
    Friend WithEvents dtpfechai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfechaf As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents nombreComercial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroCargos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalCargos As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
