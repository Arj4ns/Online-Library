<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AccInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AccInfo))
        Me.DirectorySearcher4 = New System.DirectoryServices.DirectorySearcher()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DirectorySearcher3 = New System.DirectoryServices.DirectorySearcher()
        Me.lnk_Home = New System.Windows.Forms.LinkLabel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label_30 = New System.Windows.Forms.Label()
        Me.lbl_zip = New System.Windows.Forms.Label()
        Me.lbl_state = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_city = New System.Windows.Forms.Label()
        Me.lbl_Address = New System.Windows.Forms.Label()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lnk_AccInfo = New System.Windows.Forms.LinkLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lnk_logOut = New System.Windows.Forms.LinkLabel()
        Me.Results = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Renew = New System.Windows.Forms.Button()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.ELibrary_DatabaseDataSet = New WindowsApplication1.ELibrary_DatabaseDataSet()
        Me.CheckoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckoutTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.CheckoutTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.LibraryResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryResourcesTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.LibraryResourcesTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        'lnk_Home
        '
        Me.lnk_Home.AutoSize = True
        Me.lnk_Home.BackColor = System.Drawing.Color.Transparent
        Me.lnk_Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_Home.LinkColor = System.Drawing.Color.White
        Me.lnk_Home.Location = New System.Drawing.Point(69, 20)
        Me.lnk_Home.Name = "lnk_Home"
        Me.lnk_Home.Size = New System.Drawing.Size(57, 17)
        Me.lnk_Home.TabIndex = 66
        Me.lnk_Home.TabStop = True
        Me.lnk_Home.Text = "Home >"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(76, 492)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1211, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_ID)
        Me.Panel1.Controls.Add(Me.Label_30)
        Me.Panel1.Controls.Add(Me.lbl_zip)
        Me.Panel1.Controls.Add(Me.lbl_state)
        Me.Panel1.Controls.Add(Me.lbl_email)
        Me.Panel1.Controls.Add(Me.lbl_city)
        Me.Panel1.Controls.Add(Me.lbl_Address)
        Me.Panel1.Controls.Add(Me.lbl_lastName)
        Me.Panel1.Controls.Add(Me.lbl_firstName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(76, 281)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 199)
        Me.Panel1.TabIndex = 83
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(70, 6)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(45, 13)
        Me.lbl_ID.TabIndex = 157
        Me.lbl_ID.Text = "Label27"
        '
        'Label_30
        '
        Me.Label_30.AutoSize = True
        Me.Label_30.Location = New System.Drawing.Point(9, 6)
        Me.Label_30.Name = "Label_30"
        Me.Label_30.Size = New System.Drawing.Size(62, 13)
        Me.Label_30.TabIndex = 156
        Me.Label_30.Text = "Member ID:"
        '
        'lbl_zip
        '
        Me.lbl_zip.AutoSize = True
        Me.lbl_zip.Location = New System.Drawing.Point(70, 155)
        Me.lbl_zip.Name = "lbl_zip"
        Me.lbl_zip.Size = New System.Drawing.Size(45, 13)
        Me.lbl_zip.TabIndex = 154
        Me.lbl_zip.Text = "Label27"
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.Location = New System.Drawing.Point(70, 133)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(45, 13)
        Me.lbl_state.TabIndex = 153
        Me.lbl_state.Text = "Label27"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(70, 177)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(45, 13)
        Me.lbl_email.TabIndex = 152
        Me.lbl_email.Text = "Label27"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Location = New System.Drawing.Point(70, 107)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(45, 13)
        Me.lbl_city.TabIndex = 151
        Me.lbl_city.Text = "Label27"
        '
        'lbl_Address
        '
        Me.lbl_Address.AutoSize = True
        Me.lbl_Address.Location = New System.Drawing.Point(70, 81)
        Me.lbl_Address.Name = "lbl_Address"
        Me.lbl_Address.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Address.TabIndex = 150
        Me.lbl_Address.Text = "Label27"
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(70, 55)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(45, 13)
        Me.lbl_lastName.TabIndex = 149
        Me.lbl_lastName.Text = "Label27"
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(70, 29)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(45, 13)
        Me.lbl_firstName.TabIndex = 148
        Me.lbl_firstName.Text = "Label27"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "First Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Last Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "City:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Zip Code:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(74, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(229, 27)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Account Information"
        '
        'lnk_AccInfo
        '
        Me.lnk_AccInfo.AutoSize = True
        Me.lnk_AccInfo.BackColor = System.Drawing.Color.Transparent
        Me.lnk_AccInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_AccInfo.LinkColor = System.Drawing.Color.White
        Me.lnk_AccInfo.Location = New System.Drawing.Point(132, 20)
        Me.lnk_AccInfo.Name = "lnk_AccInfo"
        Me.lnk_AccInfo.Size = New System.Drawing.Size(145, 17)
        Me.lnk_AccInfo.TabIndex = 84
        Me.lnk_AccInfo.TabStop = True
        Me.lnk_AccInfo.Text = "Account Information >"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Baskerville Old Face", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(711, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 27)
        Me.Label12.TabIndex = 139
        Me.Label12.Text = "Pending Books"
        '
        'lnk_logOut
        '
        Me.lnk_logOut.AutoSize = True
        Me.lnk_logOut.BackColor = System.Drawing.Color.Transparent
        Me.lnk_logOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_logOut.LinkColor = System.Drawing.Color.White
        Me.lnk_logOut.Location = New System.Drawing.Point(1224, 20)
        Me.lnk_logOut.Name = "lnk_logOut"
        Me.lnk_logOut.Size = New System.Drawing.Size(59, 17)
        Me.lnk_logOut.TabIndex = 143
        Me.lnk_logOut.TabStop = True
        Me.lnk_logOut.Text = "Log Out"
        '
        'Results
        '
        Me.Results.AllowUserToAddRows = False
        Me.Results.AllowUserToDeleteRows = False
        Me.Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Author, Me.StartDate, Me.dateReturned, Me.Column1, Me.Column2, Me.Column3, Me.Column8})
        Me.Results.Location = New System.Drawing.Point(313, 203)
        Me.Results.Name = "Results"
        Me.Results.ReadOnly = True
        Me.Results.RowHeadersVisible = False
        Me.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Results.Size = New System.Drawing.Size(970, 326)
        Me.Results.TabIndex = 144
        '
        'Title
        '
        Me.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Author
        '
        Me.Author.HeaderText = "Author"
        Me.Author.Name = "Author"
        Me.Author.ReadOnly = True
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "Publication Date"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        '
        'dateReturned
        '
        Me.dateReturned.HeaderText = "Series"
        Me.dateReturned.Name = "dateReturned"
        Me.dateReturned.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date Checked Out"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date Due"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Checkout Period (Days)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Resource ID"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'btn_Renew
        '
        Me.btn_Renew.Location = New System.Drawing.Point(313, 535)
        Me.btn_Renew.Name = "btn_Renew"
        Me.btn_Renew.Size = New System.Drawing.Size(246, 25)
        Me.btn_Renew.TabIndex = 146
        Me.btn_Renew.Text = "Renew Resource"
        Me.btn_Renew.UseVisualStyleBackColor = True
        '
        'btn_Return
        '
        Me.btn_Return.Location = New System.Drawing.Point(565, 535)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(249, 25)
        Me.btn_Return.TabIndex = 147
        Me.btn_Return.Text = "Return Resource"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'ELibrary_DatabaseDataSet
        '
        Me.ELibrary_DatabaseDataSet.DataSetName = "ELibrary_DatabaseDataSet"
        Me.ELibrary_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Me.CheckoutTableAdapter
        Me.TableAdapterManager.LibraryEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.LibraryMembersTableAdapter = Nothing
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(76, 203)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(226, 72)
        Me.Panel2.TabIndex = 158
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(203, 52)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = """Renew Resource"" renews the checkout" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " period of the highlighted resource. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Ret" &
    "urn Resource"" allows you to return" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the highlighted reasource to the library. "
        '
        'frm_AccInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1359, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.btn_Renew)
        Me.Controls.Add(Me.Results)
        Me.Controls.Add(Me.lnk_logOut)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lnk_AccInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lnk_Home)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_AccInfo"
        Me.Text = "Account_Information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DirectorySearcher4 As DirectoryServices.DirectorySearcher
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DirectorySearcher3 As DirectoryServices.DirectorySearcher
    Friend WithEvents lnk_Home As LinkLabel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lnk_AccInfo As LinkLabel
    Friend WithEvents Label12 As Label
    Friend WithEvents lnk_logOut As LinkLabel
    Friend WithEvents lbl_zip As Label
    Friend WithEvents lbl_state As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_city As Label
    Friend WithEvents lbl_Address As Label
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents Label_30 As Label
    Friend WithEvents ELibrary_DatabaseDataSet As ELibrary_DatabaseDataSet
    Friend WithEvents CheckoutBindingSource As BindingSource
    Friend WithEvents CheckoutTableAdapter As ELibrary_DatabaseDataSetTableAdapters.CheckoutTableAdapter
    Friend WithEvents TableAdapterManager As ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibraryResourcesBindingSource As BindingSource
    Friend WithEvents LibraryResourcesTableAdapter As ELibrary_DatabaseDataSetTableAdapters.LibraryResourcesTableAdapter
    Friend WithEvents Results As DataGridView
    Friend WithEvents btn_Renew As Button
    Friend WithEvents btn_Return As Button
    Friend WithEvents Title As DataGridViewTextBoxColumn
    Friend WithEvents Author As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents dateReturned As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
End Class
