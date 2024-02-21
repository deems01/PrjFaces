Public Class USwitch
    Dim state As Integer = 0
    Public Event switchState(state As Integer)
    Private Sub selectedSwitch(ByVal intstate As Integer)
        If Not IsNothing(pbSwitch.Image) Then
            pbSwitch.Image.Dispose()
            pbSwitch.Image = Nothing
        End If

        pbSwitch.Image = imgSwitch.Images(intstate)
    End Sub

    Public Sub setSwitch(ByVal state As String)
        If state = "ON" Then
            Me.selectedSwitch(0)
        ElseIf state = "OFF" Then
            Me.selectedSwitch(1)
        Else
            Me.selectedSwitch(1)
        End If
    End Sub

    Private Sub pbSwitch_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click
        If state = 0 Then
            setSwitch("ON")
            state = 1
        Else
            setSwitch("OFF")
            state = 0
        End If
        RaiseEvent switchState(state)
    End Sub
End Class
