Imports System

Module Program
    Sub Main(args As String())
        Dim myBMI1 As BMI = New BMI()
        Dim myBMI2 As BMI = New BMI()
        myBMI1.Height = 60
        myBMI1.Weight = 100
        myBMI2.Height = 61
        myBMI2.Weight = 100
        If myBMI1.CompareTo(myBMI2) > 0 Then
            Console.Write("BMI1 is greater")
        Else
            Console.Write("BMI2 is greater")    
        End If

    End Sub
End Module
