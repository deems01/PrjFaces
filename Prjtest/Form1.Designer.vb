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
        Me.btnConfused = New System.Windows.Forms.Button()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.UserControl = New PrjFaces.UCtrlEmotion()
        Me.UserControl11 = New PrjFaces.UCtrlEmotion()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.switchONOFF = New System.Windows.Forms.PictureBox()
        Me.USwitch = New System.Windows.Forms.PictureBox()
        CType(Me.switchONOFF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConfused
        '
        Me.btnConfused.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfused.Location = New System.Drawing.Point(373, 41)
        Me.btnConfused.Name = "btnConfused"
        Me.btnConfused.Size = New System.Drawing.Size(82, 23)
        Me.btnConfused.TabIndex = 1
        Me.btnConfused.Text = "Confused"
        Me.btnConfused.UseVisualStyleBackColor = False
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
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(373, 314)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'switchONOFF
        '
        Me.switchONOFF.Image = Global.Prjtest.My.Resources.Resources.btnOff
        Me.switchONOFF.Location = New System.Drawing.Point(79, 297)
        Me.switchONOFF.Name = "switchONOFF"
        Me.switchONOFF.Size = New System.Drawing.Size(117, 59)
        Me.switchONOFF.TabIndex = 11
        Me.switchONOFF.TabStop = False
        '
        'USwitch
        '
        Me.USwitch.Image = Global.Prjtest.My.Resources.Resources.lightOn
        Me.USwitch.Location = New System.Drawing.Point(67, 107)
        Me.USwitch.Name = "USwitch"
        Me.USwitch.Size = New System.Drawing.Size(163, 184)
        Me.USwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.USwitch.TabIndex = 10
        Me.USwitch.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.switchONOFF)
        Me.Controls.Add(Me.USwitch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.UserControl)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.btnConfused)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.switchONOFF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl11 As PrjFaces.UCtrlEmotion
    Friend WithEvents btnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnTeeth As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents UserControl As PrjFaces.UCtrlEmotion
    Friend WithEvents btnClear As Button
    Friend WithEvents USwitch As PictureBox
    Friend WithEvents switchONOFF As PictureBox
End Class
