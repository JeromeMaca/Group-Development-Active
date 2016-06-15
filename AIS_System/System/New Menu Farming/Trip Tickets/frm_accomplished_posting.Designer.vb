<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_accomplished_posting
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
        Me.txt_rateperarea = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadLabel23 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_totalamount = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_trip_ticket_no = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_grandtotal = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_update = New Telerik.WinControls.UI.RadButton()
        Me.lv_posting = New Telerik.WinControls.UI.RadListView()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.txt_operation_performed = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_lotno = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.txt_trip_ticket_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_posting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_operation_performed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lotno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_rateperarea
        '
        Me.txt_rateperarea.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_rateperarea.Location = New System.Drawing.Point(556, 42)
        Me.txt_rateperarea.Name = "txt_rateperarea"
        Me.txt_rateperarea.Size = New System.Drawing.Size(142, 22)
        Me.txt_rateperarea.TabIndex = 118
        Me.txt_rateperarea.Text = "₱0.00"
        Me.txt_rateperarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel23
        '
        Me.RadLabel23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel23.Location = New System.Drawing.Point(712, 21)
        Me.RadLabel23.Name = "RadLabel23"
        Me.RadLabel23.Size = New System.Drawing.Size(98, 21)
        Me.RadLabel23.TabIndex = 117
        Me.RadLabel23.Text = "Total Amount:"
        '
        'txt_totalamount
        '
        Me.txt_totalamount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_totalamount.Location = New System.Drawing.Point(712, 42)
        Me.txt_totalamount.Name = "txt_totalamount"
        Me.txt_totalamount.ReadOnly = True
        Me.txt_totalamount.Size = New System.Drawing.Size(142, 22)
        Me.txt_totalamount.TabIndex = 116
        Me.txt_totalamount.TabStop = False
        Me.txt_totalamount.Text = "₱0.00"
        Me.txt_totalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel22
        '
        Me.RadLabel22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel22.Location = New System.Drawing.Point(556, 21)
        Me.RadLabel22.Name = "RadLabel22"
        Me.RadLabel22.Size = New System.Drawing.Size(96, 21)
        Me.RadLabel22.TabIndex = 115
        Me.RadLabel22.Text = "Rate per Area:"
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.txt_trip_ticket_no)
        Me.gb_data.Controls.Add(Me.RadLabel4)
        Me.gb_data.Controls.Add(Me.txt_grandtotal)
        Me.gb_data.Controls.Add(Me.RadLabel3)
        Me.gb_data.Controls.Add(Me.btn_update)
        Me.gb_data.Controls.Add(Me.lv_posting)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(0, 1)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(1019, 386)
        Me.gb_data.TabIndex = 119
        '
        'txt_trip_ticket_no
        '
        Me.txt_trip_ticket_no.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_trip_ticket_no.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_trip_ticket_no.Location = New System.Drawing.Point(113, 19)
        Me.txt_trip_ticket_no.Name = "txt_trip_ticket_no"
        Me.txt_trip_ticket_no.NullText = "<System Generated>"
        Me.txt_trip_ticket_no.ReadOnly = True
        Me.txt_trip_ticket_no.Size = New System.Drawing.Size(199, 20)
        Me.txt_trip_ticket_no.TabIndex = 123
        Me.txt_trip_ticket_no.TabStop = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(5, 20)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(104, 21)
        Me.RadLabel4.TabIndex = 122
        Me.RadLabel4.Text = "Trip Ticket No.:"
        '
        'txt_grandtotal
        '
        Me.txt_grandtotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_grandtotal.Location = New System.Drawing.Point(783, 355)
        Me.txt_grandtotal.Name = "txt_grandtotal"
        Me.txt_grandtotal.ReadOnly = True
        Me.txt_grandtotal.Size = New System.Drawing.Size(223, 22)
        Me.txt_grandtotal.TabIndex = 121
        Me.txt_grandtotal.TabStop = False
        Me.txt_grandtotal.Text = "₱0.00"
        Me.txt_grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(643, 356)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(134, 21)
        Me.RadLabel3.TabIndex = 120
        Me.RadLabel3.Text = "Grand Total Amount:"
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_update.Location = New System.Drawing.Point(5, 353)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(110, 24)
        Me.btn_update.TabIndex = 118
        Me.btn_update.Text = "Update"
        '
        'lv_posting
        '
        Me.lv_posting.AllowEdit = False
        Me.lv_posting.AllowRemove = False
        Me.lv_posting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_posting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lv_posting.ItemSpacing = -1
        Me.lv_posting.Location = New System.Drawing.Point(5, 47)
        Me.lv_posting.Name = "lv_posting"
        Me.lv_posting.SelectLastAddedItem = False
        Me.lv_posting.ShowGridLines = True
        Me.lv_posting.Size = New System.Drawing.Size(1009, 300)
        Me.lv_posting.TabIndex = 0
        Me.lv_posting.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.Location = New System.Drawing.Point(896, 51)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Cancel"
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.btn_save)
        Me.gb_menu.Controls.Add(Me.txt_operation_performed)
        Me.gb_menu.Controls.Add(Me.txt_lotno)
        Me.gb_menu.Controls.Add(Me.RadLabel2)
        Me.gb_menu.Controls.Add(Me.RadLabel1)
        Me.gb_menu.Controls.Add(Me.RadLabel22)
        Me.gb_menu.Controls.Add(Me.txt_totalamount)
        Me.gb_menu.Controls.Add(Me.btn_cancel)
        Me.gb_menu.Controls.Add(Me.txt_rateperarea)
        Me.gb_menu.Controls.Add(Me.RadLabel23)
        Me.gb_menu.Enabled = False
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(0, 386)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(1019, 95)
        Me.gb_menu.TabIndex = 120
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.Location = New System.Drawing.Point(896, 21)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 24)
        Me.btn_save.TabIndex = 122
        Me.btn_save.Text = "Save"
        '
        'txt_operation_performed
        '
        Me.txt_operation_performed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_operation_performed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_operation_performed.Location = New System.Drawing.Point(269, 44)
        Me.txt_operation_performed.Name = "txt_operation_performed"
        Me.txt_operation_performed.NullText = "<System Generated>"
        Me.txt_operation_performed.ReadOnly = True
        Me.txt_operation_performed.Size = New System.Drawing.Size(233, 20)
        Me.txt_operation_performed.TabIndex = 121
        Me.txt_operation_performed.TabStop = False
        '
        'txt_lotno
        '
        Me.txt_lotno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lotno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_lotno.Location = New System.Drawing.Point(22, 44)
        Me.txt_lotno.Name = "txt_lotno"
        Me.txt_lotno.NullText = "<System Generated>"
        Me.txt_lotno.ReadOnly = True
        Me.txt_lotno.Size = New System.Drawing.Size(204, 20)
        Me.txt_lotno.TabIndex = 120
        Me.txt_lotno.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(269, 21)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(145, 21)
        Me.RadLabel2.TabIndex = 119
        Me.RadLabel2.Text = "Operation Performed:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(19, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(86, 21)
        Me.RadLabel1.TabIndex = 119
        Me.RadLabel1.Text = "Lot Number:"
        '
        'Frm_accomplished_posting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 481)
        Me.Controls.Add(Me.gb_menu)
        Me.Controls.Add(Me.gb_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_accomplished_posting"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_accomplished_posting"
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.txt_trip_ticket_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_posting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_operation_performed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lotno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_rateperarea As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents RadLabel23 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_totalamount As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents RadLabel22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_update As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_posting As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_operation_performed As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_lotno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_grandtotal As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents txt_trip_ticket_no As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
End Class

