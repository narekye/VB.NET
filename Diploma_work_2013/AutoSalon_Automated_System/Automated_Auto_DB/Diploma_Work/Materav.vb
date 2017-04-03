Imports System.Data.OleDb
Public Class Materav
    Dim con As New OleDbConnection
    Private Sub Materav_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("INSERT INTO Masters (Ազգանուն,Անուն,Հայրանուն,Ծննդ_ամսաթիվ,Լրացումներ) VALUES ('" & TextBox1.Text & "' , '" & TextBox2.Text & "' , '" & TextBox3.Text & "' , '" & TextBox4.Text & "', '" & TextBox5.Text & "')", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub


End Class