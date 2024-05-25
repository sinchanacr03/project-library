Imports System.Data.SqlClient
Public Class custregister
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Private Sub custregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        da = New SqlDataAdapter("select * from register", con)
        ds = New DataSet()
        da.Fill(ds, "register")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin_home.Show()
        Me.Hide()
    End Sub
End Class