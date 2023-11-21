<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        PicBoxGuiyabLogo = New PictureBox()
        BtnForgotPassword = New Button()
        BtnLogin = New Button()
        LblPassword = New Label()
        LblUsername = New Label()
        TxtPassword = New TextBox()
        TxtUsername = New TextBox()
        Panel1.SuspendLayout()
        CType(PicBoxGuiyabLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuBar
        Panel1.Controls.Add(PicBoxGuiyabLogo)
        Panel1.Controls.Add(BtnForgotPassword)
        Panel1.Controls.Add(BtnLogin)
        Panel1.Controls.Add(LblPassword)
        Panel1.Controls.Add(LblUsername)
        Panel1.Controls.Add(TxtPassword)
        Panel1.Controls.Add(TxtUsername)
        Panel1.Location = New Point(298, 151)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(606, 450)
        Panel1.Location = New Point(208, 91)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 270)
        Panel1.TabIndex = 0

        PicBoxGuiyabLogo.BackgroundImage = My.Resources.Resources.Guiyab_Gym_Logo___transparent
        PicBoxGuiyabLogo.BackgroundImageLayout = ImageLayout.Zoom

        PicBoxGuiyabLogo.Location = New Point(218, 4)
        PicBoxGuiyabLogo.Margin = New Padding(4)
        PicBoxGuiyabLogo.Name = "PicBoxGuiyabLogo"
        PicBoxGuiyabLogo.Size = New Size(185, 164)

        PicBoxGuiyabLogo.Location = New Point(152, 2)
        PicBoxGuiyabLogo.Margin = New Padding(3, 2, 3, 2)
        PicBoxGuiyabLogo.Name = "PicBoxGuiyabLogo"
        PicBoxGuiyabLogo.Size = New Size(130, 98)

        PicBoxGuiyabLogo.TabIndex = 11
        PicBoxGuiyabLogo.TabStop = False
        ' 
        ' BtnForgotPassword
        ' 
        BtnForgotPassword.FlatAppearance.BorderSize = 0
        BtnForgotPassword.FlatStyle = FlatStyle.Flat
        BtnForgotPassword.Font = New Font("Segoe UI Semilight", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point)

        BtnForgotPassword.Location = New Point(436, 245)
        BtnForgotPassword.Margin = New Padding(4)
        BtnForgotPassword.Name = "BtnForgotPassword"
        BtnForgotPassword.Size = New Size(150, 35)

        BtnForgotPassword.Location = New Point(118, 220)
        BtnForgotPassword.Margin = New Padding(3, 2, 3, 2)
        BtnForgotPassword.Name = "BtnForgotPassword"
        BtnForgotPassword.Size = New Size(105, 21)

        BtnForgotPassword.TabIndex = 10
        BtnForgotPassword.Text = "Forgot Password?"
        BtnForgotPassword.TextAlign = ContentAlignment.BottomCenter
        BtnForgotPassword.UseVisualStyleBackColor = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.ActiveBorder
        BtnLogin.Cursor = Cursors.Hand
        BtnLogin.FlatStyle = FlatStyle.Popup
        BtnLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), Image)
        BtnLogin.ImageAlign = ContentAlignment.MiddleLeft

        BtnLogin.Location = New Point(475, 359)
        BtnLogin.Margin = New Padding(4, 5, 4, 5)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(100, 45)

        BtnLogin.Location = New Point(332, 215)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(70, 27)

        BtnLogin.TabIndex = 9
        BtnLogin.Text = "Login"
        BtnLogin.TextAlign = ContentAlignment.MiddleRight
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)

        LblPassword.Location = New Point(48, 285)
        LblPassword.Margin = New Padding(4, 0, 4, 0)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(122, 32)

        LblPassword.Location = New Point(33, 171)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(83, 21)

        LblPassword.TabIndex = 8
        LblPassword.Text = "Password:"
        ' 
        ' LblUsername
        ' 
        LblUsername.AutoSize = True
        LblUsername.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)

        LblUsername.Location = New Point(45, 201)
        LblUsername.Margin = New Padding(4, 0, 4, 0)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(129, 32)

        LblUsername.Location = New Point(32, 121)
        LblUsername.Name = "LblUsername"
        LblUsername.Size = New Size(86, 21)

        LblUsername.TabIndex = 7
        LblUsername.Text = "Username:"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Cursor = Cursors.IBeam
        TxtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)

        TxtPassword.Location = New Point(181, 278)
        TxtPassword.Margin = New Padding(4, 5, 4, 5)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "•"c
        TxtPassword.Size = New Size(393, 36)

        TxtPassword.Location = New Point(127, 166)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "•"c
        TxtPassword.Size = New Size(276, 27)

        TxtPassword.TabIndex = 6
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Cursor = Cursors.IBeam
        TxtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)

        TxtUsername.Location = New Point(181, 194)
        TxtUsername.Margin = New Padding(4, 5, 4, 5)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(393, 36)

        TxtUsername.Location = New Point(127, 116)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(276, 27)

        TxtUsername.TabIndex = 5
        ' 
        ' Login
        ' 

        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1194, 778)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)

        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(836, 466)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)

        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PicBoxGuiyabLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents BtnForgotPassword As Button
    Friend WithEvents PicBoxGuiyabLogo As PictureBox
End Class
