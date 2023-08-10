Imports System

Module Program
    Sub Main(args As String())
        Dim inValue As String
        Dim sum As Integer
        Do
            inValue = console.ReadLine()
            If CInt(inValue) <> -1 Then
                sum +=CInt(inValue)
            End If
            Loop Until CInt(inValue) = -1
            Console.WriteLine(sum)    
    End Sub
End Module
