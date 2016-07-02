Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class FmKhachHang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QL-SACH.mssql.somee.com;packet size=4096;user id=vantoan1996_SQLLogin_1;pwd=m2zj7kx1to;data source=QL-SACH.mssql.somee.com;persist security info=False;initial catalog=QL-SACH"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub FmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã Khách Hàng' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa Chỉ', SDT as 'SDT', MAIL as 'Mail' from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
        conn.Close()
    End Sub

    'Private Sub reset()
    'txtmakh.Text = ""
    ' txthoten.Text = ""
    ' txtdiachi.Text = ""
    ' txtsdt.Text = ""
    'txtmail.Text = ""
    'txtmakh.Focus()
    ' End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim khachhang As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MAKH,@TENKH,@DIACHI,@SDT,@MAIL)"
        Dim save As SqlCommand = New SqlCommand(query, khachhang)
        khachhang.Open()
        Try
            txtmakh.Focus()
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã KH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txthoten.Focus()
                If txthoten.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtdiachi.Focus()
                    If txtdiachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập dia chi", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtsdt.Focus()
                        If txtsdt.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập sdt", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtmail.Focus()
                            If txtmail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập mail", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MAKH", txtmakh.Text)
                                save.Parameters.AddWithValue("@TENKH", txthoten.Text)
                                save.Parameters.AddWithValue("@DIACHI", txtdiachi.Text)
                                save.Parameters.AddWithValue("@SDT", txtsdt.Text)
                                save.Parameters.AddWithValue("@MAIL", txtmail.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtmakh.Text = Nothing
                                txthoten.Text = Nothing
                                txtdiachi.Text = Nothing
                                txtsdt.Text = Nothing
                                txtmail.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

          
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khach hang", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã Khách Hàng' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa Chỉ', SDT as 'SDT', MAIL as 'Mail' from KHACHHANG ", khachhang)
        db.Clear()
        refesh.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        If btcapnhat.Text = "Sửa" Then
            txtmakh.ReadOnly = True
            btcapnhat.Text = "Update"
            txthoten.Focus()
        ElseIf btcapnhat.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT, MAIL=@MAIL where MAKH=@MAKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtmakh.Text)
            save.Parameters.AddWithValue("@TENKH", txthoten.Text)
            save.Parameters.AddWithValue("@DIACHI", txtdiachi.Text)
            save.Parameters.AddWithValue("@SDT", txtsdt.Text)
            save.Parameters.AddWithValue("@MAIL", txtmail.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtmakh.ReadOnly = False
            btcapnhat.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        If txtmakh.Text = "" Then
            MessageBox.Show("Nhap MAKH cần xóa")
            txtmakh.Focus()
        Else
            Dim delquery As String = "delete from KHACHHANG inner join HOADON on KHACHHANG.MAKH = HOADON.MAKH where KHACHHANG.MAKH=@KHACHHANG.MAKH "
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult
            resulft = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", txtmakh.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btload_Click(sender As Object, e As EventArgs) Handles btload.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim khachhang As SqlDataAdapter = New SqlDataAdapter("select MAKH as 'Mã Khách Hàng' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa Chỉ', SDT as 'SDT', MAIL as 'Mail' from KHACHHANG", connect)
        Try
            db.Clear()
            dgvkhachhang.DataSource = Nothing
            khachhang.Fill(db)
            If db.Rows.Count > 0 Then
                dgvkhachhang.DataSource = db.DefaultView
                txtmakh.Text = Nothing
            Else
                MessageBox.Show("Không tìm được")
                txtmakh.Text = Nothing
            End If

            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick
        Dim click As Integer = dgvkhachhang.CurrentCell.RowIndex
        txtmakh.Text = dgvkhachhang.Item(0, click).Value
        txthoten.Text = dgvkhachhang.Item(1, click).Value
        txtdiachi.Text = dgvkhachhang.Item(2, click).Value
        txtsdt.Text = dgvkhachhang.Item(3, click).Value
        txtmail.Text = dgvkhachhang.Item(4, click).Value
    End Sub
End Class