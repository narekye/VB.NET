Module FirstModule
    Class Book
        Public Name As String
        Public Age As Integer
        Private same As String 'property field
        Public Property GetSame() As String
            Get
                Return same
            End Get
            Set(ByVal value As String)
                same = value
            End Set
        End Property
        Public Sub New(Name As String, age As Integer)
            Me.Name = Name ' C# this.Name = name
            Me.Age = age
        End Sub
    End Class
    Sub Main()
        Dim book As New Book("John", 23)
        Console.WriteLine(book.Age)
        Console.WriteLine(book.Name)
        Console.ReadLine()
    End Sub

End Module

