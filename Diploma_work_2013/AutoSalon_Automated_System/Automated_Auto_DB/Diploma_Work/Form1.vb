Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Visible = False
        parts.Visible = False
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            Form2.Visible = True
        ElseIf TextBox1.Text = "user" And TextBox2.Text = "user" Then
            addclient.Show()
            Me.Hide()
        Else
            MsgBox("Մուտքագրված ինֆորմացիան սխալ է", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        MsgBox("Ավտոսալոն ՓԲԸ, Ստեղծված է բոլոր մակնիշի մեքենաների տեխսպասարկման համար, պատրաստված է ՀԱՊՀ քոլեջի ուսանող Եգորյան Նարեկի կողմից։", MsgBoxStyle.OkOnly)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
