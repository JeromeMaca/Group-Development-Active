<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_masterlist_location_addexisting
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
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.dp_lot_code = New Telerik.WinControls.UI.RadDropDownList()
        Me.txt_current_area = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_loc_desc = New Telerik.WinControls.UI.RadDropDownList()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_edit_save = New Telerik.WinControls.UI.RadButton()
        Me.sp_area = New Telerik.WinControls.UI.RadSpinEditor()
        Me.txt_new_code = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_existing_code = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_new_area = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.dp_lot_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_current_area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_loc_desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.btn_edit_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_new_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_existing_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_new_area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.dp_lot_code)
        Me.gb_menu.Controls.Add(Me.txt_current_area)
        Me.gb_menu.Controls.Add(Me.RadLabel5)
        Me.gb_menu.Controls.Add(Me.RadLabel2)
        Me.gb_menu.Controls.Add(Me.RadLabel1)
        Me.gb_menu.Controls.Add(Me.dp_loc_desc)
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(1, 0)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(319, 131)
        Me.gb_menu.TabIndex = 5
        '
        'dp_lot_code
        '
        Me.dp_lot_code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_lot_code.Location = New System.Drawing.Point(69, 59)
        Me.dp_lot_code.Name = "dp_lot_code"
        '
        '
        '
        Me.dp_lot_code.RootElement.StretchVertically = True
        Me.dp_lot_code.Size = New System.Drawing.Size(233, 20)
        Me.dp_lot_code.TabIndex = 55
        '
        'txt_current_area
        '
        Me.txt_current_area.Location = New System.Drawing.Point(136, 87)
        Me.txt_current_area.Name = "txt_current_area"
        Me.txt_current_area.NullText = "<System Generated>"
        Me.txt_current_area.Size = New System.Drawing.Size(166, 20)
        Me.txt_current_area.TabIndex = 54
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel5.Location = New System.Drawing.Point(12, 90)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(126, 18)
        Me.RadLabel5.TabIndex = 53
        Me.RadLabel5.Text = "Current Area Measure:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(12, 11)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(119, 18)
        Me.RadLabel2.TabIndex = 18
        Me.RadLabel2.Text = "Location Description:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(12, 59)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(57, 18)
        Me.RadLabel1.TabIndex = 16
        Me.RadLabel1.Text = "Lot Code:"
        '
        'dp_loc_desc
        '
        Me.dp_loc_desc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_loc_desc.Location = New System.Drawing.Point(12, 32)
        Me.dp_loc_desc.Name = "dp_loc_desc"
        '
        '
        '
        Me.dp_loc_desc.RootElement.StretchVertically = True
        Me.dp_loc_desc.Size = New System.Drawing.Size(290, 20)
        Me.dp_loc_desc.TabIndex = 23
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.Location = New System.Drawing.Point(521, 8)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.Location = New System.Drawing.Point(405, 8)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 24)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Save"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.btn_save)
        Me.RadGroupBox1.Controls.Add(Me.btn_cancel)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(1, 131)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(638, 40)
        Me.RadGroupBox1.TabIndex = 6
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.btn_edit_save)
        Me.RadGroupBox2.Controls.Add(Me.sp_area)
        Me.RadGroupBox2.Controls.Add(Me.txt_new_code)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel7)
        Me.RadGroupBox2.Controls.Add(Me.txt_existing_code)
        Me.RadGroupBox2.Controls.Add(Me.txt_new_area)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(319, 0)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(320, 131)
        Me.RadGroupBox2.TabIndex = 7
        '
        'btn_edit_save
        '
        Me.btn_edit_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit_save.Enabled = False
        Me.btn_edit_save.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_edit_save.Location = New System.Drawing.Point(268, 12)
        Me.btn_edit_save.Name = "btn_edit_save"
        Me.btn_edit_save.Size = New System.Drawing.Size(41, 25)
        Me.btn_edit_save.TabIndex = 59
        Me.btn_edit_save.Text = "Edit"
        '
        'sp_area
        '
        Me.sp_area.DecimalPlaces = 4
        Me.sp_area.Location = New System.Drawing.Point(116, 88)
        Me.sp_area.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.sp_area.Name = "sp_area"
        '
        '
        '
        Me.sp_area.RootElement.StretchVertically = True
        Me.sp_area.Size = New System.Drawing.Size(83, 20)
        Me.sp_area.TabIndex = 58
        Me.sp_area.TabStop = False
        Me.sp_area.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.sp_area.ThousandsSeparator = True
        '
        'txt_new_code
        '
        Me.txt_new_code.Location = New System.Drawing.Point(116, 64)
        Me.txt_new_code.Name = "txt_new_code"
        Me.txt_new_code.NullText = "<Required>"
        Me.txt_new_code.Size = New System.Drawing.Size(193, 20)
        Me.txt_new_code.TabIndex = 57
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel7.Location = New System.Drawing.Point(49, 40)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel7.TabIndex = 56
        Me.RadLabel7.Text = "New Area:"
        '
        'txt_existing_code
        '
        Me.txt_existing_code.Location = New System.Drawing.Point(116, 15)
        Me.txt_existing_code.Name = "txt_existing_code"
        Me.txt_existing_code.NullText = "<System Generated>"
        Me.txt_existing_code.ReadOnly = True
        Me.txt_existing_code.Size = New System.Drawing.Size(155, 20)
        Me.txt_existing_code.TabIndex = 55
        '
        'txt_new_area
        '
        Me.txt_new_area.Location = New System.Drawing.Point(116, 41)
        Me.txt_new_area.Name = "txt_new_area"
        Me.txt_new_area.NullText = "<System Generated>"
        Me.txt_new_area.ReadOnly = True
        Me.txt_new_area.Size = New System.Drawing.Size(124, 20)
        Me.txt_new_area.TabIndex = 55
        '
        'RadLabel3
        '
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(32, 90)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(78, 18)
        Me.RadLabel3.TabIndex = 53
        Me.RadLabel3.Text = "Divided Area:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(12, 17)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(102, 18)
        Me.RadLabel4.TabIndex = 18
        Me.RadLabel4.Text = "Existing Lot Code:"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(12, 64)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(102, 18)
        Me.RadLabel6.TabIndex = 16
        Me.RadLabel6.Text = "New Added Code:"
        '
        'Frm_masterlist_location_addexisting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 171)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.gb_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_masterlist_location_addexisting"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_masterlist_location_addexisting"
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.dp_lot_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_current_area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_loc_desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.btn_edit_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_new_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_existing_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_new_area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_current_area As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents dp_loc_desc As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dp_lot_code As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_existing_code As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_new_area As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_new_code As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents sp_area As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents btn_edit_save As Telerik.WinControls.UI.RadButton
End Class

