Imports System.Data.OleDb
Imports System.Security

Public Class addclient


    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("INSERT INTO Client (Անուն,Ազգանուն,Հասցե,Հեռախոս,Գրանցման) VALUES ('" & TextBox1.Text & "' , '" & TextBox2.Text & "' , '" & TextBox3.Text & "' , '" & TextBox4.Text & "', '" & TextBox5.Text & "')", con)
        da.Fill(dt)
        con.Close()
        MsgBox("Հաճախորդն ավելացված է", MsgBoxStyle.Information)

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub addclient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Timer1.Start()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label6.Text = TimeOfDay.ToString("h:mm:ss tt")

    End Sub
End Class
