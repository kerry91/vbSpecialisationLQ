Imports System

Module Program
    Sub Main(args As String())
        dim mySum As Decimal
        dim inValue As Integer
        dim count As Integer

        Do
            inValue = CInt(Console.ReadLine())
            mySum += inValue
            count += 1
        Loop Until inValue = -1

        Console.WriteLine(((mySum + 1) / (count - 1)).ToString("N"))    
    End Sub
End Module
