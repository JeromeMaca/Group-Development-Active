<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_request_form_add
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
        Me.txt_ST_purpose = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.tp_ST_neededtime = New Telerik.WinControls.UI.RadTimePicker()
        Me.btn_cancel_add = New Telerik.WinControls.UI.RadButton()
        Me.dp_workoperations = New Telerik.WinControls.UI.RadDropDownList()
        Me.btn_new_request = New Telerik.WinControls.UI.RadButton()
        Me.txt_planter = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_add_request = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_location_lot = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.dt_ST_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.chk_group = New System.Windows.Forms.CheckBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_queued = New Telerik.WinControls.UI.RadListView()
        Me.btn_cancel_selected_queued = New Telerik.WinControls.UI.RadButton()
        Me.btn_save_request = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel_all_queued_request = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tp_ST_neededtime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_workoperations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_new_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_planter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location_lot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_queued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_selected_queued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_all_queued_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.txt_ST_purpose)
        Me.gb_menu.Controls.Add(Me.RadLabel13)
        Me.gb_menu.Controls.Add(Me.RadLabel11)
        Me.gb_menu.Controls.Add(Me.tp_ST_neededtime)
        Me.gb_menu.Controls.Add(Me.btn_cancel_add)
        Me.gb_menu.Controls.Add(Me.dp_workoperations)
        Me.gb_menu.Controls.Add(Me.btn_new_request)
        Me.gb_menu.Controls.Add(Me.txt_planter)
        Me.gb_menu.Controls.Add(Me.btn_add_request)
        Me.gb_menu.Controls.Add(Me.RadLabel6)
        Me.gb_menu.Controls.Add(Me.dp_location_lot)
        Me.gb_menu.Controls.Add(Me.RadLabel2)
        Me.gb_menu.Controls.Add(Me.dp_location)
        Me.gb_menu.Controls.Add(Me.RadLabel1)
        Me.gb_menu.Controls.Add(Me.RadLabel15)
        Me.gb_menu.Controls.Add(Me.dt_ST_date)
        Me.gb_menu.Controls.Add(Me.RadLabel4)
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(1, 1)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(1081, 134)
        Me.gb_menu.TabIndex = 30
        '
        'txt_ST_purpose
        '
        Me.txt_ST_purpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ST_purpose.AutoSize = False
        Me.txt_ST_purpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ST_purpose.ForeColor = System.Drawing.Color.Black
        Me.txt_ST_purpose.Location = New System.Drawing.Point(751, 22)
        Me.txt_ST_purpose.Multiline = True
        Me.txt_ST_purpose.Name = "txt_ST_purpose"
        Me.txt_ST_purpose.NullText = "<Optional>"
        Me.txt_ST_purpose.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_ST_purpose.Size = New System.Drawing.Size(311, 65)
        Me.txt_ST_purpose.TabIndex = 102
        '
        'RadLabel13
        '
        Me.RadLabel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel13.Location = New System.Drawing.Point(696, 22)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(49, 18)
        Me.RadLabel13.TabIndex = 101
        Me.RadLabel13.Text = "Purpose:"
        '
        'RadLabel11
        '
        Me.RadLabel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel11.Location = New System.Drawing.Point(20, 46)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(80, 18)
        Me.RadLabel11.TabIndex = 100
        Me.RadLabel11.Text = "Needed Time:"
        '
        'tp_ST_neededtime
        '
        Me.tp_ST_neededtime.Location = New System.Drawing.Point(105, 44)
        Me.tp_ST_neededtime.Name = "tp_ST_neededtime"
        Me.tp_ST_neededtime.Size = New System.Drawing.Size(94, 20)
        Me.tp_ST_neededtime.TabIndex = 99
        Me.tp_ST_neededtime.TabStop = False
        Me.tp_ST_neededtime.Text = "RadTimePicker1"
        Me.tp_ST_neededtime.Value = New Date(2016, 2, 10, 8, 20, 0, 0)
        '
        'btn_cancel_add
        '
        Me.btn_cancel_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_add.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_add.Location = New System.Drawing.Point(965, 105)
        Me.btn_cancel_add.Name = "btn_cancel_add"
        Me.btn_cancel_add.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel_add.TabIndex = 44
        Me.btn_cancel_add.Text = "CANCEL"
        '
        'dp_workoperations
        '
        Me.dp_workoperations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_workoperations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_workoperations.Location = New System.Drawing.Point(435, 68)
        Me.dp_workoperations.Name = "dp_workoperations"
        Me.dp_workoperations.NullText = "<Required>"
        '
        '
        '
        Me.dp_workoperations.RootElement.StretchVertically = True
        Me.dp_workoperations.Size = New System.Drawing.Size(246, 20)
        Me.dp_workoperations.TabIndex = 43
        CType(Me.dp_workoperations.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        '
        'btn_new_request
        '
        Me.btn_new_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_new_request.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_new_request.Location = New System.Drawing.Point(849, 105)
        Me.btn_new_request.Name = "btn_new_request"
        Me.btn_new_request.Size = New System.Drawing.Size(110, 24)
        Me.btn_new_request.TabIndex = 42
        Me.btn_new_request.Text = "NEW REQUEST"
        '
        'txt_planter
        '
        Me.txt_planter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_planter.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_planter.Location = New System.Drawing.Point(426, 20)
        Me.txt_planter.Name = "txt_planter"
        Me.txt_planter.NullText = "<Required>"
        Me.txt_planter.ReadOnly = True
        Me.txt_planter.Size = New System.Drawing.Size(255, 20)
        Me.txt_planter.TabIndex = 33
        Me.txt_planter.TabStop = False
        '
        'btn_add_request
        '
        Me.btn_add_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add_request.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_add_request.Location = New System.Drawing.Point(733, 105)
        Me.btn_add_request.Name = "btn_add_request"
        Me.btn_add_request.Size = New System.Drawing.Size(110, 24)
        Me.btn_add_request.TabIndex = 41
        Me.btn_add_request.Text = "ADD TO QUEUE"
        '
        'RadLabel6
        '
        Me.RadLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(373, 46)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(95, 18)
        Me.RadLabel6.TabIndex = 40
        Me.RadLabel6.Text = "Work Operation:"
        '
        'dp_location_lot
        '
        Me.dp_location_lot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_location_lot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location_lot.Location = New System.Drawing.Point(80, 94)
        Me.dp_location_lot.Name = "dp_location_lot"
        Me.dp_location_lot.NullText = "<Required>"
        '
        '
        '
        Me.dp_location_lot.RootElement.StretchVertically = True
        Me.dp_location_lot.Size = New System.Drawing.Size(238, 20)
        Me.dp_location_lot.TabIndex = 38
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(20, 96)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel2.TabIndex = 37
        Me.RadLabel2.Text = "Lot No.:"
        '
        'dp_location
        '
        Me.dp_location.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.Location = New System.Drawing.Point(80, 68)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "<Required>"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(267, 20)
        Me.dp_location.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(20, 70)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel1.TabIndex = 35
        Me.RadLabel1.Text = "Location:"
        '
        'RadLabel15
        '
        Me.RadLabel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel15.Location = New System.Drawing.Point(373, 22)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(47, 18)
        Me.RadLabel15.TabIndex = 34
        Me.RadLabel15.Text = "Planter:"
        '
        'dt_ST_date
        '
        Me.dt_ST_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_ST_date.Location = New System.Drawing.Point(105, 20)
        Me.dt_ST_date.Name = "dt_ST_date"
        Me.dt_ST_date.Size = New System.Drawing.Size(242, 20)
        Me.dt_ST_date.TabIndex = 31
        Me.dt_ST_date.TabStop = False
        Me.dt_ST_date.Text = "Monday, December 28, 2015"
        Me.dt_ST_date.Value = New Date(2015, 12, 28, 0, 0, 0, 0)
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(20, 22)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel4.TabIndex = 30
        Me.RadLabel4.Text = "Date Needed:"
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.chk_group)
        Me.gb_data.Controls.Add(Me.RadLabel3)
        Me.gb_data.Controls.Add(Me.lv_queued)
        Me.gb_data.Controls.Add(Me.btn_cancel_selected_queued)
        Me.gb_data.Controls.Add(Me.btn_save_request)
        Me.gb_data.Controls.Add(Me.btn_cancel_all_queued_request)
        Me.gb_data.Controls.Add(Me.RadLabel5)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(1, 136)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(1081, 428)
        Me.gb_data.TabIndex = 31
        '
        'chk_group
        '
        Me.chk_group.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chk_group.AutoSize = True
        Me.chk_group.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_group.Location = New System.Drawing.Point(373, 402)
        Me.chk_group.Name = "chk_group"
        Me.chk_group.Size = New System.Drawing.Size(107, 17)
        Me.chk_group.TabIndex = 46
        Me.chk_group.Text = "Group By CODE"
        Me.chk_group.UseVisualStyleBackColor = True
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(15, 400)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(297, 19)
        Me.RadLabel3.TabIndex = 45
        Me.RadLabel3.Text = "NOTE: Queued request data is group by LOCATION."
        '
        'lv_queued
        '
        Me.lv_queued.AllowEdit = False
        Me.lv_queued.AllowRemove = False
        Me.lv_queued.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_queued.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lv_queued.ItemSpacing = -1
        Me.lv_queued.Location = New System.Drawing.Point(9, 36)
        Me.lv_queued.Name = "lv_queued"
        Me.lv_queued.SelectLastAddedItem = False
        Me.lv_queued.Size = New System.Drawing.Size(1062, 355)
        Me.lv_queued.TabIndex = 44
        Me.lv_queued.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'btn_cancel_selected_queued
        '
        Me.btn_cancel_selected_queued.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_selected_queued.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_selected_queued.Location = New System.Drawing.Point(493, 397)
        Me.btn_cancel_selected_queued.Name = "btn_cancel_selected_queued"
        Me.btn_cancel_selected_queued.Size = New System.Drawing.Size(224, 24)
        Me.btn_cancel_selected_queued.TabIndex = 43
        Me.btn_cancel_selected_queued.Text = "CANCEL SELECTED QUEUED REQUEST"
        '
        'btn_save_request
        '
        Me.btn_save_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save_request.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save_request.Location = New System.Drawing.Point(952, 397)
        Me.btn_save_request.Name = "btn_save_request"
        Me.btn_save_request.Size = New System.Drawing.Size(119, 24)
        Me.btn_save_request.TabIndex = 32
        Me.btn_save_request.Text = "SAVE ALL REQUEST"
        '
        'btn_cancel_all_queued_request
        '
        Me.btn_cancel_all_queued_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_all_queued_request.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_all_queued_request.Location = New System.Drawing.Point(723, 397)
        Me.btn_cancel_all_queued_request.Name = "btn_cancel_all_queued_request"
        Me.btn_cancel_all_queued_request.Size = New System.Drawing.Size(224, 24)
        Me.btn_cancel_all_queued_request.TabIndex = 42
        Me.btn_cancel_all_queued_request.Text = "CANCEL ALL QUEUED REQUEST"
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(9, 11)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(100, 19)
        Me.RadLabel5.TabIndex = 31
        Me.RadLabel5.Text = "Queued Request"
        '
        'Frm_request_form_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 564)
        Me.Controls.Add(Me.gb_menu)
        Me.Controls.Add(Me.gb_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_request_form_add"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Form"
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tp_ST_neededtime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_workoperations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_new_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_planter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location_lot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_queued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_selected_queued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_all_queued_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_planter As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btn_cancel_all_queued_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_add_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dp_location_lot As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dt_ST_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_save_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_new_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents dp_workoperations As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents btn_cancel_selected_queued As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_queued As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents chk_group As System.Windows.Forms.CheckBox
    Friend WithEvents btn_cancel_add As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tp_ST_neededtime As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents txt_ST_purpose As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
End Class

