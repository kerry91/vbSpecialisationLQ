Imports System

Module Program
    Sub Main(args As String())
        Dim myT As Triangle = New Triangle()
        myT.Side1 = 100
        myT.Side2 = 10
        Console.WriteLine(myT.area())
    End Sub
End Module
