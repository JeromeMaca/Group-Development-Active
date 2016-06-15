<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_master_list_operation
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
        Me.btn_addcat = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_saveOpera = New Telerik.WinControls.UI.RadButton()
        Me.dropd_category = New Telerik.WinControls.UI.RadDropDownList()
        Me.txt_unitmeasure = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.spine_operrate = New Telerik.WinControls.UI.RadSpinEditor()
        Me.txt_operation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.cms_operationmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteOperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lv_operations = New System.Windows.Forms.ListView()
        Me.No = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.desc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.unit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.category = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_addcat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_saveOpera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dropd_category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_unitmeasure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spine_operrate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_operation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_operationmenu.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.btn_addcat)
        Me.RadGroupBox1.Controls.Add(Me.btn_cancel)
        Me.RadGroupBox1.Controls.Add(Me.btn_saveOpera)
        Me.RadGroupBox1.Controls.Add(Me.dropd_category)
        Me.RadGroupBox1.Controls.Add(Me.txt_unitmeasure)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.spine_operrate)
        Me.RadGroupBox1.Controls.Add(Me.txt_operation)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(1143, 177)
        Me.RadGroupBox1.TabIndex = 0
        '
        'btn_addcat
        '
        Me.btn_addcat.Location = New System.Drawing.Point(476, 103)
        Me.btn_addcat.Name = "btn_addcat"
        Me.btn_addcat.Size = New System.Drawing.Size(99, 20)
        Me.btn_addcat.TabIndex = 9
        Me.btn_addcat.Text = "Add Category"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(241, 139)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_saveOpera
        '
        Me.btn_saveOpera.Location = New System.Drawing.Point(125, 139)
        Me.btn_saveOpera.Name = "btn_saveOpera"
        Me.btn_saveOpera.Size = New System.Drawing.Size(110, 24)
        Me.btn_saveOpera.TabIndex = 7
        Me.btn_saveOpera.Text = "Save Operation"
        '
        'dropd_category
        '
        Me.dropd_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dropd_category.AutoSizeItems = True
        Me.dropd_category.DefaultItemsCountInDropDown = 8
        Me.dropd_category.Location = New System.Drawing.Point(143, 103)
        Me.dropd_category.Name = "dropd_category"
        Me.dropd_category.NullText = "<Required>"
        Me.dropd_category.Size = New System.Drawing.Size(326, 20)
        Me.dropd_category.TabIndex = 6
        '
        'txt_unitmeasure
        '
        Me.txt_unitmeasure.Location = New System.Drawing.Point(125, 74)
        Me.txt_unitmeasure.Name = "txt_unitmeasure"
        Me.txt_unitmeasure.NullText = "<Required>"
        Me.txt_unitmeasure.Size = New System.Drawing.Size(154, 20)
        Me.txt_unitmeasure.TabIndex = 5
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(30, 105)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(107, 18)
        Me.RadLabel4.TabIndex = 4
        Me.RadLabel4.Text = "Operation Category:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(30, 76)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(75, 18)
        Me.RadLabel3.TabIndex = 1
        Me.RadLabel3.Text = "Unit Measure:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(30, 51)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Operation Rate:"
        '
        'spine_operrate
        '
        Me.spine_operrate.DecimalPlaces = 2
        Me.spine_operrate.Location = New System.Drawing.Point(125, 49)
        Me.spine_operrate.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.spine_operrate.Name = "spine_operrate"
        Me.spine_operrate.Size = New System.Drawing.Size(154, 20)
        Me.spine_operrate.TabIndex = 2
        Me.spine_operrate.TabStop = False
        Me.spine_operrate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.spine_operrate.ThousandsSeparator = True
        '
        'txt_operation
        '
        Me.txt_operation.Location = New System.Drawing.Point(125, 19)
        Me.txt_operation.Name = "txt_operation"
        Me.txt_operation.NullText = "<Required>"
        Me.txt_operation.Size = New System.Drawing.Size(450, 20)
        Me.txt_operation.TabIndex = 1
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(30, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(89, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Operation Desc.:"
        '
        'cms_operationmenu
        '
        Me.cms_operationmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripSeparator1, Me.AddOperationToolStripMenuItem, Me.UpdateOperationToolStripMenuItem, Me.DeleteOperationToolStripMenuItem})
        Me.cms_operationmenu.Name = "cms_operationmenu"
        Me.cms_operationmenu.Size = New System.Drawing.Size(169, 98)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'AddOperationToolStripMenuItem
        '
        Me.AddOperationToolStripMenuItem.Name = "AddOperationToolStripMenuItem"
        Me.AddOperationToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AddOperationToolStripMenuItem.Text = "Add Operation"
        '
        'UpdateOperationToolStripMenuItem
        '
        Me.UpdateOperationToolStripMenuItem.Name = "UpdateOperationToolStripMenuItem"
        Me.UpdateOperationToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UpdateOperationToolStripMenuItem.Text = "Update Operation"
        '
        'DeleteOperationToolStripMenuItem
        '
        Me.DeleteOperationToolStripMenuItem.Name = "DeleteOperationToolStripMenuItem"
        Me.DeleteOperationToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DeleteOperationToolStripMenuItem.Text = "Delete Operation"
        '
        'lv_operations
        '
        Me.lv_operations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_operations.BackColor = System.Drawing.Color.FloralWhite
        Me.lv_operations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.No, Me.id, Me.desc, Me.rate, Me.unit, Me.category})
        Me.lv_operations.FullRowSelect = True
        Me.lv_operations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_operations.Location = New System.Drawing.Point(1, 183)
        Me.lv_operations.MultiSelect = False
        Me.lv_operations.Name = "lv_operations"
        Me.lv_operations.Size = New System.Drawing.Size(1143, 287)
        Me.lv_operations.TabIndex = 1
        Me.lv_operations.TabStop = False
        Me.lv_operations.UseCompatibleStateImageBehavior = False
        Me.lv_operations.View = System.Windows.Forms.View.Details
        '
        'No
        '
        Me.No.Text = "No."
        Me.No.Width = 0
        '
        'id
        '
        Me.id.Width = 0
        '
        'desc
        '
        Me.desc.Text = "Work Operation"
        Me.desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.desc.Width = 400
        '
        'rate
        '
        Me.rate.Text = "(₱) - Amount Rate"
        Me.rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.rate.Width = 150
        '
        'unit
        '
        Me.unit.Text = "Unit Measure"
        Me.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.unit.Width = 120
        '
        'category
        '
        Me.category.Text = "Operation Category"
        Me.category.Width = 800
        '
        'frm_master_list_operation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 473)
        Me.Controls.Add(Me.lv_operations)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "frm_master_list_operation"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_operations"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btn_addcat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_saveOpera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dropd_category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_unitmeasure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spine_operrate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_operation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_operationmenu.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_operation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dropd_category As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txt_unitmeasure As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents spine_operrate As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_saveOpera As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_addcat As Telerik.WinControls.UI.RadButton
    Friend WithEvents cms_operationmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddOperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateOperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteOperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lv_operations As System.Windows.Forms.ListView
    Friend WithEvents No As System.Windows.Forms.ColumnHeader
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents desc As System.Windows.Forms.ColumnHeader
    Friend WithEvents rate As System.Windows.Forms.ColumnHeader
    Friend WithEvents unit As System.Windows.Forms.ColumnHeader
    Friend WithEvents category As System.Windows.Forms.ColumnHeader
End Class

