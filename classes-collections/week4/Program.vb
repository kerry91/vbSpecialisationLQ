Imports System

Module Program
    Sub Main(args As String())
        dim sum As Integer
        dim inValue As Integer
        dim myList As New List(Of Integer)
        Do
            inValue = CInt(Console.ReadLine())
            if inValue <> -1 Then
            sum += inValue
            myList.Add(inValue)
            End If
        Loop Until inValue = -1
    Console.WriteLine(sum / myList.Count)
    For i = 0  To myList.Count -1
    Console.WriteLine(myList(i))
    Next
    End Sub
End Module
