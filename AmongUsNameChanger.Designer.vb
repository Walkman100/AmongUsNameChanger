<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AmongUsNameChanger
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
        Me.grpName = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSettingsFolderLbl = New System.Windows.Forms.Label()
        Me.lblSettingsFileLbl = New System.Windows.Forms.Label()
        Me.lblSettingsFolder = New System.Windows.Forms.Label()
        Me.lblSettingsFile = New System.Windows.Forms.Label()
        Me.grpName.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpName
        '
        Me.grpName.Controls.Add(Me.txtName)
        Me.grpName.Enabled = False
        Me.grpName.Location = New System.Drawing.Point(12, 45)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(251, 45)
        Me.grpName.TabIndex = 0
        Me.grpName.TabStop = False
        Me.grpName.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 199)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Birth Date"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(6, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(239, 20)
        Me.txtName.TabIndex = 0
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 25)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(12, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(141, 301)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSettingsFolderLbl
        '
        Me.lblSettingsFolderLbl.AutoSize = True
        Me.lblSettingsFolderLbl.Location = New System.Drawing.Point(12, 9)
        Me.lblSettingsFolderLbl.Name = "lblSettingsFolderLbl"
        Me.lblSettingsFolderLbl.Size = New System.Drawing.Size(132, 13)
        Me.lblSettingsFolderLbl.TabIndex = 3
        Me.lblSettingsFolderLbl.Text = "Among Us Settings Folder:"
        '
        'lblSettingsFileLbl
        '
        Me.lblSettingsFileLbl.AutoSize = True
        Me.lblSettingsFileLbl.Location = New System.Drawing.Point(12, 22)
        Me.lblSettingsFileLbl.Name = "lblSettingsFileLbl"
        Me.lblSettingsFileLbl.Size = New System.Drawing.Size(119, 13)
        Me.lblSettingsFileLbl.TabIndex = 4
        Me.lblSettingsFileLbl.Text = "Among Us Settings File:"
        '
        'lblSettingsFolder
        '
        Me.lblSettingsFolder.AutoSize = True
        Me.lblSettingsFolder.Location = New System.Drawing.Point(150, 9)
        Me.lblSettingsFolder.Name = "lblSettingsFolder"
        Me.lblSettingsFolder.Size = New System.Drawing.Size(54, 13)
        Me.lblSettingsFolder.TabIndex = 5
        Me.lblSettingsFolder.Text = "Loading..."
        '
        'lblSettingsFile
        '
        Me.lblSettingsFile.AutoSize = True
        Me.lblSettingsFile.Location = New System.Drawing.Point(150, 22)
        Me.lblSettingsFile.Name = "lblSettingsFile"
        Me.lblSettingsFile.Size = New System.Drawing.Size(54, 13)
        Me.lblSettingsFile.TabIndex = 6
        Me.lblSettingsFile.Text = "Loading..."
        '
        'AmongUsNameChanger
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(275, 336)
        Me.Controls.Add(Me.lblSettingsFile)
        Me.Controls.Add(Me.lblSettingsFolder)
        Me.Controls.Add(Me.lblSettingsFileLbl)
        Me.Controls.Add(Me.lblSettingsFolderLbl)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpName)
        Me.Name = "AmongUsNameChanger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Among Us Name Changer"
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpName As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblSettingsFolderLbl As System.Windows.Forms.Label
    Friend WithEvents lblSettingsFileLbl As System.Windows.Forms.Label
    Friend WithEvents lblSettingsFolder As System.Windows.Forms.Label
    Friend WithEvents lblSettingsFile As System.Windows.Forms.Label
End Class
