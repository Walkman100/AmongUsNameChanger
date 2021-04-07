Imports System
Imports System.Windows.Forms

Public Class AmongUsNameChanger
    Private Sub AmongUsNameChanger_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        dateSelector.MaxDate = Date.Today
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        e.Handled = (e.KeyChar = ","c)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub
End Class
