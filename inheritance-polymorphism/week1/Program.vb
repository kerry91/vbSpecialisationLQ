Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim fs As FileStream = New FileStream("indata.txt", FileMode.Open, FileAccess.Read)
        Dim sr As StreamReader = New StreamReader(fs)
        Dim sum As Integer
        Dim inData As String
        Do
            inData = sr.readline()
                sum += Cint(indata)
        Loop Until inData = Nothing  
        Console.WriteLine(sum.ToString("n"))      
    End Sub
End Module
