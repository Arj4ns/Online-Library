Public Class frm_AccInfo

    Dim RowDataMember As Object
    Dim MemberBooks As Object
    Dim checkedOutBooks As Object

    Dim RowData As Object
    Dim checkoutperiod As Long
    Dim NumberOfRows As Integer
    Dim checkedoutrecord As Integer
    Dim bookinfo As Object
    Dim checkedOutBookInfo As Object
    Dim checkedOutBookInfoDate
    Dim resourceid As String
    Dim Resourcestatus As String
    Dim DueDate As Date
    Dim checkoutdate As Date
    Dim memberid As String
    Dim returned As String


    Private Sub frm_AccInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.LibraryResources)
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.Checkout' table. You can move, or remove it, as needed.
        'Me.CheckoutTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.Checkout)

        Results.Rows.Clear()
        'determine the number of books the current member has checked out.
        NumberOfRows = CheckoutTableAdapter.FillByMemberID(ELibrary_DatabaseDataSet.Checkout, memberid)
        'if the member has at least one book checked out then…
        If NumberOfRows > 0 Then

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookinfo = CheckoutTableAdapter.GetDataByMemberID(memberid)(x)
                resourceid = bookinfo.resourceID

                RowData = LibraryResourcesTableAdapter.GetDataByResource(resourceid)(0)
                'calculate the due date for a book based on the check out date and the book’s checkout period.
                checkoutdate = bookinfo.checkoutdate
                checkoutperiod = RowData.checkoutperiod
                DueDate = DateAdd(DateInterval.Day, checkoutperiod, checkoutdate)
                'at “due” to the due date so that the member knows when the book is due
                Resourcestatus = "Due " & DueDate.Date
                If bookinfo.IsReturnDateNull = True Then
                    Resourcestatus = "Due " & DueDate.Date
                Else
                    Resourcestatus = "Returned"
                End If


                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add title to the first column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                'add author’s last name to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.authorlast
                dgvRow.Cells.Add(dgvCell)

                'add publication date to the 3rd  column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.publicationdate
                dgvRow.Cells.Add(dgvCell)

                'add series to the 4th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Series
                dgvRow.Cells.Add(dgvCell)

                'add checkout data to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = checkoutdate.Date
                dgvRow.Cells.Add(dgvCell)

                'add resourcestatus, created above, to the 6th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Resourcestatus
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = resourceid
                dgvRow.Cells.Add(dgvCell)

                Results.Rows.Add(dgvRow)
                'Results is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            Results.Rows.Clear()
        End If


    End Sub

    'Loads the data retrieved from the database when we first log in, and lets us use it on this window.
    Public Sub loadData(data As Object)
        'Assigns variables and stats retrieved from the database to the labels on the Account info page.
        RowDataMember = data
        lbl_firstName.Text = RowDataMember.FirstName
        lbl_lastName.Text = RowDataMember.LastName
        lbl_ID.Text = RowDataMember.MemberID
        lbl_Address.Text = RowDataMember.StreetAddress
        lbl_city.Text = RowDataMember.City
        lbl_state.Text = RowDataMember.State
        lbl_zip.Text = RowDataMember.ZipCode
        lbl_email.Text = RowDataMember.Email
        'memberid = lbl_ID.Text
        memberid = frm_Login.memberID
    End Sub

    Private Sub CheckoutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.CheckoutBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.ELibrary_DatabaseDataSet)

    End Sub

    Private Sub btn_getCheckedBooks_Click(sender As Object, e As EventArgs)
        Results.Rows.Clear()
        'determine the number of books the current member has checked out.
        NumberOfRows = CheckoutTableAdapter.FillByMemberID(ELibrary_DatabaseDataSet.Checkout, memberid)
        'if the member has at least one book checked out then…
        If NumberOfRows > 0 Then

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookinfo = CheckoutTableAdapter.GetDataByMemberID(memberid)(x)
                resourceid = bookinfo.resourceID

                RowData = LibraryResourcesTableAdapter.GetDataByResource(resourceid)(0)
                'calculate the due date for a book based on the check out date and the book’s checkout period.
                checkoutdate = bookinfo.checkoutdate
                checkoutperiod = RowData.checkoutperiod
                DueDate = DateAdd(DateInterval.Day, checkoutperiod, checkoutdate)
                'at “due” to the due date so that the member knows when the book is due
                Resourcestatus = "Due " & DueDate.Date
                If bookinfo.IsReturnDateNull = True Then
                    Resourcestatus = "Due " & DueDate.Date
                Else
                    Resourcestatus = "Returned"
                End If


                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add title to the first column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                'add author’s last name to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.authorlast
                dgvRow.Cells.Add(dgvCell)

                'add publication date to the 3rd  column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.publicationdate
                dgvRow.Cells.Add(dgvCell)

                'add series to the 4th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Series
                dgvRow.Cells.Add(dgvCell)

                'add checkout data to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = checkoutdate.Date
                dgvRow.Cells.Add(dgvCell)

                'add resourcestatus, created above, to the 6th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = Resourcestatus
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = resourceid
                dgvRow.Cells.Add(dgvCell)

                Results.Rows.Add(dgvRow)
                'Results is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("Checkout history refreshed.")
        End If

    End Sub

    Private Sub lnk_logOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_logOut.LinkClicked
        frm_MemHome.Close()
        Me.Close()
        frm_Login.Show()
    End Sub

    Private Sub lnk_Home_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Home.LinkClicked
        Me.Close()
        frm_MemHome.limitCheckout(memberid)
        frm_MemHome.Show()
    End Sub

    Private Sub btn_Renew_Click(sender As Object, e As EventArgs) Handles btn_Renew.Click
        'Gets the current date
        Dim currentdate As Date = Date.Today.Date
        'Retrieves information on the member
        NumberOfRows = CheckoutTableAdapter.FillByMemberID(ELibrary_DatabaseDataSet.Checkout, memberid)

        If NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else
            'If you have not selected any cells, this message will be returned.
            If Results.SelectedCells.Count = 0 Then
                MessageBox.Show("Please select the book you wish to renew")
            Else

                'renew book by altering the due date and updating the record selected in 
                'the “results” data grid the numbers in parentheses are the index of the 
                'data grid column holding the piece of information needed.

                'Obtains the resource id from the last cell
                resourceid = Results.SelectedCells(7).Value

                'Obtains the check out period form the repsective cell
                checkoutperiod = Results.SelectedCells(6).Value
                'creates a new due dat based on the current date and the checkout period
                DueDate = DateAdd(DateInterval.Day, checkoutperiod, currentdate)
                Resourcestatus = "Due " & DueDate.Date
                'Updates the cells with the new dates
                If Results.SelectedCells(5).Value = "Returned" Then
                    MessageBox.Show("Resource has already been returned!", "Book Renewal Failed", MessageBoxButtons.OK)
                Else
                    Results.SelectedCells(5).Value = Resourcestatus
                    Results.SelectedCells(4).Value = currentdate

                    'Updates the database with the new values
                    CheckoutTableAdapter.RenewBookUpdateQuery(currentdate, resourceid)
                    MessageBox.Show("You have successfully renewed your book.", " Book Renewal Successful", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click
        'gets the current date
        Dim currentdate As Date = Date.Today.Date
        'retrieves info on the member
        NumberOfRows = CheckoutTableAdapter.FillByMemberID(ELibrary_DatabaseDataSet.Checkout, memberid)

        If NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else
            'If you have not selected any cells, this message will be returned.
            If Results.SelectedCells.Count = 0 Then
                MessageBox.Show("Please select the book you wish to return")
            Else
                'Obtains the resource id from the last cell
                resourceid = Results.SelectedCells(7).Value
                'Updates the database for returned books
                CheckoutTableAdapter.ReturnBookUpdateQuery(currentdate, resourceid)
                'clears the datagridview
                If Results.SelectedCells(5).Value = "Returned" Then
                    MessageBox.Show("Resource has already been returned!", "Book Return Failed", MessageBoxButtons.OK)
                Else
                    Resourcestatus = "Returned"
                    Results.SelectedCells(5).Value = Resourcestatus
                    MessageBox.Show("Resource has been returned! Thank you for using our library!", "Book Return Successful", MessageBoxButtons.OK)
                End If
            End If
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class