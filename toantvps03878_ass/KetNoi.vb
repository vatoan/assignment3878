Imports System.Data.SqlClient

Public Class KetNoi
    Public Function Loadkhachhang() As DataSet
        Dim chuoiketnoi As String = "workstation id=QL-SACH.mssql.somee.com;packet size=4096;user id=vantoan1996_SQLLogin_1;pwd=m2zj7kx1to;data source=QL-SACH.mssql.somee.com;persist security info=False;initial catalog=QL-SACH"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH', TENKH as 'Tên KH', DIACHI as 'Địa Chỉ', SDT as 'SĐT', Mail as 'Mail'", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function


    Public Function Loadtheloai() As DataSet
        Dim chuoiketnoi As String = "workstation id=QL-SACH.mssql.somee.com;packet size=4096;user id=vantoan1996_SQLLogin_1;pwd=m2zj7kx1to;data source=QL-SACH.mssql.somee.com;persist security info=False;initial catalog=QL-SACH"
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadTL As New SqlDataAdapter("select MATL as 'Mã TL', TEN as 'Tên TL'", theloai)
        Dim db As New DataSet
        theloai.Open()
        LoadTL.Fill(db)
        theloai.Close()
        Return db
    End Function


    Public Function Loadtimliem() As DataSet
        Dim chuoiketnoi As String = "workstation id=QL-SACH.mssql.somee.com;packet size=4096;user id=vantoan1996_SQLLogin_1;pwd=m2zj7kx1to;data source=QL-SACH.mssql.somee.com;persist security info=False;initial catalog=QL-SACH"
        Dim timkiem As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadTK As New SqlDataAdapter("select MATL as 'Mã TL', TEN as 'Tên TL'", timkiem)
        Dim db As New DataSet
        timkiem.Open()
        LoadTK.Fill(db)
        timkiem.Close()
        Return db
    End Function
End Class
