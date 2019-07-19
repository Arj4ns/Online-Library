<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_MemHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_MemHome))
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher3 = New System.DirectoryServices.DirectorySearcher()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.txt_SearchBox = New System.Windows.Forms.TextBox()
        Me.DirectorySearcher4 = New System.DirectoryServices.DirectorySearcher()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_TotReasource = New System.Windows.Forms.Label()
        Me.lbl_Name = New System.Windows.Forms.Label()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_memClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.Results = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Checkout = New System.Windows.Forms.Button()
        Me.ELibrary_DatabaseDataSet = New WindowsApplication1.ELibrary_DatabaseDataSet()
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryResourcesTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckoutTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.CheckoutTableAdapter()
        Me.btn_desc = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher3
        '
        Me.DirectorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(573, 52)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.btn_Search.TabIndex = 2
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'txt_SearchBox
        '
        Me.txt_SearchBox.Location = New System.Drawing.Point(24, 54)
        Me.txt_SearchBox.Name = "txt_SearchBox"
        Me.txt_SearchBox.Size = New System.Drawing.Size(543, 20)
        Me.txt_SearchBox.TabIndex = 1
        '
        'DirectorySearcher4
        '
        Me.DirectorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(70, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Home >"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(73, 354)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 36
        Me.MonthCalendar1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1056, 207)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(227, 117)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Welcome,"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_TotReasource)
        Me.Panel1.Controls.Add(Me.lbl_Name)
        Me.Panel1.Controls.Add(Me.LinkLabel10)
        Me.Panel1.Controls.Add(Me.LinkLabel8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(73, 207)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 135)
        Me.Panel1.TabIndex = 40
        '
        'lbl_TotReasource
        '
        Me.lbl_TotReasource.AutoSize = True
        Me.lbl_TotReasource.Location = New System.Drawing.Point(3, 58)
        Me.lbl_TotReasource.Name = "lbl_TotReasource"
        Me.lbl_TotReasource.Size = New System.Drawing.Size(199, 13)
        Me.lbl_TotReasource.TabIndex = 46
        Me.lbl_TotReasource.Text = "You have 0/10 Resources checked out."
        '
        'lbl_Name
        '
        Me.lbl_Name.AutoSize = True
        Me.lbl_Name.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Name.Location = New System.Drawing.Point(78, 10)
        Me.lbl_Name.Name = "lbl_Name"
        Me.lbl_Name.Size = New System.Drawing.Size(51, 16)
        Me.lbl_Name.TabIndex = 44
        Me.lbl_Name.Text = "Label3"
        '
        'LinkLabel10
        '
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.Location = New System.Drawing.Point(13, 85)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel10.TabIndex = 42
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Location = New System.Drawing.Point(3, 38)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(102, 13)
        Me.LinkLabel8.TabIndex = 5
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Account Information"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_memClear)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_SearchBox)
        Me.Panel2.Controls.Add(Me.btn_Search)
        Me.Panel2.Location = New System.Drawing.Point(312, 207)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(738, 117)
        Me.Panel2.TabIndex = 42
        '
        'btn_memClear
        '
        Me.btn_memClear.Location = New System.Drawing.Point(654, 52)
        Me.btn_memClear.Name = "btn_memClear"
        Me.btn_memClear.Size = New System.Drawing.Size(75, 23)
        Me.btn_memClear.TabIndex = 3
        Me.btn_memClear.Text = "Clear"
        Me.btn_memClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(609, 26)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "You can search resources by: ExactTitle, Title keywords, the Last Name of the Aut" &
    "hor, the ISBN, the Series, or keywords of the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "series that the resource is from" &
    "."
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel12.LinkColor = System.Drawing.Color.White
        Me.LinkLabel12.Location = New System.Drawing.Point(1224, 20)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(59, 17)
        Me.LinkLabel12.TabIndex = 7
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "Log Out"
        '
        'Results
        '
        Me.Results.AllowUserToAddRows = False
        Me.Results.AllowUserToDeleteRows = False
        Me.Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.Results.Location = New System.Drawing.Point(312, 336)
        Me.Results.Name = "Results"
        Me.Results.ReadOnly = True
        Me.Results.RowHeadersVisible = False
        Me.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Results.Size = New System.Drawing.Size(971, 213)
        Me.Results.TabIndex = 145
        Me.Results.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Title"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column2
        '
        Me.Column2.HeaderText = "Author"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Publication Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Series"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Availibility"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Checkout Period"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Resource ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1211, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'btn_Checkout
        '
        Me.btn_Checkout.Location = New System.Drawing.Point(466, 555)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(148, 23)
        Me.btn_Checkout.TabIndex = 5
        Me.btn_Checkout.Text = "Check Out"
        Me.btn_Checkout.UseVisualStyleBackColor = True
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
        'CheckoutBindingSource
        '
        Me.CheckoutBindingSource.DataMember = "Checkout"
        Me.CheckoutBindingSource.DataSource = Me.ELibrary_DatabaseDataSet
        '
        'CheckoutTableAdapter
        '
        Me.CheckoutTableAdapter.ClearBeforeFill = True
        '
        'btn_desc
        '
        Me.btn_desc.Location = New System.Drawing.Point(312, 555)
        Me.btn_desc.Name = "btn_desc"
        Me.btn_desc.Size = New System.Drawing.Size(148, 23)
        Me.btn_desc.TabIndex = 4
        Me.btn_desc.Text = "Resource Description"
        Me.btn_desc.UseVisualStyleBackColor = True
        '
        'frm_MemHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1359, 721)
        Me.Controls.Add(Me.btn_desc)
        Me.Controls.Add(Me.btn_Checkout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Results)
        Me.Controls.Add(Me.LinkLabel12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_MemHome"
        Me.Text = "Home Screen Member "
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher3 As DirectoryServices.DirectorySearcher
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btn_Search As Button
    Friend WithEvents txt_SearchBox As TextBox
    Friend WithEvents DirectorySearcher4 As DirectoryServices.DirectorySearcher
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents lbl_Name As Label
    Friend WithEvents ELibrary_DatabaseDataSet As ELibrary_DatabaseDataSet
    Friend WithEvents LibraryResourcesBindingSource As BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As ELibrary_DatabaseDataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents TableAdapterManager As ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents CheckoutTableAdapter As ELibrary_DatabaseDataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents Results As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Checkout As Button
    Friend WithEvents btn_memClear As Button
    Friend WithEvents btn_desc As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents lbl_TotReasource As Label
End Class
