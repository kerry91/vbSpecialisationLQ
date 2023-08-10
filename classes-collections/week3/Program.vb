Imports System

Module Program
    Sub Main(args As String())
        dim myBmi = new BMI
        myBmi.height = 2.0
        myBmi.weight = 12
        Console.WriteLine(myBmi.BMI_Value())
    End Sub
End Module
