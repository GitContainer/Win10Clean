﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.HomeTab = New System.Windows.Forms.TabPage()
        Me.VerLabel = New System.Windows.Forms.Label()
        Me.CheckUpdatesBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.AdsBtn = New System.Windows.Forms.Button()
        Me.GameDVRBtn = New System.Windows.Forms.Button()
        Me.HomeGroupBtn = New System.Windows.Forms.Button()
        Me.DefenderBtn = New System.Windows.Forms.Button()
        Me.OneDriveBtn = New System.Windows.Forms.Button()
        Me.Revert7Btn = New System.Windows.Forms.Button()
        Me.MeteroTab = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.UninstallBtn = New System.Windows.Forms.Button()
        Me.AppBox = New System.Windows.Forms.ListBox()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.DebugBox = New System.Windows.Forms.RichTextBox()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.HomeTab.SuspendLayout()
        Me.MeteroTab.SuspendLayout()
        Me.Tab2.SuspendLayout()
        Me.Tab3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.HomeTab)
        Me.TabControl1.Controls.Add(Me.MeteroTab)
        Me.TabControl1.Controls.Add(Me.Tab2)
        Me.TabControl1.Controls.Add(Me.Tab3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(537, 413)
        Me.TabControl1.TabIndex = 0
        '
        'HomeTab
        '
        Me.HomeTab.Controls.Add(Me.VerLabel)
        Me.HomeTab.Controls.Add(Me.CheckUpdatesBtn)
        Me.HomeTab.Controls.Add(Me.CloseBtn)
        Me.HomeTab.Controls.Add(Me.AdsBtn)
        Me.HomeTab.Controls.Add(Me.GameDVRBtn)
        Me.HomeTab.Controls.Add(Me.HomeGroupBtn)
        Me.HomeTab.Controls.Add(Me.DefenderBtn)
        Me.HomeTab.Controls.Add(Me.OneDriveBtn)
        Me.HomeTab.Controls.Add(Me.Revert7Btn)
        Me.HomeTab.Location = New System.Drawing.Point(4, 25)
        Me.HomeTab.Name = "HomeTab"
        Me.HomeTab.Size = New System.Drawing.Size(529, 384)
        Me.HomeTab.TabIndex = 0
        Me.HomeTab.Text = "Home"
        Me.HomeTab.UseVisualStyleBackColor = True
        '
        'VerLabel
        '
        Me.VerLabel.AutoSize = True
        Me.VerLabel.Location = New System.Drawing.Point(8, 362)
        Me.VerLabel.Name = "VerLabel"
        Me.VerLabel.Size = New System.Drawing.Size(64, 17)
        Me.VerLabel.TabIndex = 25
        Me.VerLabel.Text = "Version: "
        '
        'CheckUpdatesBtn
        '
        Me.CheckUpdatesBtn.Location = New System.Drawing.Point(375, 345)
        Me.CheckUpdatesBtn.Name = "CheckUpdatesBtn"
        Me.CheckUpdatesBtn.Size = New System.Drawing.Size(79, 31)
        Me.CheckUpdatesBtn.TabIndex = 23
        Me.CheckUpdatesBtn.Text = "Updates"
        Me.CheckUpdatesBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(460, 345)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(61, 31)
        Me.CloseBtn.TabIndex = 24
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'AdsBtn
        '
        Me.AdsBtn.Location = New System.Drawing.Point(306, 3)
        Me.AdsBtn.Name = "AdsBtn"
        Me.AdsBtn.Size = New System.Drawing.Size(220, 31)
        Me.AdsBtn.TabIndex = 18
        Me.AdsBtn.Text = "Disable start menu ads"
        Me.AdsBtn.UseVisualStyleBackColor = True
        '
        'GameDVRBtn
        '
        Me.GameDVRBtn.Location = New System.Drawing.Point(306, 77)
        Me.GameDVRBtn.Name = "GameDVRBtn"
        Me.GameDVRBtn.Size = New System.Drawing.Size(220, 31)
        Me.GameDVRBtn.TabIndex = 17
        Me.GameDVRBtn.Text = "Disable GameDVR"
        Me.GameDVRBtn.UseVisualStyleBackColor = True
        '
        'HomeGroupBtn
        '
        Me.HomeGroupBtn.Location = New System.Drawing.Point(3, 77)
        Me.HomeGroupBtn.Name = "HomeGroupBtn"
        Me.HomeGroupBtn.Size = New System.Drawing.Size(220, 31)
        Me.HomeGroupBtn.TabIndex = 16
        Me.HomeGroupBtn.Text = "Disable HomeGroup"
        Me.HomeGroupBtn.UseVisualStyleBackColor = True
        '
        'DefenderBtn
        '
        Me.DefenderBtn.Location = New System.Drawing.Point(3, 3)
        Me.DefenderBtn.Name = "DefenderBtn"
        Me.DefenderBtn.Size = New System.Drawing.Size(220, 31)
        Me.DefenderBtn.TabIndex = 12
        Me.DefenderBtn.Text = "Disable Windows Defender"
        Me.DefenderBtn.UseVisualStyleBackColor = True
        '
        'OneDriveBtn
        '
        Me.OneDriveBtn.Location = New System.Drawing.Point(306, 40)
        Me.OneDriveBtn.Name = "OneDriveBtn"
        Me.OneDriveBtn.Size = New System.Drawing.Size(220, 31)
        Me.OneDriveBtn.TabIndex = 15
        Me.OneDriveBtn.Text = "Uninstall OneDrive"
        Me.OneDriveBtn.UseVisualStyleBackColor = True
        '
        'Revert7Btn
        '
        Me.Revert7Btn.Location = New System.Drawing.Point(3, 40)
        Me.Revert7Btn.Name = "Revert7Btn"
        Me.Revert7Btn.Size = New System.Drawing.Size(220, 31)
        Me.Revert7Btn.TabIndex = 14
        Me.Revert7Btn.Text = "Revert explorer to Win7 style"
        Me.Revert7Btn.UseVisualStyleBackColor = True
        '
        'MeteroTab
        '
        Me.MeteroTab.Controls.Add(Me.CheckBox2)
        Me.MeteroTab.Controls.Add(Me.CheckBox1)
        Me.MeteroTab.Controls.Add(Me.UninstallBtn)
        Me.MeteroTab.Controls.Add(Me.AppBox)
        Me.MeteroTab.Controls.Add(Me.RefreshBtn)
        Me.MeteroTab.Location = New System.Drawing.Point(4, 25)
        Me.MeteroTab.Name = "MeteroTab"
        Me.MeteroTab.Size = New System.Drawing.Size(529, 384)
        Me.MeteroTab.TabIndex = 1
        Me.MeteroTab.Text = "Win10 / metero apps"
        Me.MeteroTab.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(376, 30)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(145, 21)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Delete from image"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(376, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 21)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "All users"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'UninstallBtn
        '
        Me.UninstallBtn.Image = Global.Win10Clean.My.Resources.Resources.bin
        Me.UninstallBtn.Location = New System.Drawing.Point(336, 349)
        Me.UninstallBtn.Name = "UninstallBtn"
        Me.UninstallBtn.Size = New System.Drawing.Size(34, 34)
        Me.UninstallBtn.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.UninstallBtn, "Uninstall selected app")
        Me.UninstallBtn.UseVisualStyleBackColor = True
        '
        'AppBox
        '
        Me.AppBox.FormattingEnabled = True
        Me.AppBox.ItemHeight = 16
        Me.AppBox.Location = New System.Drawing.Point(3, 3)
        Me.AppBox.Name = "AppBox"
        Me.AppBox.Size = New System.Drawing.Size(367, 340)
        Me.AppBox.TabIndex = 5
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Image = Global.Win10Clean.My.Resources.Resources.arrow_refresh
        Me.RefreshBtn.Location = New System.Drawing.Point(296, 349)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(34, 34)
        Me.RefreshBtn.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.RefreshBtn, "Refresh the app list")
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.DebugBox)
        Me.Tab2.Location = New System.Drawing.Point(4, 25)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Size = New System.Drawing.Size(529, 384)
        Me.Tab2.TabIndex = 2
        Me.Tab2.Text = "Console"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'DebugBox
        '
        Me.DebugBox.Location = New System.Drawing.Point(0, 0)
        Me.DebugBox.Name = "DebugBox"
        Me.DebugBox.ReadOnly = True
        Me.DebugBox.Size = New System.Drawing.Size(533, 388)
        Me.DebugBox.TabIndex = 0
        Me.DebugBox.Text = ""
        '
        'Tab3
        '
        Me.Tab3.Controls.Add(Me.RichTextBox1)
        Me.Tab3.Location = New System.Drawing.Point(4, 25)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Size = New System.Drawing.Size(529, 384)
        Me.Tab3.TabIndex = 3
        Me.Tab3.Text = "About"
        Me.Tab3.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(-4, 2)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(533, 395)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 413)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HomeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Win10Clean"
        Me.TabControl1.ResumeLayout(False)
        Me.HomeTab.ResumeLayout(False)
        Me.HomeTab.PerformLayout()
        Me.MeteroTab.ResumeLayout(False)
        Me.MeteroTab.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        Me.Tab3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents HomeTab As TabPage
    Friend WithEvents MeteroTab As TabPage
    Friend WithEvents Tab2 As TabPage
    Friend WithEvents Tab3 As TabPage
    Friend WithEvents AdsBtn As Button
    Friend WithEvents GameDVRBtn As Button
    Friend WithEvents HomeGroupBtn As Button
    Friend WithEvents DefenderBtn As Button
    Friend WithEvents OneDriveBtn As Button
    Friend WithEvents Revert7Btn As Button
    Friend WithEvents UninstallBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents AppBox As ListBox
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents VerLabel As Label
    Friend WithEvents CheckUpdatesBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DebugBox As RichTextBox
End Class