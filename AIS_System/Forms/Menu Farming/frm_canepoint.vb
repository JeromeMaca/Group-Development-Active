Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class Frm_canepoint

    Private Sub Frm_canepoint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
    End Sub
    Private Sub Frm_canepoint_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("Closing form will lose unsaved data.", vbOKCancel + vbExclamation, "Warning!") <> vbOK Then
                e.Cancel = True
            End If
        End If
    End Sub

End Class
