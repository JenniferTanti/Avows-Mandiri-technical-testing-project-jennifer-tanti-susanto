Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Server

Public Class FrmGameDetails

    Public isAdd As Boolean, isEdit As Boolean
    Dim isCancel As Boolean
    Public GameName As String, DetailsGame As String
    Public GamesCom As String, Price As Double, Tax As Double
    Dim cmdInserts As SqlCommand, cmdUpdates As SqlCommand
    Dim cmdInsertPrice As SqlCommand, cmdUpdatePrice As SqlCommand
    Dim cmdCom As SqlCommand, dapa As SqlDataAdapter, dso As DataTable
    Dim Triscition As SqlTransaction
    Dim idxNbrs As Integer, sqlas As String
    Public Nbrs As Integer

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            isCancel = True
            TxGameName.Text = ""
            idxNbrs = 0
            TxtDetails.Text = ""
            TxPrices.Text = ""
            TxtTaxs.Text = ""
            TxtTotals.Text = ""
            If isEdit = True Then
                Nbrs = 0
                GameName = ""
                DetailsGame = ""
                GamesCom = ""
                Price = 0
                Tax = 0
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ChkIncludeTax_CheckedChanged(sender As Object, e As EventArgs) Handles ChkIncludeTax.CheckedChanged
        If ChkIncludeTax.Checked = True Then
            TxtTaxs.Enabled = True
        ElseIf ChkIncludeTax.Checked = False Then
            TxtTaxs.Enabled = False
        End If
    End Sub
    Private Sub TxPrices_Validating(sender As Object, e As CancelEventArgs) Handles TxPrices.Validating
        If isCancel = False Then TotalCalc()
    End Sub

    Private Sub TxtTaxs_Validating(sender As Object, e As CancelEventArgs) Handles TxtTaxs.Validating
        If isCancel = False Then TotalCalc()
    End Sub
    Private Sub TotalCalc()
        TxtTotals.Text = CDbl(TxPrices.Text) + IIf(CDbl(TxtTaxs.Text) = 0, 0, CDbl(TxtTaxs.Text))
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            If Len(TxGameName.Text) = 0 Then
                MsgBox("It should write the Name first!!", vbExclamation, "Error")
                TxGameName.Focus()
                Exit Sub
            End If

            If Len(TxtDetails.Text) = 0 Then
                MsgBox("It should write the detail first!!", vbExclamation, "Error")
                TxtDetails.Focus()
                Exit Sub
            End If

            If TxGameName.Text = GameName And TxtDetails.Text = DetailsGame And cboCompanies.Text = GamesCom Then
                MsgBox("You should edit one of the components!", vbExclamation, "Warning")
                Exit Sub
            End If

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            conn.BeginTransaction()
            cmdUpdates = New SqlCommand

            With cmdUpdates
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = "Update GameList Set GameName = @NamaGames, GameList = @DaftarGames, " &
                                "GameCompany = @NamaCompany where IdGame = @idGame "
                .Parameters.Add("@NamaGames", SqlDbType.VarChar).Value = TxGameName.Text
                .Parameters.Add("@DetailGame", SqlDbType.VarChar).Value = TxtDetails.Text
                .Parameters.Add("@NamaCompany", SqlDbType.VarChar).Value = cboCompanies.Text
                .Parameters.Add("@idGame", SqlDbType.Int).Value = idxNbrs
                .ExecuteNonQuery()
            End With

            cmdUpdatePrice = New SqlCommand

            With cmdUpdatePrice
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = "Update GamePrice Set PriceforGame = @GamePrice, GameTax = @TaxesGame, " &
                                "TotalPrice = @PriceMix, IncludeTax = @TxInc where IdGameList = @IdList"
                .Parameters.AddWithValue("@GamePrice", CDbl(TxPrices.Text))
                .Parameters.AddWithValue("@TaxesGame", CDbl(TxtTaxs.Text))
                .Parameters.AddWithValue("@PriceMix", CDbl(TxtTotals.Text))
                .Parameters.AddWithValue("@TxInc", IIf(ChkIncludeTax.Checked, 1, 0))
                .Parameters.AddWithValue("@IdList", idxNbrs)
                .ExecuteNonQuery()
            End With

            Triscition.Commit()

            MsgBox("Game has been updated into System!!", vbInformation, "Saved")

            Me.Close()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.ToString)
            If conn.State = ConnectionState.Open Then
                Triscition.Rollback()
            End If
            conn.Close()
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            If Len(TxGameName.Text) = 0 Then
                MsgBox("It should write the Name first!!", vbExclamation, "Error")
                TxGameName.Focus()
                Exit Sub
            End If

            If Len(TxtDetails.Text) = 0 Then
                MsgBox("It should write the detail first!!", vbExclamation, "Error")
                TxtDetails.Focus()
                Exit Sub
            End If

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            conn.BeginTransaction()

            cmdInserts = New SqlCommand

            With cmdInserts
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO GameList(IdGame, GameName, GameList, GameCompany) " &
                                "VALUES(@IdGames, @NamaGaming, @DaftarGaming, @ComGames) "
                .Parameters.AddWithValue("@IdGames", idxNbrs)
                .Parameters.AddWithValue("@NamaGaming", TxGameName.Text)
                .Parameters.AddWithValue("@DaftarGaming", TxtDetails.Text)
                .Parameters.AddWithValue("@ComGames", cboCompanies.Text)
                .ExecuteNonQuery()
            End With

            cmdInsertPrice = New SqlCommand

            With cmdInsertPrice
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO GamePrice(IdGameList, PriceforGame, GameTax, TotalPrice, IncludeTax) " &
                                "VALUES(@IdGamessList, @Prices, @Taxes, @TotalPrices,@Taxinc) "
                .Parameters.AddWithValue("@IdGamessList", idxNbrs)
                .Parameters.AddWithValue("@Prices", CDbl(TxPrices.Text))
                .Parameters.AddWithValue("@Taxes", CDbl(TxtTaxs.Text))
                .Parameters.AddWithValue("@TotalPrices", CDbl(TxtTotals.Text))
                .Parameters.AddWithValue("@Taxinc", IIf(ChkIncludeTax.Checked, 1, 0))
                .ExecuteNonQuery()
            End With

            Triscition.Commit()

            MsgBox("Game has been added into System!!", vbInformation, "Saved")

            Me.Close()
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.ToString)
            If conn.State = ConnectionState.Open Then
                Triscition.Rollback()
            End If
            conn.Close()
        End Try
    End Sub

    Private Sub FrmGameDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()

            If isAdd Then
                BtnAdd.Visible = True : BtnUpdate.Visible = False
            ElseIf isEdit Then
                BtnAdd.Visible = False : BtnUpdate.Visible = True
            End If

            With cboCompanies
                .Items.Add("Bamaico Company")
                .Items.Add("Saiga Holding")
                .Items.Add("E3 Sports")
                .Items.Add("Awovisioon")
                .Items.Add("Meg Productions")
                .Items.Add("Ten Dollar Pictures")
                .SelectedIndex = 0
            End With

            isCancel = False

            If isAdd = True Then
                cmdCom = New SqlCommand
                dso = New DataTable
                sqlas = ""
                sqlas = "select IsNull(Max(isNull(IdGame,0)),0) as IdGame from GameList"

                dapa = New SqlDataAdapter(sqlas, conn)
                dapa.Fill(dso)
                dapa.Dispose()

                idxNbrs = CInt(dso("IdGame").ToString())

                TxPrices.Text = 0
                TxtTaxs.Text = 0
            ElseIf isEdit = True Then
                cmdCom = New SqlCommand
                dso = New DataTable
                sqlas = ""
                sqlas = "select GameCompany from GameList where IdGame = " & Nbrs & " and GameName = '" & GameName & "'"

                dapa = New SqlDataAdapter(sqlas, conn)
                dapa.Fill(dso)
                dapa.Dispose()

                cboCompanies.Text = dso("GameCompany").ToString()

                idxNbrs = Nbrs
                TxGameName.Text = GameName
                TxtDetails.Text = DetailsGame
                TxPrices.Text = CDbl(Price)
                TxtTaxs.Text = CDbl(Tax)
            End If

            If ChkIncludeTax.Checked Then
                TxtTaxs.Enabled = True
            Else
                TxtTaxs.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical, "Failed")
            conn.Close()
        End Try
    End Sub
End Class