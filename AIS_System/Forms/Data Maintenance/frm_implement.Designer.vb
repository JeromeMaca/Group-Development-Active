<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_implement
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
        Me.cb_imp_ownername = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.txt_implement_desc = New Telerik.WinControls.UI.RadTextBox()
        Me.cb_implement_owner = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.cms_impl_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.imp_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.owner_id_i = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.owner_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.impl_desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_implements = New System.Windows.Forms.ListView()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_addname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_imp_ownername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_implement_desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_implement_owner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_impl_menu.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.btn_addname)
        Me.RadGroupBox1.Controls.Add(Me.cb_imp_ownername)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.btn_cancel)
        Me.RadGroupBox1.Controls.Add(Me.btn_save)
        Me.RadGroupBox1.Controls.Add(Me.txt_implement_desc)
        Me.RadGroupBox1.Controls.Add(Me.cb_implement_owner)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(815, 142)
        Me.RadGroupBox1.TabIndex = 1
        '
        'btn_addname
        '
        Me.btn_addname.Location = New System.Drawing.Point(418, 45)
        Me.btn_addname.Name = "btn_addname"
        Me.btn_addname.Size = New System.Drawing.Size(71, 24)
        Me.btn_addname.TabIndex = 13
        Me.btn_addname.Text = "Add Name"
        '
        'cb_imp_ownername
        '
        Me.cb_imp_ownername.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cb_imp_ownername.Location = New System.Drawing.Point(136, 48)
        Me.cb_imp_ownername.Name = "cb_imp_ownername"
        Me.cb_imp_ownername.Size = New System.Drawing.Size(275, 20)
        Me.cb_imp_ownername.TabIndex = 12
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
        Me.btn_cancel.Location = New System.Drawing.Point(379, 105)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(263, 105)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 24)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Save"
        '
        'txt_implement_desc
        '
        Me.txt_implement_desc.Location = New System.Drawing.Point(136, 74)
        Me.txt_implement_desc.Name = "txt_implement_desc"
        Me.txt_implement_desc.NullText = "<Required>"
        Me.txt_implement_desc.Size = New System.Drawing.Size(353, 20)
        Me.txt_implement_desc.TabIndex = 2
        '
        'cb_implement_owner
        '
        Me.cb_implement_owner.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "CAT - Central Azucarera De Tarlac"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Agrikulto Inc."
        RadListDataItem2.TextWrap = True
        RadListDataItem3.Text = "SUBCON"
        RadListDataItem3.TextWrap = True
        Me.cb_implement_owner.Items.Add(RadListDataItem1)
        Me.cb_implement_owner.Items.Add(RadListDataItem2)
        Me.cb_implement_owner.Items.Add(RadListDataItem3)
        Me.cb_implement_owner.Location = New System.Drawing.Point(136, 20)
        Me.cb_implement_owner.Name = "cb_implement_owner"
        Me.cb_implement_owner.NullText = "<Requird>"
        Me.cb_implement_owner.Size = New System.Drawing.Size(226, 20)
        Me.cb_implement_owner.TabIndex = 0
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(31, 74)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(90, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Implement Desc."
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(31, 22)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(99, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Implement Owner:"
        '
        'cms_impl_menu
        '
        Me.cms_impl_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms_impl_menu.Name = "cms_impl_menu"
        Me.cms_impl_menu.Size = New System.Drawing.Size(114, 98)
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
        'imp_id
        '
        Me.imp_id.Text = "ID"
        Me.imp_id.Width = 0
        '
        'owner_id_i
        '
        Me.owner_id_i.Text = "owner_id"
        Me.owner_id_i.Width = 0
        '
        'count
        '
        Me.count.Text = "#"
        Me.count.Width = 40
        '
        'owner_name
        '
        Me.owner_name.Text = "Implement Owner Name"
        Me.owner_name.Width = 250
        '
        'impl_desc
        '
        Me.impl_desc.Text = "Implement Description"
        Me.impl_desc.Width = 1080
        '
        'lv_implements
        '
        Me.lv_implements.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_implements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv_implements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.imp_id, Me.owner_id_i, Me.count, Me.owner_name, Me.impl_desc})
        Me.lv_implements.FullRowSelect = True
        Me.lv_implements.GridLines = True
        Me.lv_implements.Location = New System.Drawing.Point(0, 148)
        Me.lv_implements.Name = "lv_implements"
        Me.lv_implements.Size = New System.Drawing.Size(815, 334)
        Me.lv_implements.TabIndex = 2
        Me.lv_implements.UseCompatibleStateImageBehavior = False
        Me.lv_implements.View = System.Windows.Forms.View.Details
        '
        'Frm_implement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 484)
        Me.Controls.Add(Me.lv_implements)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Frm_implement"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_implement"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btn_addname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_imp_ownername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_implement_desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_implement_owner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_impl_menu.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_addname As Telerik.WinControls.UI.RadButton
    Friend WithEvents cb_imp_ownername As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_implement_desc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cb_implement_owner As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cms_impl_menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents imp_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents owner_id_i As System.Windows.Forms.ColumnHeader
    Friend WithEvents count As System.Windows.Forms.ColumnHeader
    Friend WithEvents owner_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents impl_desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents lv_implements As System.Windows.Forms.ListView
End Class

