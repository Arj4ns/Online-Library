<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_reg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reg))
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher3 = New System.DirectoryServices.DirectorySearcher()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DirectorySearcher4 = New System.DirectoryServices.DirectorySearcher()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.txt_first = New System.Windows.Forms.TextBox()
        Me.txt_last = New System.Windows.Forms.TextBox()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_zip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_emailuser = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.txt_state = New System.Windows.Forms.ComboBox()
        Me.txt_emaildom = New System.Windows.Forms.TextBox()
        Me.txt_emailweb = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_repassword = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ELibrary_DatabaseDataSet = New WindowsApplication1.ELibrary_DatabaseDataSet()
        Me.LibraryMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryMembersTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.LibraryMembersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DirectorySearcher4
        '
        Me.DirectorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txt_first
        '
        Me.txt_first.Location = New System.Drawing.Point(96, 101)
        Me.txt_first.Name = "txt_first"
        Me.txt_first.Size = New System.Drawing.Size(191, 20)
        Me.txt_first.TabIndex = 1
        '
        'txt_last
        '
        Me.txt_last.Location = New System.Drawing.Point(397, 101)
        Me.txt_last.Name = "txt_last"
        Me.txt_last.Size = New System.Drawing.Size(205, 20)
        Me.txt_last.TabIndex = 2
        '
        'txt_city
        '
        Me.txt_city.Location = New System.Drawing.Point(397, 127)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(205, 20)
        Me.txt_city.TabIndex = 4
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(96, 127)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(191, 20)
        Me.txt_address.TabIndex = 3
        '
        'txt_zip
        '
        Me.txt_zip.Location = New System.Drawing.Point(397, 153)
        Me.txt_zip.MaxLength = 5
        Me.txt_zip.Name = "txt_zip"
        Me.txt_zip.Size = New System.Drawing.Size(59, 20)
        Me.txt_zip.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "First Name *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Last Name *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Address *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "City *"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(335, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Zip Code *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(201, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 20)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Sign Up for Redwood Library Access"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "State *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Email *"
        '
        'txt_emailuser
        '
        Me.txt_emailuser.Location = New System.Drawing.Point(96, 179)
        Me.txt_emailuser.Name = "txt_emailuser"
        Me.txt_emailuser.Size = New System.Drawing.Size(77, 20)
        Me.txt_emailuser.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_emailuser)
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Controls.Add(Me.txt_state)
        Me.Panel1.Controls.Add(Me.txt_emaildom)
        Me.Panel1.Controls.Add(Me.txt_emailweb)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_repassword)
        Me.Panel1.Controls.Add(Me.txt_password)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txt_first)
        Me.Panel1.Controls.Add(Me.txt_last)
        Me.Panel1.Controls.Add(Me.txt_city)
        Me.Panel1.Controls.Add(Me.txt_address)
        Me.Panel1.Controls.Add(Me.txt_zip)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(364, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 330)
        Me.Panel1.TabIndex = 82
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(320, 279)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Text = "Clear Form"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'txt_state
        '
        Me.txt_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_state.FormattingEnabled = True
        Me.txt_state.Items.AddRange(New Object() {"AK", "AL", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.txt_state.Location = New System.Drawing.Point(96, 153)
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(54, 21)
        Me.txt_state.TabIndex = 5
        '
        'txt_emaildom
        '
        Me.txt_emaildom.Location = New System.Drawing.Point(257, 179)
        Me.txt_emaildom.MaxLength = 3
        Me.txt_emaildom.Name = "txt_emaildom"
        Me.txt_emaildom.Size = New System.Drawing.Size(37, 20)
        Me.txt_emaildom.TabIndex = 9
        '
        'txt_emailweb
        '
        Me.txt_emailweb.Location = New System.Drawing.Point(187, 179)
        Me.txt_emailweb.Name = "txt_emailweb"
        Me.txt_emailweb.Size = New System.Drawing.Size(61, 20)
        Me.txt_emailweb.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(286, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Re-Enter Password *"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(171, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "@"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(509, 26)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "When registering, take note that your email will be used to log in. Your member I" &
    "D is only used by the library" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to track the books you have checked out. All fiel" &
    "ds must be filled out."
        '
        'txt_repassword
        '
        Me.txt_repassword.Location = New System.Drawing.Point(397, 239)
        Me.txt_repassword.Name = "txt_repassword"
        Me.txt_repassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repassword.Size = New System.Drawing.Size(205, 20)
        Me.txt_repassword.TabIndex = 11
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(96, 239)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(175, 20)
        Me.txt_password.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Password *"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Sign Up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(248, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(69, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 17)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log In >"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.LinkColor = System.Drawing.Color.White
        Me.LinkLabel8.Location = New System.Drawing.Point(134, 20)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(73, 17)
        Me.LinkLabel8.TabIndex = 15
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Register >"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(72, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1211, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 165
        Me.PictureBox3.TabStop = False
        '
        'ELibrary_DatabaseDataSet
        '
        Me.ELibrary_DatabaseDataSet.DataSetName = "ELibrary_DatabaseDataSet"
        Me.ELibrary_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryMembersBindingSource
        '
        Me.LibraryMembersBindingSource.DataMember = "LibraryMembers"
        Me.LibraryMembersBindingSource.DataSource = Me.ELibrary_DatabaseDataSet
        '
        'LibraryMembersTableAdapter
        '
        Me.LibraryMembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Nothing
        Me.TableAdapterManager.LibraryEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.LibraryMembersTableAdapter = Me.LibraryMembersTableAdapter
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frm_reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1359, 721)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LinkLabel8)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_reg"
        Me.Text = "Registration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher3 As DirectoryServices.DirectorySearcher
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DirectorySearcher4 As DirectoryServices.DirectorySearcher
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents txt_first As TextBox
    Friend WithEvents txt_last As TextBox
    Friend WithEvents txt_city As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_zip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_emailuser As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_repassword As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ELibrary_DatabaseDataSet As ELibrary_DatabaseDataSet
    Friend WithEvents LibraryMembersBindingSource As BindingSource
    Friend WithEvents LibraryMembersTableAdapter As ELibrary_DatabaseDataSetTableAdapters.LibraryMembersTableAdapter
    Friend WithEvents TableAdapterManager As ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txt_emaildom As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_emailweb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_state As ComboBox
    Friend WithEvents btn_clear As Button
End Class
