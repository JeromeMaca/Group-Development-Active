<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_trip_ticket_monitoring
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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.btn_lotno = New Telerik.WinControls.UI.RadButton()
        Me.lv_trip_ticket_list = New Telerik.WinControls.UI.RadListView()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_tripticket_information = New Telerik.WinControls.UI.RadListView()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_tripticket_unprocessed = New Telerik.WinControls.UI.RadListView()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_tripticket_processed = New Telerik.WinControls.UI.RadListView()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
        Me.SplitPanel1 = New Telerik.WinControls.UI.SplitPanel()
        Me.SplitPanel2 = New Telerik.WinControls.UI.SplitPanel()
        Me.cms_issued_ticket = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.view_more_date_info = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.btn_lotno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_trip_ticket_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.lv_tripticket_information, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.lv_tripticket_unprocessed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.lv_tripticket_processed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer1.SuspendLayout()
        CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitPanel1.SuspendLayout()
        CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitPanel2.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox1.Controls.Add(Me.lv_trip_ticket_list)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 4)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(368, 580)
        Me.RadGroupBox1.TabIndex = 1
        '
        'RadPanel1
        '
        Me.RadPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel1.Controls.Add(Me.btn_lotno)
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.Location = New System.Drawing.Point(6, 4)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(356, 32)
        Me.RadPanel1.TabIndex = 124
        Me.RadPanel1.Text = "Issued Trip Ticket"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_lotno
        '
        Me.btn_lotno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_lotno.Location = New System.Drawing.Point(3, 4)
        Me.btn_lotno.Name = "btn_lotno"
        Me.btn_lotno.Size = New System.Drawing.Size(110, 24)
        Me.btn_lotno.TabIndex = 123
        Me.btn_lotno.Text = "Load Lot Code"
        '
        'lv_trip_ticket_list
        '
        Me.lv_trip_ticket_list.AllowColumnReorder = False
        Me.lv_trip_ticket_list.AllowEdit = False
        Me.lv_trip_ticket_list.AllowRemove = False
        Me.lv_trip_ticket_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_trip_ticket_list.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_trip_ticket_list.HeaderHeight = 30.0!
        Me.lv_trip_ticket_list.ItemSpacing = -1
        Me.lv_trip_ticket_list.Location = New System.Drawing.Point(6, 32)
        Me.lv_trip_ticket_list.Name = "lv_trip_ticket_list"
        Me.lv_trip_ticket_list.SelectLastAddedItem = False
        Me.lv_trip_ticket_list.ShowGridLines = True
        Me.lv_trip_ticket_list.Size = New System.Drawing.Size(356, 543)
        Me.lv_trip_ticket_list.TabIndex = 117
        Me.lv_trip_ticket_list.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox4.Controls.Add(Me.lv_tripticket_information)
        Me.RadGroupBox4.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox4.HeaderText = ""
        Me.RadGroupBox4.Location = New System.Drawing.Point(371, 342)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(887, 242)
        Me.RadGroupBox4.TabIndex = 4
        '
        'lv_tripticket_information
        '
        Me.lv_tripticket_information.AllowColumnReorder = False
        Me.lv_tripticket_information.AllowEdit = False
        Me.lv_tripticket_information.AllowRemove = False
        Me.lv_tripticket_information.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_tripticket_information.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_tripticket_information.HeaderHeight = 30.0!
        Me.lv_tripticket_information.ItemSpacing = -1
        Me.lv_tripticket_information.Location = New System.Drawing.Point(6, 30)
        Me.lv_tripticket_information.Name = "lv_tripticket_information"
        Me.lv_tripticket_information.SelectLastAddedItem = False
        Me.lv_tripticket_information.ShowGridLines = True
        Me.lv_tripticket_information.Size = New System.Drawing.Size(875, 207)
        Me.lv_tripticket_information.TabIndex = 117
        Me.lv_tripticket_information.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(8, 12)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(142, 19)
        Me.RadLabel5.TabIndex = 118
        Me.RadLabel5.Text = "Trip Ticket Information"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.lv_tripticket_unprocessed)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(3, 4)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(451, 335)
        Me.RadGroupBox3.TabIndex = 7
        '
        'lv_tripticket_unprocessed
        '
        Me.lv_tripticket_unprocessed.AllowColumnReorder = False
        Me.lv_tripticket_unprocessed.AllowEdit = False
        Me.lv_tripticket_unprocessed.AllowRemove = False
        Me.lv_tripticket_unprocessed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_tripticket_unprocessed.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_tripticket_unprocessed.HeaderHeight = 30.0!
        Me.lv_tripticket_unprocessed.ItemSpacing = -1
        Me.lv_tripticket_unprocessed.Location = New System.Drawing.Point(6, 31)
        Me.lv_tripticket_unprocessed.Name = "lv_tripticket_unprocessed"
        Me.lv_tripticket_unprocessed.SelectLastAddedItem = False
        Me.lv_tripticket_unprocessed.ShowGridLines = True
        Me.lv_tripticket_unprocessed.Size = New System.Drawing.Size(439, 297)
        Me.lv_tripticket_unprocessed.TabIndex = 117
        Me.lv_tripticket_unprocessed.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(6, 13)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(144, 19)
        Me.RadLabel3.TabIndex = 118
        Me.RadLabel3.Text = "Unprocessed trip Ticket"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.lv_tripticket_processed)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(420, 336)
        Me.RadGroupBox2.TabIndex = 6
        '
        'lv_tripticket_processed
        '
        Me.lv_tripticket_processed.AllowColumnReorder = False
        Me.lv_tripticket_processed.AllowEdit = False
        Me.lv_tripticket_processed.AllowRemove = False
        Me.lv_tripticket_processed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_tripticket_processed.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lv_tripticket_processed.HeaderHeight = 30.0!
        Me.lv_tripticket_processed.ItemSpacing = -1
        Me.lv_tripticket_processed.Location = New System.Drawing.Point(6, 32)
        Me.lv_tripticket_processed.Name = "lv_tripticket_processed"
        Me.lv_tripticket_processed.SelectLastAddedItem = False
        Me.lv_tripticket_processed.ShowGridLines = True
        Me.lv_tripticket_processed.Size = New System.Drawing.Size(408, 297)
        Me.lv_tripticket_processed.TabIndex = 117
        Me.lv_tripticket_processed.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(6, 14)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(130, 19)
        Me.RadLabel4.TabIndex = 118
        Me.RadLabel4.Text = "Processed Trip Ticket"
        '
        'RadSplitContainer1
        '
        Me.RadSplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadSplitContainer1.Controls.Add(Me.SplitPanel1)
        Me.RadSplitContainer1.Controls.Add(Me.SplitPanel2)
        Me.RadSplitContainer1.Location = New System.Drawing.Point(371, 1)
        Me.RadSplitContainer1.Name = "RadSplitContainer1"
        '
        '
        '
        Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer1.Size = New System.Drawing.Size(887, 342)
        Me.RadSplitContainer1.SplitterWidth = 4
        Me.RadSplitContainer1.TabIndex = 8
        Me.RadSplitContainer1.TabStop = False
        Me.RadSplitContainer1.Text = "RadSplitContainer1"
        '
        'SplitPanel1
        '
        Me.SplitPanel1.Controls.Add(Me.RadGroupBox2)
        Me.SplitPanel1.Location = New System.Drawing.Point(0, 0)
        Me.SplitPanel1.Name = "SplitPanel1"
        '
        '
        '
        Me.SplitPanel1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.SplitPanel1.Size = New System.Drawing.Size(426, 342)
        Me.SplitPanel1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.01702127!, 0.0!)
        Me.SplitPanel1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-16, 0)
        Me.SplitPanel1.TabIndex = 0
        Me.SplitPanel1.TabStop = False
        Me.SplitPanel1.Text = "SplitPanel1"
        '
        'SplitPanel2
        '
        Me.SplitPanel2.Controls.Add(Me.RadGroupBox3)
        Me.SplitPanel2.Location = New System.Drawing.Point(430, 0)
        Me.SplitPanel2.Name = "SplitPanel2"
        '
        '
        '
        Me.SplitPanel2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.SplitPanel2.Size = New System.Drawing.Size(457, 342)
        Me.SplitPanel2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.0170213!, 0.0!)
        Me.SplitPanel2.SizeInfo.SplitterCorrection = New System.Drawing.Size(16, 0)
        Me.SplitPanel2.TabIndex = 1
        Me.SplitPanel2.TabStop = False
        Me.SplitPanel2.Text = "SplitPanel2"
        '
        'cms_issued_ticket
        '
        Me.cms_issued_ticket.Items.AddRange(New Telerik.WinControls.RadItem() {Me.view_more_date_info})
        '
        'view_more_date_info
        '
        Me.view_more_date_info.AccessibleDescription = "View Detail to this Date"
        Me.view_more_date_info.AccessibleName = "View Detail to this Date"
        Me.view_more_date_info.Name = "view_more_date_info"
        Me.view_more_date_info.Text = "View Detail to this Date"
        Me.view_more_date_info.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'Frm_trip_ticket_monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 584)
        Me.Controls.Add(Me.RadSplitContainer1)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "Frm_trip_ticket_monitoring"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_trip_ticket_monitoring"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.btn_lotno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_trip_ticket_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        Me.RadGroupBox4.PerformLayout()
        CType(Me.lv_tripticket_information, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.lv_tripticket_unprocessed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.lv_tripticket_processed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer1.ResumeLayout(False)
        CType(Me.SplitPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitPanel1.ResumeLayout(False)
        CType(Me.SplitPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitPanel2.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_lotno As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_trip_ticket_list As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lv_tripticket_information As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lv_tripticket_unprocessed As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lv_tripticket_processed As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
    Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents cms_issued_ticket As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents view_more_date_info As Telerik.WinControls.UI.RadMenuItem
End Class

