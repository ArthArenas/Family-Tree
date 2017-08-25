<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.buttonFather = New System.Windows.Forms.Button()
        Me.buttonMother = New System.Windows.Forms.Button()
        Me.buttonChild = New System.Windows.Forms.Button()
        Me.labelName = New System.Windows.Forms.Label()
        Me.labelFather = New System.Windows.Forms.Label()
        Me.labelMother = New System.Windows.Forms.Label()
        Me.picboxPhoto = New System.Windows.Forms.PictureBox()
        Me.buttonAddMember = New System.Windows.Forms.Button()
        Me.buttonAddSideMember = New System.Windows.Forms.Button()
        Me.cboxChildren = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picboxPhotoF = New System.Windows.Forms.PictureBox()
        Me.picboxPhotoM = New System.Windows.Forms.PictureBox()
        CType(Me.picboxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPhotoF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPhotoM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonFather
        '
        Me.buttonFather.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonFather.Location = New System.Drawing.Point(52, 212)
        Me.buttonFather.Name = "buttonFather"
        Me.buttonFather.Size = New System.Drawing.Size(138, 64)
        Me.buttonFather.TabIndex = 0
        Me.buttonFather.Text = "See Father"
        Me.buttonFather.UseVisualStyleBackColor = True
        '
        'buttonMother
        '
        Me.buttonMother.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonMother.Location = New System.Drawing.Point(493, 212)
        Me.buttonMother.Name = "buttonMother"
        Me.buttonMother.Size = New System.Drawing.Size(138, 64)
        Me.buttonMother.TabIndex = 1
        Me.buttonMother.Text = "See Mother"
        Me.buttonMother.UseVisualStyleBackColor = True
        '
        'buttonChild
        '
        Me.buttonChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonChild.Location = New System.Drawing.Point(92, 611)
        Me.buttonChild.Name = "buttonChild"
        Me.buttonChild.Size = New System.Drawing.Size(138, 64)
        Me.buttonChild.TabIndex = 2
        Me.buttonChild.Text = "See Child"
        Me.buttonChild.UseVisualStyleBackColor = True
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.Location = New System.Drawing.Point(86, 477)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(95, 31)
        Me.labelName.TabIndex = 3
        Me.labelName.Text = "Label1"
        '
        'labelFather
        '
        Me.labelFather.AutoSize = True
        Me.labelFather.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFather.Location = New System.Drawing.Point(89, 525)
        Me.labelFather.Name = "labelFather"
        Me.labelFather.Size = New System.Drawing.Size(49, 16)
        Me.labelFather.TabIndex = 4
        Me.labelFather.Text = "Label1"
        '
        'labelMother
        '
        Me.labelMother.AutoSize = True
        Me.labelMother.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMother.Location = New System.Drawing.Point(89, 561)
        Me.labelMother.Name = "labelMother"
        Me.labelMother.Size = New System.Drawing.Size(49, 16)
        Me.labelMother.TabIndex = 5
        Me.labelMother.Text = "Label2"
        '
        'picboxPhoto
        '
        Me.picboxPhoto.Image = Global.FamilyTree_v2.My.Resources.Resources.Default_Photo
        Me.picboxPhoto.Location = New System.Drawing.Point(231, 212)
        Me.picboxPhoto.Name = "picboxPhoto"
        Me.picboxPhoto.Size = New System.Drawing.Size(223, 224)
        Me.picboxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPhoto.TabIndex = 6
        Me.picboxPhoto.TabStop = False
        '
        'buttonAddMember
        '
        Me.buttonAddMember.Enabled = False
        Me.buttonAddMember.Location = New System.Drawing.Point(84, 332)
        Me.buttonAddMember.Name = "buttonAddMember"
        Me.buttonAddMember.Size = New System.Drawing.Size(106, 104)
        Me.buttonAddMember.TabIndex = 7
        Me.buttonAddMember.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Member"
        Me.buttonAddMember.UseVisualStyleBackColor = True
        Me.buttonAddMember.Visible = False
        '
        'buttonAddSideMember
        '
        Me.buttonAddSideMember.Enabled = False
        Me.buttonAddSideMember.Location = New System.Drawing.Point(493, 332)
        Me.buttonAddSideMember.Name = "buttonAddSideMember"
        Me.buttonAddSideMember.Size = New System.Drawing.Size(106, 104)
        Me.buttonAddSideMember.TabIndex = 8
        Me.buttonAddSideMember.Text = "Add Side" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Member"
        Me.buttonAddSideMember.UseVisualStyleBackColor = True
        Me.buttonAddSideMember.Visible = False
        '
        'cboxChildren
        '
        Me.cboxChildren.FormattingEnabled = True
        Me.cboxChildren.Location = New System.Drawing.Point(242, 611)
        Me.cboxChildren.Name = "cboxChildren"
        Me.cboxChildren.Size = New System.Drawing.Size(279, 21)
        Me.cboxChildren.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'picboxPhotoF
        '
        Me.picboxPhotoF.Location = New System.Drawing.Point(52, 33)
        Me.picboxPhotoF.Name = "picboxPhotoF"
        Me.picboxPhotoF.Size = New System.Drawing.Size(138, 132)
        Me.picboxPhotoF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPhotoF.TabIndex = 11
        Me.picboxPhotoF.TabStop = False
        '
        'picboxPhotoM
        '
        Me.picboxPhotoM.Location = New System.Drawing.Point(493, 33)
        Me.picboxPhotoM.Name = "picboxPhotoM"
        Me.picboxPhotoM.Size = New System.Drawing.Size(138, 132)
        Me.picboxPhotoM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxPhotoM.TabIndex = 12
        Me.picboxPhotoM.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(675, 761)
        Me.Controls.Add(Me.picboxPhotoM)
        Me.Controls.Add(Me.picboxPhotoF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboxChildren)
        Me.Controls.Add(Me.buttonAddSideMember)
        Me.Controls.Add(Me.buttonAddMember)
        Me.Controls.Add(Me.picboxPhoto)
        Me.Controls.Add(Me.labelMother)
        Me.Controls.Add(Me.labelFather)
        Me.Controls.Add(Me.labelName)
        Me.Controls.Add(Me.buttonChild)
        Me.Controls.Add(Me.buttonMother)
        Me.Controls.Add(Me.buttonFather)
        Me.Name = "Form1"
        Me.Text = "Family Tree v 2.0"
        CType(Me.picboxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPhotoF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPhotoM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonFather As Button
    Friend WithEvents buttonMother As Button
    Friend WithEvents buttonChild As Button
    Friend WithEvents labelName As Label
    Friend WithEvents labelFather As Label
    Friend WithEvents labelMother As Label
    Friend WithEvents picboxPhoto As PictureBox
    Friend WithEvents buttonAddMember As Button
    Friend WithEvents buttonAddSideMember As Button
    Friend WithEvents cboxChildren As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picboxPhotoF As PictureBox
    Friend WithEvents picboxPhotoM As PictureBox
End Class
