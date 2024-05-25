Imports System.Data.SqlClient
Public Class Payment
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rd As SqlDataReader
    Private Sub Payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Main_form.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("insert into Payment values('" + txtcc.Text + "','" + txtname.Text + "','" + txtemail.Text + "','" + txtphone.Text + "','" + txtevent.Text + "','" + txteid.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox1.Text + "')", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Paid Successfully ")

        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        con.Open()
        cmd = New SqlCommand("select eventcode from event where eventname='" + txtevent.Text + "'", con)
        rd = cmd.ExecuteReader()
        While rd.Read
            txteid.Text = rd("eventcode")
        End While
        rd.Close()
        con.Close()
    End Sub

   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd = New SqlCommand("select cost from event where eventname='" + txtevent.Text + "'", con)
        rd = cmd.ExecuteReader
        While rd.Read
            TextBox1.Text = rd("cost")
        End While
        rd.Close()
        con.Close()
    End Sub
End Class