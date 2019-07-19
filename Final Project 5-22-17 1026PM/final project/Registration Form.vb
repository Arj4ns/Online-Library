Public Class frm_reg
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.LibraryMembers' table. You can move, or remove it, as needed.
        txt_state.SelectedIndex = 4
        Me.LibraryMembersTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.LibraryMembers)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'variables
        Dim memberid As String
        Dim email As String
        Dim NumberOfRowsMember As Integer
        Dim NumberOfRowsEmail As Integer

        'Creates a random Member ID for the user
        Randomize()
        Dim memberdigits As Integer = Int((100000 * Rnd()) + 1)


        'Checks if textboxes have been filled out.
        If txt_first.Text = "" Or txt_last.Text = "" Or txt_address.Text = "" Or txt_city.Text = "" Or txt_emailuser.Text = "" Or txt_emaildom.Text = "" Or txt_emailweb.Text = "" Or txt_password.Text = "" Or txt_repassword.Text = "" Then
            MessageBox.Show("Please fill in all fields of this form.")
            Return
        Else
            'if the password and the re-entered password match, then the program will continue.
            If txt_password.Text = txt_repassword.Text Then
                'MemberId declared previously
                memberid = "PLIV" & memberdigits

                email = txt_emailuser.Text & "@" & txt_emailweb.Text & "." & txt_emaildom.Text
                'Checks to see if the entered email matches any current emails in the database.
                NumberOfRowsEmail = LibraryMembersTableAdapter.FillByEmail(ELibrary_DatabaseDataSet.LibraryMembers, email)

                'if so, then then an error message will show up.
                If NumberOfRowsEmail = 1 Then
                    MessageBox.Show("This email has already been used. Please enter a different email.")
                    Return
                End If

                'Create or ask the user to help create their MemberID then check to see if that
                'ID is already in the Member table
                'FillbyMemberID to see if a record already exists with provided MemberID
                NumberOfRowsMember = LibraryMembersTableAdapter.FillByMemberID(ELibrary_DatabaseDataSet.LibraryMembers, memberid)

                'if by some chance, the generated member id already exists, then this snippet of code
                'generates a new one. It will continue to do so until the member ID generated is not
                'already in the database.
                If NumberOfRowsMember = 1 Then
                    While NumberOfRowsMember = 1
                        Randomize()
                        memberdigits = Int((100000 * Rnd()) + 1)
                        memberid = "PLIV" & memberdigits
                        NumberOfRowsMember = LibraryMembersTableAdapter.FillByMemberID(ELibrary_DatabaseDataSet.LibraryMembers, memberid)
                    End While

                Else
                    'inserts the actual member into the database.
                    LibraryMembersTableAdapter.InsertMember(memberid, txt_first.Text, txt_last.Text, txt_address.Text, txt_city.Text, txt_state.Text, txt_zip.Text, email, txt_password.Text)
                    'provide confirmation to the user of a successful registration
                    MessageBox.Show("Registration Complete. Your new Member Id is " & memberid & "." & vbCrLf & "Remember to log in with your email and password, " & txt_first.Text & ".")
                    'return the user to the login form to login.
                    frm_Login.Show()
                    frm_Login.txt_ID.Focus()
                    'close the form after registration.
                    Me.Close()
                End If
            Else
                MessageBox.Show("Your password and the password you re-entered do not match!")
                txt_password.Clear()
                txt_repassword.Clear()
                Return
            End If
        End If
    End Sub
    'allows numbers only to be entered into zip text box.

    Private Sub txt_zip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_zip.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    'clears the form
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_address.Text = ""
        txt_city.Text = ""
        txt_emaildom.Text = ""
        txt_emailuser.Text = ""
        txt_emailweb.Text = ""
        txt_first.Text = ""
        txt_last.Text = ""
        txt_password.Text = ""
        txt_repassword.Text = ""
        txt_state.SelectedIndex = 4
        txt_zip.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_Login.Show()
        Me.Close()
    End Sub
End Class

