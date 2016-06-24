<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_addownername
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
        Me.txt_name = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.lv_ownername = New System.Windows.Forms.ListView()
        Me.cms_name = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ids = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.count = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.names = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_name.SuspendLayout()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(13, 18)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Owner Name:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(91, 16)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.NullText = "<required>"
        Me.txt_name.Size = New System.Drawing.Size(260, 20)
        Me.txt_name.TabIndex = 1
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(197, 43)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(74, 24)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(277, 43)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(74, 24)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        '
        'lv_ownername
        '
        Me.lv_ownername.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ids, Me.count, Me.names})
        Me.lv_ownername.FullRowSelect = True
        Me.lv_ownername.GridLines = True
        Me.lv_ownername.Location = New System.Drawing.Point(0, 90)
        Me.lv_ownername.Name = "lv_ownername"
        Me.lv_ownername.Size = New System.Drawing.Size(363, 263)
        Me.lv_ownername.TabIndex = 4
        Me.lv_ownername.UseCompatibleStateImageBehavior = False
        Me.lv_ownername.View = System.Windows.Forms.View.Details
        '
        'cms_name
        '
        Me.cms_name.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms_name.Name = "cms_name"
        Me.cms_name.Size = New System.Drawing.Size(114, 98)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        'ids
        '
        Me.ids.Text = "id"
        Me.ids.Width = 0
        '
        'count
        '
        Me.count.Text = "#"
        Me.count.Width = 40
        '
        'names
        '
        Me.names.Text = "Owner Name"
        Me.names.Width = 320
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.txt_name)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.btn_save)
        Me.RadGroupBox1.Controls.Add(Me.btn_cancel)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(363, 84)
        Me.RadGroupBox1.TabIndex = 6
        '
        'Frm_addownername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 354)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.lv_ownername)
        Me.Name = "Frm_addownername"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_addownername"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_name.ResumeLayout(False)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_name As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_ownername As System.Windows.Forms.ListView
    Friend WithEvents cms_name As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ids As System.Windows.Forms.ColumnHeader
    Friend WithEvents count As System.Windows.Forms.ColumnHeader
    Friend WithEvents names As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
End Class

