<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_lot_by_lot_monitoring
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
        Me.btn_lotno = New Telerik.WinControls.UI.RadButton()
        Me.dp_cropyear = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_search = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_lotcodelist = New Telerik.WinControls.UI.RadListView()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_implement = New Telerik.WinControls.UI.RadListView()
        Me.lv_equipment = New Telerik.WinControls.UI.RadListView()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_lotcode_history = New Telerik.WinControls.UI.RadListView()
        Me.cms_menu = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.menu_totalcostsummary = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_lotno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_cropyear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_lotcodelist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.lv_implement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_equipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_lotcode_history, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.btn_lotno)
        Me.RadGroupBox1.Controls.Add(Me.dp_cropyear)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.txt_search)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.lv_lotcodelist)
        Me.RadGroupBox1.Controls.Add(Me.dp_location)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel19)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(254, 608)
        Me.RadGroupBox1.TabIndex = 0
        '
        'btn_lotno
        '
        Me.btn_lotno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_lotno.Location = New System.Drawing.Point(134, 125)
        Me.btn_lotno.Name = "btn_lotno"
        Me.btn_lotno.Size = New System.Drawing.Size(110, 24)
        Me.btn_lotno.TabIndex = 123
        Me.btn_lotno.Text = "Load Lot Code"
        '
        'dp_cropyear
        '
        Me.dp_cropyear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_cropyear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_cropyear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dp_cropyear.Location = New System.Drawing.Point(10, 88)
        Me.dp_cropyear.Name = "dp_cropyear"
        Me.dp_cropyear.NullText = "<Required>"
        '
        '
        '
        Me.dp_cropyear.RootElement.StretchVertically = True
        Me.dp_cropyear.Size = New System.Drawing.Size(234, 20)
        Me.dp_cropyear.TabIndex = 122
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(6, 65)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(96, 21)
        Me.RadLabel3.TabIndex = 121
        Me.RadLabel3.Text = "Set Crop Year:"
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_search.Location = New System.Drawing.Point(109, 579)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.NullText = "<Find Lot Number>"
        Me.txt_search.Size = New System.Drawing.Size(140, 20)
        Me.txt_search.TabIndex = 120
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(6, 578)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(97, 21)
        Me.RadLabel2.TabIndex = 119
        Me.RadLabel2.Text = "Find Lot Code:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(10, 128)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(92, 21)
        Me.RadLabel1.TabIndex = 118
        Me.RadLabel1.Text = "Lot Code List:"
        '
        'lv_lotcodelist
        '
        Me.lv_lotcodelist.AllowColumnReorder = False
        Me.lv_lotcodelist.AllowEdit = False
        Me.lv_lotcodelist.AllowRemove = False
        Me.lv_lotcodelist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lotcodelist.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_lotcodelist.ItemSpacing = -1
        Me.lv_lotcodelist.Location = New System.Drawing.Point(6, 155)
        Me.lv_lotcodelist.Name = "lv_lotcodelist"
        Me.lv_lotcodelist.SelectLastAddedItem = False
        Me.lv_lotcodelist.ShowGridLines = True
        Me.lv_lotcodelist.Size = New System.Drawing.Size(243, 417)
        Me.lv_lotcodelist.TabIndex = 117
        Me.lv_lotcodelist.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'dp_location
        '
        Me.dp_location.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dp_location.Location = New System.Drawing.Point(10, 39)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "<Required>"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(234, 20)
        Me.dp_location.TabIndex = 116
        CType(Me.dp_location.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        CType(Me.dp_location.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadLabel19
        '
        Me.RadLabel19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel19.Location = New System.Drawing.Point(6, 16)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(88, 21)
        Me.RadLabel19.TabIndex = 115
        Me.RadLabel19.Text = "Set Location:"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.lv_implement)
        Me.RadGroupBox2.Controls.Add(Me.lv_equipment)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel4)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel3)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel2)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox2.Controls.Add(Me.lv_lotcode_history)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(257, 1)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(889, 608)
        Me.RadGroupBox2.TabIndex = 1
        '
        'lv_implement
        '
        Me.lv_implement.AllowColumnReorder = False
        Me.lv_implement.AllowEdit = False
        Me.lv_implement.AllowRemove = False
        Me.lv_implement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_implement.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_implement.ItemSpacing = -1
        Me.lv_implement.Location = New System.Drawing.Point(5, 435)
        Me.lv_implement.Name = "lv_implement"
        Me.lv_implement.SelectLastAddedItem = False
        Me.lv_implement.ShowGridLines = True
        Me.lv_implement.Size = New System.Drawing.Size(879, 137)
        Me.lv_implement.TabIndex = 121
        Me.lv_implement.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'lv_equipment
        '
        Me.lv_equipment.AllowColumnReorder = False
        Me.lv_equipment.AllowEdit = False
        Me.lv_equipment.AllowRemove = False
        Me.lv_equipment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_equipment.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_equipment.ItemSpacing = -1
        Me.lv_equipment.Location = New System.Drawing.Point(5, 268)
        Me.lv_equipment.Name = "lv_equipment"
        Me.lv_equipment.SelectLastAddedItem = False
        Me.lv_equipment.ShowGridLines = True
        Me.lv_equipment.Size = New System.Drawing.Size(879, 137)
        Me.lv_equipment.TabIndex = 120
        Me.lv_equipment.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadPanel4
        '
        Me.RadPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel4.Location = New System.Drawing.Point(5, 575)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(879, 27)
        Me.RadPanel4.TabIndex = 124
        Me.RadPanel4.Text = "|| -----------------------------------------------------------------------"
        '
        'RadPanel3
        '
        Me.RadPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel3.Location = New System.Drawing.Point(5, 407)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(879, 27)
        Me.RadPanel3.TabIndex = 123
        Me.RadPanel3.Text = "Implement Used:"
        '
        'RadPanel2
        '
        Me.RadPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel2.Location = New System.Drawing.Point(5, 240)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(879, 27)
        Me.RadPanel2.TabIndex = 122
        Me.RadPanel2.Text = "Equipment Used:"
        '
        'RadPanel1
        '
        Me.RadPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.Location = New System.Drawing.Point(5, 6)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(879, 31)
        Me.RadPanel1.TabIndex = 119
        Me.RadPanel1.Text = "All work history performed to the specific Lot Code.:"
        '
        'lv_lotcode_history
        '
        Me.lv_lotcode_history.AllowColumnReorder = False
        Me.lv_lotcode_history.AllowEdit = False
        Me.lv_lotcode_history.AllowRemove = False
        Me.lv_lotcode_history.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lotcode_history.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_lotcode_history.ItemSpacing = -1
        Me.lv_lotcode_history.Location = New System.Drawing.Point(5, 39)
        Me.lv_lotcode_history.Name = "lv_lotcode_history"
        '
        '
        '
        Me.lv_lotcode_history.RootElement.ApplyShapeToControl = False
        Me.lv_lotcode_history.RootElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        Me.lv_lotcode_history.RootElement.UseDefaultDisabledPaint = True
        Me.lv_lotcode_history.SelectLastAddedItem = False
        Me.lv_lotcode_history.ShowGridLines = True
        Me.lv_lotcode_history.ShowItemToolTips = False
        Me.lv_lotcode_history.Size = New System.Drawing.Size(879, 199)
        Me.lv_lotcode_history.TabIndex = 118
        Me.lv_lotcode_history.TabStop = False
        Me.lv_lotcode_history.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'cms_menu
        '
        Me.cms_menu.Items.AddRange(New Telerik.WinControls.RadItem() {Me.menu_totalcostsummary})
        '
        'menu_totalcostsummary
        '
        Me.menu_totalcostsummary.AccessibleDescription = "Total Cost Summary"
        Me.menu_totalcostsummary.AccessibleName = "Total Cost Summary"
        Me.menu_totalcostsummary.Name = "menu_totalcostsummary"
        Me.menu_totalcostsummary.Text = "Total Cost Summary"
        Me.menu_totalcostsummary.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Frm_lot_by_lot_monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 609)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Frm_lot_by_lot_monitoring"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_lot_by_lot_monitoring"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.btn_lotno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_cropyear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_lotcodelist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.lv_implement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_equipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_lotcode_history, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lv_lotcodelist As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_search As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lv_lotcode_history As Telerik.WinControls.UI.RadListView
    Friend WithEvents dp_cropyear As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lv_implement As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_lotno As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_equipment As Telerik.WinControls.UI.RadListView
    Friend WithEvents cms_menu As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents menu_totalcostsummary As Telerik.WinControls.UI.RadMenuItem
End Class

