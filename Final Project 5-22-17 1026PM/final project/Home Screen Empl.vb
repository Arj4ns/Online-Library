Public Class frm_empHome

    Dim RowDataEmpl As Object
    Dim EmplBooks As Object
    Dim CheckedBooks As Object

    Dim RowData As Object
    Dim rowdata2 As Object
    Dim checkedOutBooks As Object
    Dim checkedOutBookInfo As Object
    Dim standardinfo As Object
    Dim checkoutperiod As Long
    Dim NumberOfRows As Integer
    Dim resourceid As String
    Dim resourceStatus As String
    Dim DueDate As Date
    Dim checkoutdate As Date

    Dim title As String
    Dim ISBN As String
    Dim splitName() As String
    Dim authorLast As String
    Dim series As String
    Private txt_SearchBox As Object
    Private lbl_Name As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.Checkout)
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.Checkout' table. You can move, or remove it, as needed.
        'Me.CheckoutTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.Checkout)
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.LibraryResources' table. You can move, or remove it, as needed.
        'Me.LibraryResourcesTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.LibraryResources)

    End Sub

    'Loads the retrieved data from the database that was used in the login screen.
    Public Sub loadData(data As Object)
        RowDataEmpl = data
        lbl_empName.Text = RowDataEmpl.FirstName
    End Sub



    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        'clears the rows for the data grid
        Results.Rows.Clear()
        title = "%" & txt_searchemp.Text & "%"
        ISBN = txt_searchemp.Text
        splitName = Split(txt_searchemp.Text, ",")
        authorLast = splitName(0)
        series = "%" & txt_searchemp.Text & "%"
        'now we are searching for any matching rows to our search critieria
        NumberOfRows = LibraryResourcesTableAdapter.FillByTitleAuthorLastSeriesISBN(ELibrary_DatabaseDataSet.LibraryResources, title, authorLast, series, ISBN)

        'if we find rows
        If NumberOfRows > 0 Then

            Dim x As Integer = 0
            For x = 0 To NumberOfRows - 1 Step 1
                'loop through each row, and pull data from it.
                RowData = LibraryResourcesTableAdapter.GetDataByTitleAuthorLastSeriesISBN(title, authorLast, series, ISBN)(x)


                'This puts all the information we have pulled from the rows into the Datagrid.
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

            'No results? No Problem. A message box will come up telling you that no results were found.
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("No results matching your search were found. Please try again.")
        End If

    End Sub

    'Close this window, thus wiping any loaded data, and revealing the login screen.
    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        frm_Login.Show()
        Me.Close()
    End Sub

    'Clears the serach box and the datagrid
    Private Sub btn_empClear_Click(sender As Object, e As EventArgs) Handles btn_empClear.Click
        txt_searchemp.Text = ""
        Results.Rows.Clear()
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        frm_NewResource.Show()
        Me.Hide()
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
            Rowdata2 = LibraryResourcesTableAdapter.GetDataByResource(resourceid)(0)
            info = rowdata2.BookInfo
            sub1 = rowdata2.Subject_1
            sub2 = rowdata2.Subject_2
            author = rowdata2.AuthorFirst & " " & rowdata2.AuthorMiddle & " " & rowdata2.AuthorLast
            title = rowdata2.Title

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

