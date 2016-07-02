<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmKhachHang))
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.Label()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.tsdt = New System.Windows.Forms.Label()
        Me.diachi = New System.Windows.Forms.Label()
        Me.hoten = New System.Windows.Forms.Label()
        Me.makh = New System.Windows.Forms.Label()
        Me.dgvkhachhang = New System.Windows.Forms.DataGridView()
        Me.btload = New System.Windows.Forms.Button()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(140, 94)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(232, 20)
        Me.txtmail.TabIndex = 39
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Location = New System.Drawing.Point(105, 97)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(29, 13)
        Me.mail.TabIndex = 38
        Me.mail.Text = "Mail:"
        '
        'btxoa
        '
        Me.btxoa.Image = CType(resources.GetObject("btxoa.Image"), System.Drawing.Image)
        Me.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxoa.Location = New System.Drawing.Point(389, 130)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(77, 35)
        Me.btxoa.TabIndex = 37
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'btcapnhat
        '
        Me.btcapnhat.Image = CType(resources.GetObject("btcapnhat.Image"), System.Drawing.Image)
        Me.btcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btcapnhat.Location = New System.Drawing.Point(259, 130)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(85, 35)
        Me.btcapnhat.TabIndex = 36
        Me.btcapnhat.Text = "Cập nhật"
        Me.btcapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Image = CType(resources.GetObject("btthem.Image"), System.Drawing.Image)
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btthem.Location = New System.Drawing.Point(140, 130)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(77, 35)
        Me.btthem.TabIndex = 35
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = True
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(364, 52)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(100, 20)
        Me.txtsdt.TabIndex = 31
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(97, 52)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(140, 20)
        Me.txtdiachi.TabIndex = 32
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(364, 8)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(100, 20)
        Me.txthoten.TabIndex = 33
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(97, 8)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(86, 20)
        Me.txtmakh.TabIndex = 34
        '
        'tsdt
        '
        Me.tsdt.AutoSize = True
        Me.tsdt.BackColor = System.Drawing.Color.Transparent
        Me.tsdt.Location = New System.Drawing.Point(271, 57)
        Me.tsdt.Name = "tsdt"
        Me.tsdt.Size = New System.Drawing.Size(73, 13)
        Me.tsdt.TabIndex = 30
        Me.tsdt.Text = "Số điện thoại:"
        '
        'diachi
        '
        Me.diachi.AutoSize = True
        Me.diachi.BackColor = System.Drawing.Color.Transparent
        Me.diachi.Location = New System.Drawing.Point(12, 55)
        Me.diachi.Name = "diachi"
        Me.diachi.Size = New System.Drawing.Size(43, 13)
        Me.diachi.TabIndex = 29
        Me.diachi.Text = "Địa chỉ:"
        '
        'hoten
        '
        Me.hoten.AutoSize = True
        Me.hoten.BackColor = System.Drawing.Color.Transparent
        Me.hoten.Location = New System.Drawing.Point(273, 11)
        Me.hoten.Name = "hoten"
        Me.hoten.Size = New System.Drawing.Size(42, 13)
        Me.hoten.TabIndex = 28
        Me.hoten.Text = "Họ tên:"
        '
        'makh
        '
        Me.makh.AutoSize = True
        Me.makh.BackColor = System.Drawing.Color.Transparent
        Me.makh.Location = New System.Drawing.Point(12, 11)
        Me.makh.Name = "makh"
        Me.makh.Size = New System.Drawing.Size(85, 13)
        Me.makh.TabIndex = 27
        Me.makh.Text = "Mã khách hàng:"
        '
        'dgvkhachhang
        '
        Me.dgvkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhachhang.Location = New System.Drawing.Point(12, 188)
        Me.dgvkhachhang.Name = "dgvkhachhang"
        Me.dgvkhachhang.Size = New System.Drawing.Size(452, 152)
        Me.dgvkhachhang.TabIndex = 26
        '
        'btload
        '
        Me.btload.Image = CType(resources.GetObject("btload.Image"), System.Drawing.Image)
        Me.btload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btload.Location = New System.Drawing.Point(12, 130)
        Me.btload.Name = "btload"
        Me.btload.Size = New System.Drawing.Size(77, 35)
        Me.btload.TabIndex = 25
        Me.btload.Text = "Load"
        Me.btload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btload.UseVisualStyleBackColor = True
        '
        'FmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(478, 346)
        Me.Controls.Add(Me.txtmail)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.tsdt)
        Me.Controls.Add(Me.diachi)
        Me.Controls.Add(Me.hoten)
        Me.Controls.Add(Me.makh)
        Me.Controls.Add(Me.dgvkhachhang)
        Me.Controls.Add(Me.btload)
        Me.Name = "FmKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FmKhachHang"
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents mail As System.Windows.Forms.Label
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents btcapnhat As System.Windows.Forms.Button
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents tsdt As System.Windows.Forms.Label
    Friend WithEvents diachi As System.Windows.Forms.Label
    Friend WithEvents hoten As System.Windows.Forms.Label
    Friend WithEvents makh As System.Windows.Forms.Label
    Friend WithEvents dgvkhachhang As System.Windows.Forms.DataGridView
    Friend WithEvents btload As System.Windows.Forms.Button
End Class
