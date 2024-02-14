Public Class USwitch
    Private Sub selectedSwitch(ByVal intSwitch As Integer)
        pbSwitch.Image = imgSwitch.Images(intSwitch)
    End Sub

    Public Sub setSwitch(ByVal strSwitch As String)
        Select Case strSwitch
            Case "OFF"
                Me.selectedSwitch(0)
            Case "ON"
                Me.selectedSwitch(1)
            Case Else
                Me.selectedSwitch(0)
        End Select
    End Sub

    Private Sub pbSwitch_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click

    End Sub
End Class
