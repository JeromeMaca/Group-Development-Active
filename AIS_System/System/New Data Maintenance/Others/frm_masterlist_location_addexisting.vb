Public Class Frm_masterlist_location_addexisting
    Private Sub Frm_masterlist_location_addexisting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_masterlist_location_addexisting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        location_masterlist_view.dp_load_location()
    End Sub
End Class
