Public Class Form1
    Private mRootPath As String = "C:\Users\Narek-PC\Desktop\aaaaa"
    Property RootPath As String
        Get
            Return mRootPath
        End Get
        Set(value As String)
            mRootPath = value
        End Set
    End Property
    Private Sub UserControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mRootNode As New TreeNode
        mRootNode.Text = "DATEBASE"
        mRootNode.Tag = RootPath
        mRootNode.Nodes.Add("*DUMMY*")
        TreeView1.Nodes.Add(mRootNode)

        mRootNode.ImageKey = CacheShellIcon(RootPath)
        mRootNode.SelectedImageKey = mRootNode.ImageKey
    End Sub
    Private Sub TreeView1_BeforeCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeCollapse
        e.Node.Nodes.Clear()
        e.Node.Nodes.Add("*DUMMY*")
    End Sub

    Private Sub TreeView1_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        e.Node.Nodes.Clear()
        Dim mNodeDirectory As IO.DirectoryInfo
        mNodeDirectory = New IO.DirectoryInfo(e.Node.Tag.ToString)
        For Each mDirectory As IO.DirectoryInfo In mNodeDirectory.GetDirectories
            Dim mDirectoryNode As New TreeNode
            mDirectoryNode.Tag = mDirectory.FullName
            mDirectoryNode.Text = mDirectory.Name
            mDirectoryNode.Nodes.Add("*DUMMY*")
            e.Node.Nodes.Add(mDirectoryNode)
            mDirectoryNode.ImageKey = CacheShellIcon(mDirectory.FullName)
            mDirectoryNode.SelectedImageKey = mDirectoryNode.ImageKey
        Next

        For Each mFile As IO.FileInfo In mNodeDirectory.GetFiles
            Dim mFileNode As New TreeNode
            mFileNode.Tag = mFile.FullName
            mFileNode.Text = mFile.Name
            mFileNode.ImageKey = CacheShellIcon(mFile.FullName)
            mFileNode.SelectedImageKey = mFileNode.ImageKey & "-open"
            e.Node.Nodes.Add(mFileNode)
        Next
        
    End Sub

    Public Declare Auto Function SHGetFileInfo Lib "shell32.dll" (ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, ByVal uFlags As Integer) As IntPtr

    Public Const SHGFI_ICON As Integer = &H100
    Public Const SHGFI_SMALLICON As Integer = &H1
    Public Const SHGFI_LARGEICON As Integer = &H0
    Public Const SHGFI_OPENICON As Integer = &H2

    Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As Integer
        <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=260)> _
        Public szDisplayName As String
        <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=80)> _
        Public szTypeName As String
    End Structure
    Function GetShellIconAsImage(ByVal argPath As String) As Image
        Dim mShellFileInfo As New SHFILEINFO
        mShellFileInfo.szDisplayName = New String(Chr(0), 260)
        mShellFileInfo.szTypeName = New String(Chr(0), 80)
        SHGetFileInfo(argPath, 0, mShellFileInfo, System.Runtime.InteropServices.Marshal.SizeOf(mShellFileInfo), SHGFI_ICON Or SHGFI_SMALLICON)
        Dim mIcon As System.Drawing.Icon
        Dim mImage As System.Drawing.Image
        Try
            mIcon = System.Drawing.Icon.FromHandle(mShellFileInfo.hIcon)
            mImage = mIcon.ToBitmap
        Catch ex As Exception
            mImage = New System.Drawing.Bitmap(16, 16)
        End Try
        Return mImage
    End Function
    Function CacheShellIcon(ByVal argPath As String) As String
        Dim mKey As String = Nothing
        If IO.Directory.Exists(argPath) = True Then
            mKey = "folder"
        ElseIf IO.File.Exists(argPath) = True Then
            mKey = IO.Path.GetExtension(argPath)
        End If
        If ImageList1.Images.ContainsKey(mKey) = False Then
            ImageList1.Images.Add(mKey, GetShellIconAsImage(argPath))
        End If
        Return mKey
    End Function
    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        If e.Node.ImageKey = "folder" Then Exit Sub
        If e.Node.Tag = "" Then Exit Sub
        Try
            Process.Start(e.Node.Tag)
        Catch ex As Exception
            MessageBox.Show("Error opening file: " & ex.Message)
        End Try
    End Sub

End Class
