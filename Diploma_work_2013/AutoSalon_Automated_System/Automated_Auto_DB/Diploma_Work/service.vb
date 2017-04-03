Public Class service

    Private Sub ServiceBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ServiceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ServiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub service_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DatabaseDataSet.Service". При необходимости она может быть перемещена или удалена.
        Me.ServiceTableAdapter.Fill(Me.DatabaseDataSet.Service)

    End Sub
End Class