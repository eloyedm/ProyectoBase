Public Class frm_Depositar
    Dim idSel As Integer
    Private Sub frm_Depositar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBox()
        If (cmbEmpresa.Text = "") Then
            EnabledControls(False)
        End If
    End Sub

    Private Sub EnabledControls(ByVal enableControls As Boolean)
        txtNombre.Enabled = enableControls
        txtImporte.Enabled = enableControls
        txtNumero.Enabled = enableControls
        btnAgregar.Enabled = enableControls
        btnQuitar.Enabled = enableControls
        btnCancelar.Enabled = enableControls
        btnDepositar.Enabled = enableControls
        rbEmpresa.Enabled = enableControls
        rbIndi.Enabled = enableControls
        rbLibre.Enabled = enableControls
    End Sub
    Private Sub LoadComboBox()

        Dim Empresas As DataTable = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa", "Empresa").Tables("Empresa")

        For index As Integer = 0 To Empresas.Rows.Count() - 1
            cmbEmpresa.Items.Add(Empresas.Rows(index).Item("nombreComercial"))
        Next

    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresa.SelectedIndexChanged

        If (cmbEmpresa.Text <> "") Then
            EnabledControls(True)
            Dim Empresas As DataTable = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa", "Empresa").Tables("Empresa")
            idSel = Integer.Parse(Empresas.Rows(cmbEmpresa.SelectedIndex).Item("idEmpresa").ToString())
        Else
            EnabledControls(False)
        End If

    End Sub
    Private Sub frm_Depositar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub

    Private Sub rbEmpresa_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpresa.CheckedChanged
        If (rbEmpresa.Checked) Then
            txtNombre.Enabled = False
            txtNumero.Enabled = False
            btnAgregar.Enabled = False
            btnQuitar.Enabled = False

        End If
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        If (rbEmpresa.Checked And txtImporte.Text <> "") Then
            ConnectionModule.connection.NonQueryCommand("INSERT INTO Abono (idEmpleado, monto,fechaAbono)" &
                                                           " SELECT idEmpleado, '" & txtImporte.Text & "', GETDATE() FROM Empleado WHERE idEmpresa = '" & idSel & "'")
        End If
        If ((rbIndi.Checked Or rbLibre.Checked) And txtImporte.Text <> "") Then
            If (txtNombre.Text <> "") Then
                Dim temp As DataTable =
                ConnectionModule.connection.NonQueryCommand("INSERT INTO Abono (idEmpleado, monto,fechaAbono)" &
                                                            " SELECT idEmpleado, '" & txtImporte.Text & "', GETDATE() FROM Empleado WHERE idEmpresa = '" & idSel & "' AND nombreEmpleado = '" & txtNombre.Text & "'")
            End If
        End If
    End Sub

    Private Sub rbIndi_CheckedChanged(sender As Object, e As EventArgs) Handles rbIndi.CheckedChanged
        If (rbIndi.Checked) Then
            txtNombre.Enabled = True
            txtNumero.Enabled = True
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (rbIndi.Checked) Then
            ConnectionModule.connection.NonQueryCommand("select verificaEmpleado ('" & txtNombre.Text & "','" & txtNumero.Text & "','" & txtImporte.Text & "')")
        End If
    End Sub
End Class