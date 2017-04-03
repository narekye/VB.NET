Imports System.Data.OleDb


Public Class autopartsav
    Dim serverstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader

   

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sqlquery As String = "INSERT INTO Auto_Parts (Անուն,Համար,Երաշխիք,Գին,Մնացորդ) VALUES ('" & TextBox1.Text & "' , '" & TextBox2.Text & "' , '" & TextBox3.Text & "' , '" & TextBox4.Text & "', '" & TextBox5.Text & "')"
        cmd.Connection = con
        con.ConnectionString = serverstring
        con.Open()
        cmd.CommandText = sqlquery
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class