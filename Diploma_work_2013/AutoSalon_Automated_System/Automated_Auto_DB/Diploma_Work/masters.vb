Public Class masters

    Private Sub MastersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles MastersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MastersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub masters_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MastersTableAdapter.Fill(Me.DatabaseDataSet.Masters)
    End Sub
End Class