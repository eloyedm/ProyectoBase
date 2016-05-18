<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Depositar
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
        Me.dgEmpleados = New System.Windows.Forms.DataGridView()
        Me.EmpleadoNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbLibre = New System.Windows.Forms.RadioButton()
        Me.rbEmpresa = New System.Windows.Forms.RadioButton()
        Me.rbIndi = New System.Windows.Forms.RadioButton()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.cmbEmpresa = New System.Windows.Forms.ComboBox()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgEmpleados
        '
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpleadoNumero, Me.EmpleadoNombre, Me.Importe})
        Me.dgEmpleados.Location = New System.Drawing.Point(16, 287)
        Me.dgEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.Size = New System.Drawing.Size(532, 272)
        Me.dgEmpleados.TabIndex = 0
        '
        'EmpleadoNumero
        '
        Me.EmpleadoNumero.HeaderText = "Numero"
        Me.EmpleadoNumero.Name = "EmpleadoNumero"
        Me.EmpleadoNumero.ReadOnly = True
        '
        'EmpleadoNombre
        '
        Me.EmpleadoNombre.HeaderText = "Nombre"
        Me.EmpleadoNombre.Name = "EmpleadoNombre"
        Me.EmpleadoNombre.ReadOnly = True
        Me.EmpleadoNombre.Width = 155
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ToolTipText = "Cantidad a depositar."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(9, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 31)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Crono-Vales"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(-1, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(567, 78)
        Me.Label3.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(383, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Empresa"
        '
        'btnDepositar
        '
        Me.btnDepositar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDepositar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnDepositar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDepositar.Location = New System.Drawing.Point(448, 251)
        Me.btnDepositar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(100, 28)
        Me.btnDepositar.TabIndex = 19
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAgregar.Location = New System.Drawing.Point(116, 251)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(61, 28)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "+"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.Gray
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnQuitar.Location = New System.Drawing.Point(16, 251)
        Me.btnQuitar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(60, 28)
        Me.btnQuitar.TabIndex = 21
        Me.btnQuitar.Text = "-"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 199)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Importe"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(448, 219)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(99, 22)
        Me.txtImporte.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 95)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(243, 134)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleado"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(12, 94)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(221, 22)
        Me.txtNumero.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Numero"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 43)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(221, 22)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbLibre)
        Me.GroupBox2.Controls.Add(Me.rbEmpresa)
        Me.GroupBox2.Controls.Add(Me.rbIndi)
        Me.GroupBox2.Location = New System.Drawing.Point(284, 95)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(264, 90)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Importe"
        '
        'rbLibre
        '
        Me.rbLibre.AutoSize = True
        Me.rbLibre.Location = New System.Drawing.Point(8, 62)
        Me.rbLibre.Margin = New System.Windows.Forms.Padding(4)
        Me.rbLibre.Name = "rbLibre"
        Me.rbLibre.Size = New System.Drawing.Size(61, 21)
        Me.rbLibre.TabIndex = 32
        Me.rbLibre.Text = "Libre"
        Me.rbLibre.UseVisualStyleBackColor = True
        '
        'rbEmpresa
        '
        Me.rbEmpresa.AutoSize = True
        Me.rbEmpresa.Location = New System.Drawing.Point(144, 27)
        Me.rbEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.rbEmpresa.Name = "rbEmpresa"
        Me.rbEmpresa.Size = New System.Drawing.Size(111, 21)
        Me.rbEmpresa.TabIndex = 31
        Me.rbEmpresa.Text = "Por Empresa"
        Me.rbEmpresa.UseVisualStyleBackColor = True
        '
        'rbIndi
        '
        Me.rbIndi.AutoSize = True
        Me.rbIndi.Checked = True
        Me.rbIndi.Location = New System.Drawing.Point(8, 27)
        Me.rbIndi.Margin = New System.Windows.Forms.Padding(4)
        Me.rbIndi.Name = "rbIndi"
        Me.rbIndi.Size = New System.Drawing.Size(88, 21)
        Me.rbIndi.TabIndex = 30
        Me.rbIndi.TabStop = True
        Me.rbIndi.Text = "Individual"
        Me.rbIndi.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.Location = New System.Drawing.Point(321, 251)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'cmbEmpresa
        '
        Me.cmbEmpresa.FormattingEnabled = True
        Me.cmbEmpresa.Location = New System.Drawing.Point(387, 35)
        Me.cmbEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEmpresa.Name = "cmbEmpresa"
        Me.cmbEmpresa.Size = New System.Drawing.Size(160, 24)
        Me.cmbEmpresa.TabIndex = 1
        '
        'frm_Depositar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 574)
        Me.Controls.Add(Me.cmbEmpresa)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgEmpleados)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_Depositar"
        Me.Text = "Agregar saldo"
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgEmpleados As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpleadoNumero As DataGridViewTextBoxColumn
    Friend WithEvents EmpleadoNombre As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbLibre As RadioButton
    Friend WithEvents rbEmpresa As RadioButton
    Friend WithEvents rbIndi As RadioButton
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbEmpresa As System.Windows.Forms.ComboBox
End Class
