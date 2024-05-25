Imports System.Data.SqlClient
Public Class Admin_login
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        ' da = New SqlDataAdapter("select * from register where userid ='" + txtadminid.Text + "' and password='" + txtadminpassword.Text + "'", con)
        cmd = New SqlCommand("select * from adminlogin where name='" + txtname.Text + "' and password='" + txtpassword.Text + "'", con)


        dr = cmd.ExecuteReader()
        If (dr.HasRows) Then
            MessageBox.Show("Login successful")
            Admin_home.Show()

            Me.Close()

        Else
            MessageBox.Show("incorrect userid or password")

        End If

        ' ds = New DataSet()
        '  da.Fill(ds, "emp")
        ' DataGridView1.DataSource = ds.Tables(0).DefaultView

        con.Close()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Admin_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class