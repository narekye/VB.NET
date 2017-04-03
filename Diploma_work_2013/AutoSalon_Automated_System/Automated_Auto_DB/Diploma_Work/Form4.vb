Imports System.Data.OleDb

Public Class Form4
    Dim con As New OleDbConnection
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Cars where Մակնիշ like '%" & TextBox1.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
    'tiv
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM Cars where Տարեթիվ  like '%" & TextBox2.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
    'vazq
    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM cars where Վազք_KM  like '%" & TextBox3.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub

   
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Ցանկանում եք հեռացնել տվյալ տողը?", "Ջնջել", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter
            con.Open()
            ds.Tables.Add(dt)
            da = New OleDbDataAdapter("DELETE * FROM cars where Код  like '%" & TextBox6.Text & "%'", con)
            da.Fill(dt)
            Form2.DataGridView1.DataSource = dt.DefaultView
            con.Close()
        Else
            MsgBox("Գործողությունը կասեցված է։")

        End If
    End Sub

    Private Sub TextBox4_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM cars where Մոտավոր_արժեք  like '%" & TextBox4.Text & "%'", con)
        da.Fill(dt)
        Form2.DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class