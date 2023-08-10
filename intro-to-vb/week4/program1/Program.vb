Imports System

Module Program
    Sub Main(args As String())
        Dim inValue As String = Console.ReadLine()
        Dim inValueInt As Integer = CInt(inValue)
        Dim sum As Integer
        For i As Integer = 1 To inValue
            sum = sum + i
            Next
            Console.WriteLine(sum)
    End Sub
End Module
