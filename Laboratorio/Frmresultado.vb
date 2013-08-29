Public Class Frmresultado
    Private context As LaboratorioEntities
    Private Sub Frmresultado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        context = New LaboratorioEntities()
        TIPORESULTADOBindingSource.DataSource = context.TIPORESULTADO


    End Sub

    Private Sub CodigoRes3TextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CodigoRes3TextBox.TextChanged

    End Sub

    Private Sub TIPORESULTADOBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TIPORESULTADOBindingNavigatorSaveItem.Click
        TIPORESULTADOBindingSource.EndEdit()
        context.SaveChanges()
    End Sub
End Class