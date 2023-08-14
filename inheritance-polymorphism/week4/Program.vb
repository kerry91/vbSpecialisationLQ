Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim myCow1 As Cow = New Cow()
        Dim myCow2 As Cow = New Cow()
        myCow1.height = 10
        myCow1.weight = 200
        myCow2.height = 10
        myCow2.weight = 200
        Dim x As Integer = myCow1.CompareTo(myCow2)
        Console.WriteLine(x)
    End Sub
End Module
