<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmTheLoai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmTheLoai))
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.bttimkiem = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.dgvtheloai = New System.Windows.Forms.DataGridView()
        Me.txttentl = New System.Windows.Forms.TextBox()
        Me.txtmatl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btLoad = New System.Windows.Forms.Button()
        CType(Me.dgvtheloai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcapnhat
        '
        Me.btcapnhat.Image = CType(resources.GetObject("btcapnhat.Image"), System.Drawing.Image)
        Me.btcapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btcapnhat.Location = New System.Drawing.Point(481, 53)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(129, 33)
        Me.btcapnhat.TabIndex = 18
        Me.btcapnhat.Text = "Cập nhật"
        Me.btcapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'btxoa
        '
        Me.btxoa.Image = CType(resources.GetObject("btxoa.Image"), System.Drawing.Image)
        Me.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxoa.Location = New System.Drawing.Point(331, 53)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(129, 33)
        Me.btxoa.TabIndex = 19
        Me.btxoa.Text = "Xóa"
        Me.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'bttimkiem
        '
        Me.bttimkiem.Image = CType(resources.GetObject("bttimkiem.Image"), System.Drawing.Image)
        Me.bttimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttimkiem.Location = New System.Drawing.Point(331, 10)
        Me.bttimkiem.Name = "bttimkiem"
        Me.bttimkiem.Size = New System.Drawing.Size(129, 33)
        Me.bttimkiem.TabIndex = 20
        Me.bttimkiem.Text = "Tìm kiếm"
        Me.bttimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttimkiem.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Image = CType(resources.GetObject("btthem.Image"), System.Drawing.Image)
        Me.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btthem.Location = New System.Drawing.Point(481, 10)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(129, 33)
        Me.btthem.TabIndex = 21
        Me.btthem.Text = "Thêm"
        Me.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btthem.UseVisualStyleBackColor = True
        '
        'dgvtheloai
        '
        Me.dgvtheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtheloai.Location = New System.Drawing.Point(37, 102)
        Me.dgvtheloai.Name = "dgvtheloai"
        Me.dgvtheloai.Size = New System.Drawing.Size(512, 150)
        Me.dgvtheloai.TabIndex = 17
        '
        'txttentl
        '
        Me.txttentl.Location = New System.Drawing.Point(112, 55)
        Me.txttentl.Name = "txttentl"
        Me.txttentl.Size = New System.Drawing.Size(201, 20)
        Me.txttentl.TabIndex = 15
        '
        'txtmatl
        '
        Me.txtmatl.Location = New System.Drawing.Point(112, 12)
        Me.txtmatl.Name = "txtmatl"
        Me.txtmatl.Size = New System.Drawing.Size(201, 20)
        Me.txtmatl.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(14, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tên thể loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Mã thể loại:"
        '
        'btLoad
        '
        Me.btLoad.Image = CType(resources.GetObject("btLoad.Image"), System.Drawing.Image)
        Me.btLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btLoad.Location = New System.Drawing.Point(556, 154)
        Me.btLoad.Name = "btLoad"
        Me.btLoad.Size = New System.Drawing.Size(103, 34)
        Me.btLoad.TabIndex = 22
        Me.btLoad.Text = "Load"
        Me.btLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btLoad.UseVisualStyleBackColor = True
        '
        'FmTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(681, 264)
        Me.Controls.Add(Me.btLoad)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.bttimkiem)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.dgvtheloai)
        Me.Controls.Add(Me.txttentl)
        Me.Controls.Add(Me.txtmatl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "FmTheLoai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FmTheLoai"
        CType(Me.dgvtheloai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btcapnhat As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents bttimkiem As System.Windows.Forms.Button
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents dgvtheloai As System.Windows.Forms.DataGridView
    Friend WithEvents txttentl As System.Windows.Forms.TextBox
    Friend WithEvents txtmatl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btLoad As System.Windows.Forms.Button
End Class
