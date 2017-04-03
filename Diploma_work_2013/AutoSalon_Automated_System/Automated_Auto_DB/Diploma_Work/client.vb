Public Class client

    Private Sub ClientBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub client_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DatabaseDataSet.Client". При необходимости она может быть перемещена или удалена.
        Me.ClientTableAdapter.Fill(Me.DatabaseDataSet.Client)

    End Sub
End Class