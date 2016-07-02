<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmMenu))
        Me.BtKhachHang = New System.Windows.Forms.Button()
        Me.BtTheLoai = New System.Windows.Forms.Button()
        Me.BtTimKiem = New System.Windows.Forms.Button()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtKhachHang
        '
        Me.BtKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtKhachHang.ForeColor = System.Drawing.Color.Black
        Me.BtKhachHang.Image = CType(resources.GetObject("BtKhachHang.Image"), System.Drawing.Image)
        Me.BtKhachHang.Location = New System.Drawing.Point(42, 39)
        Me.BtKhachHang.Name = "BtKhachHang"
        Me.BtKhachHang.Size = New System.Drawing.Size(130, 78)
        Me.BtKhachHang.TabIndex = 0
        Me.BtKhachHang.Text = "Khách Hàng"
        Me.BtKhachHang.UseVisualStyleBackColor = True
        '
        'BtTheLoai
        '
        Me.BtTheLoai.BackColor = System.Drawing.Color.Gold
        Me.BtTheLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtTheLoai.ForeColor = System.Drawing.Color.Black
        Me.BtTheLoai.Location = New System.Drawing.Point(235, 39)
        Me.BtTheLoai.Name = "BtTheLoai"
        Me.BtTheLoai.Size = New System.Drawing.Size(130, 78)
        Me.BtTheLoai.TabIndex = 1
        Me.BtTheLoai.Text = "Thể Loại"
        Me.BtTheLoai.UseVisualStyleBackColor = False
        '
        'BtTimKiem
        '
        Me.BtTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtTimKiem.Image = CType(resources.GetObject("BtTimKiem.Image"), System.Drawing.Image)
        Me.BtTimKiem.Location = New System.Drawing.Point(42, 149)
        Me.BtTimKiem.Name = "BtTimKiem"
        Me.BtTimKiem.Size = New System.Drawing.Size(130, 78)
        Me.BtTimKiem.TabIndex = 2
        Me.BtTimKiem.Text = "Tìm Kiếm"
        Me.BtTimKiem.UseVisualStyleBackColor = True
        '
        'BtClose
        '
        Me.BtClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtClose.Image = CType(resources.GetObject("BtClose.Image"), System.Drawing.Image)
        Me.BtClose.Location = New System.Drawing.Point(235, 149)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(130, 78)
        Me.BtClose.TabIndex = 3
        Me.BtClose.Text = "Đóng"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'FmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(403, 276)
        Me.Controls.Add(Me.BtClose)
        Me.Controls.Add(Me.BtTimKiem)
        Me.Controls.Add(Me.BtTheLoai)
        Me.Controls.Add(Me.BtKhachHang)
        Me.Name = "FmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtKhachHang As System.Windows.Forms.Button
    Friend WithEvents BtTheLoai As System.Windows.Forms.Button
    Friend WithEvents BtTimKiem As System.Windows.Forms.Button
    Friend WithEvents BtClose As System.Windows.Forms.Button

End Class
