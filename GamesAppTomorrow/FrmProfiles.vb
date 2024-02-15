Imports System.Data.SqlClient
Public Class FrmProfiles

    Public NamaProfil As String
    Public Tanggal As Date
    Public Alamat As String
    Public Telephone As String
    Public UsernameVerif As String
    Dim commands As SqlCommand
    Dim dps As SqlDataAdapter
    Dim daaa As DataSet
    Dim sqlsql As String

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtProfileName.Text = ""
        TxtAdd.Text = ""
        TxtPhone.Text = ""
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        NamaProfil = "" : Tanggal = ""
        Alamat = "" : Telephone = "" : UsernameVerif = ""
        Me.Hide()
    End Sub

    Private Sub FrmProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            TxtProfileName.Text = NamaProfil
            DtBorn.Value = CDate(Tanggal)
            TxtAdd.Text = Alamat
            TxtPhone.Text = CDbl(Telephone)
            TxtUsername.Text = UsernameVerif
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            If Len(TxtUsername.Text) = 0 Then
                MsgBox("Please write username first", vbExclamation + vbOKOnly, "Error")
                Exit Sub
            End If

            If Len(TxtPassword.Text) = 0 Then
                MsgBox("Please write Password first", vbExclamation + vbOKOnly, "Error")
                Exit Sub
            End If

            If TxtProfileName.Text = NamaProfil And CDate(DtBorn.Value) = CDate(Tanggal) _
                And TxtAdd.Text = Alamat And CDbl(TxtPhone.Text) = CDbl(Telephone) Then
                MsgBox("Make sure to updates one of the components first!!", vbExclamation, "Error")
                Exit Sub
            End If

            If MsgBox("Are you sure to update profiles?", vbQuestion + vbYesNo, "Confirmations") = vbNo Then Exit Sub


            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            commands = New SqlCommand
            sqlsql = "Update Profiles Set ProfileName = @Profiles, DOB = @DatesUltah, " &
                        " AddressName = @AddNames, ProfilePhones = @PhoneName where Usernama = @UserNames"
            With commands
                .Connection = conn
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                .CommandType = CommandType.Text
                .CommandText = sqlsql
                .Parameters.Add("@Profiles", SqlDbType.VarChar).Value = TxtProfileName.Text
                .Parameters.Add("@DatesUltah", SqlDbType.Date).Value = CDate(DtBorn.Value)
                .Parameters.Add("@AddNames", SqlDbType.VarChar).Value = TxtAdd.Text
                .Parameters.Add("@PhoneName", SqlDbType.VarChar).Value = CDbl(TxtPhone.Text)
                .Parameters.Add("@UserNames", SqlDbType.VarChar).Value = TxtUsername.Text
                .ExecuteNonQuery()
            End With
            MsgBox("Profile updated successfully!!", vbInformation, "Update")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            TxtAdd.Text = ""
            TxtPhone.Text = ""
            TxtProfileName.Text = ""
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub
End Class