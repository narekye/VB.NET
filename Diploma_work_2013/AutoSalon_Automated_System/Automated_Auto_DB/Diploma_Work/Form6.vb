Imports System.Data.OleDb
Public Class Form6

    Dim con As New OleDbConnection

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Did you want to delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter
            con.Open()
            ds.Tables.Add(dt)
            da = New OleDbDataAdapter("DELETE * FROM Masters where Код  like '%" & TextBox1.Text & "%'", con)
            da.Fill(dt)
            Form2.DataGridView1.DataSource = dt.DefaultView
            con.Close()
        Else
            MsgBox("Operation canceled.")

        End If
    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub
    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Masters where Անուն like '%" & TextBox6.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Masters where Ազգանուն like '%" & TextBox7.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
End Class