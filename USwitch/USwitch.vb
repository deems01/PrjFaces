Public Class USwitch
    Dim state As Integer = 0
    Public Event switchState(state As Integer)
    Private Sub selectedSwitch(ByVal intstate As Integer)
        If Not pbSwitch.Image = imgSwitch.Images(intSwitch) Then
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
