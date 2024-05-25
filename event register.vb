Imports System.Data.SqlClient
Public Class event_register
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Admin_home.Show()
        Me.Hide()
    End Sub

    Private Sub event_register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        da = New SqlDataAdapter("select * from schevent", con)
        ds = New DataSet()
        da.Fill(ds, "schevent")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
    End Sub
End Class