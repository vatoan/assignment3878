Imports System.Data.SqlClient

Public Class FmTheLoai
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QL-SACH.mssql.somee.com;packet size=4096;user id=vantoan1996_SQLLogin_1;pwd=m2zj7kx1to;data source=QL-SACH.mssql.somee.com;persist security info=False;initial catalog=QL-SACH"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into THELOAI values(@MATL,@TEN)"
        Dim save As SqlCommand = New SqlCommand(query, theloai)
        theloai.Open()
        Try
            txtmatl.Focus()
            If txtmatl.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmatl.Focus()
                If txttentl.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    save.Parameters.AddWithValue("@MATL", txtmatl.Text)
                    save.Parameters.AddWithValue("@TEN", txttentl.Text)
                    save.ExecuteNonQuery()
                    MessageBox.Show("Lưu thành công")
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                    txtmatl.Text = Nothing
                    txttentl.Text = Nothing

                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã thể loại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MATL as 'Mã TL', TEN as 'Tên TL' from THELOAI", theloai)
        db.Clear()
        refesh.Fill(db)
        dgvtheloai.DataSource = db.DefaultView
    End Sub

    Private Sub bttimkiem_Click(sender As Object, e As EventArgs) Handles bttimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MATL as 'Mã TL', TEN as 'Tên TL'FROM THELOAI where MATL= '" & txtmatl.Text & "'", connect)
        Try
            If txtmatl.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã the loai", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvtheloai.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtheloai.DataSource = db.DefaultView
                    txtmatl.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtmatl.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btLoad_Click(sender As Object, e As EventArgs) Handles btLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim theloai As SqlDataAdapter = New SqlDataAdapter("select MATL as 'Mã TL', TEN as 'Tên TL' from THELOAI", connect)
        Try
            db.Clear()
            dgvtheloai.DataSource = Nothing
            theloai.Fill(db)
            If db.Rows.Count > 0 Then
                dgvtheloai.DataSource = db.DefaultView
                txtmatl.Text = Nothing
            Else
                MessageBox.Show("Không tìm được")
                txtmatl.Text = Nothing
            End If

            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        If txtmatl.Text = "" Then
            MessageBox.Show("Nhap MaTL cần xóa")
            txtmatl.Focus()
        Else
            Dim delquery As String = "delete from THELOAI where MaTL=@MATL"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult
            resulft = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MATL", txtmatl.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub
    Private Sub LoadData()
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        theloai.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MATL as 'Mã TL' ,TEN as 'Tên TL' from THELOAI", theloai)
        db.Clear()
        load.Fill(db)
        dgvtheloai.DataSource = db.DefaultView
        theloai.Close()
    End Sub

    Private Sub dgvtheloai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtheloai.CellContentClick
        Dim click As Integer = dgvtheloai.CurrentCell.RowIndex
        txtmatl.Text = dgvtheloai.Item(0, click).Value
        txttentl.Text = dgvtheloai.Item(1, click).Value
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        If btcapnhat.Text = "Sửa" Then
            txtmatl.ReadOnly = True
            btcapnhat.Text = "Update"
            txttentl.Focus()
        ElseIf btcapnhat.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update THELOAI set MATL=@MATL, TEN=@TEN where MATL=@MATL"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MATL", txtmatl.Text)
            save.Parameters.AddWithValue("@TEN", txttentl.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtmatl.ReadOnly = False
            btcapnhat.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub FmTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class