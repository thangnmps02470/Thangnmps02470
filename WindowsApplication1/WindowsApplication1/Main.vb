Public Class frmMenu

    Private Sub mniThoat_Click(sender As Object, e As EventArgs) Handles mniThoat.Click
        Me.Close()
        Application.Exit() 'Tắt ứng dụng
    End Sub

    Private Sub mniSanpham_Click(sender As Object, e As EventArgs) Handles mniSanpham.Click
        frmSanpham.Show() 'load form Sản phẩm
        Me.Hide() 'Ẩn form main
    End Sub

    Private Sub mniHoadon_Click(sender As Object, e As EventArgs) Handles mniHoadon.Click
        frmHoadon.Show() 'load form Hóa đơn
        Me.Hide() 'Ẩn form main
    End Sub

    Private Sub msiChitiet_Click(sender As Object, e As EventArgs) Handles msiChitiet.Click
        frmThongtin.Show() 'load form Thông tin
        Me.Hide() 'Ẩn form main
    End Sub

    'Xử lý sự kiện đăng xuất sẽ đăng nhập lại form đăng nhập
    Private Sub msiDangxuat_Click(sender As Object, e As EventArgs) Handles msiDangxuat.Click
        Me.Close()
        frmDangnhap.Show()
    End Sub
End Class