<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnConfused = New System.Windows.Forms.Button()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.UserControl = New PrjFaces.UCtrlEmotion()
        Me.UserControl11 = New PrjFaces.UCtrlEmotion()
        Me.BtnPuhasta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConfused
        '
        Me.BtnConfused.BackColor = System.Drawing.SystemColors.Control
        Me.BtnConfused.Location = New System.Drawing.Point(373, 41)
        Me.BtnConfused.Name = "BtnConfused"
        Me.BtnConfused.Size = New System.Drawing.Size(82, 23)
        Me.BtnConfused.TabIndex = 1
        Me.BtnConfused.Text = "Confused"
        Me.BtnConfused.UseVisualStyleBackColor = False
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(373, 81)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(82, 23)
        Me.btnCool.TabIndex = 2
        Me.btnCool.Text = "Cool"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(373, 124)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(82, 23)
        Me.btnSmile.TabIndex = 3
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(373, 175)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(82, 23)
        Me.btnStar.TabIndex = 4
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnTeeth
        '
        Me.btnTeeth.Location = New System.Drawing.Point(373, 225)
        Me.btnTeeth.Name = "btnTeeth"
        Me.btnTeeth.Size = New System.Drawing.Size(82, 23)
        Me.btnTeeth.TabIndex = 5
        Me.btnTeeth.Text = "Teeth"
        Me.btnTeeth.UseVisualStyleBackColor = True
        '
        'btnYell
        '
        Me.btnYell.Location = New System.Drawing.Point(373, 268)
        Me.btnYell.Name = "btnYell"
        Me.btnYell.Size = New System.Drawing.Size(82, 23)
        Me.btnYell.TabIndex = 6
        Me.btnYell.Text = "Yell"
        Me.btnYell.UseVisualStyleBackColor = True
        '
        'UserControl
        '
        Me.UserControl.Location = New System.Drawing.Point(32, 32)
        Me.UserControl.Name = "UserControl"
        Me.UserControl.Size = New System.Drawing.Size(198, 106)
        Me.UserControl.TabIndex = 7
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.Control
        Me.UserControl11.Location = New System.Drawing.Point(32, 32)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(32, 32)
        Me.UserControl11.TabIndex = 0
        '
        'BtnPuhasta
        '
        Me.BtnPuhasta.Location = New System.Drawing.Point(373, 314)
        Me.BtnPuhasta.Name = "BtnPuhasta"
        Me.BtnPuhasta.Size = New System.Drawing.Size(82, 23)
        Me.BtnPuhasta.TabIndex = 8
        Me.BtnPuhasta.Text = "Puhasta"
        Me.BtnPuhasta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnPuhasta)
        Me.Controls.Add(Me.UserControl)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.BtnConfused)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl11 As PrjFaces.UCtrlEmotion
    Friend WithEvents BtnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnTeeth As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents UserControl As PrjFaces.UCtrlEmotion
    Friend WithEvents BtnPuhasta As Button
End Class
