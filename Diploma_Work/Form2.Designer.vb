<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HassaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DsadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DasdsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ՊահեստամասերToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ԱվելացնելToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՑուցադրելToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՈրոնումToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ԱվտոմեքենաներToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ԱվելացնելToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՑուցադրելToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՈրոնումToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՀաճախորդներToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՑուցադրելToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՈրոնումToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՎարպետներToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՑուցադրելToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՀեռացնելToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՍպասարկումToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ՑուցադրելToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ԱվելացնելToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.sbc = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ՀեռացնելToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(690, 425)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HassaToolStripMenuItem, Me.ՊահեստամասերToolStripMenuItem, Me.ԱվտոմեքենաներToolStripMenuItem, Me.ՀաճախորդներToolStripMenuItem, Me.ՎարպետներToolStripMenuItem, Me.ՍպասարկումToolStripMenuItem, Me.sbc})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HassaToolStripMenuItem
        '
        Me.HassaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DsadToolStripMenuItem, Me.DasdsToolStripMenuItem, Me.ToolStripSeparator1})
        Me.HassaToolStripMenuItem.Name = "HassaToolStripMenuItem"
        Me.HassaToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.HassaToolStripMenuItem.Text = "Գլխավոր"
        '
        'DsadToolStripMenuItem
        '
        Me.DsadToolStripMenuItem.Name = "DsadToolStripMenuItem"
        Me.DsadToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.DsadToolStripMenuItem.Text = "Մեր մասին"
        '
        'DasdsToolStripMenuItem
        '
        Me.DasdsToolStripMenuItem.Name = "DasdsToolStripMenuItem"
        Me.DasdsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.DasdsToolStripMenuItem.Text = "Ելք"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'ՊահեստամասերToolStripMenuItem
        '
        Me.ՊահեստամասերToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ԱվելացնելToolStripMenuItem, Me.ՑուցադրելToolStripMenuItem, Me.ՈրոնումToolStripMenuItem})
        Me.ՊահեստամասերToolStripMenuItem.Name = "ՊահեստամասերToolStripMenuItem"
        Me.ՊահեստամասերToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.ՊահեստամասերToolStripMenuItem.Text = "Պահեստամասեր"
        '
        'ԱվելացնելToolStripMenuItem
        '
        Me.ԱվելացնելToolStripMenuItem.Name = "ԱվելացնելToolStripMenuItem"
        Me.ԱվելացնելToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ԱվելացնելToolStripMenuItem.Text = "Ավելացնել"
        '
        'ՑուցադրելToolStripMenuItem
        '
        Me.ՑուցադրելToolStripMenuItem.Name = "ՑուցադրելToolStripMenuItem"
        Me.ՑուցադրելToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ՑուցադրելToolStripMenuItem.Text = "Ցուցադրել"
        '
        'ՈրոնումToolStripMenuItem
        '
        Me.ՈրոնումToolStripMenuItem.Name = "ՈրոնումToolStripMenuItem"
        Me.ՈրոնումToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ՈրոնումToolStripMenuItem.Text = "Որոնում/Հեռացում"
        '
        'ԱվտոմեքենաներToolStripMenuItem
        '
        Me.ԱվտոմեքենաներToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ԱվելացնելToolStripMenuItem1, Me.ՑուցադրելToolStripMenuItem1, Me.ՈրոնումToolStripMenuItem1})
        Me.ԱվտոմեքենաներToolStripMenuItem.Name = "ԱվտոմեքենաներToolStripMenuItem"
        Me.ԱվտոմեքենաներToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ԱվտոմեքենաներToolStripMenuItem.Text = "Ավտոմեքենաներ"
        '
        'ԱվելացնելToolStripMenuItem1
        '
        Me.ԱվելացնելToolStripMenuItem1.Name = "ԱվելացնելToolStripMenuItem1"
        Me.ԱվելացնելToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.ԱվելացնելToolStripMenuItem1.Text = "Ավելացնել"
        '
        'ՑուցադրելToolStripMenuItem1
        '
        Me.ՑուցադրելToolStripMenuItem1.Name = "ՑուցադրելToolStripMenuItem1"
        Me.ՑուցադրելToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.ՑուցադրելToolStripMenuItem1.Text = "Ցուցադրել"
        '
        'ՈրոնումToolStripMenuItem1
        '
        Me.ՈրոնումToolStripMenuItem1.Name = "ՈրոնումToolStripMenuItem1"
        Me.ՈրոնումToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.ՈրոնումToolStripMenuItem1.Text = "Որոնում/Հեռացում"
        '
        'ՀաճախորդներToolStripMenuItem
        '
        Me.ՀաճախորդներToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ՑուցադրելToolStripMenuItem2, Me.ՈրոնումToolStripMenuItem2})
        Me.ՀաճախորդներToolStripMenuItem.Name = "ՀաճախորդներToolStripMenuItem"
        Me.ՀաճախորդներToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.ՀաճախորդներToolStripMenuItem.Text = "Հաճախորդներ"
        '
        'ՑուցադրելToolStripMenuItem2
        '
        Me.ՑուցադրելToolStripMenuItem2.Name = "ՑուցադրելToolStripMenuItem2"
        Me.ՑուցադրելToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ՑուցադրելToolStripMenuItem2.Text = "Ցուցադրել"
        '
        'ՈրոնումToolStripMenuItem2
        '
        Me.ՈրոնումToolStripMenuItem2.Name = "ՈրոնումToolStripMenuItem2"
        Me.ՈրոնումToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ՈրոնումToolStripMenuItem2.Text = "Որոնում"
        '
        'ՎարպետներToolStripMenuItem
        '
        Me.ՎարպետներToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ՑուցադրելToolStripMenuItem3, Me.ՀեռացնելToolStripMenuItem, Me.ՀեռացնելToolStripMenuItem1})
        Me.ՎարպետներToolStripMenuItem.Name = "ՎարպետներToolStripMenuItem"
        Me.ՎարպետներToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ՎարպետներToolStripMenuItem.Text = "Վարպետներ"
        '
        'ՑուցադրելToolStripMenuItem3
        '
        Me.ՑուցադրելToolStripMenuItem3.Name = "ՑուցադրելToolStripMenuItem3"
        Me.ՑուցադրելToolStripMenuItem3.Size = New System.Drawing.Size(185, 22)
        Me.ՑուցադրելToolStripMenuItem3.Text = "Ավելացնել"
        '
        'ՀեռացնելToolStripMenuItem
        '
        Me.ՀեռացնելToolStripMenuItem.Name = "ՀեռացնելToolStripMenuItem"
        Me.ՀեռացնելToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ՀեռացնելToolStripMenuItem.Text = "Ցուցադրել"
        '
        'ՍպասարկումToolStripMenuItem
        '
        Me.ՍպասարկումToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ՑուցադրելToolStripMenuItem4, Me.ԱվելացնելToolStripMenuItem2})
        Me.ՍպասարկումToolStripMenuItem.Name = "ՍպասարկումToolStripMenuItem"
        Me.ՍպասարկումToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ՍպասարկումToolStripMenuItem.Text = "Սպասարկում"
        '
        'ՑուցադրելToolStripMenuItem4
        '
        Me.ՑուցադրելToolStripMenuItem4.Name = "ՑուցադրելToolStripMenuItem4"
        Me.ՑուցադրելToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ՑուցադրելToolStripMenuItem4.Text = "Ցուցադրել"
        '
        'ԱվելացնելToolStripMenuItem2
        '
        Me.ԱվելացնելToolStripMenuItem2.Name = "ԱվելացնելToolStripMenuItem2"
        Me.ԱվելացնելToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ԱվելացնելToolStripMenuItem2.Text = "Ավելացնել"
        '
        'sbc
        '
        Me.sbc.BackColor = System.Drawing.SystemColors.ControlDark
        Me.sbc.ForeColor = System.Drawing.Color.DarkRed
        Me.sbc.Name = "sbc"
        Me.sbc.Size = New System.Drawing.Size(48, 20)
        Me.sbc.Text = "Տպել"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(906, 304)
        Me.DataGridView1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "<< Ետ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 420)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ընթացիկ ժամ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'ՀեռացնելToolStripMenuItem1
        '
        Me.ՀեռացնելToolStripMenuItem1.Name = "ՀեռացնելToolStripMenuItem1"
        Me.ՀեռացնելToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.ՀեռացնելToolStripMenuItem1.Text = "Որոնում/Հեռացում"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 449)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.Text = "Գլխավոր մենյու"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HassaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DsadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DasdsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՊահեստամասերToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ԱվտոմեքենաներToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՀաճախորդներToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՎարպետներToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՍպասարկումToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ԱվելացնելToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՑուցադրելToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ԱվելացնելToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՑուցադրելToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՑուցադրելToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՑուցադրելToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՑուցադրելToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents sbc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՈրոնումToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՀեռացնելToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՈրոնումToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՈրոնումToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ԱվելացնելToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ՀեռացնելToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
