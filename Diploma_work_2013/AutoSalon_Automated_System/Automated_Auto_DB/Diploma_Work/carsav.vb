Imports System.Data.OleDb

Public Class carsav
    Dim serverstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim reader As OleDbDataReader
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sqlquery As String = "INSERT INTO Cars (Մակնիշ,Գույն,Տարեթիվ,Վազք_KM,Շարժիչի_կոդ,Նույնացման_կոդ,Թափքի_կոդ,VIN,Մոտավոր_արժեք,Լրացում) VALUES ('" & TextBox1.Text & "' , '" & TextBox2.Text & "' , '" & TextBox3.Text & "' , '" & TextBox4.Text & "', '" & TextBox5.Text & "' , '" & TextBox6.Text & "' , '" & TextBox7.Text & "' , '" & TextBox8.Text & "' , '" & TextBox9.Text & "' , '" & TextBox10.Text & "')"
        cmd.Connection = con
        con.ConnectionString = serverstring
        con.Open()
        cmd.CommandText = sqlquery
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class