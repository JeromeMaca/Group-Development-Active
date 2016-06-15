<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_job_ticket_NEW
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
        Me.pvp_tab = New Telerik.WinControls.UI.RadPageView()
        Me.pvp_1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pvp1_tab = New Telerik.WinControls.UI.RadPageView()
        Me.pvp1_1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_ST_ticketsno = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_request_opearation = New System.Windows.Forms.ListView()
        Me.pvp1_2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pvp_2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.pvp2_tab = New Telerik.WinControls.UI.RadPageView()
        Me.pvp2_1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.pvp2_2 = New Telerik.WinControls.UI.RadPageViewPage()
        CType(Me.pvp_tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvp_tab.SuspendLayout()
        Me.pvp_1.SuspendLayout()
        CType(Me.pvp1_tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvp1_tab.SuspendLayout()
        Me.pvp1_1.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.txt_ST_ticketsno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvp_2.SuspendLayout()
        CType(Me.pvp2_tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pvp2_tab.SuspendLayout()
        Me.pvp2_1.SuspendLayout()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pvp_tab
        '
        Me.pvp_tab.Controls.Add(Me.pvp_1)
        Me.pvp_tab.Controls.Add(Me.pvp_2)
        Me.pvp_tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvp_tab.Location = New System.Drawing.Point(0, 0)
        Me.pvp_tab.Name = "pvp_tab"
        Me.pvp_tab.SelectedPage = Me.pvp_2
        Me.pvp_tab.Size = New System.Drawing.Size(908, 581)
        Me.pvp_tab.TabIndex = 0
        Me.pvp_tab.Text = "RadPageView1"
        Me.pvp_tab.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage
        '
        'pvp_1
        '
        Me.pvp_1.Controls.Add(Me.pvp1_tab)
        Me.pvp_1.Location = New System.Drawing.Point(305, 4)
        Me.pvp_1.Name = "pvp_1"
        Me.pvp_1.Size = New System.Drawing.Size(599, 573)
        Me.pvp_1.Text = "Schedule Job Ticket"
        '
        'pvp1_tab
        '
        Me.pvp1_tab.Controls.Add(Me.pvp1_1)
        Me.pvp1_tab.Controls.Add(Me.pvp1_2)
        Me.pvp1_tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvp1_tab.Location = New System.Drawing.Point(0, 0)
        Me.pvp1_tab.Name = "pvp1_tab"
        Me.pvp1_tab.SelectedPage = Me.pvp1_1
        Me.pvp1_tab.Size = New System.Drawing.Size(599, 573)
        Me.pvp1_tab.TabIndex = 1
        Me.pvp1_tab.Text = "RadPageView1"
        CType(Me.pvp1_tab.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'pvp1_1
        '
        Me.pvp1_1.Controls.Add(Me.RadGroupBox2)
        Me.pvp1_1.Location = New System.Drawing.Point(10, 37)
        Me.pvp1_1.Name = "pvp1_1"
        Me.pvp1_1.Size = New System.Drawing.Size(578, 525)
        Me.pvp1_1.Text = "Schedule Job Ticket"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.txt_ST_ticketsno)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.lv_request_opearation)
        Me.RadGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(578, 525)
        Me.RadGroupBox2.TabIndex = 2
        '
        'txt_ST_ticketsno
        '
        Me.txt_ST_ticketsno.Location = New System.Drawing.Point(98, 21)
        Me.txt_ST_ticketsno.Name = "txt_ST_ticketsno"
        Me.txt_ST_ticketsno.NullText = "<Required>"
        Me.txt_ST_ticketsno.Size = New System.Drawing.Size(216, 20)
        Me.txt_ST_ticketsno.TabIndex = 18
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(7, 21)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(87, 21)
        Me.RadLabel3.TabIndex = 17
        Me.RadLabel3.Text = "Request No.:"
        '
        'lv_request_opearation
        '
        Me.lv_request_opearation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_request_opearation.FullRowSelect = True
        Me.lv_request_opearation.GridLines = True
        Me.lv_request_opearation.Location = New System.Drawing.Point(6, 47)
        Me.lv_request_opearation.Name = "lv_request_opearation"
        Me.lv_request_opearation.Size = New System.Drawing.Size(566, 472)
        Me.lv_request_opearation.TabIndex = 0
        Me.lv_request_opearation.UseCompatibleStateImageBehavior = False
        Me.lv_request_opearation.View = System.Windows.Forms.View.Details
        '
        'pvp1_2
        '
        Me.pvp1_2.Location = New System.Drawing.Point(10, 37)
        Me.pvp1_2.Name = "pvp1_2"
        Me.pvp1_2.Size = New System.Drawing.Size(578, 525)
        Me.pvp1_2.Text = "Approved Request Item List"
        '
        'pvp_2
        '
        Me.pvp_2.Controls.Add(Me.pvp2_tab)
        Me.pvp_2.Location = New System.Drawing.Point(305, 4)
        Me.pvp_2.Name = "pvp_2"
        Me.pvp_2.Size = New System.Drawing.Size(599, 573)
        Me.pvp_2.Text = "Accomplish Job Ticket"
        '
        'pvp2_tab
        '
        Me.pvp2_tab.Controls.Add(Me.pvp2_1)
        Me.pvp2_tab.Controls.Add(Me.pvp2_2)
        Me.pvp2_tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pvp2_tab.Location = New System.Drawing.Point(0, 0)
        Me.pvp2_tab.Name = "pvp2_tab"
        Me.pvp2_tab.SelectedPage = Me.pvp2_1
        Me.pvp2_tab.Size = New System.Drawing.Size(599, 573)
        Me.pvp2_tab.TabIndex = 2
        Me.pvp2_tab.Text = "RadPageView1"
        CType(Me.pvp2_tab.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'pvp2_1
        '
        Me.pvp2_1.Controls.Add(Me.RadGroupBox1)
        Me.pvp2_1.Location = New System.Drawing.Point(10, 37)
        Me.pvp2_1.Name = "pvp2_1"
        Me.pvp2_1.Size = New System.Drawing.Size(578, 525)
        Me.pvp2_1.Text = "Accomplish Job Ticket"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadTextBox1)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.ListView1)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(578, 525)
        Me.RadGroupBox1.TabIndex = 2
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(98, 21)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "<Required>"
        Me.RadTextBox1.Size = New System.Drawing.Size(216, 20)
        Me.RadTextBox1.TabIndex = 18
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(7, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(87, 21)
        Me.RadLabel1.TabIndex = 17
        Me.RadLabel1.Text = "Request No.:"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 47)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(566, 472)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'pvp2_2
        '
        Me.pvp2_2.Location = New System.Drawing.Point(10, 37)
        Me.pvp2_2.Name = "pvp2_2"
        Me.pvp2_2.Size = New System.Drawing.Size(578, 525)
        Me.pvp2_2.Text = "Posted Job Ticket"
        '
        'Frm_job_ticket_NEW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 581)
        Me.Controls.Add(Me.pvp_tab)
        Me.Name = "Frm_job_ticket_NEW"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_job_ticket_NEW"
        CType(Me.pvp_tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvp_tab.ResumeLayout(False)
        Me.pvp_1.ResumeLayout(False)
        CType(Me.pvp1_tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvp1_tab.ResumeLayout(False)
        Me.pvp1_1.ResumeLayout(False)
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.txt_ST_ticketsno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvp_2.ResumeLayout(False)
        CType(Me.pvp2_tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pvp2_tab.ResumeLayout(False)
        Me.pvp2_1.ResumeLayout(False)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pvp_tab As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pvp_1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvp_2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvp1_tab As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pvp1_1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_ST_ticketsno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lv_request_opearation As System.Windows.Forms.ListView
    Friend WithEvents pvp1_2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents pvp2_tab As Telerik.WinControls.UI.RadPageView
    Friend WithEvents pvp2_1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents pvp2_2 As Telerik.WinControls.UI.RadPageViewPage
End Class

