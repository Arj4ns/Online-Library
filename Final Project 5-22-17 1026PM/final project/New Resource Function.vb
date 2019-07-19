Public Class frm_NewResource
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub New_Resource_Function_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ELibrary_DatabaseDataSet.LibraryResources' table. You can move, or remove it, as needed.
        Me.LibraryResourcesTableAdapter.Fill(Me.ELibrary_DatabaseDataSet.LibraryResources)
        txt_sub1.SelectedIndex = 0
        txt_sub2.SelectedIndex = 0
        cbox_checkout.SelectedIndex = 0
    End Sub

    Private Sub btn_addRes_Click(sender As Object, e As EventArgs) Handles btn_addRes.Click
        Dim title As String = txt_title.Text
        Dim authFirst As String = txt_authFirst.Text
        Dim authMid As String = txt_authMid.Text
        Dim authLast As String = txt_authLast.Text
        Dim series As String = txt_series.Text
        Dim checkPeriod As String = cbox_checkout.Text
        Dim publ As String = txt_publYear.Text
        Dim resourceID As String

        If txt_resourceID.Text.Count = 7 Then
            resourceID = "b" & txt_resourceID.Text & "_1"
        Else
            MessageBox.Show("Resource ID must be 7 characters only", "Error", MessageBoxButtons.OK)
            Return
        End If

        Dim sub1 As String = txt_sub1.Text
        Dim sub2 As String = txt_sub2.Text
        Dim ISBN As String = txt_ISBN.Text
        Dim info As String = txt_info.Text
        Dim NumberOfRows As Object = LibraryResourcesTableAdapter.FillByResource(ELibrary_DatabaseDataSet.LibraryResources, resourceID)
        Dim NumberOfTitles As Object = LibraryResourcesTableAdapter.FillByTitle(ELibrary_DatabaseDataSet.LibraryResources, title)
        Dim rowdata As Object
        Dim titledata As Object
        'Checks to see if the proper feilds are filled out.
        If title = "" Or authFirst = "" Or authLast = "" Or txt_resourceID.Text = "" Or txt_resourceIDCount.Text = "" Or sub1 = "" Or sub2 = "" Or ISBN = "" Or info = "" Or txt_publYear.Text = "" Or checkPeriod = "" Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK)
            Return
        Else
            If series = "" Then
                series = "No Series"
            End If

            If NumberOfTitles > 0 Then
                rowdata = LibraryResourcesTableAdapter.GetDataByTitle(title)(0)
                MessageBox.Show("This resource already exists. Assigning current resource ID to resource with updated copy number.", "Warning", MessageBoxButtons.OK)
                Dim modifiedID As String = rowdata.ResourceID
                Dim ID As String = modifiedID.Substring(1, 7)
                'Dim copy As String = modifiedID.Substring(9, 1)
                Dim copy As Integer = NumberOfTitles + 1
                resourceID = "b" & ID & "_" & copy
                LibraryResourcesTableAdapter.InsertResource(resourceID, title, authLast, authFirst, authMid, publ, series, ISBN, checkPeriod, sub1, sub2, info)
                txt_resourceIDCount.Text = copy
                MessageBox.Show("Resource " & resourceID & " Added")
                Return
            End If

            If NumberOfRows > 0 Then
                MessageBox.Show("This resource ID already belongs to another resource.", "Warning", MessageBoxButtons.OK)
                txt_resourceID.Text = ""
                txt_resourceIDCount.Text = ""
                Return
            End If

            'If series is blank, it will return "No Series" by default
            If series = "" Then
                series = "No Series"
            End If
            'Adds resource to database.
            resourceID = "b" & txt_resourceID.Text & "_1"
            txt_resourceIDCount.Text = "1"
            LibraryResourcesTableAdapter.InsertResource(resourceID, title, authLast, authFirst, authMid, publ, series, ISBN, checkPeriod, sub1, sub2, info)
            MessageBox.Show("Resource " & resourceID & " Added. No copies were detected, so the copy number has been set to the default of '1'.")
        End If
    End Sub

    'makes it so that only numbers can be entered into this field.
    Private Sub txt_publYear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_publYear.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'makes it so that only numbers can be entered into this field.
    Private Sub txt_resourceID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_resourceID.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'makes it so that only numbers can be entered into this field.
    Private Sub txt_resourceIDCount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_resourceIDCount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'makes it so that only numbers can be entered into this field.
    Private Sub txt_ISBN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ISBN.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frm_empHome.Show()
        Me.Close()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txt_resourceID.Text = ""
        txt_authFirst.Text = ""
        txt_authLast.Text = ""
        txt_authMid.Text = ""
        txt_info.Text = ""
        txt_ISBN.Text = ""
        txt_publYear.Text = ""
        txt_resourceIDCount.Text = ""
        txt_series.Text = ""
        txt_title.Text = ""
        txt_sub1.SelectedIndex = 0
        txt_sub2.SelectedIndex = 0
        cbox_checkout.SelectedIndex = 0
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Me.Close()
        frm_empHome.Close()
        frm_Login.Show()
    End Sub

    Private Sub txt_info_TextChanged(sender As Object, e As EventArgs) Handles txt_info.TextChanged

    End Sub
End Class