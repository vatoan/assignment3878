<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmTimKiem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmTimKiem))
        Me.btnDong = New System.Windows.Forms.Button()
        Me.dgvXem = New System.Windows.Forms.DataGridView()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnTen = New System.Windows.Forms.Button()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaSach = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvXem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.Image = CType(resources.GetObject("btnDong.Image"), System.Drawing.Image)
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(433, 51)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(106, 33)
        Me.btnDong.TabIndex = 13
        Me.btnDong.Text = "Đóng"
        Me.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'dgvXem
        '
        Me.dgvXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXem.Location = New System.Drawing.Point(8, 109)
        Me.dgvXem.Name = "dgvXem"
        Me.dgvXem.Size = New System.Drawing.Size(531, 209)
        Me.dgvXem.TabIndex = 12
        '
        'btnXemall
        '
        Me.btnXemall.Image = CType(resources.GetObject("btnXemall.Image"), System.Drawing.Image)
        Me.btnXemall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXemall.Location = New System.Drawing.Point(433, 12)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(106, 33)
        Me.btnXemall.TabIndex = 9
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXemall.UseVisualStyleBackColor = True
        '
        'btnTen
        '
        Me.btnTen.Image = CType(resources.GetObject("btnTen.Image"), System.Drawing.Image)
        Me.btnTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTen.Location = New System.Drawing.Point(306, 51)
        Me.btnTen.Name = "btnTen"
        Me.btnTen.Size = New System.Drawing.Size(100, 33)
        Me.btnTen.TabIndex = 10
        Me.btnTen.Text = "Tim TenSach"
        Me.btnTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTen.UseVisualStyleBackColor = True
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(107, 62)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(160, 20)
        Me.txtTen.TabIndex = 7
        '
        'btnXem
        '
        Me.btnXem.Image = CType(resources.GetObject("btnXem.Image"), System.Drawing.Image)
        Me.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXem.Location = New System.Drawing.Point(306, 12)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(100, 33)
        Me.btnXem.TabIndex = 11
        Me.btnXem.Text = "Tim MaSach"
        Me.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tên Sách:"
        '
        'txtMaSach
        '
        Me.txtMaSach.Location = New System.Drawing.Point(107, 23)
        Me.txtMaSach.Name = "txtMaSach"
        Me.txtMaSach.Size = New System.Drawing.Size(160, 20)
        Me.txtMaSach.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã Sách:"
        '
        'FmTimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(549, 325)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.dgvXem)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnTen)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaSach)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FmTimKiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FmTimKiem"
        CType(Me.dgvXem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents dgvXem As System.Windows.Forms.DataGridView
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnTen As System.Windows.Forms.Button
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaSach As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
