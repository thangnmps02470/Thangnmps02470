<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mniHethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniQuanly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniSanpham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHoadon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniThongtin = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiChitiet = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.msiDangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMenu
        '
        Me.mnsMenu.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.mnsMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniHethong, Me.mniQuanly, Me.mniThongtin})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnsMenu.Size = New System.Drawing.Size(504, 24)
        Me.mnsMenu.TabIndex = 0
        Me.mnsMenu.Text = "Menu1"
        '
        'mniHethong
        '
        Me.mniHethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiDangxuat, Me.mniThoat})
        Me.mniHethong.Name = "mniHethong"
        Me.mniHethong.Size = New System.Drawing.Size(71, 20)
        Me.mniHethong.Text = "Hệ thống"
        '
        'mniThoat
        '
        Me.mniThoat.Name = "mniThoat"
        Me.mniThoat.Size = New System.Drawing.Size(152, 22)
        Me.mniThoat.Text = "Thoát"
        '
        'mniQuanly
        '
        Me.mniQuanly.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniSanpham, Me.mniHoadon})
        Me.mniQuanly.Name = "mniQuanly"
        Me.mniQuanly.Size = New System.Drawing.Size(60, 20)
        Me.mniQuanly.Text = "Quản lý"
        '
        'mniSanpham
        '
        Me.mniSanpham.Name = "mniSanpham"
        Me.mniSanpham.Size = New System.Drawing.Size(128, 22)
        Me.mniSanpham.Text = "Sản phẩm"
        '
        'mniHoadon
        '
        Me.mniHoadon.Name = "mniHoadon"
        Me.mniHoadon.Size = New System.Drawing.Size(128, 22)
        Me.mniHoadon.Text = "Hóa đơn"
        '
        'mniThongtin
        '
        Me.mniThongtin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiChitiet})
        Me.mniThongtin.Name = "mniThongtin"
        Me.mniThongtin.Size = New System.Drawing.Size(72, 20)
        Me.mniThongtin.Text = "Thông tin"
        '
        'msiChitiet
        '
        Me.msiChitiet.Name = "msiChitiet"
        Me.msiChitiet.Size = New System.Drawing.Size(152, 22)
        Me.msiChitiet.Text = "Chi tiết"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.lanh_dao_gioi_27_11_2014
        Me.PictureBox1.Location = New System.Drawing.Point(1, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 221)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Red
        Me.lblWelcome.Location = New System.Drawing.Point(49, 35)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(423, 57)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome to Database "
        '
        'msiDangxuat
        '
        Me.msiDangxuat.Name = "msiDangxuat"
        Me.msiDangxuat.Size = New System.Drawing.Size(152, 22)
        Me.msiDangxuat.Text = "Đăng xuất"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(504, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mnsMenu)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnsMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mniHethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThoat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniQuanly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniSanpham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniHoadon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniThongtin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents msiChitiet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiDangxuat As System.Windows.Forms.ToolStripMenuItem
End Class
