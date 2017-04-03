Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDbConnection
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM client where Անուն like '%" & TextBox1.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM client where Ազգանուն  like '%" & TextBox2.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
End Class