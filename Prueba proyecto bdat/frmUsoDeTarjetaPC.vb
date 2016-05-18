Public Class frmUsoDeTarjetaPC
    Private Sub cargaReporte()
        Me.dgridReporte.DataSource = ConnectionModule.connection.ReaderCommand("")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridReporte.CellContentClick

    End Sub
End Class