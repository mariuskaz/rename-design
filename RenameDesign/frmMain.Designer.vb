<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.BrowseButton = New System.Windows.Forms.Button
        Me.dlgBrowse = New System.Windows.Forms.FolderBrowserDialog
        Me.filesList = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOldName = New System.Windows.Forms.TextBox
        Me.txtNewName = New System.Windows.Forms.TextBox
        Me.OkButton = New System.Windows.Forms.Button
        Me.chkPartNumbers = New System.Windows.Forms.CheckBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtAuthor = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkDate = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gaminio katalogas:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(18, 36)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(467, 20)
        Me.txtPath.TabIndex = 1
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(491, 33)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(90, 25)
        Me.BrowseButton.TabIndex = 2
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'dlgBrowse
        '
        Me.dlgBrowse.ShowNewFolderButton = False
        '
        'filesList
        '
        Me.filesList.CheckBoxes = True
        Me.filesList.Location = New System.Drawing.Point(19, 67)
        Me.filesList.Name = "filesList"
        Me.filesList.Size = New System.Drawing.Size(562, 324)
        Me.filesList.TabIndex = 3
        Me.filesList.UseCompatibleStateImageBehavior = False
        Me.filesList.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senas kodas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Naujas kodas"
        '
        'txtOldName
        '
        Me.txtOldName.Location = New System.Drawing.Point(19, 427)
        Me.txtOldName.Name = "txtOldName"
        Me.txtOldName.Size = New System.Drawing.Size(180, 20)
        Me.txtOldName.TabIndex = 6
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(401, 427)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(180, 20)
        Me.txtNewName.TabIndex = 7
        '
        'OkButton
        '
        Me.OkButton.Enabled = False
        Me.OkButton.Location = New System.Drawing.Point(236, 511)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(134, 28)
        Me.OkButton.TabIndex = 8
        Me.OkButton.Text = "Pervardinti failus"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'chkPartNumbers
        '
        Me.chkPartNumbers.AutoSize = True
        Me.chkPartNumbers.Checked = True
        Me.chkPartNumbers.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPartNumbers.Location = New System.Drawing.Point(19, 454)
        Me.chkPartNumbers.Name = "chkPartNumbers"
        Me.chkPartNumbers.Size = New System.Drawing.Size(159, 17)
        Me.chkPartNumbers.TabIndex = 10
        Me.chkPartNumbers.Text = "Pataisyti Part Number kodus"
        Me.chkPartNumbers.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(249, 397)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(401, 470)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(180, 20)
        Me.txtAuthor.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 454)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Autorius"
        '
        'chkDate
        '
        Me.chkDate.AutoSize = True
        Me.chkDate.Checked = True
        Me.chkDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDate.Location = New System.Drawing.Point(19, 473)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(135, 17)
        Me.chkDate.TabIndex = 14
        Me.chkDate.Text = "Uþdëti ðios dienos datà"
        Me.chkDate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 557)
        Me.Controls.Add(Me.chkDate)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkPartNumbers)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.txtOldName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.filesList)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Pervardinti failus"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents dlgBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents filesList As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOldName As System.Windows.Forms.TextBox
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents chkPartNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox

End Class
