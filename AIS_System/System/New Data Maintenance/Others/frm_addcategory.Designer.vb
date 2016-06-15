<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_addcategory
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
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_newoperationCat = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.cmssub_refresh = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmssub_add = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmssub_update = New Telerik.WinControls.UI.RadMenuItem()
        Me.cmssub_delete = New Telerik.WinControls.UI.RadMenuItem()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.count_no = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lv_addcategory = New System.Windows.Forms.ListView()
        Me.cms_addcategory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_newoperationCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        Me.cms_addcategory.SuspendLayout()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(9, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(114, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Category Description:"
        '
        'txt_newoperationCat
        '
        Me.txt_newoperationCat.Location = New System.Drawing.Point(12, 36)
        Me.txt_newoperationCat.Name = "txt_newoperationCat"
        Me.txt_newoperationCat.NullText = "<Category Name Required>"
        Me.txt_newoperationCat.Size = New System.Drawing.Size(313, 20)
        Me.txt_newoperationCat.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(172, 62)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 24)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.btn_cancel)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.btn_save)
        Me.RadGroupBox1.Controls.Add(Me.txt_newoperationCat)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(339, 93)
        Me.RadGroupBox1.TabIndex = 4
        '
        'cmssub_refresh
        '
        Me.cmssub_refresh.AccessibleDescription = "Refresh"
        Me.cmssub_refresh.AccessibleName = "Refresh"
        Me.cmssub_refresh.Name = "cmssub_refresh"
        Me.cmssub_refresh.Text = "Refresh"
        Me.cmssub_refresh.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cmssub_add
        '
        Me.cmssub_add.AccessibleDescription = "Add"
        Me.cmssub_add.AccessibleName = "Add"
        Me.cmssub_add.Name = "cmssub_add"
        Me.cmssub_add.Text = "Add"
        Me.cmssub_add.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cmssub_update
        '
        Me.cmssub_update.AccessibleDescription = "Update"
        Me.cmssub_update.AccessibleName = "Update"
        Me.cmssub_update.Name = "cmssub_update"
        Me.cmssub_update.Text = "Update"
        Me.cmssub_update.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cmssub_delete
        '
        Me.cmssub_delete.AccessibleDescription = "Delete"
        Me.cmssub_delete.AccessibleName = "Delete"
        Me.cmssub_delete.Name = "cmssub_delete"
        Me.cmssub_delete.Text = "Delete"
        Me.cmssub_delete.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'id
        '
        Me.id.Text = "id"
        Me.id.Width = 0
        '
        'count_no
        '
        Me.count_no.Text = "No"
        Me.count_no.Width = 30
        '
        'desc
        '
        Me.desc.Text = "Category Description"
        Me.desc.Width = 309
        '
        'lv_addcategory
        '
        Me.lv_addcategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv_addcategory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.count_no, Me.desc})
        Me.lv_addcategory.FullRowSelect = True
        Me.lv_addcategory.GridLines = True
        Me.lv_addcategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_addcategory.Location = New System.Drawing.Point(0, 99)
        Me.lv_addcategory.Name = "lv_addcategory"
        Me.lv_addcategory.Size = New System.Drawing.Size(339, 242)
        Me.lv_addcategory.TabIndex = 5
        Me.lv_addcategory.UseCompatibleStateImageBehavior = False
        Me.lv_addcategory.View = System.Windows.Forms.View.Details
        '
        'cms_addcategory
        '
        Me.cms_addcategory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms_addcategory.Name = "cms_addcategory"
        Me.cms_addcategory.Size = New System.Drawing.Size(114, 92)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
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
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(250, 62)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(72, 24)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.Text = "Cancel"
        '
        'Frm_addcategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 341)
        Me.Controls.Add(Me.lv_addcategory)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_addcategory"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operation New Category"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_newoperationCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        Me.cms_addcategory.ResumeLayout(False)
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_newoperationCat As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents cmssub_refresh As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmssub_add As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmssub_update As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents cmssub_delete As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents count_no As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents lv_addcategory As System.Windows.Forms.ListView
    Friend WithEvents cms_addcategory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
End Class

