Imports PrjFaces

Public Class Form1
    'Private isLightOn As Boolean = False
    'Private isSwitchOn As Boolean = False
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    isLightOn = True
    '    isSwitchOn = True
    '    updateimages()
    'End Sub
    'Private Sub updateimages()
    '    If isLightOn Then
    '        UBulb.setBulb("ON")
    '        USwitch.setSwitch("ON")
    '    Else
    '        UBulb.setBulb("OFF")
    '        USwitch.setSwitch("OFF")
    '    End If
    'End Sub
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
        UserControl.setMood("clear")
    End Sub
    'Private Sub switchONOFF_Click(sender As Object, e As EventArgs) Handles USwitch.Click
    '    isLightOn = Not isLightOn
    '    isSwitchOn = Not isSwitchOn
    '    UpdateImages()
    '    If isLightOn Then
    '        UBulb.Image = My.Resources.lightOn
    '        USwitch.Image = My.Resources.btnON
    '    Else
    '        UBulb.Image = My.Resources.lightOff
    '        USwitch.Image = My.Resources.btnOff
    '    End If
    'End Sub
    Private Sub USwitch1_Load(sender As Object, e As EventArgs) Handles USwitch.Load
        USwitch.setSwitch("OFF")
    End Sub

    Private Sub UBulb_Load(sender As Object, e As EventArgs) Handles UBulb.Load
        UBulb.setBulb("OFF")
    End Sub
    'Private Sub USwitch1_Click(sender As Object, e As EventArgs) Handles USwitch.Click
    '    isLightOn = Not isLightOn
    '    isSwitchOn = Not isSwitchOn
    '    updateImages()
    '    If isLightOn Then
    '        UBulb.setBulb("ON")
    '        USwitch.setSwitch("ON")
    '    Else
    '        UBulb.setBulb("OFF")
    '        USwitch.setSwitch("OFF")
    '    End If
    'End Sub
    Private Sub USwitch1_switchState(state As Integer) Handles USwitch.switchState
        If state = 1 Then
            UBulb.setBulb("ON")
        ElseIf state = 0 Then
            UBulb.setBulb("OFF")
        End If
    End Sub
End Class
