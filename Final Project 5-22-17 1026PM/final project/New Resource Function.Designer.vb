<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_NewResource
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_NewResource))
        Me.DirectorySearcher4 = New System.DirectoryServices.DirectorySearcher()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DirectorySearcher3 = New System.DirectoryServices.DirectorySearcher()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.cbox_checkout = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.txt_authFirst = New System.Windows.Forms.TextBox()
        Me.txt_ISBN = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_resourceID = New System.Windows.Forms.TextBox()
        Me.txt_sub2 = New System.Windows.Forms.ComboBox()
        Me.txt_resourceIDCount = New System.Windows.Forms.TextBox()
        Me.txt_sub1 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_publYear = New System.Windows.Forms.TextBox()
        Me.txt_info = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_series = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_authLast = New System.Windows.Forms.TextBox()
        Me.txt_authMid = New System.Windows.Forms.TextBox()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_addRes = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.ELibrary_DatabaseDataSet = New WindowsApplication1.ELibrary_DatabaseDataSet()
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryResourcesTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DirectorySearcher4
        '
        Me.DirectorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher3
        '
        Me.DirectorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1056, 408)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(227, 117)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 74
        Me.PictureBox2.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(69, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 17)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Home >"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(1056, 234)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 73
        Me.MonthCalendar1.TabStop = False
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LinkLabel12.LinkColor = System.Drawing.Color.White
        Me.LinkLabel12.Location = New System.Drawing.Point(132, 20)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(141, 17)
        Me.LinkLabel12.TabIndex = 17
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "Add New Resource >"
        '
        'cbox_checkout
        '
        Me.cbox_checkout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_checkout.FormattingEnabled = True
        Me.cbox_checkout.Items.AddRange(New Object() {"7", "14", "28"})
        Me.cbox_checkout.Location = New System.Drawing.Point(187, 63)
        Me.cbox_checkout.Name = "cbox_checkout"
        Me.cbox_checkout.Size = New System.Drawing.Size(43, 21)
        Me.cbox_checkout.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(571, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 24)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Add New Resource"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Checkout Period * :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Resource Info * :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "ISBN * :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Year Published * (YYYY):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Title * :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Author (First * , Middle, Last *): "
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(187, 90)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(277, 20)
        Me.txt_title.TabIndex = 2
        '
        'txt_authFirst
        '
        Me.txt_authFirst.Location = New System.Drawing.Point(188, 116)
        Me.txt_authFirst.Name = "txt_authFirst"
        Me.txt_authFirst.Size = New System.Drawing.Size(103, 20)
        Me.txt_authFirst.TabIndex = 3
        '
        'txt_ISBN
        '
        Me.txt_ISBN.Location = New System.Drawing.Point(187, 168)
        Me.txt_ISBN.MaxLength = 16
        Me.txt_ISBN.Name = "txt_ISBN"
        Me.txt_ISBN.Size = New System.Drawing.Size(277, 20)
        Me.txt_ISBN.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_resourceID)
        Me.Panel1.Controls.Add(Me.txt_sub2)
        Me.Panel1.Controls.Add(Me.txt_resourceIDCount)
        Me.Panel1.Controls.Add(Me.txt_sub1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txt_publYear)
        Me.Panel1.Controls.Add(Me.txt_info)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_series)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_authLast)
        Me.Panel1.Controls.Add(Me.txt_authMid)
        Me.Panel1.Controls.Add(Me.txt_title)
        Me.Panel1.Controls.Add(Me.txt_ISBN)
        Me.Panel1.Controls.Add(Me.cbox_checkout)
        Me.Panel1.Controls.Add(Me.txt_authFirst)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(423, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 446)
        Me.Panel1.TabIndex = 133
        '
        'txt_resourceID
        '
        Me.txt_resourceID.Location = New System.Drawing.Point(195, 274)
        Me.txt_resourceID.MaxLength = 7
        Me.txt_resourceID.Name = "txt_resourceID"
        Me.txt_resourceID.Size = New System.Drawing.Size(51, 20)
        Me.txt_resourceID.TabIndex = 11
        '
        'txt_sub2
        '
        Me.txt_sub2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_sub2.FormattingEnabled = True
        Me.txt_sub2.Items.AddRange(New Object() {"None", "Youth Fiction", "Mystery/Thriller", "Drama/Romance"})
        Me.txt_sub2.Location = New System.Drawing.Point(187, 244)
        Me.txt_sub2.Name = "txt_sub2"
        Me.txt_sub2.Size = New System.Drawing.Size(107, 21)
        Me.txt_sub2.TabIndex = 10
        '
        'txt_resourceIDCount
        '
        Me.txt_resourceIDCount.Location = New System.Drawing.Point(271, 274)
        Me.txt_resourceIDCount.MaxLength = 2
        Me.txt_resourceIDCount.Name = "txt_resourceIDCount"
        Me.txt_resourceIDCount.Size = New System.Drawing.Size(20, 20)
        Me.txt_resourceIDCount.TabIndex = 12
        '
        'txt_sub1
        '
        Me.txt_sub1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_sub1.FormattingEnabled = True
        Me.txt_sub1.Items.AddRange(New Object() {"Fiction", "Non-Fiction", "Science Fiction", "Fantasy"})
        Me.txt_sub1.Location = New System.Drawing.Point(187, 218)
        Me.txt_sub1.Name = "txt_sub1"
        Me.txt_sub1.Size = New System.Drawing.Size(107, 21)
        Me.txt_sub1.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(252, 277)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 152
        Me.Label16.Text = "_"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(184, 277)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "b"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(42, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(349, 39)
        Me.Label14.TabIndex = 150
        Me.Label14.Text = "Resources with a star (*) next to them must be filled out. The resource ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "consi" &
    "sts of the letter 'b' with 7 numbers, an underscore, and then another" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "number th" &
    "at denotes the copy."
        '
        'txt_publYear
        '
        Me.txt_publYear.Location = New System.Drawing.Point(187, 142)
        Me.txt_publYear.MaxLength = 4
        Me.txt_publYear.Name = "txt_publYear"
        Me.txt_publYear.Size = New System.Drawing.Size(50, 20)
        Me.txt_publYear.TabIndex = 6
        '
        'txt_info
        '
        Me.txt_info.Location = New System.Drawing.Point(187, 307)
        Me.txt_info.Multiline = True
        Me.txt_info.Name = "txt_info"
        Me.txt_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_info.Size = New System.Drawing.Size(277, 119)
        Me.txt_info.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 13)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "Resource ID  * (b1234567_8):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(102, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "Subject 2 * :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Subject 1 * :"
        '
        'txt_series
        '
        Me.txt_series.Location = New System.Drawing.Point(187, 192)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.Size = New System.Drawing.Size(277, 20)
        Me.txt_series.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Series:"
        '
        'txt_authLast
        '
        Me.txt_authLast.Location = New System.Drawing.Point(366, 116)
        Me.txt_authLast.Name = "txt_authLast"
        Me.txt_authLast.Size = New System.Drawing.Size(98, 20)
        Me.txt_authLast.TabIndex = 5
        '
        'txt_authMid
        '
        Me.txt_authMid.Location = New System.Drawing.Point(298, 116)
        Me.txt_authMid.Name = "txt_authMid"
        Me.txt_authMid.Size = New System.Drawing.Size(62, 20)
        Me.txt_authMid.TabIndex = 4
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LinkLabel9.LinkColor = System.Drawing.Color.White
        Me.LinkLabel9.Location = New System.Drawing.Point(1224, 20)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(59, 17)
        Me.LinkLabel9.TabIndex = 18
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Log Out"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(72, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1211, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 164
        Me.PictureBox3.TabStop = False
        '
        'btn_addRes
        '
        Me.btn_addRes.Location = New System.Drawing.Point(532, 652)
        Me.btn_addRes.Name = "btn_addRes"
        Me.btn_addRes.Size = New System.Drawing.Size(138, 23)
        Me.btn_addRes.TabIndex = 14
        Me.btn_addRes.Text = "Add Resource"
        Me.btn_addRes.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(694, 652)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(138, 23)
        Me.btn_Clear.TabIndex = 15
        Me.btn_Clear.Text = "Clear Form"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'ELibrary_DatabaseDataSet
        '
        Me.ELibrary_DatabaseDataSet.DataSetName = "ELibrary_DatabaseDataSet"
        Me.ELibrary_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryResourcesBindingSource
        '
        Me.LibraryResourcesBindingSource.DataMember = "LibraryResources"
        Me.LibraryResourcesBindingSource.DataSource = Me.ELibrary_DatabaseDataSet
        '
        'LibraryResourcesTableAdapter
        '
        Me.LibraryResourcesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Nothing
        Me.TableAdapterManager.LibraryEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.LibraryMembersTableAdapter = Nothing
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Me.LibraryResourcesTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frm_NewResource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1359, 721)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_addRes)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LinkLabel9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_NewResource"
        Me.Text = "New_Resource_Function"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DirectorySearcher4 As DirectoryServices.DirectorySearcher
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents DirectorySearcher3 As DirectoryServices.DirectorySearcher
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents cbox_checkout As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_title As TextBox
    Friend WithEvents txt_authFirst As TextBox
    Friend WithEvents txt_ISBN As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_resourceID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_series As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_authLast As TextBox
    Friend WithEvents txt_authMid As TextBox
    Friend WithEvents btn_addRes As Button
    Friend WithEvents txt_info As TextBox
    Friend WithEvents ELibrary_DatabaseDataSet As ELibrary_DatabaseDataSet
    Friend WithEvents LibraryResourcesBindingSource As BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As ELibrary_DatabaseDataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents TableAdapterManager As ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txt_publYear As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_resourceIDCount As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_sub2 As ComboBox
    Friend WithEvents txt_sub1 As ComboBox
    Friend WithEvents btn_Clear As Button
End Class
