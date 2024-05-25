Imports System.Data.SqlClient
Public Class Register
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim da As SqlDataAdapter

    Private NameValid As Boolean
    Private Emailvalid As Boolean
    Private Phonevalid As Boolean
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        If txtname.Text = "" Or txtphone.Text = "" Or txtdob.Text = "" Or txtemail.Text = "" Or txtpassword.Text = "" Or txtpin.Text = "" Or ComboBox1.Text = "" Or txtst.Text = "" Or txtadd.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("enter all the information")
        Else
            Try
                con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
                con.Open()
                cmd = New SqlCommand("insert into register values('" + txtname.Text + "','" + txtemail.Text + "','" + ComboBox1.Text + "','" + txtdob.Text + "','" + txtphone.Text + "','" + txtadd.Text + "','" + txtst.Text + "','" + txtpin.Text + "','" + txtna.Text + "','" + txtpassword.Text + "')", con)
                cmd.ExecuteNonQuery()
                MsgBox("Registered successfully !!!")
                txtname.Text = Nothing
                txtphone.Text = Nothing
                txtdob.Text = Nothing
                txtemail.Text = Nothing
                txtpassword.Text = Nothing
                txtpin.Text = Nothing
                ComboBox1.Text = Nothing
                txtst.Text = Nothing
                txtadd.Text = Nothing
                txtna.Text = Nothing
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtname.Clear()
        txtphone.Clear()
        txtdob.Clear()
        txtemail.Clear()
        txtpassword.Clear()
        txtpin.Clear()
        txtst.Clear()
        txtadd.Clear()
        txtna.Clear()
    End Sub
End Class