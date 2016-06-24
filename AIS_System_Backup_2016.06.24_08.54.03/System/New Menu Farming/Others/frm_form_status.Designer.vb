<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_form_status
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
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.panel_menu = New Telerik.WinControls.UI.RadPanel()
        Me.txt_jobsitedeparture = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_jobsitearrival = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_equipout = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_equipin = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_approved_request = New Telerik.WinControls.UI.RadListView()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_menu.SuspendLayout()
        CType(Me.txt_jobsitedeparture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_jobsitearrival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_approved_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.RadDateTimePicker1)
        Me.RadGroupBox2.Controls.Add(Me.RadDateTimePicker2)
        Me.RadGroupBox2.Controls.Add(Me.gb_menu)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.lv_approved_request)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(0, 1)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(1103, 517)
        Me.RadGroupBox2.TabIndex = 3
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Controls.Add(Me.RadTextBox1)
        Me.gb_menu.Controls.Add(Me.RadLabel1)
        Me.gb_menu.Controls.Add(Me.panel_menu)
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(5, 4)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(1093, 61)
        Me.gb_menu.TabIndex = 47
        '
        'RadDateTimePicker2
        '
        Me.RadDateTimePicker2.CustomFormat = "MMMM dd, yyyy"
        Me.RadDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RadDateTimePicker2.Location = New System.Drawing.Point(942, 491)
        Me.RadDateTimePicker2.Name = "RadDateTimePicker2"
        Me.RadDateTimePicker2.Size = New System.Drawing.Size(108, 20)
        Me.RadDateTimePicker2.TabIndex = 7
        Me.RadDateTimePicker2.TabStop = False
        Me.RadDateTimePicker2.Text = "June 03, 2016"
        Me.RadDateTimePicker2.Value = New Date(2016, 6, 3, 0, 0, 0, 0)
        Me.RadDateTimePicker2.Visible = False
        '
        'RadDateTimePicker1
        '
        Me.RadDateTimePicker1.CustomFormat = "MMMM dd, yyyy"
        Me.RadDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.RadDateTimePicker1.Location = New System.Drawing.Point(769, 491)
        Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
        Me.RadDateTimePicker1.Size = New System.Drawing.Size(108, 20)
        Me.RadDateTimePicker1.TabIndex = 6
        Me.RadDateTimePicker1.TabStop = False
        Me.RadDateTimePicker1.Text = "June 03, 2016"
        Me.RadDateTimePicker1.Value = New Date(2016, 6, 3, 0, 0, 0, 0)
        Me.RadDateTimePicker1.Visible = False
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel5.Location = New System.Drawing.Point(881, 486)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(55, 19)
        Me.RadLabel5.TabIndex = 5
        Me.RadLabel5.Text = "Date To:"
        Me.RadLabel5.Visible = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(692, 486)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(71, 19)
        Me.RadLabel4.TabIndex = 5
        Me.RadLabel4.Text = "Date From:"
        Me.RadLabel4.Visible = False
        '
        'panel_menu
        '
        Me.panel_menu.Controls.Add(Me.txt_jobsitedeparture)
        Me.panel_menu.Controls.Add(Me.RadLabel7)
        Me.panel_menu.Controls.Add(Me.txt_jobsitearrival)
        Me.panel_menu.Controls.Add(Me.RadLabel8)
        Me.panel_menu.Controls.Add(Me.txt_equipout)
        Me.panel_menu.Controls.Add(Me.RadLabel6)
        Me.panel_menu.Controls.Add(Me.txt_equipin)
        Me.panel_menu.Controls.Add(Me.RadLabel2)
        Me.panel_menu.Location = New System.Drawing.Point(410, 4)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Size = New System.Drawing.Size(678, 53)
        Me.panel_menu.TabIndex = 2
        Me.panel_menu.Visible = False
        '
        'txt_jobsitedeparture
        '
        Me.txt_jobsitedeparture.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txt_jobsitedeparture.Location = New System.Drawing.Point(520, 25)
        Me.txt_jobsitedeparture.Name = "txt_jobsitedeparture"
        Me.txt_jobsitedeparture.NullText = "<System Generated>"
        Me.txt_jobsitedeparture.ReadOnly = True
        Me.txt_jobsitedeparture.Size = New System.Drawing.Size(132, 20)
        Me.txt_jobsitedeparture.TabIndex = 8
        '
        'RadLabel7
        '
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel7.Location = New System.Drawing.Point(520, 6)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(110, 19)
        Me.RadLabel7.TabIndex = 9
        Me.RadLabel7.Text = "Jobsite Departure"
        '
        'txt_jobsitearrival
        '
        Me.txt_jobsitearrival.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txt_jobsitearrival.Location = New System.Drawing.Point(359, 25)
        Me.txt_jobsitearrival.Name = "txt_jobsitearrival"
        Me.txt_jobsitearrival.NullText = "<System Generated>"
        Me.txt_jobsitearrival.ReadOnly = True
        Me.txt_jobsitearrival.Size = New System.Drawing.Size(132, 20)
        Me.txt_jobsitearrival.TabIndex = 6
        '
        'RadLabel8
        '
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel8.Location = New System.Drawing.Point(359, 5)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(90, 19)
        Me.RadLabel8.TabIndex = 7
        Me.RadLabel8.Text = "Jobsite Arrival"
        '
        'txt_equipout
        '
        Me.txt_equipout.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txt_equipout.Location = New System.Drawing.Point(26, 25)
        Me.txt_equipout.Name = "txt_equipout"
        Me.txt_equipout.NullText = "<System Generated>"
        Me.txt_equipout.ReadOnly = True
        Me.txt_equipout.Size = New System.Drawing.Size(132, 20)
        Me.txt_equipout.TabIndex = 4
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(26, 6)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(95, 19)
        Me.RadLabel6.TabIndex = 5
        Me.RadLabel6.Text = "Equipment Out"
        '
        'txt_equipin
        '
        Me.txt_equipin.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.txt_equipin.Location = New System.Drawing.Point(199, 26)
        Me.txt_equipin.Name = "txt_equipin"
        Me.txt_equipin.NullText = "<System Generated>"
        Me.txt_equipin.ReadOnly = True
        Me.txt_equipin.Size = New System.Drawing.Size(132, 20)
        Me.txt_equipin.TabIndex = 2
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(199, 6)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(84, 19)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Equipment In"
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(5, 493)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(199, 19)
        Me.RadLabel3.TabIndex = 46
        Me.RadLabel3.Text = "NOTE: Group by Request Number."
        '
        'lv_approved_request
        '
        Me.lv_approved_request.AllowEdit = False
        Me.lv_approved_request.AllowRemove = False
        Me.lv_approved_request.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_approved_request.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lv_approved_request.ItemSpacing = -1
        Me.lv_approved_request.Location = New System.Drawing.Point(5, 71)
        Me.lv_approved_request.Name = "lv_approved_request"
        Me.lv_approved_request.SelectLastAddedItem = False
        Me.lv_approved_request.ShowGridLines = True
        Me.lv_approved_request.Size = New System.Drawing.Size(1093, 416)
        Me.lv_approved_request.TabIndex = 0
        Me.lv_approved_request.Text = "lv_request_tt"
        Me.lv_approved_request.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AutoSize = False
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.RadTextBox1.Location = New System.Drawing.Point(61, 21)
        Me.RadTextBox1.Multiline = True
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "<Search Here>"
        Me.RadTextBox1.Size = New System.Drawing.Size(344, 21)
        Me.RadTextBox1.TabIndex = 7
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(7, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(48, 19)
        Me.RadLabel1.TabIndex = 8
        Me.RadLabel1.Text = "Search:"
        '
        'Frm_form_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 518)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_form_status"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_form_status"
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_menu.ResumeLayout(False)
        Me.panel_menu.PerformLayout()
        CType(Me.txt_jobsitedeparture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_jobsitearrival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_approved_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lv_approved_request As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents panel_menu As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_equipin As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txt_equipout As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_jobsitedeparture As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_jobsitearrival As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class

