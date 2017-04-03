Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Form2
    Private bitmap As Bitmap
    Dim con As New OleDbConnection
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form1.Hide()

        Me.CenterToScreen()
        Timer1.Start()
        DataGridView1.Hide()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database1.accdb"
    End Sub
    Private Sub DsadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DsadToolStripMenuItem.Click
        MsgBox("Ավտոսալոն ՓԲԸ, Ստեղծված է բոլոր մակնիշի մեքենաների տեխսպասարկման համար, պատրաստված է ՀԱՊՀ քոլեջի ուսանող Եգորյան Նարեկի կողմից։", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub DasdsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DasdsToolStripMenuItem.Click
        Me.Close()
        Form1.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub
    Private Sub ԱվելացնելToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ԱվելացնելToolStripMenuItem.Click
        autopartsav.Show()
    End Sub
    Private Sub ԱվելացնելToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ԱվելացնելToolStripMenuItem1.Click
        carsav.Show()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub ՑուցադրելToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ՑուցադրելToolStripMenuItem.Click
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter
        con.Open()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT * FROM auto_parts", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
    Private Sub ՑուցադրելToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ՑուցադրելToolStripMenuItem1.Click
        Dim aa As New DataTable
        Dim da As New DataSet
        Dim gg As New OleDbDataAdapter
        con.Open()
        da.Tables.Add(aa)
        gg = New OleDbDataAdapter("SELECT * FROM cars", con)
        gg.Fill(aa)
        DataGridView1.DataSource = aa.DefaultView
        con.Close()
    End Sub
    Private Sub ՑուցադրելToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ՑուցադրելToolStripMenuItem2.Click
        Dim aa As New DataTable
        Dim da As New DataSet
        Dim gg As New OleDbDataAdapter
        con.Open()
        da.Tables.Add(aa)
        gg = New OleDbDataAdapter("SELECT * FROM client order by Код", con)
        gg.Fill(aa)
        DataGridView1.DataSource = aa.DefaultView
        con.Close()
    End Sub
   
    Private Sub ՑուցադրելToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ՑուցադրելToolStripMenuItem4.Click
        Dim aa As New DataTable
        Dim da As New DataSet
        Dim gg As New OleDbDataAdapter
        con.Open()
        da.Tables.Add(aa)
        gg = New OleDbDataAdapter("SELECT * FROM service", con)
        gg.Fill(aa)
        DataGridView1.DataSource = aa.DefaultView
        con.Close()
    End Sub
    Private Sub HassaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HassaToolStripMenuItem.Click
        DataGridView1.Hide()
    End Sub
    Private Sub ՈրոնումToolStripMenuItem_Checked(sender As System.Object, e As System.EventArgs) Handles ՈրոնումToolStripMenuItem.Click
        Form3.Show()
        DataGridView1.Show()
    End Sub
    Private Sub ՈրոնումToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ՈրոնումToolStripMenuItem1.Click
        Form4.Show()
    End Sub
    Private Sub ՊահեստամասերToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ՊահեստամասերToolStripMenuItem.Click
        DataGridView1.Show()
    End Sub
    Private Sub ԱվտոմեքենաներToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ԱվտոմեքենաներToolStripMenuItem.Click
        DataGridView1.Show()
    End Sub
    Private Sub ՀաճախորդներToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ՀաճախորդներToolStripMenuItem.Click
        DataGridView1.Show()
    End Sub
    Private Sub ՎարպետներToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ՎարպետներToolStripMenuItem.Click
        DataGridView1.Show()
    End Sub
    Private Sub ՍպասարկումToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ՍպասարկումToolStripMenuItem.Click
        DataGridView1.Show()
    End Sub
    Private Sub sbc_Click(sender As System.Object, e As System.EventArgs) Handles sbc.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        DataGridView1.Height = height
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
    Private Sub ՈրոնումToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ՈրոնումToolStripMenuItem2.Click
        Form5.Show()
    End Sub
    Private Sub ՀեռացնելToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ՀեռացնելToolStripMenuItem.Click
        Dim aa As New DataTable
        Dim da As New DataSet
        Dim gg As New OleDbDataAdapter
        con.Open()
        da.Tables.Add(aa)
        gg = New OleDbDataAdapter("SELECT * FROM masters", con)
        gg.Fill(aa)
        DataGridView1.DataSource = aa.DefaultView
        con.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selctedrow As DataGridViewRow
        selctedrow = DataGridView1.Rows(index)
        Form3.TextBox5.Text = selctedrow.Cells(5).Value.ToString()
    End Sub

    Private Sub ՀեռացնելToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ՀեռացնելToolStripMenuItem1.Click
        Form6.Show()
    End Sub

    Private Sub ՑուցադրելToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ՑուցադրելToolStripMenuItem3.Click
        Materav.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ԱվելացնելToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ԱվելացնելToolStripMenuItem2.Click
        spasarlumav.Show()
    End Sub
End Class