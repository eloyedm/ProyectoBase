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
        Me.fechaI = New System.Windows.Forms.DateTimePicker()
        Me.fechaF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgridReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgridReporte
        '
        Me.dgridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridReporte.Location = New System.Drawing.Point(31, 157)
        Me.dgridReporte.Name = "dgridReporte"
        Me.dgridReporte.RowTemplate.Height = 24
        Me.dgridReporte.Size = New System.Drawing.Size(667, 259)
        Me.dgridReporte.TabIndex = 0
        '
        'fechaI
        '
        Me.fechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaI.Location = New System.Drawing.Point(86, 48)
        Me.fechaI.Name = "fechaI"
        Me.fechaI.Size = New System.Drawing.Size(200, 22)
        Me.fechaI.TabIndex = 1
        '
        'fechaF
        '
        Me.fechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechaF.Location = New System.Drawing.Point(461, 48)
        Me.fechaF.Name = "fechaF"
        Me.fechaF.Size = New System.Drawing.Size(200, 22)
        Me.fechaF.TabIndex = 2
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
        'frmUsoDeTarjetaPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 443)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fechaF)
        Me.Controls.Add(Me.fechaI)
        Me.Controls.Add(Me.dgridReporte)
        Me.Name = "frmUsoDeTarjetaPC"
        Me.Text = "Uso de tarjeta por comercio"
        CType(Me.dgridReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgridReporte As System.Windows.Forms.DataGridView
    Friend WithEvents fechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
