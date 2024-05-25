Imports System.Data.SqlClient
Public Class update_event
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rd As SqlDataReader

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        Try
            con.Open()
            cmd = New SqlCommand("select eventcode from event where eventcode=" + txtec.Text + "", con)
            rd = cmd.ExecuteReader()
            If (rd.HasRows) Then
                cmd = New SqlCommand("update event set eventname='" + txtename.Text + "','" + txtcost.Text + "'", con)
                rd.Close()
                cmd.ExecuteNonQuery()
                txtec.Text = Nothing
                txtename.Text = Nothing
                MsgBox(" Updated successfully !!!")
            Else
                MessageBox.Show("invalid event code !!!")
            End If

        Catch ex As Exception
            MsgBox("event code does not exists !!!")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
     
    End Sub

    Private Sub update_event_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class