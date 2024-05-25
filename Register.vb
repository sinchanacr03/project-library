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
                If validatepassword(txtpassword.Text) = False Then
                    MessageBox.Show("password should have minimum 5 characters, atleast 1 number, 1 lowercase , 1 uppercase and atleast 1 special character")

                Else
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
                End If
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

    Private Sub txtphone_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles txtphone.KeyPress
        If Not (Asc(e.KeyChar)) = 8 Then
            Dim allowednos As String = "1234567890"
            If Not allowednos.Contains(e.KeyChar.ToString) Then
                MsgBox("enter only numbers")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
            If Len(txtphone.Text) > 9 Then
                MsgBox("only 10 numbers allowed")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If

        End If
    End Sub
    Private Shared Function validatepassword(ByVal password) As Boolean
        Dim regEx
        regEx = CreateObject("vbscript.regexp")
        regEx.pattern = "^.*(?=.{5,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&+=]).*$"
        validatepassword = regEx.test(password)
        regEx = Nothing
    End Function

    
End Class

