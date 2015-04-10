Imports System.Data.SqlClient

Public Class frmDangnhap

    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        'khai báo đến csdl
        Dim db As String = "workstation id=ps02470.mssql.somee.com;packet size=4096;user id=thangnmps02470_SQLLogin_1;pwd=1d3wdoptqt;data source=ps02470.mssql.somee.com;persist security info=False;initial catalog=ps02470"
        'đặt tên kết nối
        Dim ketnoidb As SqlConnection = New SqlConnection(db)

        Dim lenhsql As New SqlDataAdapter("select * from dang_nhap where tai_khoan='" & txtTaikhoan.Text & "' and mat_khau='" & txtMatkhau.Text & "'", ketnoidb)
        Dim dulieu As New DataTable 'khai báo bảng

        Try
            ketnoidb.Open() 'mở kết nối
            lenhsql.Fill(dulieu) 'đọc lệnh SQL
            If dulieu.Rows.Count > 0 Then 'nếu tài khoản mật khẩu đúng
                frmMenu.Show() 'cho đăng nhập form menu
                txtTaikhoan.Text = "" 'xóa tài khoản hiện tại
                txtMatkhau.Text = "" 'xóa mật khẩu hiện tại
                txtTaikhoan.Focus() 'cho trỏ về tài khoản
                Me.Hide() 'ẩn form
            Else 'còn nếu sai báo lỗi
                MessageBox.Show("Tài khoản hoặc mật khẩu đăng nhập không đúng",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTaikhoan_KeyDown(ByVal sender As Object, _
           ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTaikhoan.KeyDown
        If e.KeyCode = Keys.Enter Then  'nếu nhấn Enter
            txtMatkhau.Focus()         'đưa trỏ về textbox MK
            btnDangnhap.PerformClick()  'goi sự kiện click button đăng nhập
        End If
    End Sub

    Private Sub txtMatkhau_KeyDown(ByVal sender As Object, _
               ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMatkhau.KeyDown
        If e.KeyCode = Keys.Enter Then  'nếu phím nhấn là phím Enter thì
            btnDangnhap.PerformClick()   'goi sự kiện click button đăng nhập
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        Application.Exit()
    End Sub

End Class
