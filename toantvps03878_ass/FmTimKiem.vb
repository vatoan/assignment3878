Imports System.Data.SqlClient

Public Class FmTimKiem
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QL-SACH.mssql.somee.com;packet size=4096;user id=vantoan1996_SQLLogin_1;pwd=m2zj7kx1to;data source=QL-SACH.mssql.somee.com;persist security info=False;initial catalog=QL-SACH"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã Sách' ,MATL as 'Mã Thể Loại', TENSACH as 'Tên Sách', TACGIA as 'Tác Giả', NGAYPH as 'Ngày Phát Hành', SOLUONG as 'Số Lượng' from SACH where SACH.MASACH ='" & txtMaSach.Text & "' ", connect)
        Try
            If txtMaSach.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sách", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXem.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXem.DataSource = db.DefaultView
                    txtMaSach.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMaSach.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnTen_Click(sender As Object, e As EventArgs) Handles btnTen.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã Sách' ,MATL as 'Mã Thể Loại', TENSACH as 'Tên Sách', TACGIA as 'Tác Giả', NGAYPH as 'Ngày Phát Hành', SOLUONG as 'Số Lượng' from SACH where SACH.TENSACH like '%" & txtTen.Text & "%' ", connect)
        Try
            If txtTen.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXem.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXem.DataSource = db.DefaultView
                    txtTen.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtTen.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        'Dim hienthi As New Class1
        'dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MASACH as 'Mã Sách' ,MATL as 'Mã Thể Loại', TENSACH as 'Tên Sách', TACGIA as 'Tác Giả', NGAYPH as 'Ngày Phát Hành', SOLUONG as 'Số Lượng' from SACH", connect)
        Try
            db.Clear()
            dgvXem.DataSource = Nothing
            timkiem.Fill(db)
            If db.Rows.Count > 0 Then
                dgvXem.DataSource = db.DefaultView
                txtMaSach.Text = Nothing
            Else
                MessageBox.Show("Không tìm được")
                txtMaSach.Text = Nothing
            End If

            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class