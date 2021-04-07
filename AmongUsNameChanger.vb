Imports System
Imports System.IO
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class AmongUsNameChanger
    Private settingsFolder As String
    Private settingsFile As String

    Private Async Sub AmongUsNameChanger_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dateSelector.MaxDate = Date.Today

        settingsFolder = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "AppData", "LocalLow", "Innersloth", "Among Us")
        settingsFile = Path.Combine(settingsFolder, "playerPrefs")

        If Directory.Exists(settingsFolder) Then
            lblSettingsFolder.Text = "Found"
        Else
            lblSettingsFolder.Text = "Not Found!"
            lblSettingsFile.Text = "Folder not found!"
            MessageBox.Show("Could not find settings folder! Ensure the game has been ran at least once, " &
                            "then please run a search for a folder called Innersloth, and report an issue to the GitHub Repo",
                            "Error finding settings folder", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If File.Exists(settingsFile) Then
            lblSettingsFile.Text = "Found. Reading..."
        Else
            lblSettingsFile.Text = "Not Found!"
            MessageBox.Show("Found the settings folder, but not the file! Please launch the game first to create the file",
                            "Error finding settings file", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Await LoadSettings(settingsFile)
            lblSettingsFile.Text = "Found & Loaded"
            grpName.Enabled = True
            grpDate.Enabled = True
        Catch ex As Exception
            lblSettingsFile.Text = "Found! Error loading!"
            MessageBox.Show(ex.Message, "Error loading file", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function LoadSettings(filePath As String) As Task
        ' we only care about the first line
        Dim line As String
        Using reader As StreamReader = File.OpenText(filePath)
            line = Await reader.ReadLineAsync()
        End Using

        Dim arr As String() = line.Split(","c)
        If arr.Length < 26 Then Throw New InvalidDataException("Settings file corrupt or old game version!")

        txtName.Text = arr(0)

        Dim birthDay As Integer = Integer.Parse(arr(24))
        Dim birthMonth As Integer = Integer.Parse(arr(23))
        Dim birthYear As Integer = Integer.Parse(arr(25))

        dateSelector.SetDate(New Date(birthYear, birthMonth, birthDay))
    End Function

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        e.Handled = (e.KeyChar = ","c)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
