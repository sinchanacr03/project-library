﻿Imports System.Data.SqlClient
Public Class Service
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Admin_home.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\91636\Downloads\Event planning Management System\Event planning Management System\Eventdb.mdf;Integrated Security=True;User Instance=True")
            con.Open()
            cmd = New SqlCommand("insert into service values('" + txtsc.Text + "','" + txtsn.Text + "','" + txtsct.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Service Added  successfully !!!")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class