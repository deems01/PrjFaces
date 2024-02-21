Public Class USwitch
    Dim switch As Integer = 0
    Public Event switchState(state As Integer)
    Private Sub selectedSwitch(ByVal intstate As Integer)
        If Not IsNothing(pbSwitch.Image) Then
            pbSwitch.Image.Dispose()
            pbSwitch.Image = Nothing
        End If

        pbSwitch.Image = imgSwitch.Images(intstate)
    End Sub

    Public Sub setSwitch(ByVal switch As String)
        If switch = "ON" Then
            Me.selectedSwitch(0)
        ElseIf switch = "OFF" Then
            Me.selectedSwitch(1)
        Else
            Me.selectedSwitch(1)
        End If
    End Sub

    Private Sub pbSwitch_Click(sender As Object, e As EventArgs) Handles pbSwitch.Click
        If switch = 0 Then
            setSwitch("ON")
            switch = 1
        Else
            setSwitch("OFF")
            switch = 0
        End If
        RaiseEvent switchState(switch)
    End Sub
End Class
