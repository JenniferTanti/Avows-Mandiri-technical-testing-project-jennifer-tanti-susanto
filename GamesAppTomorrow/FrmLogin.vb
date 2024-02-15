Imports System.Data.SqlClient
Imports System.Net.Http
Public Class FrmLogin
    Dim NamaUser As String
    Dim PassUser As String

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub FrmOK_Click(sender As Object, e As EventArgs) Handles FrmOK.Click
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            Dim cmd As SqlCommand, dr As SqlDataReader
            Dim sql As String

            If Len(txtUser.Text) = 0 Or Len(txtPass.Text) = 0 Then
                MsgBox("You should input Username / Password first.")
                Exit Sub
            End If

            sql = ""
            sql = "select * from dbo.Logins where Username = '" & txtUser.Text & "'"

            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader()

            If dr.HasRows = False Then
                MsgBox("Username is still not yet to registered!", vbExclamation + vbOKOnly, "Error")
                txtUser.Focus()
                Exit Sub
            Else
                sql = ""
                sql = "select * from dbo.Logins where Username = '" & txtUser.Text & "' and PassName = '" & txtPass.Text & "'"

                cmd = New SqlCommand(sql, conn)
                dr = cmd.ExecuteReader()
                If dr.HasRows = False Then
                    MsgBox("Password is not yet to be registered!", vbExclamation + vbOKOnly, "Error")
                    txtPass.Focus()
                    Exit Sub
                Else
                    With FrmMenu
                        .Usermain = txtUser.Text
                        .UserPass = txtPass.Text
                        .Show()
                    End With
                    Me.Hide()
                    txtUser.Text = ""
                    txtPass.Text = ""
                End If
            End If
            conn.Close()
            cmd.Dispose()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
