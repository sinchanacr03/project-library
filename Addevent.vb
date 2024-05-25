Imports System.Data.SqlClient
Public Class Addevent
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btncreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreate.Click
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
        Try
            con.Open()
            cmd = New SqlCommand("insert into event values('" + txtec.Text + "','" + txtename.Text + "','" + TextBox1.Text + "')", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Created successfully ")
        Catch ex As Exception
            MessageBox.Show("Failed to create !")
        End Try
        con.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

    End Sub

    Private Sub txtec_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtec.KeyPress
        If Not (Asc(e.KeyChar)) = 8 Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MsgBox("enter only numbers")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Asc(e.KeyChar)) = 8 Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MsgBox("enter only numbers")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

        End If
    End Sub
End Class