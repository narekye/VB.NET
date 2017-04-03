Imports System.Data.OleDb

Public Class Form3
    Dim con As New OleDbConnection
    Dim index As Integer
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Auto_parts where Անուն like '%" & TextBox1.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
    'gin
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Auto_parts where Գին  like '%" & TextBox2.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
    'mnacord
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Auto_parts where Մնացորդ  like '%" & TextBox3.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
   

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If MessageBox.Show("Did you want to delete this record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter
            con.Open()
            ds.Tables.Add(dt)
            da = New OleDbDataAdapter("DELETE * FROM Auto_parts where Код  like '%" & TextBox4.Text & "%'", con)
            da.Fill(dt)
            Form2.DataGridView1.DataSource = dt.DefaultView

            con.Close()
        Else
            MsgBox("Operation canceled")

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub
    ' ashxatec
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("UPDATE Auto_Parts SET Մուտք_Ամս = '" & TextBox5.Text & "' WHERE Գին = '" & TextBox6.Text & "'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("UPDATE Auto_Parts SET Վաճառքի = '" & TextBox8.Text & "'  WHERE Գին = '" & TextBox7.Text & "'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

End Class