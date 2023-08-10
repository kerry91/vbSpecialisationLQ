Imports System

Module Program
    Sub Main(args As String())
        dim salary As String = Console.ReadLine()
        dim salaryInt = CInt(salary)
        Console.WriteLine(FormatNumber(Math.Round(salaryInt / 3, 3), 3))
    End Sub
End Module
