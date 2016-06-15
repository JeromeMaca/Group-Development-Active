<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_equipment
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_addname = New Telerik.WinControls.UI.RadButton()
        Me.cb_ownername = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.txt_equipmentfuelcapacity = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_equipmentdriver = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_equipment_desc = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_equipmentno = New Telerik.WinControls.UI.RadTextBox()
        Me.cb_equipment_owner = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_equipments = New System.Windows.Forms.ListView()
        Me.e_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.owner_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.equip_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.equip_desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.equip_driver = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.equip_fuelcap = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.owner_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_equipmentcon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_addname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_ownername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipmentfuelcapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipmentdriver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipment_desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipmentno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_equipment_owner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_equipmentcon.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.btn_addname)
        Me.RadGroupBox1.Controls.Add(Me.cb_ownername)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.btn_cancel)
        Me.RadGroupBox1.Controls.Add(Me.btn_save)
        Me.RadGroupBox1.Controls.Add(Me.txt_equipmentfuelcapacity)
        Me.RadGroupBox1.Controls.Add(Me.txt_equipmentdriver)
        Me.RadGroupBox1.Controls.Add(Me.txt_equipment_desc)
        Me.RadGroupBox1.Controls.Add(Me.txt_equipmentno)
        Me.RadGroupBox1.Controls.Add(Me.cb_equipment_owner)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(990, 227)
        Me.RadGroupBox1.TabIndex = 0
        '
        'btn_addname
        '
        Me.btn_addname.Location = New System.Drawing.Point(418, 45)
        Me.btn_addname.Name = "btn_addname"
        Me.btn_addname.Size = New System.Drawing.Size(71, 24)
        Me.btn_addname.TabIndex = 13
        Me.btn_addname.Text = "Add Name"
        '
        'cb_ownername
        '
        Me.cb_ownername.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cb_ownername.Location = New System.Drawing.Point(136, 48)
        Me.cb_ownername.Name = "cb_ownername"
        Me.cb_ownername.Size = New System.Drawing.Size(275, 20)
        Me.cb_ownername.TabIndex = 12
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(31, 50)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel6.TabIndex = 11
        Me.RadLabel6.Text = "Owner Name:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(252, 187)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(136, 187)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 24)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Save"
        '
        'txt_equipmentfuelcapacity
        '
        Me.txt_equipmentfuelcapacity.Location = New System.Drawing.Point(136, 152)
        Me.txt_equipmentfuelcapacity.Name = "txt_equipmentfuelcapacity"
        Me.txt_equipmentfuelcapacity.NullText = "<Required>"
        Me.txt_equipmentfuelcapacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_equipmentfuelcapacity.Size = New System.Drawing.Size(110, 20)
        Me.txt_equipmentfuelcapacity.TabIndex = 8
        '
        'txt_equipmentdriver
        '
        Me.txt_equipmentdriver.Location = New System.Drawing.Point(136, 126)
        Me.txt_equipmentdriver.Name = "txt_equipmentdriver"
        Me.txt_equipmentdriver.NullText = "<Required>"
        Me.txt_equipmentdriver.Size = New System.Drawing.Size(368, 20)
        Me.txt_equipmentdriver.TabIndex = 6
        '
        'txt_equipment_desc
        '
        Me.txt_equipment_desc.Location = New System.Drawing.Point(136, 100)
        Me.txt_equipment_desc.Name = "txt_equipment_desc"
        Me.txt_equipment_desc.NullText = "<Required>"
        Me.txt_equipment_desc.Size = New System.Drawing.Size(368, 20)
        Me.txt_equipment_desc.TabIndex = 4
        '
        'txt_equipmentno
        '
        Me.txt_equipmentno.Location = New System.Drawing.Point(136, 74)
        Me.txt_equipmentno.Name = "txt_equipmentno"
        Me.txt_equipmentno.NullText = "<Required>"
        Me.txt_equipmentno.Size = New System.Drawing.Size(353, 20)
        Me.txt_equipmentno.TabIndex = 2
        '
        'cb_equipment_owner
        '
        Me.cb_equipment_owner.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "CAT - Central Azucarera De Tarlac"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Agrikulto Inc."
        RadListDataItem2.TextWrap = True
        RadListDataItem3.Text = "SUBCON"
        RadListDataItem3.TextWrap = True
        Me.cb_equipment_owner.Items.Add(RadListDataItem1)
        Me.cb_equipment_owner.Items.Add(RadListDataItem2)
        Me.cb_equipment_owner.Items.Add(RadListDataItem3)
        Me.cb_equipment_owner.Location = New System.Drawing.Point(136, 20)
        Me.cb_equipment_owner.Name = "cb_equipment_owner"
        Me.cb_equipment_owner.NullText = "<Requird>"
        Me.cb_equipment_owner.Size = New System.Drawing.Size(226, 20)
        Me.cb_equipment_owner.TabIndex = 0
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(31, 152)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(106, 18)
        Me.RadLabel5.TabIndex = 7
        Me.RadLabel5.Text = "Fuel Capacity /LTRS:"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(31, 126)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(96, 18)
        Me.RadLabel4.TabIndex = 5
        Me.RadLabel4.Text = "Equipment Driver:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(31, 100)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(92, 18)
        Me.RadLabel3.TabIndex = 3
        Me.RadLabel3.Text = "Equipment Desc.:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(31, 74)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(81, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Equipment No."
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(31, 22)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(99, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Equipment Owner:"
        '
        'lv_equipments
        '
        Me.lv_equipments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_equipments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.e_id, Me.count, Me.owner_name, Me.equip_no, Me.equip_desc, Me.equip_driver, Me.equip_fuelcap, Me.owner_id})
        Me.lv_equipments.FullRowSelect = True
        Me.lv_equipments.GridLines = True
        Me.lv_equipments.Location = New System.Drawing.Point(0, 233)
        Me.lv_equipments.Name = "lv_equipments"
        Me.lv_equipments.Size = New System.Drawing.Size(990, 338)
        Me.lv_equipments.TabIndex = 1
        Me.lv_equipments.UseCompatibleStateImageBehavior = False
        Me.lv_equipments.View = System.Windows.Forms.View.Details
        '
        'e_id
        '
        Me.e_id.Text = "ID"
        Me.e_id.Width = 0
        '
        'count
        '
        Me.count.Text = "#"
        Me.count.Width = 40
        '
        'owner_name
        '
        Me.owner_name.Text = "Owner Name"
        Me.owner_name.Width = 250
        '
        'equip_no
        '
        Me.equip_no.Text = "Equipment No."
        Me.equip_no.Width = 180
        '
        'equip_desc
        '
        Me.equip_desc.Text = "Equipment Description"
        Me.equip_desc.Width = 300
        '
        'equip_driver
        '
        Me.equip_driver.Text = "Equipment Driver"
        Me.equip_driver.Width = 200
        '
        'equip_fuelcap
        '
        Me.equip_fuelcap.Text = "Equipment Fuel Capacity (LITER)"
        Me.equip_fuelcap.Width = 380
        '
        'owner_id
        '
        Me.owner_id.Text = "owner_ids"
        Me.owner_id.Width = 0
        '
        'cms_equipmentcon
        '
        Me.cms_equipmentcon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms_equipmentcon.Name = "cms_equipmentcon"
        Me.cms_equipmentcon.Size = New System.Drawing.Size(114, 98)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Frm_equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 572)
        Me.Controls.Add(Me.lv_equipments)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Frm_equipment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_equipment"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btn_addname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_ownername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipmentfuelcapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipmentdriver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipment_desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipmentno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_equipment_owner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_equipmentcon.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lv_equipments As System.Windows.Forms.ListView
    Friend WithEvents cb_equipment_owner As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_equipmentfuelcapacity As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_equipmentdriver As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_equipment_desc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_equipmentno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_addname As Telerik.WinControls.UI.RadButton
    Friend WithEvents cb_ownername As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents e_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents count As System.Windows.Forms.ColumnHeader
    Friend WithEvents owner_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents equip_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents equip_desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents equip_driver As System.Windows.Forms.ColumnHeader
    Friend WithEvents equip_fuelcap As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_equipmentcon As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents owner_id As System.Windows.Forms.ColumnHeader
End Class

