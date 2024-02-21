Imports System.IO

Public Class UBulb
    Private Sub selectedBulb(ByVal intBulb As Integer)
        If Not IsNothing(pbBulb.Image) Then
            pbBulb.Image.Dispose()
            pbBulb.Image = Nothing
        End If
        pbBulb.Image = imgBulb.Images(intBulb)
    End Sub

    Public Sub setBulb(ByVal bulb As String)
        If bulb = "ON" Then
            Me.selectedBulb(1)
        ElseIf bulb = "OFF" Then
            Me.selectedBulb(0)
        Else
            Me.selectedBulb(0)
        End If
    End Sub

    Private Sub pbBulb_Click(sender As Object, e As EventArgs) Handles pbBulb.Click

    End Sub
End Class
