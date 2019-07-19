<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_remember = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.DirectorySearcher4 = New System.DirectoryServices.DirectorySearcher()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher3 = New System.DirectoryServices.DirectorySearcher()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ELibrary_DatabaseDataSet = New WindowsApplication1.ELibrary_DatabaseDataSet()
        Me.LibraryMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryMembersTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.LibraryMembersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.LibraryEmployeeTableAdapter = New WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.LibraryEmployeeTableAdapter()
        Me.LibraryEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(21, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(249, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chk_remember)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_Password)
        Me.Panel1.Controls.Add(Me.txt_ID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btn_Login)
        Me.Panel1.Location = New System.Drawing.Point(405, 259)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 139)
        Me.Panel1.TabIndex = 42
        '
        'chk_remember
        '
        Me.chk_remember.AutoSize = True
        Me.chk_remember.Location = New System.Drawing.Point(53, 106)
        Me.chk_remember.Name = "chk_remember"
        Me.chk_remember.Size = New System.Drawing.Size(95, 17)
        Me.chk_remember.TabIndex = 3
        Me.chk_remember.Text = "Remember Me"
        Me.chk_remember.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(86, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Returning Users"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(109, 76)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(144, 20)
        Me.txt_Password.TabIndex = 2
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(109, 50)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(144, 20)
        Me.txt_ID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'btn_Login
        '
        Me.btn_Login.Location = New System.Drawing.Point(159, 102)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(75, 23)
        Me.btn_Login.TabIndex = 4
        Me.btn_Login.Text = "Log In"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'DirectorySearcher4
        '
        Me.DirectorySearcher4.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher4.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
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
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(69, 20)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(55, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Login >"
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
        Me.TableAdapterManager.LibraryEmployeeTableAdapter = Me.LibraryEmployeeTableAdapter
        Me.TableAdapterManager.LibraryMembersTableAdapter = Me.LibraryMembersTableAdapter
        Me.TableAdapterManager.LibraryResourcesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LibraryEmployeeTableAdapter
        '
        Me.LibraryEmployeeTableAdapter.ClearBeforeFill = True
        '
        'LibraryEmployeeBindingSource
        '
        Me.LibraryEmployeeBindingSource.DataMember = "LibraryEmployee"
        Me.LibraryEmployeeBindingSource.DataSource = Me.ELibrary_DatabaseDataSet
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(72, 40)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1211, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 163
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(703, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 139)
        Me.Panel2.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "New User? Sign up here!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1359, 721)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Login"
        Me.Text = "Login Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ELibrary_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents DirectorySearcher4 As DirectoryServices.DirectorySearcher
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher3 As DirectoryServices.DirectorySearcher
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ELibrary_DatabaseDataSet As ELibrary_DatabaseDataSet
    Friend WithEvents LibraryMembersBindingSource As BindingSource
    Friend WithEvents LibraryMembersTableAdapter As ELibrary_DatabaseDataSetTableAdapters.LibraryMembersTableAdapter
    Friend WithEvents TableAdapterManager As ELibrary_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibraryEmployeeTableAdapter As ELibrary_DatabaseDataSetTableAdapters.LibraryEmployeeTableAdapter
    Friend WithEvents LibraryEmployeeBindingSource As BindingSource
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents chk_remember As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
