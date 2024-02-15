<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnUpd = New System.Windows.Forms.Button()
        Me.BtnUpProfile = New System.Windows.Forms.Button()
        Me.TxSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DgGamesList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgGamesList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(90, 368)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(108, 23)
        Me.BtnCreate.TabIndex = 1
        Me.BtnCreate.Text = "Add New Games"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(432, 368)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(108, 23)
        Me.BtnDel.TabIndex = 2
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnUpd
        '
        Me.BtnUpd.Location = New System.Drawing.Point(269, 368)
        Me.BtnUpd.Name = "BtnUpd"
        Me.BtnUpd.Size = New System.Drawing.Size(108, 23)
        Me.BtnUpd.TabIndex = 3
        Me.BtnUpd.Text = "Update Game"
        Me.BtnUpd.UseVisualStyleBackColor = True
        '
        'BtnUpProfile
        '
        Me.BtnUpProfile.Location = New System.Drawing.Point(598, 368)
        Me.BtnUpProfile.Name = "BtnUpProfile"
        Me.BtnUpProfile.Size = New System.Drawing.Size(108, 23)
        Me.BtnUpProfile.TabIndex = 4
        Me.BtnUpProfile.Text = "Update Profile"
        Me.BtnUpProfile.UseVisualStyleBackColor = True
        '
        'TxSearch
        '
        Me.TxSearch.Location = New System.Drawing.Point(27, 41)
        Me.TxSearch.Name = "TxSearch"
        Me.TxSearch.Size = New System.Drawing.Size(219, 20)
        Me.TxSearch.TabIndex = 6
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(269, 39)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 7
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DgGamesList
        '
        Me.DgGamesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgGamesList.Location = New System.Drawing.Point(27, 88)
        Me.DgGamesList.Name = "DgGamesList"
        Me.DgGamesList.Size = New System.Drawing.Size(724, 256)
        Me.DgGamesList.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Welcome to GmesApp Tomorrow"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(359, 39)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(67, 22)
        Me.BtnRefresh.TabIndex = 10
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgGamesList)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxSearch)
        Me.Controls.Add(Me.BtnUpProfile)
        Me.Controls.Add(Me.BtnUpd)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgGamesList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnUpd As Button
    Friend WithEvents BtnUpProfile As Button
    Friend WithEvents TxSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DgGamesList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRefresh As Button
End Class
