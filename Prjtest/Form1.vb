Imports PrjFaces

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BtnConfused_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfused.Click
        UserControl.setMood("confused")
    End Sub

    Private Sub BtnCool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCool.Click
        UserControl.setMood("cool")
    End Sub

    Private Sub BtnSmile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSmile.Click
        UserControl.setMood("smile")
    End Sub

    Private Sub BtnStar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStar.Click
        UserControl.setMood("star")
    End Sub


    Private Sub BtnTeeth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeeth.Click
        UserControl.setMood("teeth")
    End Sub

    Private Sub BtnYell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYell.Click
        UserControl.setMood("yell")
    End Sub
    Private Sub BtnPuhasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPuhasta.Click
        UserControl.ClearMood()
    End Sub

End Class
