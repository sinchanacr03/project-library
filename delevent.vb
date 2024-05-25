Imports System.Data.SqlClient
Public Class delevent
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub delevent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        con.Open()
        da = New SqlDataAdapter("select * from event", con)
        ds = New DataSet()
        da.Fill(ds, "event")
        DataGridView1.DataSource = ds.Tables(0).DefaultView
        con.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
    
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        con.Open()
        If txtec.Text = "" Then
            MsgBox("enter event code to be deleted")
        Else
            cmd = New SqlCommand("delete from event where eventcode='" + txtec.Text + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Event deleted successfully")
            delevent_Load(sender, e)
            con.Close()

        End If
    End Sub

 
End Class