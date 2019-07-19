Imports System.Net.Mail

Public Class frm_MemHome

    Dim RowDataMember As Object
    Dim MemberBooks As Object
    Dim CheckedBooks As Object
    Dim bookinfo As Object

    Dim RowData As Object
    Dim RowData2 As Object
    Dim checkedOutBooks As Object
    Dim checkedOutBookInfo As Object
    Dim standardinfo As Object
    Dim checkoutperiod As Long
    Dim NumberOfRows As Integer
    Dim NumberOfCheckoutRows As Integer
    Dim resourceid As String
    Dim resourceStatus As String
    Dim DueDate As Date
    Dim checkoutdate As Date
    Dim OutOfTen As Integer = 0
    Dim value As Integer

    Dim title As String
    Dim ISBN As String
    Dim splitName() As String
    Dim authorLast As String
    Dim series As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.Checkout)
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.LibraryResources' table. You can move, or remove it, as needed.
        'Me.LibraryResourcesTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.LibraryResources)
    End Sub

    Public Sub sendEmail()

    End Sub

    Public Sub limitCheckout(memberid As String)
        'determine the number of books the current member has checked out.
        NumberOfCheckoutRows = CheckoutTableAdapter.FillByMemberID(ELibrary_DatabaseDataSet.Checkout, memberid)
        'if the member has at least one book checked out then…
        If NumberOfCheckoutRows > 0 Then

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfCheckoutRows - 1 Step 1

                bookinfo = CheckoutTableAdapter.GetDataByMemberID(memberid)(x)
                'calculate the due date for a book based on the check out date and the book’s checkout period.
                If bookinfo.IsReturnDateNull = True Then
                    OutOfTen = OutOfTen + 1
                End If
            Next
            lbl_TotReasource.Text = "Your have " & OutOfTen & "/10 Resources checked out."

        ElseIf NumberOfCheckoutRows = 0 Then
            lbl_TotReasource.Text = "You have 0/10 Resources checked out."
        End If
        value = OutOfTen
        OutOfTen = 0

    End Sub


    'Loads the retrieved data from the database that was used in the login screen.
    Public Sub loadData(data As Object)
        RowDataMember = data
        lbl_Name.Text = RowDataMember.FirstName
        limitCheckout(RowDataMember.MemberID)
    End Sub

    'Close this window, thus wiping any loaded data, and revealing the login screen.
    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        frm_Login.Show()
        Me.Close()
    End Sub

    'Hides this window, and loads the account info window. Also loads the info retrieved from the data base
    'when we first logged in and lets us utilize it on the account info window.
    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        frm_AccInfo.loadData(RowDataMember)
        frm_AccInfo.Show()
        Results.Rows.Clear()
        txt_SearchBox.Clear()
        Me.Hide()
    End Sub



    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        'Clears the rows
        Results.Rows.Clear()

        title = "%" & txt_SearchBox.Text & "%"
        ISBN = txt_SearchBox.Text
        splitName = Split(txt_SearchBox.Text, ",")
        authorLast = splitName(0)
        series = "%" & txt_SearchBox.Text & "%"
        'Searches for the resource in the query based on the critieria inputted.
        NumberOfRows = LibraryResourcesTableAdapter.FillByTitleAuthorLastSeriesISBN(ELibrary_DatabaseDataSet.LibraryResources, title, authorLast, series, ISBN)

        'if we find a row...
        If NumberOfRows > 0 Then

            Dim x As Integer = 0
            For x = 0 To NumberOfRows - 1 Step 1
                'loops through each row found and pulls the nessesary information from it.
                RowData = LibraryResourcesTableAdapter.GetDataByTitleAuthorLastSeriesISBN(title, authorLast, series, ISBN)(x)

                'Lists all the information pulled in the datagrid
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.title
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.authorlast
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.publicationdate
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Series
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "Available"
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.resourceID
                dgvRow.Cells.Add(dgvCell)


                Results.Rows.Add(dgvRow)
            Next

            For i As Integer = 0 To Results.Rows.Count - 1
                resourceid = Results.Rows(i).Cells(6).Value
                checkedOutBooks = CheckoutTableAdapter.FillByResourceID(ELibrary_DatabaseDataSet.Checkout, resourceid)
                For j As Integer = 0 To checkedOutBooks - 1
                    checkedOutBookInfo = CheckoutTableAdapter.GetDataByResourceID(resourceid)(j)
                    standardinfo = LibraryResourcesTableAdapter.GetDataByResource(resourceid)(0)
                    If checkedOutBookInfo.IsReturnDateNull = True Then
                        checkoutdate = checkedOutBookInfo.checkoutdate
                        checkoutperiod = standardinfo.checkoutperiod
                        DueDate = DateAdd(DateInterval.Day, checkoutperiod, checkoutdate)
                        Results.Rows(i).Cells(4).Value = "Due " & DueDate
                    End If
                Next
            Next

            'No result? No problem. A message box will come up telling you so.
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("No results matching your search were found. Please try again.")
        End If

    End Sub

    Private Sub btn_Checkout_Click(sender As Object, e As EventArgs) Handles btn_Checkout.Click
        'Gets the current date
        Dim currentdate As Date = Date.Today.Date

        If value >= 10 Then
            MessageBox.Show("You have reach the limit of resources you can check out.")
            Return
        End If

        'If the resource id is blank, then it will display this message.
        If resourceid = Nothing Then
            MessageBox.Show("There are no items that you can check out.")
            Return
        End If

        'If you have not selected any cells, this message will be returned.
        If Results.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select the resource you wish to check out")
        Else
            'Obtains the resource id from the last cell
            resourceid = Results.SelectedCells(6).Value
            NumberOfRows = CheckoutTableAdapter.FillByMemberAndResourceID(ELibrary_DatabaseDataSet.Checkout, resourceid, RowDataMember.MemberID)

            'Obtains the check out period from the repsective cell
            checkoutperiod = Results.SelectedCells(5).Value

            'creates a new due dat based on the current date and the checkout period
            DueDate = DateAdd(DateInterval.Day, checkoutperiod, currentdate)
            resourceStatus = "Due " & DueDate.Date

            'If the book has not been checked out, then the resource will be added to the list of checked
            'out books linked to the users account. It will then update the Resource Status on the 
            'data grid.
            If Results.SelectedCells(4).Value = "Available" Then
                If NumberOfRows = 1 Then
                    CheckoutTableAdapter.DeleteCheckout(resourceid, RowDataMember.MemberID)
                    CheckoutTableAdapter.InsertCheckedOutBook(resourceid, RowDataMember.MemberID, currentdate)
                Else
                    CheckoutTableAdapter.InsertCheckedOutBook(resourceid, RowDataMember.MemberID, currentdate)
                End If

                Results.SelectedCells(4).Value = resourceStatus
                MessageBox.Show("You have successfully checked out your resource.", "Resource Checkout Successful", MessageBoxButtons.OK)
            Else
                'If book is already checked out, then this message will display.
                MessageBox.Show("Resource is not available for checkout. Please choose another resource.", "Resource Checkout Failed", MessageBoxButtons.OK)
            End If
        End If
        limitCheckout(RowDataMember.MemberID)

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("elibrarydatabase.noreply@gmail.com", "ILoveBooks036")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("elibrarydatabase.noreply@gmail.com")
            e_mail.To.Add(RowDataMember.Email)
            e_mail.Subject = "Redwood Library Receipt"
            e_mail.IsBodyHtml = False
            Dim recipt As String = "Receipt" & vbCrLf & vbCrLf & vbCrLf & "User: " & RowDataMember.FirstName & " " & RowDataMember.LastName & vbCrLf & "User Address: " & RowDataMember.StreetAddress & " " & RowDataMember.City & " " & RowDataMember.State & " " & RowDataMember.ZipCode & vbCrLf & vbCrLf & "Resource Title: " & Results.SelectedCells(0).Value & vbCrLf & "Checked out on " & currentdate & vbCrLf & "Checkout Period: " & Results.SelectedCells(5).Value & vbCrLf & "Resource due on " & DueDate.Date & vbCrLf & vbCrLf & "Thank you for using our Library!"
            e_mail.Body = recipt
            Smtp_Server.Send(e_mail)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

    End Sub

    'Clears the search box and data grid
    Private Sub btn_memClear_Click(sender As Object, e As EventArgs) Handles btn_memClear.Click
        txt_SearchBox.Text = ""
        Results.Rows.Clear()
    End Sub

    Private Sub btn_desc_Click(sender As Object, e As EventArgs) Handles btn_desc.Click
        'Gets the current date
        Dim currentdate As Date = Date.Today.Date
        Dim info As String
        Dim sub1 As String
        Dim sub2 As String
        Dim author As String
        Dim title As String

        'If the resource id is blank, then it will display this message.
        If resourceid = Nothing Then
            MessageBox.Show("There are no items selected.")
            Return
        Else
            'Otherwise, it will proceed as normal, and fill the rows with checked out resources.
            NumberOfRows = CheckoutTableAdapter.FillByResourceID(ELibrary_DatabaseDataSet.Checkout, resourceid)
        End If

        'If you have not selected any cells, this message will be returned.
        If Results.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select the resource you wish to read about.")
        Else
            resourceid = Results.SelectedCells(6).Value
            RowData2 = LibraryResourcesTableAdapter.GetDataByResource(resourceid)(0)
            info = RowData2.BookInfo
            sub1 = RowData2.Subject_1
            sub2 = RowData2.Subject_2
            author = RowData2.AuthorFirst & " " & RowData2.AuthorMiddle & " " & RowData2.AuthorLast
            title = RowData2.Title

            MessageBox.Show(title & vbCrLf & author & vbCrLf & sub1 & " / " & sub2 & vbCrLf & vbCrLf & "Resource Summary:" & vbCrLf & info, "Description")

        End If
    End Sub


    'Private Sub LibraryResourcesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    'Me.Validate()
    'Me.LibraryResourcesBindingSource.EndEdit()
    'Me.TableAdapterManager.UpdateAll(Me.ELibrary_DatabaseDataSet)
    '
    'End Sub
End Class
