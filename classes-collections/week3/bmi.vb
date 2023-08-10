Public Class BMI
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
End Class