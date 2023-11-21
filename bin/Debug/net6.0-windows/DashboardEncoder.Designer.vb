<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardEncoder
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
        Panel1 = New Panel()
        BtnLogout = New Button()
        BtnInventory = New Button()
        LblPosition = New Label()
        LblFirstNameLastName = New Label()
        PicBoxProfileLogo = New PictureBox()
        TabControl = New TabControl()
        InventoryRecords = New TabPage()
        ComboBox6 = New ComboBox()
        Panel6 = New Panel()
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        LvInventory = New ListView()
        Panel1.SuspendLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        InventoryRecords.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnInventory)
        Panel1.Controls.Add(LblPosition)
        Panel1.Controls.Add(LblFirstNameLastName)
        Panel1.Controls.Add(PicBoxProfileLogo)
        Panel1.Location = New Point(-1, -1)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(312, 782)
        Panel1.TabIndex = 2
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = SystemColors.Info
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        BtnLogout.Location = New Point(0, 730)
        BtnLogout.Margin = New Padding(4, 4, 4, 4)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(91, 49)
        BtnLogout.TabIndex = 8
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnInventory
        ' 
        BtnInventory.AllowDrop = True
        BtnInventory.BackColor = SystemColors.Info
        BtnInventory.FlatAppearance.BorderSize = 0
        BtnInventory.FlatStyle = FlatStyle.Flat
        BtnInventory.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnInventory.Location = New Point(0, 311)
        BtnInventory.Margin = New Padding(4, 4, 4, 4)
        BtnInventory.Name = "BtnInventory"
        BtnInventory.Size = New Size(309, 49)
        BtnInventory.TabIndex = 3
        BtnInventory.Text = "Inventory Records"
        BtnInventory.UseVisualStyleBackColor = False
        ' 
        ' LblPosition
        ' 
        LblPosition.AutoSize = True
        LblPosition.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        LblPosition.Location = New Point(118, 240)
        LblPosition.Margin = New Padding(4, 0, 4, 0)
        LblPosition.Name = "LblPosition"
        LblPosition.Size = New Size(75, 25)
        LblPosition.TabIndex = 2
        LblPosition.Text = "Position"
        ' 
        ' LblFirstNameLastName
        ' 
        LblFirstNameLastName.AutoSize = True
        LblFirstNameLastName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblFirstNameLastName.Location = New Point(52, 211)
        LblFirstNameLastName.Margin = New Padding(4, 0, 4, 0)
        LblFirstNameLastName.Name = "LblFirstNameLastName"
        LblFirstNameLastName.Size = New Size(212, 30)
        LblFirstNameLastName.TabIndex = 1
        LblFirstNameLastName.Text = "FirstName LastName"
        ' 
        ' PicBoxProfileLogo
        ' 
        PicBoxProfileLogo.BackgroundImage = My.Resources.Resources.profile
        PicBoxProfileLogo.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxProfileLogo.Location = New Point(68, 35)
        PicBoxProfileLogo.Margin = New Padding(4, 4, 4, 4)
        PicBoxProfileLogo.Name = "PicBoxProfileLogo"
        PicBoxProfileLogo.Size = New Size(179, 160)
        PicBoxProfileLogo.TabIndex = 0
        PicBoxProfileLogo.TabStop = False
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(InventoryRecords)
        TabControl.Location = New Point(319, 15)
        TabControl.Margin = New Padding(4, 4, 4, 4)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(871, 748)
        TabControl.TabIndex = 3
        ' 
        ' InventoryRecords
        ' 
        InventoryRecords.Controls.Add(ComboBox6)
        InventoryRecords.Controls.Add(Panel6)
        InventoryRecords.Controls.Add(LvInventory)
        InventoryRecords.Location = New Point(4, 34)
        InventoryRecords.Margin = New Padding(4, 4, 4, 4)
        InventoryRecords.Name = "InventoryRecords"
        InventoryRecords.Padding = New Padding(4, 4, 4, 4)
        InventoryRecords.Size = New Size(863, 710)
        InventoryRecords.TabIndex = 4
        InventoryRecords.Text = "Inventory"
        InventoryRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"Date", "Serial Number", "Type / Class", "Unit Cost", "Qty", "Total Amount", "Last Maintenance"})
        ComboBox6.Location = New Point(744, 26)
        ComboBox6.Margin = New Padding(4, 4, 4, 4)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(102, 33)
        ComboBox6.TabIndex = 31
        ComboBox6.Text = "Sort by:"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Control
        Panel6.Controls.Add(PictureBox3)
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(TextBox3)
        Panel6.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel6.Location = New Point(14, 21)
        Panel6.Margin = New Padding(4, 4, 4, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(489, 52)
        Panel6.TabIndex = 30
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.search
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(4, 9)
        PictureBox3.Margin = New Padding(4, 4, 4, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 36)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(41, 19)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 21)
        Label4.TabIndex = 1
        Label4.Text = "Search Equipment"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.MenuBar
        TextBox3.Location = New Point(196, 12)
        TextBox3.Margin = New Padding(4, 4, 4, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(284, 28)
        TextBox3.TabIndex = 0
        ' 
        ' LvInventory
        ' 
        LvInventory.Activation = ItemActivation.OneClick
        LvInventory.Location = New Point(14, 81)
        LvInventory.Margin = New Padding(4, 4, 4, 4)
        LvInventory.Name = "LvInventory"
        LvInventory.Size = New Size(832, 603)
        LvInventory.TabIndex = 29
        LvInventory.UseCompatibleStateImageBehavior = False
        LvInventory.View = View.Details
        ' 
        ' DashboardEncoder
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1194, 778)
        Controls.Add(TabControl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "DashboardEncoder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardEncoder"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        InventoryRecords.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnInventory As Button
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblFirstNameLastName As Label
    Friend WithEvents PicBoxProfileLogo As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents InventoryRecords As TabPage
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LvInventory As ListView
End Class
