Imports System

Module Program
    Sub Main(args As String())
        dim thisDateTime As Date = DateTime.Now
        dim inputValue As Integer
        inputValue = CInt(Console.ReadLine())
        thisDateTime = thisDateTime.AddDays(inputValue)
        Console.WriteLine(String.Format("{0:dddd, MMMM dd, yyyy}", thisDateTime))
    End Sub
End Module
