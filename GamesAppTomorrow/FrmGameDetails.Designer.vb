<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGameDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkIncludeTax = New System.Windows.Forms.CheckBox()
        Me.TxGameName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCompanies = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxPrices = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTaxs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotals = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(87, 341)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 22)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(168, 341)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 22)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(249, 341)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 22)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Game Profile Details"
        '
        'ChkIncludeTax
        '
        Me.ChkIncludeTax.AutoSize = True
        Me.ChkIncludeTax.Location = New System.Drawing.Point(179, 233)
        Me.ChkIncludeTax.Name = "ChkIncludeTax"
        Me.ChkIncludeTax.Size = New System.Drawing.Size(82, 17)
        Me.ChkIncludeTax.TabIndex = 4
        Me.ChkIncludeTax.Text = "Include Tax"
        Me.ChkIncludeTax.UseVisualStyleBackColor = True
        '
        'TxGameName
        '
        Me.TxGameName.Location = New System.Drawing.Point(179, 60)
        Me.TxGameName.Name = "TxGameName"
        Me.TxGameName.Size = New System.Drawing.Size(213, 20)
        Me.TxGameName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Details"
        '
        'TxtDetails
        '
        Me.TxtDetails.Location = New System.Drawing.Point(179, 92)
        Me.TxtDetails.Multiline = True
        Me.TxtDetails.Name = "TxtDetails"
        Me.TxtDetails.Size = New System.Drawing.Size(213, 66)
        Me.TxtDetails.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Company"
        '
        'cboCompanies
        '
        Me.cboCompanies.FormattingEnabled = True
        Me.cboCompanies.Location = New System.Drawing.Point(179, 166)
        Me.cboCompanies.Name = "cboCompanies"
        Me.cboCompanies.Size = New System.Drawing.Size(213, 21)
        Me.cboCompanies.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Prices"
        '
        'TxPrices
        '
        Me.TxPrices.Location = New System.Drawing.Point(179, 207)
        Me.TxPrices.Name = "TxPrices"
        Me.TxPrices.Size = New System.Drawing.Size(213, 20)
        Me.TxPrices.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tax"
        '
        'TxtTaxs
        '
        Me.TxtTaxs.Location = New System.Drawing.Point(179, 266)
        Me.TxtTaxs.Name = "TxtTaxs"
        Me.TxtTaxs.Size = New System.Drawing.Size(213, 20)
        Me.TxtTaxs.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total"
        '
        'TxtTotals
        '
        Me.TxtTotals.Enabled = False
        Me.TxtTotals.Location = New System.Drawing.Point(179, 300)
        Me.TxtTotals.Name = "TxtTotals"
        Me.TxtTotals.Size = New System.Drawing.Size(213, 20)
        Me.TxtTotals.TabIndex = 16
        '
        'FrmGameDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 375)
        Me.Controls.Add(Me.TxtTotals)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTaxs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxPrices)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCompanies)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDetails)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxGameName)
        Me.Controls.Add(Me.ChkIncludeTax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Name = "FrmGameDetails"
        Me.Text = "Game Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkIncludeTax As CheckBox
    Friend WithEvents TxGameName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDetails As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCompanies As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxPrices As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTaxs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotals As TextBox
End Class
