

Public Class Frmprocedencia

    Private context As LaboratorioEntities

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click

    End Sub
    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click

    End Sub
    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click

    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Frmprocedencia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        context = New LaboratorioEntities()
        ORIGENPACIENTEBindingSource.DataSource = context.ORIGENPACIENTE

    End Sub

    Private Sub ORIGENPACIENTEBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ORIGENPACIENTEBindingNavigatorSaveItem.Click
        ORIGENPACIENTEBindingSource.EndEdit()
        context.SaveChanges()

    End Sub
End Class