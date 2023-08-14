Public Class Cow : Implements Animal, IComparable

    Private pHeight As Double
    Private pWeight As Double

    Public Property height As Double Implements Animal.height
        Get
            return pHeight
        End Get

        Set(value As Double)
            pHeight = value
        End Set
    End Property

    Public Property weight As Double Implements Animal.weight
        Get
            return pWeight
        End Get

        Set(value As Double)
            pWeight = value
        End Set  
    End Property      

        Public Function speed() As Double Implements Animal.speed
            return pHeight * pWeight / 10
        End Function

        Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
            If TypeOf obj Is Cow Then
                return CType(obj, Cow).speed = speed()
            Else
                return -1    
            End If    
        End Function

End Class