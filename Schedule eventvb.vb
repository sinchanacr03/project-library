Imports System.Data.SqlClient
Public Class Schedule_eventvb
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
            con.Open()
            cmd = New SqlCommand("insert into schevent values('" + txtname.Text + "','" + txtet.Text + "','" + txtst.Text + "','" + txtsd.Text + "','" + txted.Text + "','" + txtvenue.Text + "','" + txtetime.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Scheduled successfully !!!")

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main_form.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
   
End Class