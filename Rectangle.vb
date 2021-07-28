Public Class Rectangle
    Private dblLength As Double
    Private dblWidth As Double

    Public Property Length As Double
        Get
            Return dblLength
        End Get
        Set(value As Double)
            If value > 0 Then
                dblLength = value
            Else
                dblLength = 0
            End If
        End Set
    End Property

    Public Property Width As Double
        Get
            Return dblWidth
        End Get
        Set(value As Double)
            If value > 0 Then
                dblWidth = value
            Else
                dblWidth = 0
            End If
        End Set
    End Property

    Public Sub New()
        dblLength = 0
        dblWidth = 0
    End Sub

    Public Function GetPerimeter() As Double
        Return 2 * (dblLength + dblWidth)
    End Function
End Class
