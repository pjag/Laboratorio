Public Class Frmmateriales
    Private context As LaboratorioEntities
    Private Sub Frmmateriales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        context = New LaboratorioEntities()
        MATERIALBindingSource.DataSource = context.MATERIAL
    End Sub

    Private Sub MATERIALBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MATERIALBindingNavigatorSaveItem.Click
        MATERIALBindingSource.EndEdit()
        context.SaveChanges()
    End Sub
End Class