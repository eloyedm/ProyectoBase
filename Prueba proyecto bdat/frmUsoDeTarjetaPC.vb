Public Class frmUsoDeTarjetaPC
    Private Sub cargaReporte()
        Me.dgridReporte.DataSource = ConnectionModule.connection.ReaderCommand("SELECT Comercio.nombreComercial,COUNT(Cargo.idCargo) AS NumeroCargos, SUM(Cargo.monto) AS totalCargos FROM Cargo LEFT JOIN Comercio ON Cargo.idComercio=Comercio.idComercio WHERE CONVERT(VARCHAR(30),fechaCargo, 126) BETWEEN '2016-04-10%' AND '2016-04-20%' GROUP BY nombreComercial", "Cargo").Tables("Cargo")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridReporte.CellContentClick

    End Sub
End Class