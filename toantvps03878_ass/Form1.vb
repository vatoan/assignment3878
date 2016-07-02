Public Class FmMenu

    Private Sub BtKhachHang_Click(sender As Object, e As EventArgs) Handles BtKhachHang.Click
        FmKhachHang.ShowDialog()
    End Sub

    Private Sub BtTheLoai_Click(sender As Object, e As EventArgs) Handles BtTheLoai.Click
        FmTheLoai.ShowDialog()
    End Sub

    Private Sub BtTimKiem_Click(sender As Object, e As EventArgs) Handles BtTimKiem.Click
        FmTimKiem.ShowDialog()
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        Me.Close()
    End Sub
End Class
