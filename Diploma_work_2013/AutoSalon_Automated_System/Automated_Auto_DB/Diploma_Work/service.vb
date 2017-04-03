Public Class service

    Private Sub ServiceBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ServiceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ServiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub service_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ServiceTableAdapter.Fill(Me.DatabaseDataSet.Service)
    End Sub
End Class