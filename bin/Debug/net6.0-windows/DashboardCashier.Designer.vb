<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardCashier
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
        BtnSalesRecords = New Button()
        BtnMonitoring = New Button()
        BtnMembershipRegistration = New Button()
        BtnPOS = New Button()
        LblPosition = New Label()
        LblFirstNameLastName = New Label()
        PicBoxProfileLogo = New PictureBox()
        TabControl = New TabControl()
        PointOfSale = New TabPage()
        MembershipRegistration = New TabPage()
        AccountMonitoring = New TabPage()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        LvAccountMonitoring = New ListView()
        SalesRecords = New TabPage()
        ComboBox3 = New ComboBox()
        Panel5 = New Panel()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        LvSales = New ListView()
        GroupBox1 = New GroupBox()
        bronzeCB = New RadioButton()
        goldCB = New RadioButton()
        silverCB = New RadioButton()
        noneCB = New RadioButton()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        mem7RB = New RadioButton()
        mem3RB = New RadioButton()
        mem1RB = New RadioButton()
        Label1 = New Label()
        GroupBox3 = New GroupBox()
        mpCB = New CheckBox()
        lockerCB = New CheckBox()
        ptCB = New CheckBox()
        GroupBox4 = New GroupBox()
        Button2 = New Button()
        Label10 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        ListBox2 = New ListBox()
        totalLbl = New Label()
        Label4 = New Label()
        ListBox1 = New ListBox()
        TextBox3 = New TextBox()
        Label9 = New Label()
        monthLbl = New Label()
        Label6 = New Label()
        Label11 = New Label()
        Panel1.SuspendLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl.SuspendLayout()
        PointOfSale.SuspendLayout()
        AccountMonitoring.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SalesRecords.SuspendLayout()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(BtnLogout)
        Panel1.Controls.Add(BtnSalesRecords)
        Panel1.Controls.Add(BtnMonitoring)
        Panel1.Controls.Add(BtnMembershipRegistration)
        Panel1.Controls.Add(BtnPOS)
        Panel1.Controls.Add(LblPosition)
        Panel1.Controls.Add(LblFirstNameLastName)
        Panel1.Controls.Add(PicBoxProfileLogo)
        Panel1.Location = New Point(-2, -1)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(219, 470)
        Panel1.TabIndex = 1
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = SystemColors.Info
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        BtnLogout.Location = New Point(0, 438)
        BtnLogout.Margin = New Padding(3, 2, 3, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Size = New Size(64, 29)
        BtnLogout.TabIndex = 8
        BtnLogout.Text = "Logout"
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' BtnSalesRecords
        ' 
        BtnSalesRecords.BackColor = SystemColors.Info
        BtnSalesRecords.FlatAppearance.BorderSize = 0
        BtnSalesRecords.FlatStyle = FlatStyle.Flat
        BtnSalesRecords.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSalesRecords.Location = New Point(0, 288)
        BtnSalesRecords.Margin = New Padding(3, 2, 3, 2)
        BtnSalesRecords.Name = "BtnSalesRecords"
        BtnSalesRecords.Size = New Size(216, 29)
        BtnSalesRecords.TabIndex = 6
        BtnSalesRecords.Text = "Sales Records"
        BtnSalesRecords.UseVisualStyleBackColor = False
        ' 
        ' BtnMonitoring
        ' 
        BtnMonitoring.BackColor = SystemColors.Info
        BtnMonitoring.FlatAppearance.BorderSize = 0
        BtnMonitoring.FlatStyle = FlatStyle.Flat
        BtnMonitoring.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMonitoring.Location = New Point(0, 254)
        BtnMonitoring.Margin = New Padding(3, 2, 3, 2)
        BtnMonitoring.Name = "BtnMonitoring"
        BtnMonitoring.Size = New Size(216, 29)
        BtnMonitoring.TabIndex = 5
        BtnMonitoring.Text = "Account Monitoring"
        BtnMonitoring.UseVisualStyleBackColor = False
        ' 
        ' BtnMembershipRegistration
        ' 
        BtnMembershipRegistration.BackColor = SystemColors.Info
        BtnMembershipRegistration.FlatAppearance.BorderSize = 0
        BtnMembershipRegistration.FlatStyle = FlatStyle.Flat
        BtnMembershipRegistration.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnMembershipRegistration.Location = New Point(2, 220)
        BtnMembershipRegistration.Margin = New Padding(3, 2, 3, 2)
        BtnMembershipRegistration.Name = "BtnMembershipRegistration"
        BtnMembershipRegistration.Size = New Size(216, 29)
        BtnMembershipRegistration.TabIndex = 4
        BtnMembershipRegistration.Text = "Membership Registration"
        BtnMembershipRegistration.UseVisualStyleBackColor = False
        ' 
        ' BtnPOS
        ' 
        BtnPOS.BackColor = SystemColors.Info
        BtnPOS.FlatAppearance.BorderSize = 0
        BtnPOS.FlatStyle = FlatStyle.Flat
        BtnPOS.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPOS.Location = New Point(0, 187)
        BtnPOS.Margin = New Padding(3, 2, 3, 2)
        BtnPOS.Name = "BtnPOS"
        BtnPOS.Size = New Size(216, 29)
        BtnPOS.TabIndex = 3
        BtnPOS.Text = "Point of Sale"
        BtnPOS.UseVisualStyleBackColor = False
        ' 
        ' LblPosition
        ' 
        LblPosition.AutoSize = True
        LblPosition.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        LblPosition.Location = New Point(82, 144)
        LblPosition.Name = "LblPosition"
        LblPosition.Size = New Size(48, 15)
        LblPosition.TabIndex = 2
        LblPosition.Text = "Position"
        ' 
        ' LblFirstNameLastName
        ' 
        LblFirstNameLastName.AutoSize = True
        LblFirstNameLastName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblFirstNameLastName.Location = New Point(37, 127)
        LblFirstNameLastName.Name = "LblFirstNameLastName"
        LblFirstNameLastName.Size = New Size(139, 19)
        LblFirstNameLastName.TabIndex = 1
        LblFirstNameLastName.Text = "FirstName LastName"
        ' 
        ' PicBoxProfileLogo
        ' 
        PicBoxProfileLogo.BackgroundImage = My.Resources.Resources.profile
        PicBoxProfileLogo.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxProfileLogo.Location = New Point(47, 21)
        PicBoxProfileLogo.Margin = New Padding(3, 2, 3, 2)
        PicBoxProfileLogo.Name = "PicBoxProfileLogo"
        PicBoxProfileLogo.Size = New Size(125, 96)
        PicBoxProfileLogo.TabIndex = 0
        PicBoxProfileLogo.TabStop = False
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(PointOfSale)
        TabControl.Controls.Add(MembershipRegistration)
        TabControl.Controls.Add(AccountMonitoring)
        TabControl.Controls.Add(SalesRecords)
        TabControl.Location = New Point(222, 9)
        TabControl.Margin = New Padding(3, 2, 3, 2)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(610, 448)
        TabControl.TabIndex = 2
        ' 
        ' PointOfSale
        ' 
        PointOfSale.Controls.Add(GroupBox4)
        PointOfSale.Controls.Add(GroupBox3)
        PointOfSale.Controls.Add(GroupBox2)
        PointOfSale.Controls.Add(GroupBox1)
        PointOfSale.Location = New Point(4, 24)
        PointOfSale.Margin = New Padding(3, 2, 3, 2)
        PointOfSale.Name = "PointOfSale"
        PointOfSale.Padding = New Padding(3, 2, 3, 2)
        PointOfSale.Size = New Size(602, 420)
        PointOfSale.TabIndex = 4
        PointOfSale.Text = "POS"
        PointOfSale.UseVisualStyleBackColor = True
        ' 
        ' MembershipRegistration
        ' 
        MembershipRegistration.Location = New Point(4, 24)
        MembershipRegistration.Margin = New Padding(3, 2, 3, 2)
        MembershipRegistration.Name = "MembershipRegistration"
        MembershipRegistration.Padding = New Padding(3, 2, 3, 2)
        MembershipRegistration.Size = New Size(602, 420)
        MembershipRegistration.TabIndex = 5
        MembershipRegistration.Text = "Registration"
        MembershipRegistration.UseVisualStyleBackColor = True
        ' 
        ' AccountMonitoring
        ' 
        AccountMonitoring.Controls.Add(Button1)
        AccountMonitoring.Controls.Add(ComboBox2)
        AccountMonitoring.Controls.Add(Panel4)
        AccountMonitoring.Controls.Add(LvAccountMonitoring)
        AccountMonitoring.Location = New Point(4, 24)
        AccountMonitoring.Margin = New Padding(3, 2, 3, 2)
        AccountMonitoring.Name = "AccountMonitoring"
        AccountMonitoring.Padding = New Padding(3, 2, 3, 2)
        AccountMonitoring.Size = New Size(602, 420)
        AccountMonitoring.TabIndex = 2
        AccountMonitoring.Text = "Monitoring"
        AccountMonitoring.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(481, 15)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(34, 22)
        Button1.TabIndex = 28
        Button1.Text = "req"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Active", "Inactive"})
        ComboBox2.Location = New Point(521, 16)
        ComboBox2.Margin = New Padding(3, 2, 3, 2)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(72, 23)
        ComboBox2.TabIndex = 27
        ComboBox2.Text = "Sort by:"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(PictureBox1)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(TextBox1)
        Panel4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel4.Location = New Point(10, 13)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(342, 32)
        Panel4.TabIndex = 26
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.search
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 5)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 22)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 13)
        Label2.TabIndex = 1
        Label2.Text = "Search Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.MenuBar
        TextBox1.Location = New Point(108, 8)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(229, 21)
        TextBox1.TabIndex = 0
        ' 
        ' LvAccountMonitoring
        ' 
        LvAccountMonitoring.Location = New Point(10, 49)
        LvAccountMonitoring.Margin = New Padding(3, 2, 3, 2)
        LvAccountMonitoring.Name = "LvAccountMonitoring"
        LvAccountMonitoring.Size = New Size(583, 363)
        LvAccountMonitoring.TabIndex = 25
        LvAccountMonitoring.UseCompatibleStateImageBehavior = False
        LvAccountMonitoring.View = View.Details
        ' 
        ' SalesRecords
        ' 
        SalesRecords.Controls.Add(ComboBox3)
        SalesRecords.Controls.Add(Panel5)
        SalesRecords.Controls.Add(LvSales)
        SalesRecords.Location = New Point(4, 24)
        SalesRecords.Margin = New Padding(3, 2, 3, 2)
        SalesRecords.Name = "SalesRecords"
        SalesRecords.Padding = New Padding(3, 2, 3, 2)
        SalesRecords.Size = New Size(602, 420)
        SalesRecords.TabIndex = 3
        SalesRecords.Text = "Sales"
        SalesRecords.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Date", "Transaction Number", "Level of Membership", "Total Amount"})
        ComboBox3.Location = New Point(521, 16)
        ComboBox3.Margin = New Padding(3, 2, 3, 2)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(72, 23)
        ComboBox3.TabIndex = 27
        ComboBox3.Text = "Sort by:"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.Controls.Add(PictureBox2)
        Panel5.Controls.Add(Label3)
        Panel5.Controls.Add(TextBox2)
        Panel5.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point)
        Panel5.Location = New Point(10, 13)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(342, 32)
        Panel5.TabIndex = 26
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.search
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(3, 5)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 22)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(29, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 13)
        Label3.TabIndex = 1
        Label3.Text = "Search Transaction"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.MenuBar
        TextBox2.Location = New Point(137, 8)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 21)
        TextBox2.TabIndex = 0
        ' 
        ' LvSales
        ' 
        LvSales.Location = New Point(10, 49)
        LvSales.Margin = New Padding(3, 2, 3, 2)
        LvSales.Name = "LvSales"
        LvSales.Size = New Size(583, 363)
        LvSales.TabIndex = 25
        LvSales.UseCompatibleStateImageBehavior = False
        LvSales.View = View.Details
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.Controls.Add(bronzeCB)
        GroupBox1.Controls.Add(goldCB)
        GroupBox1.Controls.Add(silverCB)
        GroupBox1.Controls.Add(noneCB)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(7, 6)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(157, 153)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' bronzeCB
        ' 
        bronzeCB.AutoSize = True
        bronzeCB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        bronzeCB.Location = New Point(8, 50)
        bronzeCB.Margin = New Padding(4)
        bronzeCB.Name = "bronzeCB"
        bronzeCB.Size = New Size(74, 23)
        bronzeCB.TabIndex = 9
        bronzeCB.TabStop = True
        bronzeCB.Text = "Bronze"
        bronzeCB.UseVisualStyleBackColor = True
        ' 
        ' goldCB
        ' 
        goldCB.AutoSize = True
        goldCB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        goldCB.Location = New Point(8, 121)
        goldCB.Margin = New Padding(4)
        goldCB.Name = "goldCB"
        goldCB.Size = New Size(59, 23)
        goldCB.TabIndex = 8
        goldCB.TabStop = True
        goldCB.Text = "Gold"
        goldCB.UseVisualStyleBackColor = True
        ' 
        ' silverCB
        ' 
        silverCB.AutoSize = True
        silverCB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        silverCB.Location = New Point(8, 87)
        silverCB.Margin = New Padding(4)
        silverCB.Name = "silverCB"
        silverCB.Size = New Size(65, 23)
        silverCB.TabIndex = 7
        silverCB.TabStop = True
        silverCB.Text = "Silver"
        silverCB.UseVisualStyleBackColor = True
        ' 
        ' noneCB
        ' 
        noneCB.AutoSize = True
        noneCB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        noneCB.Location = New Point(96, 87)
        noneCB.Margin = New Padding(4)
        noneCB.Name = "noneCB"
        noneCB.Size = New Size(63, 23)
        noneCB.TabIndex = 6
        noneCB.TabStop = True
        noneCB.Text = "None"
        noneCB.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(8, 10)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 36)
        Label5.TabIndex = 5
        Label5.Text = "Packages"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(mem7RB)
        GroupBox2.Controls.Add(mem3RB)
        GroupBox2.Controls.Add(mem1RB)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(7, 163)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(144, 155)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        ' 
        ' mem7RB
        ' 
        mem7RB.AutoSize = True
        mem7RB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        mem7RB.Location = New Point(8, 124)
        mem7RB.Margin = New Padding(4)
        mem7RB.Name = "mem7RB"
        mem7RB.Size = New Size(88, 23)
        mem7RB.TabIndex = 12
        mem7RB.TabStop = True
        mem7RB.Text = "7 Months"
        mem7RB.UseVisualStyleBackColor = True
        ' 
        ' mem3RB
        ' 
        mem3RB.AutoSize = True
        mem3RB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        mem3RB.Location = New Point(8, 93)
        mem3RB.Margin = New Padding(4)
        mem3RB.Name = "mem3RB"
        mem3RB.Size = New Size(88, 23)
        mem3RB.TabIndex = 11
        mem3RB.TabStop = True
        mem3RB.Text = "3 Months"
        mem3RB.UseVisualStyleBackColor = True
        ' 
        ' mem1RB
        ' 
        mem1RB.AutoSize = True
        mem1RB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        mem1RB.Location = New Point(8, 59)
        mem1RB.Margin = New Padding(4)
        mem1RB.Name = "mem1RB"
        mem1RB.Size = New Size(82, 23)
        mem1RB.TabIndex = 10
        mem1RB.TabStop = True
        mem1RB.Text = "1 Month"
        mem1RB.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(8, 20)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 26)
        Label1.TabIndex = 6
        Label1.Text = "Membership"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(mpCB)
        GroupBox3.Controls.Add(lockerCB)
        GroupBox3.Controls.Add(ptCB)
        GroupBox3.Location = New Point(7, 319)
        GroupBox3.Margin = New Padding(4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4)
        GroupBox3.Size = New Size(178, 96)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        ' 
        ' mpCB
        ' 
        mpCB.AutoSize = True
        mpCB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        mpCB.Location = New Point(87, 60)
        mpCB.Margin = New Padding(4)
        mpCB.Name = "mpCB"
        mpCB.Size = New Size(94, 23)
        mpCB.TabIndex = 13
        mpCB.Text = "Meal Plan"
        mpCB.UseVisualStyleBackColor = True
        ' 
        ' lockerCB
        ' 
        lockerCB.AutoSize = True
        lockerCB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lockerCB.Location = New Point(16, 60)
        lockerCB.Margin = New Padding(4)
        lockerCB.Name = "lockerCB"
        lockerCB.Size = New Size(73, 23)
        lockerCB.TabIndex = 12
        lockerCB.Text = "Locker"
        lockerCB.UseVisualStyleBackColor = True
        ' 
        ' ptCB
        ' 
        ptCB.AutoSize = True
        ptCB.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ptCB.Location = New Point(16, 23)
        ptCB.Margin = New Padding(4)
        ptCB.Name = "ptCB"
        ptCB.Size = New Size(138, 23)
        ptCB.TabIndex = 11
        ptCB.Text = "Personal Trainer"
        ptCB.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Button2)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(ListBox2)
        GroupBox4.Controls.Add(totalLbl)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(ListBox1)
        GroupBox4.Controls.Add(TextBox3)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(monthLbl)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Location = New Point(184, -13)
        GroupBox4.Margin = New Padding(4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4)
        GroupBox4.Size = New Size(400, 437)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(181, 390)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 31)
        Button2.TabIndex = 15
        Button2.Text = "Confirm"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(302, 313)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 19)
        Label10.TabIndex = 14
        Label10.Text = "1 Month"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(63, 313)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 19)
        Label8.TabIndex = 13
        Label8.Text = "1 Month"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft YaHei", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(120, 231)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(164, 21)
        Label7.TabIndex = 12
        Label7.Text = "Bronze (Discounted)"
        ' 
        ' ListBox2
        ' 
        ListBox2.BackColor = SystemColors.Control
        ListBox2.BorderStyle = BorderStyle.None
        ListBox2.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 19
        ListBox2.Location = New Point(63, 344)
        ListBox2.Margin = New Padding(4)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(307, 38)
        ListBox2.TabIndex = 11
        ' 
        ' totalLbl
        ' 
        totalLbl.AutoSize = True
        totalLbl.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        totalLbl.Location = New Point(216, 268)
        totalLbl.Margin = New Padding(4, 0, 4, 0)
        totalLbl.Name = "totalLbl"
        totalLbl.Size = New Size(41, 19)
        totalLbl.TabIndex = 10
        totalLbl.Text = "5000"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(140, 268)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 19)
        Label4.TabIndex = 9
        Label4.Text = "Total: ₱"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = SystemColors.Control
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 19
        ListBox1.Location = New Point(152, 136)
        ListBox1.Margin = New Padding(4)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(180, 76)
        ListBox1.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(152, 33)
        TextBox3.Margin = New Padding(4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(132, 22)
        TextBox3.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(55, 136)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 19)
        Label9.TabIndex = 4
        Label9.Text = "Addition:"
        ' 
        ' monthLbl
        ' 
        monthLbl.AutoSize = True
        monthLbl.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        monthLbl.Location = New Point(152, 79)
        monthLbl.Margin = New Padding(4, 0, 4, 0)
        monthLbl.Name = "monthLbl"
        monthLbl.Size = New Size(63, 19)
        monthLbl.TabIndex = 2
        monthLbl.Text = "1 Month"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(73, 33)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 19)
        Label6.TabIndex = 1
        Label6.Text = "Name:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(29, 79)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(97, 19)
        Label11.TabIndex = 0
        Label11.Text = "Membership:"
        ' 
        ' DashboardCashier
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(836, 466)
        Controls.Add(TabControl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "DashboardCashier"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DashboardCashier"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxProfileLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl.ResumeLayout(False)
        PointOfSale.ResumeLayout(False)
        AccountMonitoring.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SalesRecords.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnInventoryRecords As Button
    Friend WithEvents BtnSalesRecords As Button
    Friend WithEvents BtnMonitoring As Button
    Friend WithEvents BtnMembershipRegistration As Button
    Friend WithEvents BtnPOS As Button
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblFirstNameLastName As Label
    Friend WithEvents PicBoxProfileLogo As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents CurrentlyTimeIn As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnViewActiveMember As Button
    Friend WithEvents LblTotalMemberNumber As Label
    Friend WithEvents LblActiveMemberNumber As Label
    Friend WithEvents LblTotalMember As Label
    Friend WithEvents LblActiveMember As Label
    Friend WithEvents AttendanceRecords As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PbSearch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInputName As TextBox
    Friend WithEvents LvAttendance As ListView
    Friend WithEvents AccountMonitoring As TabPage
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LvTrainers As ListView
    Friend WithEvents SalesRecords As TabPage
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LvSales As ListView
    Friend WithEvents InventoryRecords As TabPage
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LvInventory As ListView
    Friend WithEvents PointOfSale As TabPage
    Friend WithEvents MembershipRegistration As TabPage
    Friend WithEvents LvAccountMonitoring As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bronzeCB As RadioButton
    Friend WithEvents goldCB As RadioButton
    Friend WithEvents silverCB As RadioButton
    Friend WithEvents noneCB As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents mem7RB As RadioButton
    Friend WithEvents mem3RB As RadioButton
    Friend WithEvents mem1RB As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mpCB As CheckBox
    Friend WithEvents lockerCB As CheckBox
    Friend WithEvents ptCB As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents totalLbl As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents monthLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
End Class
