Public Class UCtrlEmotion

    Private Sub selectedMood(ByVal intMood As Integer)
        pbEmotion.Image = imgLoend.Images(intMood)
    End Sub

    Public Sub setMood(ByVal strMood As String)
        Select Case strMood
            Case "confused"
                Me.selectedMood(0)
            Case "cool"
                Me.selectedMood(1)
            Case "smile"
                Me.selectedMood(2)
            Case "star"
                Me.selectedMood(3)
            Case "teeth"
                Me.selectedMood(4)
            Case "yell"
                Me.selectedMood(5)
            Case Else
                Me.selectedMood(0)
        End Select
    End Sub
    Public Sub clearMood()
        pbEmotion.Image.Dispose()
        pbEmotion.Image = Nothing
    End Sub
End Class
