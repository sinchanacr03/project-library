Imports System.Data.SqlClient
Public Class Receipt
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rd As SqlDataReader

    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main_form.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        cmd = New SqlCommand("select * from Payment where customercode='" + TextBox1.Text + "'", con)
        rd = cmd.ExecuteReader
        While rd.Read
            txtec.Text = rd("eventcode")
            txtname.Text = rd("name")
            txtet.Text = rd("eventtype")
            txtphone.Text = rd("phoneno")
            txttotal.Text = rd("total")
        End While
        rd.Close()
        con.Close()
    End Sub
End Class