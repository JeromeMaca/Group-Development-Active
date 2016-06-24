<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_user_control_permission
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.tv_useraccessmenu = New Telerik.WinControls.UI.RadTreeView()
        Me.txt_searchuser = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.tv_useraccessmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.tv_useraccessmenu)
        Me.gb_data.Controls.Add(Me.txt_searchuser)
        Me.gb_data.Controls.Add(Me.RadLabel4)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(2, 3)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(453, 605)
        Me.gb_data.TabIndex = 2
        '
        'tv_useraccessmenu
        '
        Me.tv_useraccessmenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tv_useraccessmenu.CheckBoxes = True
        Me.tv_useraccessmenu.Location = New System.Drawing.Point(5, 38)
        Me.tv_useraccessmenu.Name = "tv_useraccessmenu"
        Me.tv_useraccessmenu.Size = New System.Drawing.Size(443, 559)
        Me.tv_useraccessmenu.SpacingBetweenNodes = -1
        Me.tv_useraccessmenu.TabIndex = 123
        Me.tv_useraccessmenu.Text = "RadTreeView1"
        Me.tv_useraccessmenu.TriStateMode = True
        '
        'txt_searchuser
        '
        Me.txt_searchuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchuser.Location = New System.Drawing.Point(95, 13)
        Me.txt_searchuser.Name = "txt_searchuser"
        Me.txt_searchuser.NullText = "<System Generated>"
        Me.txt_searchuser.Size = New System.Drawing.Size(353, 20)
        Me.txt_searchuser.TabIndex = 122
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(5, 13)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(92, 19)
        Me.RadLabel4.TabIndex = 121
        Me.RadLabel4.Text = "User Fullname:"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(456, 3)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(486, 605)
        Me.RadGroupBox2.TabIndex = 4
        '
        'Frm_user_control_permission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 612)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.gb_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_user_control_permission"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_user_control_permission"
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.tv_useraccessmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_searchuser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tv_useraccessmenu As Telerik.WinControls.UI.RadTreeView
End Class

