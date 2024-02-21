Imports System.Diagnostics.Eventing.Reader

Public Class UCtrlEmotion

    Private Sub selectedMood(ByVal intMood As Integer)
        pbEmotion.Image = imgLoend.Images(intMood)
    End Sub

    Public Sub setMood(ByVal strMood As String)
        If Not IsNothing(pbEmotion.Image) Then
            pbEmotion.Image.Dispose()
            pbEmotion.Image = Nothing
        End If
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
            Case "clear"
                If Not IsNothing(pbEmotion.Image) Then
                    pbEmotion.Image.Dispose()
                    pbEmotion.Image = Nothing
                End If
            Case Else
                Me.selectedMood(0)
        End Select
    End Sub
End Class
