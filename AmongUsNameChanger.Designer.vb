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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpDate = New System.Windows.Forms.GroupBox()
        Me.dateSelector = New System.Windows.Forms.MonthCalendar()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblSettingsFolderLbl = New System.Windows.Forms.Label()
        Me.lblSettingsFileLbl = New System.Windows.Forms.Label()
        Me.lblSettingsFolder = New System.Windows.Forms.Label()
        Me.lblSettingsFile = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpName.SuspendLayout()
        Me.grpDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpName
        '
        Me.grpName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpName.Controls.Add(Me.txtName)
        Me.grpName.Enabled = False
        Me.grpName.Location = New System.Drawing.Point(12, 45)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(251, 45)
        Me.grpName.TabIndex = 4
        Me.grpName.TabStop = False
        Me.grpName.Text = "Name"
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
        'grpDate
        '
        Me.grpDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDate.Controls.Add(Me.dateSelector)
        Me.grpDate.Enabled = False
        Me.grpDate.Location = New System.Drawing.Point(12, 96)
        Me.grpDate.Name = "grpDate"
        Me.grpDate.Size = New System.Drawing.Size(251, 199)
        Me.grpDate.TabIndex = 5
        Me.grpDate.TabStop = False
        Me.grpDate.Text = "Birth Date"
        '
        'dateSelector
        '
        Me.dateSelector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateSelector.Location = New System.Drawing.Point(12, 25)
        Me.dateSelector.MaxSelectionCount = 1
        Me.dateSelector.Name = "dateSelector"
        Me.dateSelector.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(12, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(141, 301)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblSettingsFolderLbl
        '
        Me.lblSettingsFolderLbl.AutoSize = True
        Me.lblSettingsFolderLbl.Location = New System.Drawing.Point(12, 9)
        Me.lblSettingsFolderLbl.Name = "lblSettingsFolderLbl"
        Me.lblSettingsFolderLbl.Size = New System.Drawing.Size(132, 13)
        Me.lblSettingsFolderLbl.TabIndex = 0
        Me.lblSettingsFolderLbl.Text = "Among Us Settings Folder:"
        Me.lblSettingsFolderLbl.UseMnemonic = False
        '
        'lblSettingsFileLbl
        '
        Me.lblSettingsFileLbl.AutoSize = True
        Me.lblSettingsFileLbl.Location = New System.Drawing.Point(12, 22)
        Me.lblSettingsFileLbl.Name = "lblSettingsFileLbl"
        Me.lblSettingsFileLbl.Size = New System.Drawing.Size(119, 13)
        Me.lblSettingsFileLbl.TabIndex = 1
        Me.lblSettingsFileLbl.Text = "Among Us Settings File:"
        Me.lblSettingsFileLbl.UseMnemonic = False
        '
        'lblSettingsFolder
        '
        Me.lblSettingsFolder.AutoSize = True
        Me.lblSettingsFolder.Location = New System.Drawing.Point(150, 9)
        Me.lblSettingsFolder.Name = "lblSettingsFolder"
        Me.lblSettingsFolder.Size = New System.Drawing.Size(54, 13)
        Me.lblSettingsFolder.TabIndex = 2
        Me.lblSettingsFolder.Text = "Loading..."
        Me.lblSettingsFolder.UseMnemonic = False
        '
        'lblSettingsFile
        '
        Me.lblSettingsFile.AutoSize = True
        Me.lblSettingsFile.Location = New System.Drawing.Point(150, 22)
        Me.lblSettingsFile.Name = "lblSettingsFile"
        Me.lblSettingsFile.Size = New System.Drawing.Size(54, 13)
        Me.lblSettingsFile.TabIndex = 3
        Me.lblSettingsFile.Text = "Loading..."
        Me.lblSettingsFile.UseMnemonic = False
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(244, 325)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(30, 9)
        Me.lblVersion.TabIndex = 8
        Me.lblVersion.Text = "v0.0.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AmongUsNameChanger
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(275, 336)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblSettingsFile)
        Me.Controls.Add(Me.lblSettingsFolder)
        Me.Controls.Add(Me.lblSettingsFileLbl)
        Me.Controls.Add(Me.lblSettingsFolderLbl)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpDate)
        Me.Controls.Add(Me.grpName)
        Me.Name = "AmongUsNameChanger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Among Us Name Changer"
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.grpDate.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpName As System.Windows.Forms.GroupBox
    Friend WithEvents grpDate As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents dateSelector As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblSettingsFolderLbl As System.Windows.Forms.Label
    Friend WithEvents lblSettingsFileLbl As System.Windows.Forms.Label
    Friend WithEvents lblSettingsFolder As System.Windows.Forms.Label
    Friend WithEvents lblSettingsFile As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
End Class
