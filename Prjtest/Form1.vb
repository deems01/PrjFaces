Imports PrjFaces

Public Class Form1
    Private isLightOn As Boolean = False
    Private isSwitchOn As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLightOn = True
        isSwitchOn = True
        UpdateImages()
    End Sub
    Private Sub UpdateImages()
        If isLightOn Then
            UBulb.Image = My.Resources.lightOn
            USwitch.Image = My.Resources.btnON
        Else
            UBulb.Image = My.Resources.lightOff
            USwitch.Image = My.Resources.btnOff
        End If
    End Sub
    Private Sub btnConfused_Click(sender As Object, e As EventArgs) Handles btnConfused.Click
        UserControl.setMood("confused")
    End Sub

    Private Sub btnCool_Click(sender As Object, e As EventArgs) Handles btnCool.Click
        UserControl.setMood("cool")
    End Sub

    Private Sub btnSmile_Click(sender As Object, e As EventArgs) Handles btnSmile.Click
        UserControl.setMood("smile")
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) Handles btnStar.Click
        UserControl.setMood("star")
    End Sub

    Private Sub btnTeeth_Click(sender As Object, e As EventArgs) Handles btnTeeth.Click
        UserControl.setMood("teeth")
    End Sub

    Private Sub btnYell_Click(sender As Object, e As EventArgs) Handles btnYell.Click
        UserControl.setMood("yell")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        UserControl.ClearMood()
    End Sub
    Private Sub switchONOFF_Click(sender As Object, e As EventArgs) Handles USwitch.Click
        isLightOn = Not isLightOn
        isSwitchOn = Not isSwitchOn
        UpdateImages()
        If isLightOn Then
            UBulb.Image = My.Resources.lightOn
            USwitch.Image = My.Resources.btnON

        Else
            UBulb.Image = My.Resources.lightOff
            USwitch.Image = My.Resources.btnOff
        End If
    End Sub
End Class
