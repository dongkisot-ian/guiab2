<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        LblGuiyabGymManagement = New Label()
        Panel3 = New Panel()
        Label1 = New Label()
        TxtInputName = New TextBox()
        BtnTimeOut = New Button()
        BtnTimeIn = New Button()
        Timer1 = New Timer(components)
        BtnLogin = New Button()
        PicBoxLogin = New PictureBox()
        lblDateTime = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PicBoxLogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Info
        Panel1.Controls.Add(LblGuiyabGymManagement)
        Panel1.Location = New Point(-1, 0)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1195, 101)
        Panel1.TabIndex = 7
        ' 
        ' LblGuiyabGymManagement
        ' 
        LblGuiyabGymManagement.AutoSize = True
        LblGuiyabGymManagement.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        LblGuiyabGymManagement.Location = New Point(214, 11)
        LblGuiyabGymManagement.Margin = New Padding(4, 0, 4, 0)
        LblGuiyabGymManagement.Name = "LblGuiyabGymManagement"
        LblGuiyabGymManagement.Size = New Size(731, 76)
        LblGuiyabGymManagement.TabIndex = 2
        LblGuiyabGymManagement.Text = "Guiyab Gym Management"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(TxtInputName)
        Panel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.Location = New Point(262, 149)
        Panel3.Margin = New Padding(4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(654, 70)
        Panel3.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(6, 18)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 32)
        Label1.TabIndex = 1
        Label1.Text = "Enter Name:"
        ' 
        ' TxtInputName
        ' 
        TxtInputName.BackColor = SystemColors.MenuBar
        TxtInputName.Location = New Point(175, 14)
        TxtInputName.Margin = New Padding(4)
        TxtInputName.Name = "TxtInputName"
        TxtInputName.Size = New Size(463, 39)
        TxtInputName.TabIndex = 0
        ' 
        ' BtnTimeOut
        ' 
        BtnTimeOut.BackColor = Color.Red
        BtnTimeOut.FlatAppearance.BorderColor = Color.Black
        BtnTimeOut.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnTimeOut.FlatStyle = FlatStyle.Flat
        BtnTimeOut.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnTimeOut.ForeColor = SystemColors.ControlLightLight
        BtnTimeOut.Location = New Point(600, 394)
        BtnTimeOut.Margin = New Padding(4)
        BtnTimeOut.Name = "BtnTimeOut"
        BtnTimeOut.Size = New Size(316, 145)
        BtnTimeOut.TabIndex = 12
        BtnTimeOut.Text = "Time Out"
        BtnTimeOut.UseVisualStyleBackColor = False
        ' 
        ' BtnTimeIn
        ' 
        BtnTimeIn.BackColor = Color.Green
        BtnTimeIn.FlatAppearance.BorderColor = Color.Black
        BtnTimeIn.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnTimeIn.FlatStyle = FlatStyle.Flat
        BtnTimeIn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnTimeIn.ForeColor = SystemColors.ControlLightLight
        BtnTimeIn.Location = New Point(262, 394)
        BtnTimeIn.Margin = New Padding(4)
        BtnTimeIn.Name = "BtnTimeIn"
        BtnTimeIn.Size = New Size(316, 145)
        BtnTimeIn.TabIndex = 11
        BtnTimeIn.Text = "Time In"
        BtnTimeIn.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.Info
        BtnLogin.FlatAppearance.BorderColor = Color.Black
        BtnLogin.FlatAppearance.MouseDownBackColor = Color.Gray
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.ForeColor = SystemColors.ControlText
        BtnLogin.Location = New Point(982, 660)
        BtnLogin.Margin = New Padding(4)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(141, 59)
        BtnLogin.TabIndex = 14
        BtnLogin.Text = "Login"
        BtnLogin.TextAlign = ContentAlignment.MiddleLeft
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' PicBoxLogin
        ' 
        PicBoxLogin.BackColor = SystemColors.Info
        PicBoxLogin.BackgroundImage = My.Resources.Resources.log_in
        PicBoxLogin.BackgroundImageLayout = ImageLayout.Zoom
        PicBoxLogin.Location = New Point(1074, 668)
        PicBoxLogin.Margin = New Padding(4)
        PicBoxLogin.Name = "PicBoxLogin"
        PicBoxLogin.Size = New Size(44, 44)
        PicBoxLogin.TabIndex = 15
        PicBoxLogin.TabStop = False
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Font = New Font("Courier New", 36F, FontStyle.Regular, GraphicsUnit.Point)
        lblDateTime.Location = New Point(141, 257)
        lblDateTime.Margin = New Padding(4, 0, 4, 0)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(1108, 77)
        lblDateTime.TabIndex = 13
        lblDateTime.Text = "Date-Month-Year  00:00:00"
        lblDateTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1194, 778)
        Controls.Add(PicBoxLogin)
        Controls.Add(BtnLogin)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(lblDateTime)
        Controls.Add(BtnTimeOut)
        Controls.Add(BtnTimeIn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PicBoxLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblGuiyabGymManagement As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInputName As TextBox
    Friend WithEvents BtnTimeOut As Button
    Friend WithEvents BtnTimeIn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnLogin As Button
    Friend WithEvents PicBoxLogin As PictureBox
    Friend WithEvents lblDateTime As Label
End Class
