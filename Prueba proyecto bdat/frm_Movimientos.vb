Public Class frm_Movimientos
    Private Sub frm_Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cargaReporte()
        Dim tarjeta As Long = Long.Parse(txtTarjeta.Text)
 
        Dim regreso As DataTable = ConnectionModule.connection.ReaderCommand("SELECT tarjetaVales FROM Empleado WHERE tarjetaVales = " & tarjeta & "", "Empleado").Tables("Empleado")
        If (regreso.Rows.Count() = 0) Then
            MessageBox.Show("Ese número de tarjeta no existe o no tiene ningún movimiento registrado, intente con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.dgridReporteMov.DataSource = ConnectionModule.connection.ReaderCommand("SELECT E.tarjetaVales, A.fechaAbono AS fecha, A.monto FROM Abono A, Empleado E WHERE A.idEmpleado = E.idEmpleado AND E.tarjetaVales = " & tarjeta & " AND CONVERT(VARCHAR(30),A.fechaAbono, 126) BETWEEN '" & dtpfechai.Text & "' + '%' AND '" & dtpfechaf.Text & "' + '%' UNION SELECT E.tarjetaVales, C.fechaCargo AS fecha, C.monto * -1 FROM Cargo C, Empleado E WHERE C.idEmpleado = E.idEmpleado AND E.tarjetaVales = " & tarjeta & " AND CONVERT(VARCHAR(30),C.fechaCargo, 126) BETWEEN '" & dtpfechai.Text & "' + '%' AND '" & dtpfechaf.Text & "' + '%' ORDER BY fecha DESC;", "Abono").Tables("Abono")
            Me.dgridReporteMov.Columns("fecha").DisplayIndex = 0
            Me.dgridReporteMov.Columns("monto").DisplayIndex = 1
            Me.dgridReporteMov.Columns("fecha").ToString()
            Me.dgridReporteMov.Columns("tarjetaVales").DisplayIndex = 2S
        End If
    End Sub
    Private Sub frm_Movimientos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If (txtTarjeta.Text <> "") Then
            cargaReporte()
        End If
    End Sub
End Class