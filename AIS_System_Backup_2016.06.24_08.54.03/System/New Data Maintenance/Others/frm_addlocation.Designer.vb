<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_addlocation
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
        Me.txt_locdesc = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.lv_location_list = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_addlocation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_locdesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_addlocation.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(11, 18)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(111, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Location Description:"
        '
        'txt_locdesc
        '
        Me.txt_locdesc.Location = New System.Drawing.Point(12, 38)
        Me.txt_locdesc.Name = "txt_locdesc"
        Me.txt_locdesc.NullText = "<Required>"
        Me.txt_locdesc.Size = New System.Drawing.Size(247, 20)
        Me.txt_locdesc.TabIndex = 1
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.lv_location_list)
        Me.RadGroupBox1.Controls.Add(Me.txt_locdesc)
        Me.RadGroupBox1.Controls.Add(Me.btn_save)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(339, 292)
        Me.RadGroupBox1.TabIndex = 2
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(265, 38)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(62, 20)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        '
        'lv_location_list
        '
        Me.lv_location_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_location_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lv_location_list.FullRowSelect = True
        Me.lv_location_list.GridLines = True
        Me.lv_location_list.Location = New System.Drawing.Point(5, 76)
        Me.lv_location_list.Name = "lv_location_list"
        Me.lv_location_list.Size = New System.Drawing.Size(329, 211)
        Me.lv_location_list.TabIndex = 4
        Me.lv_location_list.UseCompatibleStateImageBehavior = False
        Me.lv_location_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "#"
        Me.ColumnHeader2.Width = 30
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Location Description"
        Me.ColumnHeader3.Width = 300
        '
        'cms_addlocation
        '
        Me.cms_addlocation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms_addlocation.Name = "cms_addcategory"
        Me.cms_addlocation.Size = New System.Drawing.Size(114, 92)
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
        'Frm_addlocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 292)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_addlocation"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Location Description"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_locdesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_addlocation.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_locdesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_location_list As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_addlocation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

