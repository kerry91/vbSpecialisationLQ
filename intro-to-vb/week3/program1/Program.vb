Imports System

Module Program
    Sub Main(args As String())
        dim inValue As String
        inValue = Console.ReadLine()

        if inValue < 100 Then
            Console.WriteLine("Small")
        Elseif inValue > 200 Then
            Console.WriteLine("Large")
        Else  
            Console.WriteLine("Medium")  
        End if    
    End Sub
End Module
