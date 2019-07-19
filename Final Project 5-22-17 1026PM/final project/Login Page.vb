Public Class frm_Login

    Public memberID As String

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.LibraryEmployee' table. You can move, or remove it, as needed.
        ' Me.LibraryEmployeeTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.LibraryEmployee)
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.LibraryMembers' table. You can move, or remove it, as needed.
        'Me.LibraryMembersTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.LibraryMembers)


        'Changes the characters in the password box to stars. For privacy. 
        txt_Password.PasswordChar = "*"
    End Sub


    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        'Variables are self explanitory for the most part. The names are literal after all.

        Dim NumberOfMemberRows As Integer
        Dim NumberOfEmployeeRows As Integer
        Dim RowDataMember As Object
        Dim RowDataEmployee As Object
        Dim Password As String = String.Empty

        'If there is no text in either the Email or Password box, then this message will pop up.
        If txt_ID.Text = String.Empty Or txt_Password.Text = String.Empty Then
            MessageBox.Show("Please enter your email and password.")
        Else

            'how many records contain the email provided by the user?
            'There are records for oth employees and members
            NumberOfMemberRows = LibraryMembersTableAdapter.FillByEmail(ELibrary_DatabaseDataSet.LibraryMembers, txt_ID.Text)
            NumberOfEmployeeRows = LibraryEmployeeTableAdapter.FillByEmail(ELibrary_DatabaseDataSet.LibraryEmployee, txt_ID.Text)
            'if there is one existing record with the email then get the user's record with the getdataby method
            'and put the record (really point to the record) in the object "RowData" then get the email from the object. 
            'The dataset's index names will match the names of the columns in the table.  
            'Thus RowData.Password points to the user's password

            'Basically checks if there is a record that matches what you typed in. If there is, then is it set to 1 or "True".
            'The actions below the if statement are then executed.
            If NumberOfMemberRows = 1 Then

                'Retrieve the record.
                RowDataMember = LibraryMembersTableAdapter.GetDataByEmail(txt_ID.Text)(0)
                'Then set its password to the variable password we have here.
                Password = RowDataMember.Password


                'If the password from the record matches the one entered, then the login is successful, and we move to the next page.
                'Otherwise it will return failure message and force you to retry.
                If Password = txt_Password.Text Then
                    MessageBox.Show("Login successful")
                    frm_MemHome.loadData(RowDataMember)
                    memberID = RowDataMember.MemberID
                    frm_MemHome.Show()

                    If chk_remember.Checked = True Then
                        txt_Password.Clear()
                    Else
                        txt_Password.Clear()
                        txt_ID.Clear()
                    End If

                    Me.Hide()
                Else
                    MessageBox.Show("Login unsuccessful")
                    txt_Password.Clear()
                End If
                'Suppose that the program looks through all the member files, and does not find a matching record.
                'It will then check the emplyee records to see if there is a matching record in there. 
                'Like before, if it finds one, then it will return 1 or true, and execute the below code.
            ElseIf NumberOfEmployeeRows = 1 Then

                'Once again, retrieving the record.
                RowDataEmployee = LibraryEmployeeTableAdapter.GetDataByEmail(txt_ID.Text)(0)
                'Then assigning the records password to the varible password we have here.
                Password = RowDataEmployee.Password

                'If the password from the record matches the one entered, then the login is successful, and we move to the next page.
                'Otherwise it will return failure message and force you to retry.
                If Password = txt_Password.Text Then
                    MessageBox.Show("Login successful")
                    frm_empHome.loadData(RowDataEmployee)
                    frm_empHome.Show()

                    If chk_remember.Checked = True Then
                        txt_Password.Clear()
                    Else
                        txt_Password.Clear()
                        txt_ID.Clear()
                    End If

                    Me.Hide()
                Else
                    MessageBox.Show("Login unsuccessful")
                    txt_Password.Clear()
                End If
            Else
                'If there is no record found that matches the one typed in, then this message will be returned.
                MessageBox.Show("No user has registered with this email, please try a different email or register as a new user")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        frm_reg.Show()
    End Sub
End Class