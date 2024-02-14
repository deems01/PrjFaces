Public Class UBulb
    Private Sub selectedBulb(ByVal intBulb As Integer)
        pbBulb.Image = imgBulb.Images(intBulb)
    End Sub

    Public Sub setBulb(ByVal strBulb As String)
        Select Case strBulb
            Case "OFF"
                Me.selectedBulb(0)
            Case "ON"
                Me.selectedBulb(1)
            Case Else
                Me.selectedBulb(0)
        End Select
    End Sub
End Class
