Imports System.Data.SqlClient
Public Class Main_form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Public temp As String
    Shared userid As String

    Private Sub Main_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        temp = Main_form.userid
        Me.Text = temp

        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Login_form.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Schedule_eventvb.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Payment.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Receipt.Show()
        Me.Hide()
    End Sub
   
End Class