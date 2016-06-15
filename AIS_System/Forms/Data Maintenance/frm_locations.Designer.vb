<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_locations
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
        Me.components = New System.ComponentModel.Container()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_add = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.txt_culture = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_code = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.cb_loc_desc = New Telerik.WinControls.UI.RadDropDownList()
        Me.sp_area = New Telerik.WinControls.UI.RadSpinEditor()
        Me.lv_location = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_locationMaster = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_culture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_loc_desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_area, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_locationMaster.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.lv_location)
        Me.RadGroupBox1.Controls.Add(Me.sp_area)
        Me.RadGroupBox1.Controls.Add(Me.cb_loc_desc)
        Me.RadGroupBox1.Controls.Add(Me.btn_add)
        Me.RadGroupBox1.Controls.Add(Me.btn_cancel)
        Me.RadGroupBox1.Controls.Add(Me.btn_save)
        Me.RadGroupBox1.Controls.Add(Me.txt_culture)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.txt_code)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(1011, 518)
        Me.RadGroupBox1.TabIndex = 0
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(232, 69)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(110, 24)
        Me.btn_add.TabIndex = 13
        Me.btn_add.Text = "Add Location"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(232, 151)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 12
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(114, 151)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 24)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save"
        '
        'txt_culture
        '
        Me.txt_culture.Location = New System.Drawing.Point(82, 122)
        Me.txt_culture.Name = "txt_culture"
        Me.txt_culture.NullText = "<Required>"
        Me.txt_culture.Size = New System.Drawing.Size(196, 20)
        Me.txt_culture.TabIndex = 8
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(31, 124)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "Culture:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(31, 100)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(77, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Location Area:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(31, 51)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(111, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Location Description:"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(95, 24)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.NullText = "<Required>"
        Me.txt_code.Size = New System.Drawing.Size(183, 20)
        Me.txt_code.TabIndex = 2
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(31, 26)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Area Code:"
        '
        'cb_loc_desc
        '
        Me.cb_loc_desc.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cb_loc_desc.Location = New System.Drawing.Point(147, 48)
        Me.cb_loc_desc.Name = "cb_loc_desc"
        Me.cb_loc_desc.Size = New System.Drawing.Size(195, 20)
        Me.cb_loc_desc.TabIndex = 14
        '
        'sp_area
        '
        Me.sp_area.DecimalPlaces = 4
        Me.sp_area.Location = New System.Drawing.Point(114, 99)
        Me.sp_area.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.sp_area.Name = "sp_area"
        Me.sp_area.Size = New System.Drawing.Size(164, 20)
        Me.sp_area.TabIndex = 15
        Me.sp_area.TabStop = False
        Me.sp_area.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.sp_area.ThousandsSeparator = True
        '
        'lv_location
        '
        Me.lv_location.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_location.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lv_location.FullRowSelect = True
        Me.lv_location.GridLines = True
        Me.lv_location.Location = New System.Drawing.Point(5, 181)
        Me.lv_location.Name = "lv_location"
        Me.lv_location.Size = New System.Drawing.Size(1001, 332)
        Me.lv_location.TabIndex = 16
        Me.lv_location.UseCompatibleStateImageBehavior = False
        Me.lv_location.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "#"
        Me.ColumnHeader2.Width = 40
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Code"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Location Description"
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Area"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Culture"
        Me.ColumnHeader6.Width = 120
        '
        'cms_locationMaster
        '
        Me.cms_locationMaster.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms_locationMaster.Name = "cms_addcategory"
        Me.cms_locationMaster.Size = New System.Drawing.Size(114, 92)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = ""
        Me.ColumnHeader7.Width = 700
        '
        'Frm_locations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 520)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Frm_locations"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_locations"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_culture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_loc_desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_area, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_locationMaster.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_code As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_culture As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_add As Telerik.WinControls.UI.RadButton
    Friend WithEvents cb_loc_desc As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents sp_area As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents lv_location As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_locationMaster As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class

