Public Class frmUsoDeTarjetaPC
    Private Sub cargaReporte()
        Me.dgridReporte.DataSource = ConnectionModule.connection.ReaderCommand("SELECT Comercio.nombreComercial,COUNT(Cargo.idCargo) AS NumeroCargos, SUM(Cargo.monto) AS totalCargos FROM Cargo LEFT JOIN Comercio ON Cargo.idComercio=Comercio.idComercio WHERE CONVERT(VARCHAR(30),fechaCargo, 126) BETWEEN '" & dtpfechai.Text & "' + '%' AND '" & dtpfechaf.Text & "' + '%' GROUP BY nombreComercial", "Cargo").Tables("Cargo")
        Me.dgridReporte.Columns("nombreComercial").DisplayIndex = 0
        Me.dgridReporte.Columns("numeroCargos").DisplayIndex = 1
        Me.dgridReporte.Columns("totalCargos").DisplayIndex = 2
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridReporte.CellContentClick

    End Sub

    
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        cargaReporte()
    End Sub

    Private Sub frm_CatalogoDeEmpleado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        frm_Menu.Show()
        frm_Menu.Focus()
    End Sub
End Class