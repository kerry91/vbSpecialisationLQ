Imports System

Public Class BMI : Implements IComparable
    Private pWeight As Decimal
    Private pHeight As Decimal
    Public Property Weight
        Get
        return pWeight
        End Get
        Set(value)
            pWeight = value
        End Set
    End Property
    Public Property Height
        Get
        return pHeight
        End Get
        Set(value)
            pHeight = value
        End Set
    End Property
    Public Function BMI_Value()
    return pWeight/pHeight^2
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If TypeOf obj Is BMI Then
            return (BMI_Value() - ctype(obj,BMI).BMI_Value()) * 1000
            Else
            return -1
        End If
    End Function
End Class