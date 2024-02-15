Imports System.Data.SqlClient

Public Class FrmMenu
    Public Usermain As String
    Public UserPass As String

    Dim cmd As SqlCommand
    Dim ps As SqlDataAdapter
    Dim das As DataTable
    Dim dataidx As Integer
    Dim Trans As SqlTransaction
    Dim cmdDelGamesList As SqlCommand, cmdDelGamesPrice As SqlCommand
    Dim Names As String, details As String, Company As String
    Dim Price As Double, Tax As Double
    Dim idsx As Integer
    Dim idNumber As Integer
    Dim sqlcontent As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        End 'selesai
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        FrmLogin.Show()
        FrmLogin.txtUser.Text = ""
        FrmLogin.txtPass.Text = ""
        Exit Sub
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This mini project is made by Jennifer. This project did not copy paste 100% from Internet." &
               "Hope to enjoy this!! :)", vbOKOnly, "Info")
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            TxSearch.Text = ""
            MainRefresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnUpProfile_Click(sender As Object, e As EventArgs) Handles BtnUpProfile.Click
        Try
            cmd = New SqlCommand
            Dim pa As SqlDataReader

            sqlcontent = ""
            sqlcontent = "select ProfileName, DOB, AddressName, ProfilePhones, Usernama " &
                                "from Profiles a " &
                                "inner join Logins b on a.Usernama = b.Username " &
                                "where Username = '" & Usermain & "'"
            With cmd
                .Connection = conn
                If conn.State = ConnectionState.Open Then conn.Close()
                conn.Open()
                .CommandType = CommandType.Text
                .CommandText = sqlcontent
                pa = .ExecuteReader()
            End With
            pa.Read()

            With FrmProfiles
                .NamaProfil = pa("ProfileName").ToString()
                .Tanggal = pa("DOB").ToString()
                .Alamat = pa("Alamat").ToString()
                .Telephone = pa("ProfilePhones").ToString()
                .UsernameVerif = Usermain
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            cmd = New SqlCommand
            das = New DataTable

            sqlcontent = ""
            sqlcontent = "select a.IdGame as [No], a.GameName as [Names], a.GameList as [Details], " &
                            " a.GameCompany as [Company], b.PriceforGame as [Price], " &
                            " b.GameTax as [Tax], b.TotalPrice as [Totals] from GameList a " &
                            "Inner join GamePrice b on a.IdGame = b.IdGameList " &
                            "Where GameName like '%" & TxSearch.Text & "%' " &
                            "Order by a.IdGame"

            ps = New SqlDataAdapter(sqlcontent, conn)
            ps.Fill(das)
            ps.Dispose()

            DgGamesList.DataSource = das

            If DgGamesList.Rows.Count = 0 Then
                MsgBox("Game List Is empty!! " &
                       "Make sure to search the proper name!", vbExclamation + vbOK, "Empty")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Fail")
        End Try
    End Sub

    Private Sub BtnUpd_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click
        Try
            If DgGamesList.Rows.Count = 0 Then Exit Sub
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            idsx = DgGamesList.CurrentRow.Index

            idNumber = DgGamesList.Rows(idsx).Cells("No").Value.ToString
            Names = DgGamesList.Rows(idsx).Cells("Names").Value.ToString
            details = DgGamesList.Rows(idsx).Cells("Details").Value.ToString
            Company = DgGamesList.Rows(idsx).Cells("Company").Value.ToString
            Price = DgGamesList.Rows(idsx).Cells("Price").Value.ToString
            Tax = DgGamesList.Rows(idsx).Cells("Tax").Value.ToString

            With FrmGameDetails
                .isEdit = True
                .isAdd = False
                .Nbrs = idNumber
                .GameName = Names
                .DetailsGame = details
                .Price = Price
                .Tax = Tax
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Try
            If DgGamesList.Rows.Count = 0 Then Exit Sub

            dataidx = DgGamesList.CurrentRow.Index


            cmdDelGamesList = New SqlCommand
            cmdDelGamesPrice = New SqlCommand

            conn.BeginTransaction()

            With cmdDelGamesList
                .Connection = conn
                conn.Open()
                .CommandType = CommandType.Text
                .CommandText = "Delete from GameList where IdGame = @IdGames and GameName = @NameGame"
                .Parameters.Add("@IdGames", SqlDbType.Int).Value = dataidx + 1
                .Parameters.Add("@NameGame", SqlDbType.VarChar).Value = DgGamesList.Rows(dataidx).Cells("Names").Value.ToString()
                .ExecuteNonQuery()
            End With

            With cmdDelGamesPrice
                .Connection = conn
                conn.Open()
                .CommandType = CommandType.Text
                .CommandText = "Delete from GamePrice where IdGameList = @IdListGames"
                .Parameters.Add("@IdListGames", SqlDbType.Int).Value = dataidx + 1
                .ExecuteNonQuery()
            End With

            Trans.Commit()
            MsgBox("Data has been deleted successfully", vbInformation, "Delete Info")
            MainRefresh()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical, "Error")
            Trans.Rollback()
            conn.Close()
        End Try
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            With FrmGameDetails
                .isAdd = True
                .isEdit = False
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Try
            MainRefresh()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MainRefresh()
        Try
            cmd = New SqlCommand
            das = New DataTable

            sqlcontent = ""
            sqlcontent = "select a.IdGame as [No], a.GameName as [Names], a.GameList as [Details], " &
                            " a.GameCompany as [Company], b.PriceforGame as [Price], " &
                            " b.GameTax as [Tax], b.TotalPrice as [Totals] from GameList a " &
                            "Inner join GamePrice b on a.IdGame = b.IdGameList " &
                            "Order by a.IdGame"

            ps = New SqlDataAdapter(sqlcontent, conn)
            ps.Fill(das)
            ps.Dispose()

            DgGamesList.DataSource = das

            If DgGamesList.Rows.Count = 0 Then
                MsgBox("Game List Is empty!! " &
                       "Make sure to create The Game List first!!", vbExclamation + vbOK, "Empty")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
        End Try
    End Sub
End Class