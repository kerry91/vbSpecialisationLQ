Imports System

Module Program
    Sub Main(args As String())
        dim salary As String
        salary = Console.ReadLine()
        dim salaryDec As Decimal
        salaryDec = CDec(salary)
        Console.WriteLine(FormatNumber(salaryDec, 2))
    End Sub
End Module
