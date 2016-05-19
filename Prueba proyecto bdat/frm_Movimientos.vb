Public Class frm_Movimientos
    Private Sub frm_Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cargaReporte()
        Me.dgridReporteMov.DataSource = ConnectionModule.connection.ReaderCommand("SELECT E.tarjetaVales, A.fechaAbono AS fecha, A.monto FROM Abono A, Empleado E WHERE A.idEmpleado = E.idEmpleado AND E.tarjetaVales = 1879234111819100 AND CONVERT(VARCHAR(30),A.fechaAbono, 126) BETWEEN '2016-04-10%' AND '2016-04-20%' UNION SELECT E.tarjetaVales, C.fechaCargo AS fecha, C.monto * -1 FROM Cargo C, Empleado E WHERE C.idEmpleado = E.idEmpleado AND E.tarjetaVales = 1879234111819100 AND CONVERT(VARCHAR(30),C.fechaCargo, 126) BETWEEN '2016-04-10%' AND '2016-04-20%' ORDER BY fecha DESC;", "Abono").Tables("Abono")
        Me.dgridReporteMov.Columns("fecha").DisplayIndex = 0
        Me.dgridReporteMov.Columns("monto").DisplayIndex = 1
        Me.dgridReporteMov.Columns("tarjetaVales").DisplayIndex = 2
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