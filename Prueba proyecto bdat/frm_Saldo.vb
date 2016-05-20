Public Class frm_Saldo
    Dim idEmpresa As Integer
    Private Sub LoadComboBox()

        Dim Empresas As DataTable = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa", "Empresa").Tables("Empresa")

        For index As Integer = 0 To Empresas.Rows.Count() - 1
            cmbEmpresa.Items.Add(Empresas.Rows(index).Item("nombreComercial"))
        Next

    End Sub
    Private Sub frm_Saldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBox()
    End Sub
    Private Sub cargaReporte()
        Dim tarjeta As Long = Long.Parse(txtTarjeta.Text)

        Dim regreso As DataTable = ConnectionModule.connection.ReaderCommand("SELECT tarjetaVales FROM Empleado WHERE tarjetaVales = " & tarjeta & " AND idEmpresa = " & idEmpresa & " ", "Empleado").Tables("Empleado")
        If (regreso.Rows.Count() = 0) Then
            MessageBox.Show("Ese número de tarjeta no existe o no pertenece a esta empresa, intente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.dgridReporteMov.DataSource = ConnectionModule.connection.ReaderCommand("SELECT E.nombreEmpleado + ' ' + E.apellidoPaterno + ' ' + E.apellidoMaterno AS nombreEmpleado, E.tarjetaVales, SUM(A.monto) AS totalAbonos, SUM(C.monto) AS totalCargos, SUM(A.monto) - SUM(C.monto) AS saldoActual FROM Abono as A, Cargo as C, Empleado as E WHERE A.idEmpleado = E.idEmpleado AND C.idEmpleado = E.idEmpleado  AND E.tarjetaVales = " & tarjeta & " AND E.idEmpresa = " & idEmpresa & " GROUP BY E.nombreEmpleado, E.apellidoPaterno, E.apellidoMaterno, E.tarjetaVales ORDER BY saldoActual DESC, E.apellidoPaterno, E.apellidoMaterno, E.nombreEmpleado ", "Abono").Tables("Abono")
            Me.dgridReporteMov.Columns("nombreEmpleado").DisplayIndex = 0
            Me.dgridReporteMov.Columns("tarjetaVales").DisplayIndex = 1
            Me.dgridReporteMov.Columns("totalAbonos").DisplayIndex = 2
            Me.dgridReporteMov.Columns("totalCargos").DisplayIndex = 3
            Me.dgridReporteMov.Columns("saldoActual").DisplayIndex = 4
        End If
    End Sub

    Private Sub cargaReporteGlo()
        Me.dgridReporteMov.DataSource = ConnectionModule.connection.ReaderCommand("SELECT E.nombreEmpleado + ' ' + E.apellidoPaterno + ' ' + E.apellidoMaterno AS nombreEmpleado, E.tarjetaVales, SUM(A.monto) AS totalAbonos, SUM(C.monto) AS totalCargos, SUM(A.monto) - SUM(C.monto) AS saldoActual FROM Abono as A, Cargo as C, Empleado as E WHERE A.idEmpleado = E.idEmpleado AND C.idEmpleado = E.idEmpleado AND E.idEmpresa = " & idEmpresa & " GROUP BY E.nombreEmpleado, E.apellidoPaterno, E.apellidoMaterno, E.tarjetaVales ORDER BY saldoActual DESC, E.apellidoPaterno, E.apellidoMaterno, E.nombreEmpleado ", "Abono").Tables("Abono")
            Me.dgridReporteMov.Columns("nombreEmpleado").DisplayIndex = 0
            Me.dgridReporteMov.Columns("tarjetaVales").DisplayIndex = 1
            Me.dgridReporteMov.Columns("totalAbonos").DisplayIndex = 2
            Me.dgridReporteMov.Columns("totalCargos").DisplayIndex = 3
            Me.dgridReporteMov.Columns("saldoActual").DisplayIndex = 4
    End Sub

    Private Sub frm_Saldo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If (txtTarjeta.Text <> "") Then
            cargaReporte()
        Else
            cargaReporteGlo()
        End If

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub cmbEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresa.SelectedIndexChanged

        If (cmbEmpresa.Text <> "") Then
            Dim Empresas As DataTable = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa", "Empresa").Tables("Empresa")
            idEmpresa = Integer.Parse(Empresas.Rows(cmbEmpresa.SelectedIndex).Item("idEmpresa").ToString())
        End If

    End Sub
End Class