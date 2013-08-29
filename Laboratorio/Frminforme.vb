Public Class Frminforme


    Private context As LaboratorioEntities
    Private Sub Frminforme_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        context = New LaboratorioEntities
        TIPOINFORMEBindingSource.DataSource = context.TIPOINFORME
    End Sub

    Private Sub TIPOINFORMEBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TIPOINFORMEBindingNavigatorSaveItem.Click
        TIPOINFORMEBindingSource.EndEdit()
        context.SaveChanges()
    End Sub
End Class