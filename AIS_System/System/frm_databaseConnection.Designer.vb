<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_databaseConnection
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
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.txt_servername = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.chk_authentication = New Telerik.WinControls.UI.RadCheckBox()
        Me.txt_serverusername = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_serverpass = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.cb_serverdatabasename = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_reset = New Telerik.WinControls.UI.RadButton()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_servername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_authentication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_serverusername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_serverpass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_serverdatabasename, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_reset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(106, 176)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 24)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Save"
        '
        'txt_servername
        '
        Me.txt_servername.Location = New System.Drawing.Point(23, 33)
        Me.txt_servername.Name = "txt_servername"
        Me.txt_servername.Size = New System.Drawing.Size(260, 19)
        Me.txt_servername.TabIndex = 1
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(141, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Server Name (IP ADDRESS)"
        '
        'chk_authentication
        '
        Me.chk_authentication.Location = New System.Drawing.Point(163, 58)
        Me.chk_authentication.Name = "chk_authentication"
        Me.chk_authentication.Size = New System.Drawing.Size(120, 18)
        Me.chk_authentication.TabIndex = 2
        Me.chk_authentication.Text = "With Authentication"
        '
        'txt_serverusername
        '
        Me.txt_serverusername.Enabled = False
        Me.txt_serverusername.Location = New System.Drawing.Point(77, 82)
        Me.txt_serverusername.Name = "txt_serverusername"
        Me.txt_serverusername.Size = New System.Drawing.Size(206, 19)
        Me.txt_serverusername.TabIndex = 4
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 83)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Username:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 107)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(56, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Password:"
        '
        'txt_serverpass
        '
        Me.txt_serverpass.Enabled = False
        Me.txt_serverpass.Location = New System.Drawing.Point(77, 106)
        Me.txt_serverpass.Name = "txt_serverpass"
        Me.txt_serverpass.Size = New System.Drawing.Size(206, 19)
        Me.txt_serverpass.TabIndex = 6
        '
        'cb_serverdatabasename
        '
        Me.cb_serverdatabasename.Location = New System.Drawing.Point(106, 140)
        Me.cb_serverdatabasename.Name = "cb_serverdatabasename"
        Me.cb_serverdatabasename.Size = New System.Drawing.Size(177, 20)
        Me.cb_serverdatabasename.TabIndex = 8
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(12, 140)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(88, 18)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "Database Name:"
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(196, 176)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(84, 24)
        Me.btn_reset.TabIndex = 10
        Me.btn_reset.Text = "Reset"
        '
        'Frm_databaseConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 216)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.cb_serverdatabasename)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.txt_serverpass)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.txt_serverusername)
        Me.Controls.Add(Me.chk_authentication)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_servername)
        Me.Controls.Add(Me.RadLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_databaseConnection"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Database Connection Setup"
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_servername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_authentication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_serverusername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_serverpass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_serverdatabasename, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_reset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_servername As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents chk_authentication As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents txt_serverusername As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_serverpass As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents cb_serverdatabasename As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_reset As Telerik.WinControls.UI.RadButton
End Class

