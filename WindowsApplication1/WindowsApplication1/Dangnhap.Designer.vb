<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangnhap
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.lblMatkhau = New System.Windows.Forms.Label()
        Me.lblTaikhoan = New System.Windows.Forms.Label()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.txtTaikhoan = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnThoat)
        Me.GroupBox1.Controls.Add(Me.btnDangnhap)
        Me.GroupBox1.Controls.Add(Me.lblMatkhau)
        Me.GroupBox1.Controls.Add(Me.lblTaikhoan)
        Me.GroupBox1.Controls.Add(Me.txtMatkhau)
        Me.GroupBox1.Controls.Add(Me.txtTaikhoan)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đăng nhâp"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.S
        Me.PictureBox1.Location = New System.Drawing.Point(14, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnThoat
        '
        Me.btnThoat.ForeColor = System.Drawing.Color.Blue
        Me.btnThoat.Location = New System.Drawing.Point(270, 145)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(92, 28)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnDangnhap
        '
        Me.btnDangnhap.ForeColor = System.Drawing.Color.Blue
        Me.btnDangnhap.Location = New System.Drawing.Point(148, 145)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(92, 28)
        Me.btnDangnhap.TabIndex = 3
        Me.btnDangnhap.Text = "Đăng nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'lblMatkhau
        '
        Me.lblMatkhau.AutoSize = True
        Me.lblMatkhau.ForeColor = System.Drawing.Color.Red
        Me.lblMatkhau.Location = New System.Drawing.Point(33, 88)
        Me.lblMatkhau.Name = "lblMatkhau"
        Me.lblMatkhau.Size = New System.Drawing.Size(70, 16)
        Me.lblMatkhau.TabIndex = 10
        Me.lblMatkhau.Text = "Mật khẩu"
        '
        'lblTaikhoan
        '
        Me.lblTaikhoan.AutoSize = True
        Me.lblTaikhoan.ForeColor = System.Drawing.Color.Red
        Me.lblTaikhoan.Location = New System.Drawing.Point(26, 46)
        Me.lblTaikhoan.Name = "lblTaikhoan"
        Me.lblTaikhoan.Size = New System.Drawing.Size(77, 16)
        Me.lblTaikhoan.TabIndex = 10
        Me.lblTaikhoan.Text = "Tài khoản"
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatkhau.Location = New System.Drawing.Point(148, 88)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.Size = New System.Drawing.Size(214, 22)
        Me.txtMatkhau.TabIndex = 2
        '
        'txtTaikhoan
        '
        Me.txtTaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaikhoan.Location = New System.Drawing.Point(148, 43)
        Me.txtTaikhoan.Name = "txtTaikhoan"
        Me.txtTaikhoan.Size = New System.Drawing.Size(214, 22)
        Me.txtTaikhoan.TabIndex = 1
        '
        'frmDangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(404, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnDangnhap As System.Windows.Forms.Button
    Friend WithEvents lblMatkhau As System.Windows.Forms.Label
    Friend WithEvents lblTaikhoan As System.Windows.Forms.Label
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTaikhoan As System.Windows.Forms.TextBox

End Class
