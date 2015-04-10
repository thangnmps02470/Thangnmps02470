Public Class frmThongtin

    Private Sub frmThongtin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub msiTrolai_Click_1(sender As Object, e As EventArgs) Handles msiTrolai.Click
        frmMenu.Show() 'trở lại
        Me.Close()
    End Sub

    Private Sub msiThoat_Click_1(sender As Object, e As EventArgs) Handles msiThoat.Click
        Application.Exit() 'thoát
    End Sub
End Class