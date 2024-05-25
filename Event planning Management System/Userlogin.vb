Imports System.Data.SqlClient
Public Class Login_form
    Public userid As String
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        userid = txtuserid.Text
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        ' da = New SqlDataAdapter("select * from register where userid ='" + txtuserid.Text + "' and password='" + txtpassword.Text + "'", con)
        cmd = New SqlCommand("select * from register where name ='" + txtuserid.Text + "' and password='" + txtpassword.Text + "'", con)


        dr = cmd.ExecuteReader()
        If txtuserid.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Enter Username ad password")
        Else

            If (dr.HasRows) Then
                MessageBox.Show("Login successful")
                userid = txtuserid.Text
                Main_form.Show()
                Me.Hide()
            Else
                MessageBox.Show("incorrect userid or password")
            End If
        End If
        con.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Userlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        userid = txtuserid.Text
    End Sub
End Class