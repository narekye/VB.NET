Imports System.Data.OleDb
Public Class hashv
    Dim con As New OleDbConnection
    Private Sub hashv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM cars where Մակնիշ like '%" & TextBox1.Text & "%'", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Dim a1 As New DataTable
        Dim c1 As New DataSet
        Dim d1 As New OleDbDataAdapter
        con.Open()
        c1.Tables.Add(a1)
        d1 = New OleDbDataAdapter("SELECT * FROM cars where Գույն like '%" & TextBox2.Text & "%'", con)
        d1.Fill(a1)
        DataGridView1.DataSource = a1.DefaultView
        con.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        Dim a2 As New DataTable
        Dim c2 As New DataSet
        Dim d2 As New OleDbDataAdapter
        con.Open()
        c2.Tables.Add(a2)
        d2 = New OleDbDataAdapter("SELECT * FROM cars where Տարեթիվ like '%" & TextBox3.Text & "%'", con)
        d2.Fill(a2)
        DataGridView1.DataSource = a2.DefaultView
        con.Close()
    End Sub
End Class