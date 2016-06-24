<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Office2013LightTheme1 = New Telerik.WinControls.Themes.Office2013LightTheme()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.Windows7Theme1 = New Telerik.WinControls.Themes.Windows7Theme()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.txt_username = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_password = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_login = New Telerik.WinControls.UI.RadButton()
        Me.sbtn_themes = New Telerik.WinControls.UI.RadSplitButton()
        Me.defaultT = New Telerik.WinControls.UI.RadMenuItem()
        Me.MetroT = New Telerik.WinControls.UI.RadMenuItem()
        Me.MetroBT = New Telerik.WinControls.UI.RadMenuItem()
        Me.LightT = New Telerik.WinControls.UI.RadMenuItem()
        Me.DarkT = New Telerik.WinControls.UI.RadMenuItem()
        Me.LightT2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.win7 = New Telerik.WinControls.UI.RadMenuItem()
        Me.win8 = New Telerik.WinControls.UI.RadMenuItem()
        Me.btn_database = New Telerik.WinControls.UI.RadButton()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadDropDownMenu()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.office2010black = New Telerik.WinControls.UI.RadMenuItem()
        Me.office2010blue = New Telerik.WinControls.UI.RadMenuItem()
        Me.office2010silver = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbtn_themes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenuItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(-2, 2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(412, 193)
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(154, 42)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.NullText = "<Required>"
        Me.txt_username.Size = New System.Drawing.Size(238, 19)
        Me.txt_username.TabIndex = 1
        Me.txt_username.Text = "admin"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(133, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "&Username:"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(154, 87)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.NullText = "<Required>"
        Me.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_password.Size = New System.Drawing.Size(238, 19)
        Me.txt_password.TabIndex = 4
        Me.txt_password.Text = "1234"
        Me.txt_password.UseSystemPasswordChar = True
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(133, 65)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "&Password"
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_login.Location = New System.Drawing.Point(154, 124)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(110, 24)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Logi&n"
        '
        'sbtn_themes
        '
        Me.sbtn_themes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.sbtn_themes.Items.AddRange(New Telerik.WinControls.RadItem() {Me.defaultT, Me.MetroT, Me.MetroBT, Me.office2010blue, Me.office2010silver, Me.office2010black, Me.LightT, Me.DarkT, Me.LightT2, Me.win7, Me.win8})
        Me.sbtn_themes.Location = New System.Drawing.Point(282, 124)
        Me.sbtn_themes.Name = "sbtn_themes"
        Me.sbtn_themes.Size = New System.Drawing.Size(110, 24)
        Me.sbtn_themes.TabIndex = 6
        Me.sbtn_themes.Text = "&Appearance"
        '
        'defaultT
        '
        Me.defaultT.AccessibleDescription = "Default Theme"
        Me.defaultT.AccessibleName = "Default Theme"
        Me.defaultT.Name = "defaultT"
        Me.defaultT.Text = "Default Theme"
        '
        'MetroT
        '
        Me.MetroT.AccessibleDescription = "Metro Theme"
        Me.MetroT.AccessibleName = "Metro Theme"
        Me.MetroT.Name = "MetroT"
        Me.MetroT.Text = "Metro Theme"
        '
        'MetroBT
        '
        Me.MetroBT.AccessibleDescription = "Metro Blue Theme"
        Me.MetroBT.AccessibleName = "Metro Blue Theme"
        Me.MetroBT.Name = "MetroBT"
        Me.MetroBT.Text = "Metro Blue Theme"
        '
        'LightT
        '
        Me.LightT.AccessibleDescription = "2012 Light Theme"
        Me.LightT.AccessibleName = "2012 Light Theme"
        Me.LightT.Name = "LightT"
        Me.LightT.Text = "2012 Light Theme"
        '
        'DarkT
        '
        Me.DarkT.AccessibleDescription = "2012 Dark Theme"
        Me.DarkT.AccessibleName = "2012 Dark Theme"
        Me.DarkT.Name = "DarkT"
        Me.DarkT.Text = "2012 Dark Theme"
        '
        'LightT2
        '
        Me.LightT2.AccessibleDescription = "2013 Light Theme"
        Me.LightT2.AccessibleName = "2013 Light Theme"
        Me.LightT2.Name = "LightT2"
        Me.LightT2.Text = "2013 Light Theme"
        '
        'win7
        '
        Me.win7.AccessibleDescription = "Window 7 Theme"
        Me.win7.AccessibleName = "Window 7 Theme"
        Me.win7.Name = "win7"
        Me.win7.Text = "Window 7 Theme"
        '
        'win8
        '
        Me.win8.AccessibleDescription = "Window 8 Theme"
        Me.win8.AccessibleName = "Window 8 Theme"
        Me.win8.Name = "win8"
        Me.win8.Text = "Window 8 Theme"
        '
        'btn_database
        '
        Me.btn_database.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_database.Location = New System.Drawing.Point(154, 154)
        Me.btn_database.Name = "btn_database"
        Me.btn_database.Size = New System.Drawing.Size(238, 24)
        Me.btn_database.TabIndex = 7
        Me.btn_database.Text = "&Database"
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.AnimationEnabled = True
        Me.RadMenuItem1.AnimationFrames = 1
        Me.RadMenuItem1.AnimationType = Telerik.WinControls.UI.PopupAnimationTypes.Fade
        Me.RadMenuItem1.AutoSize = True
        Me.RadMenuItem1.DropDownAnimationDirection = Telerik.WinControls.UI.RadDirection.Down
        Me.RadMenuItem1.DropShadow = True
        Me.RadMenuItem1.EasingType = Telerik.WinControls.RadEasingType.InQuad
        Me.RadMenuItem1.EnableAeroEffects = False
        Me.RadMenuItem1.FadeAnimationFrames = 10
        Me.RadMenuItem1.FadeAnimationSpeed = 10
        Me.RadMenuItem1.FadeAnimationType = Telerik.WinControls.UI.FadeAnimationType.FadeIn
        Me.RadMenuItem1.FitToScreenMode = CType((Telerik.WinControls.UI.FitToScreenModes.FitWidth Or Telerik.WinControls.UI.FitToScreenModes.FitHeight), Telerik.WinControls.UI.FitToScreenModes)
        Me.RadMenuItem1.HorizontalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.SnapToOuterEdges
        Me.RadMenuItem1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenuItem1.Maximum = New System.Drawing.Size(0, 0)
        Me.RadMenuItem1.Minimum = New System.Drawing.Size(0, 0)
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Opacity = 1.0!
        Me.RadMenuItem1.ProcessKeyboard = False
        Me.RadMenuItem1.RollOverItemSelection = True
        Me.RadMenuItem1.Size = New System.Drawing.Size(0, 0)
        Me.RadMenuItem1.TabIndex = 0
        Me.RadMenuItem1.VerticalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.SnapToOuterEdges
        Me.RadMenuItem1.Visible = False
        '
        'office2010black
        '
        Me.office2010black.AccessibleDescription = "Office 2010 Black"
        Me.office2010black.AccessibleName = "Office 2010 Black"
        Me.office2010black.Name = "office2010black"
        Me.office2010black.Text = "Office 2010 Black"
        '
        'office2010blue
        '
        Me.office2010blue.AccessibleDescription = "Office 2010 Blue"
        Me.office2010blue.AccessibleName = "Office 2010 Blue"
        Me.office2010blue.Name = "office2010blue"
        Me.office2010blue.Text = "Office 2010 Blue"
        '
        'office2010silver
        '
        Me.office2010silver.AccessibleDescription = "Office 2010 Silver"
        Me.office2010silver.AccessibleName = "Office 2010 Silver"
        Me.office2010silver.Name = "office2010silver"
        Me.office2010silver.Text = "Office 2010 Silver"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 192)
        Me.Controls.Add(Me.btn_database)
        Me.Controls.Add(Me.sbtn_themes)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Login Window"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbtn_themes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenuItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2013LightTheme1 As Telerik.WinControls.Themes.Office2013LightTheme
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents Windows7Theme1 As Telerik.WinControls.Themes.Windows7Theme
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents txt_username As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_password As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_login As Telerik.WinControls.UI.RadButton
    Friend WithEvents sbtn_themes As Telerik.WinControls.UI.RadSplitButton
    Friend WithEvents btn_database As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadDropDownMenu
    Friend WithEvents MetroT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents MetroBT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents LightT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents DarkT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents LightT2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents win7 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents win8 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents defaultT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents office2010black As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents office2010blue As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents office2010silver As Telerik.WinControls.UI.RadMenuItem
End Class
