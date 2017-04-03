Public Class cars

    Private Sub CarsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CarsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub cars_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DatabaseDataSet.Cars". При необходимости она может быть перемещена или удалена.
        Me.CarsTableAdapter.Fill(Me.DatabaseDataSet.Cars)

    End Sub
End Class