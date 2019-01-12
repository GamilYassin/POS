
Imports System.Configuration
Imports POSLib.POSLibrary.Models


Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test As UserPrivilages

        test = UserPrivilages.Admin

        ' MsgBox(test & "  - " & test.ToString)
        MsgBox(Prompt:=ConfigurationSettings.AppSettings.Item("Source"))

    End Sub
End Class