Public Class frm_Movimientos
    Private Sub LoadComboBox()

        Dim Empresas As DataTable = ConnectionModule.connection.ReaderCommand("SELECT * FROM Empresa", "Empresa").Tables("Empresa")

        For index As Integer = 0 To empresas.Rows.Count() - 1
            cmbEmpresa.Items.Add(empresas.Rows(index).Item("nombreComercial"))
        Next

    End Sub

    Private Sub frm_Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBox()
    End Sub
End Class