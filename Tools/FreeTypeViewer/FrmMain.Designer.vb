﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstCharCodes = New System.Windows.Forms.ListBox()
        Me.btnOpenFont = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnPerView = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.trackBarQuality = New System.Windows.Forms.TrackBar()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.trackDis = New System.Windows.Forms.TrackBar()
        Me.trackPow = New System.Windows.Forms.TrackBar()
        Me.btnViewFF = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackBarQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackPow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(271, 68)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 256)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lstCharCodes
        '
        Me.lstCharCodes.FormattingEnabled = True
        Me.lstCharCodes.ItemHeight = 15
        Me.lstCharCodes.Location = New System.Drawing.Point(27, 65)
        Me.lstCharCodes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCharCodes.Name = "lstCharCodes"
        Me.lstCharCodes.Size = New System.Drawing.Size(199, 259)
        Me.lstCharCodes.TabIndex = 1
        '
        'btnOpenFont
        '
        Me.btnOpenFont.Location = New System.Drawing.Point(27, 24)
        Me.btnOpenFont.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOpenFont.Name = "btnOpenFont"
        Me.btnOpenFont.Size = New System.Drawing.Size(75, 22)
        Me.btnOpenFont.TabIndex = 2
        Me.btnOpenFont.Text = "打开字体"
        Me.btnOpenFont.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1067, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(271, 22)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 22)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "输出"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(688, 20)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(352, 338)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 400)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(527, 22)
        Me.ProgressBar1.TabIndex = 7
        '
        'btnPerView
        '
        Me.btnPerView.Location = New System.Drawing.Point(547, 20)
        Me.btnPerView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPerView.Name = "btnPerView"
        Me.btnPerView.Size = New System.Drawing.Size(100, 29)
        Me.btnPerView.TabIndex = 8
        Me.btnPerView.Text = "渲染预览"
        Me.btnPerView.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(547, 68)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.TrackBar1.Maximum = 128
        Me.TrackBar1.Minimum = 16
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(56, 130)
        Me.TrackBar1.TabIndex = 9
        Me.TrackBar1.Value = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(547, 205)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 62)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'trackBarQuality
        '
        Me.trackBarQuality.Location = New System.Drawing.Point(610, 68)
        Me.trackBarQuality.Maximum = 100
        Me.trackBarQuality.Name = "trackBarQuality"
        Me.trackBarQuality.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trackBarQuality.Size = New System.Drawing.Size(56, 130)
        Me.trackBarQuality.TabIndex = 11
        Me.trackBarQuality.Value = 7
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(688, 364)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 15)
        Me.lblInfo.TabIndex = 12
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(609, 205)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(57, 62)
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'trackDis
        '
        Me.trackDis.Location = New System.Drawing.Point(541, 275)
        Me.trackDis.Maximum = 30
        Me.trackDis.Minimum = 1
        Me.trackDis.Name = "trackDis"
        Me.trackDis.Size = New System.Drawing.Size(106, 56)
        Me.trackDis.TabIndex = 14
        Me.trackDis.Value = 21
        '
        'trackPow
        '
        Me.trackPow.Location = New System.Drawing.Point(541, 337)
        Me.trackPow.Maximum = 100
        Me.trackPow.Minimum = 1
        Me.trackPow.Name = "trackPow"
        Me.trackPow.Size = New System.Drawing.Size(106, 56)
        Me.trackPow.TabIndex = 15
        Me.trackPow.Value = 1
        Me.trackPow.Visible = False
        '
        'btnViewFF
        '
        Me.btnViewFF.Location = New System.Drawing.Point(125, 23)
        Me.btnViewFF.Name = "btnViewFF"
        Me.btnViewFF.Size = New System.Drawing.Size(101, 23)
        Me.btnViewFF.TabIndex = 16
        Me.btnViewFF.Text = "已处理字体"
        Me.btnViewFF.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 448)
        Me.Controls.Add(Me.btnViewFF)
        Me.Controls.Add(Me.trackPow)
        Me.Controls.Add(Me.trackDis)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.trackBarQuality)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.btnPerView)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnOpenFont)
        Me.Controls.Add(Me.lstCharCodes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmMain"
        Me.Text = "字体生成器"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackBarQuality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackPow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstCharCodes As System.Windows.Forms.ListBox
    Friend WithEvents btnOpenFont As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnPerView As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents trackBarQuality As System.Windows.Forms.TrackBar
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents trackDis As System.Windows.Forms.TrackBar
    Friend WithEvents trackPow As System.Windows.Forms.TrackBar
    Friend WithEvents btnViewFF As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog

End Class
