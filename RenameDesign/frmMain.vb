Public Class frmMain

    Private invApp As New Inventor.ApprenticeServerComponent


    Private Sub BrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        If dlgBrowse.ShowDialog() = DialogResult.OK Then
            txtPath.Text = dlgBrowse.SelectedPath
            txtOldName.Text = Microsoft.VisualBasic.Mid(txtPath.Text, InStrRev(txtPath.Text, "\") + 1)
            txtNewName.Text = Microsoft.VisualBasic.Mid(txtPath.Text, InStrRev(txtPath.Text, "\") + 1)
            Dim files As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            files = My.Computer.FileSystem.GetFiles(txtPath.Text)
            filesList.Items.Clear()
            Dim flen = txtPath.Text.Length + 2
            Dim fp As String, fn As Integer
            Dim file As Object
            For Each file In files
                fp = Microsoft.VisualBasic.Mid(file, flen)
                filesList.Items.Add(fp)
                filesList.Items(fn).Checked = True
                filesList.Items(fn).Tag = file
                fn = fn + 1
            Next
            txtOldName.Text = Microsoft.VisualBasic.Left(filesList.Items(1).Text, 10)
        End If
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        If MsgBox("Ar tikrai pervardinti failus?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Pervardinti") = MsgBoxResult.Ok Then
            Dim file As Object, fileName As String
            Dim poz As Integer
            If txtOldName.Text = "" Or txtNewName.Text = "" Then
                MsgBox("Laukas negali buti tuscias!", MsgBoxStyle.Critical, "Klaida")
                Exit Sub
            End If

            Dim invDoc As Inventor.ApprenticeServerDocument
            Dim oldName = txtOldName.Text
            Dim newName = txtNewName.Text
            Dim lenx = Len(oldName)
            For Each file In filesList.Items
                If file.checked Then
                    fileName = file.text
                    If Microsoft.VisualBasic.Left(fileName, lenx) = oldName Then
                        fileName = newName & Mid(fileName, lenx + 1)
                        My.Computer.FileSystem.RenameFile(file.tag, fileName)
                        file.text = fileName
                        file.tag = txtPath.Text & "\" & fileName
                        If chkPartNumbers.Checked = True Or chkDate.Checked = True Then
                            If fileName.EndsWith("iam") Or fileName.EndsWith("ipt") Or fileName.EndsWith("idw") Then
                                invDoc = invApp.Open(file.tag)
                                If chkPartNumbers.Checked = True Then
                                    invDoc.PropertySets("Design Tracking Properties").Item("Part Number").Value = Microsoft.VisualBasic.Left(fileName, fileName.Length - 4)
                                End If
                                If chkDate.Checked = True Then
                                    invDoc.PropertySets("Design Tracking Properties").Item("Creation Time").Value = Now()
                                End If
                                If txtAuthor.Text <> "" Then
                                    invDoc.PropertySets("Inventor Summary Information").Item("Author").Value = txtAuthor.Text
                                End If
                                invDoc.PropertySets.FlushToFile()
                                invDoc.Close()
                            End If
                            filesList.Refresh()
                        End If
                    End If
                End If
            Next
            MsgBox("Failai pervardinti!", MsgBoxStyle.Information, "Viskas")
        End If
    End Sub

    Private Sub txtNewName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNewName.TextChanged
        If txtNewName.Text.Length > 0 Then
            OkButton.Enabled = True
        Else
            OkButton.Enabled = False
        End If
    End Sub

    Private Sub txtOldName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOldName.TextChanged
        If txtOldName.Text.Length > 0 Then
            OkButton.Enabled = True
        Else
            OkButton.Enabled = False
        End If
    End Sub
End Class
