<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_request_form_update
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
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_save_request = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel_request = New Telerik.WinControls.UI.RadButton()
        Me.btn_add_request = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_ST_ticketsno = New Telerik.WinControls.UI.RadTextBox()
        Me.dt_ST_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ST_ticketsno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTextBox1.Location = New System.Drawing.Point(72, 157)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "<Required>"
        Me.RadTextBox1.Size = New System.Drawing.Size(236, 20)
        Me.RadTextBox1.TabIndex = 35
        '
        'btn_save_request
        '
        Me.btn_save_request.Location = New System.Drawing.Point(960, 416)
        Me.btn_save_request.Name = "btn_save_request"
        Me.btn_save_request.Size = New System.Drawing.Size(110, 24)
        Me.btn_save_request.TabIndex = 46
        Me.btn_save_request.Text = "SAVE"
        '
        'btn_cancel_request
        '
        Me.btn_cancel_request.Location = New System.Drawing.Point(228, 416)
        Me.btn_cancel_request.Name = "btn_cancel_request"
        Me.btn_cancel_request.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel_request.TabIndex = 45
        Me.btn_cancel_request.Text = "CANCEL"
        '
        'btn_add_request
        '
        Me.btn_add_request.Location = New System.Drawing.Point(112, 416)
        Me.btn_add_request.Name = "btn_add_request"
        Me.btn_add_request.Size = New System.Drawing.Size(110, 24)
        Me.btn_add_request.TabIndex = 44
        Me.btn_add_request.Text = "ADD"
        '
        'RadLabel6
        '
        Me.RadLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel6.Location = New System.Drawing.Point(12, 194)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(89, 18)
        Me.RadLabel6.TabIndex = 43
        Me.RadLabel6.Text = "Work Operation:"
        '
        'ListView2
        '
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(12, 218)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(326, 192)
        Me.ListView2.TabIndex = 42
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel5.Location = New System.Drawing.Point(403, 12)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(174, 19)
        Me.RadLabel5.TabIndex = 41
        Me.RadLabel5.Text = "Pending Data...Ready to Save."
        '
        'RadDropDownList2
        '
        Me.RadDropDownList2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.RadDropDownList2.Location = New System.Drawing.Point(72, 122)
        Me.RadDropDownList2.Name = "RadDropDownList2"
        '
        '
        '
        Me.RadDropDownList2.RootElement.StretchVertically = True
        Me.RadDropDownList2.Size = New System.Drawing.Size(236, 20)
        Me.RadDropDownList2.TabIndex = 40
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Location = New System.Drawing.Point(12, 124)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(45, 18)
        Me.RadLabel2.TabIndex = 39
        Me.RadLabel2.Text = "Lot No.:"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.RadDropDownList1.Location = New System.Drawing.Point(72, 87)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        '
        '
        '
        Me.RadDropDownList1.RootElement.StretchVertically = True
        Me.RadDropDownList1.Size = New System.Drawing.Size(236, 20)
        Me.RadDropDownList1.TabIndex = 38
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Location = New System.Drawing.Point(12, 89)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(51, 18)
        Me.RadLabel1.TabIndex = 37
        Me.RadLabel1.Text = "Location:"
        '
        'RadLabel15
        '
        Me.RadLabel15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel15.Location = New System.Drawing.Point(12, 159)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel15.TabIndex = 36
        Me.RadLabel15.Text = "Planter:"
        '
        'txt_ST_ticketsno
        '
        Me.txt_ST_ticketsno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ST_ticketsno.Location = New System.Drawing.Point(105, 13)
        Me.txt_ST_ticketsno.Name = "txt_ST_ticketsno"
        Me.txt_ST_ticketsno.NullText = "<Required>"
        Me.txt_ST_ticketsno.Size = New System.Drawing.Size(203, 20)
        Me.txt_ST_ticketsno.TabIndex = 34
        '
        'dt_ST_date
        '
        Me.dt_ST_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_ST_date.Location = New System.Drawing.Point(47, 47)
        Me.dt_ST_date.Name = "dt_ST_date"
        Me.dt_ST_date.Size = New System.Drawing.Size(258, 20)
        Me.dt_ST_date.TabIndex = 33
        Me.dt_ST_date.TabStop = False
        Me.dt_ST_date.Text = "Monday, December 28, 2015"
        Me.dt_ST_date.Value = New Date(2015, 12, 28, 0, 0, 0, 0)
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Location = New System.Drawing.Point(12, 48)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(32, 18)
        Me.RadLabel4.TabIndex = 32
        Me.RadLabel4.Text = "Date:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(87, 21)
        Me.RadLabel3.TabIndex = 31
        Me.RadLabel3.Text = "Request No.:"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(403, 33)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(667, 377)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Frm_request_form_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 456)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.btn_save_request)
        Me.Controls.Add(Me.btn_cancel_request)
        Me.Controls.Add(Me.btn_add_request)
        Me.Controls.Add(Me.RadLabel6)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.RadLabel5)
        Me.Controls.Add(Me.RadDropDownList2)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadLabel15)
        Me.Controls.Add(Me.txt_ST_ticketsno)
        Me.Controls.Add(Me.dt_ST_date)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_request_form_update"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Form"
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ST_ticketsno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btn_save_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_add_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_ST_ticketsno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dt_ST_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class

