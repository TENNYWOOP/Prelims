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
        lblStudent = New Label()
        lblFirst = New Label()
        lblMiddle = New Label()
        lblLast = New Label()
        lblAge = New Label()
        lblBirthday = New Label()
        lblAddress = New Label()
        lblGradeLevel = New Label()
        txtFirst = New TextBox()
        txtMiddle = New TextBox()
        txtLast = New TextBox()
        txtAge = New TextBox()
        txtBirthday = New TextBox()
        txtAddress = New TextBox()
        txtGradeLevel = New TextBox()
        btnEnable = New Button()
        btnDisable = New Button()
        btnSmallcaps = New Button()
        btnInput = New Button()
        btnAllCaps = New Button()
        btnClearAll = New Button()
        rchOutput = New RichTextBox()
        btnHideAll = New Button()
        btnRed = New Button()
        btnBlue = New Button()
        btnGreen = New Button()
        btnShow = New Button()
        txtFontSize = New TextBox()
        lblFontSize = New Label()
        btnGeom = New Button()
        SuspendLayout()
        ' 
        ' lblStudent
        ' 
        lblStudent.AutoSize = True
        lblStudent.Location = New Point(555, 9)
        lblStudent.Name = "lblStudent"
        lblStudent.Size = New Size(142, 20)
        lblStudent.TabIndex = 0
        lblStudent.Text = "Student Information"
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Location = New Point(85, 56)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(80, 20)
        lblFirst.TabIndex = 1
        lblFirst.Text = "First Name"
        ' 
        ' lblMiddle
        ' 
        lblMiddle.AutoSize = True
        lblMiddle.Location = New Point(85, 110)
        lblMiddle.Name = "lblMiddle"
        lblMiddle.Size = New Size(100, 20)
        lblMiddle.TabIndex = 2
        lblMiddle.Text = "Middle Name"
        ' 
        ' lblLast
        ' 
        lblLast.AutoSize = True
        lblLast.Location = New Point(85, 176)
        lblLast.Name = "lblLast"
        lblLast.Size = New Size(79, 20)
        lblLast.TabIndex = 3
        lblLast.Text = "Last Name"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(85, 233)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(36, 20)
        lblAge.TabIndex = 4
        lblAge.Text = "Age"
        ' 
        ' lblBirthday
        ' 
        lblBirthday.AutoSize = True
        lblBirthday.Location = New Point(85, 290)
        lblBirthday.Name = "lblBirthday"
        lblBirthday.Size = New Size(64, 20)
        lblBirthday.TabIndex = 5
        lblBirthday.Text = "Birthday"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(85, 349)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(62, 20)
        lblAddress.TabIndex = 6
        lblAddress.Text = "Address"
        ' 
        ' lblGradeLevel
        ' 
        lblGradeLevel.AutoSize = True
        lblGradeLevel.Location = New Point(85, 405)
        lblGradeLevel.Name = "lblGradeLevel"
        lblGradeLevel.Size = New Size(87, 20)
        lblGradeLevel.TabIndex = 7
        lblGradeLevel.Text = "Grade Level"
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(231, 49)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(125, 27)
        txtFirst.TabIndex = 8
        ' 
        ' txtMiddle
        ' 
        txtMiddle.Location = New Point(231, 103)
        txtMiddle.Name = "txtMiddle"
        txtMiddle.Size = New Size(125, 27)
        txtMiddle.TabIndex = 9
        ' 
        ' txtLast
        ' 
        txtLast.Location = New Point(231, 169)
        txtLast.Name = "txtLast"
        txtLast.Size = New Size(125, 27)
        txtLast.TabIndex = 10
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(231, 226)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 27)
        txtAge.TabIndex = 11
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Location = New Point(231, 283)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(125, 27)
        txtBirthday.TabIndex = 12
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(231, 342)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(125, 27)
        txtAddress.TabIndex = 13
        ' 
        ' txtGradeLevel
        ' 
        txtGradeLevel.Location = New Point(231, 398)
        txtGradeLevel.Name = "txtGradeLevel"
        txtGradeLevel.Size = New Size(125, 27)
        txtGradeLevel.TabIndex = 14
        ' 
        ' btnEnable
        ' 
        btnEnable.Location = New Point(890, 49)
        btnEnable.Name = "btnEnable"
        btnEnable.Size = New Size(94, 29)
        btnEnable.TabIndex = 15
        btnEnable.Text = "Enable"
        btnEnable.UseVisualStyleBackColor = True
        ' 
        ' btnDisable
        ' 
        btnDisable.Location = New Point(890, 99)
        btnDisable.Name = "btnDisable"
        btnDisable.Size = New Size(94, 29)
        btnDisable.TabIndex = 16
        btnDisable.Text = "Disable"
        btnDisable.UseVisualStyleBackColor = True
        ' 
        ' btnSmallcaps
        ' 
        btnSmallcaps.Location = New Point(871, 148)
        btnSmallcaps.Name = "btnSmallcaps"
        btnSmallcaps.Size = New Size(134, 29)
        btnSmallcaps.TabIndex = 17
        btnSmallcaps.Text = "Small Caps"
        btnSmallcaps.UseVisualStyleBackColor = True
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(871, 266)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(134, 29)
        btnInput.TabIndex = 18
        btnInput.Text = "Generate input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' btnAllCaps
        ' 
        btnAllCaps.Location = New Point(871, 209)
        btnAllCaps.Name = "btnAllCaps"
        btnAllCaps.Size = New Size(134, 29)
        btnAllCaps.TabIndex = 19
        btnAllCaps.Text = "All Caps"
        btnAllCaps.UseVisualStyleBackColor = True
        ' 
        ' btnClearAll
        ' 
        btnClearAll.Location = New Point(871, 316)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(134, 29)
        btnClearAll.TabIndex = 20
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = True
        ' 
        ' rchOutput
        ' 
        rchOutput.Location = New Point(401, 49)
        rchOutput.Name = "rchOutput"
        rchOutput.Size = New Size(444, 261)
        rchOutput.TabIndex = 21
        rchOutput.Text = ""
        ' 
        ' btnHideAll
        ' 
        btnHideAll.Location = New Point(871, 361)
        btnHideAll.Name = "btnHideAll"
        btnHideAll.Size = New Size(134, 29)
        btnHideAll.TabIndex = 22
        btnHideAll.Text = "Hide All"
        btnHideAll.UseVisualStyleBackColor = True
        ' 
        ' btnRed
        ' 
        btnRed.BackColor = Color.Red
        btnRed.Location = New Point(401, 329)
        btnRed.Name = "btnRed"
        btnRed.Size = New Size(134, 29)
        btnRed.TabIndex = 23
        btnRed.UseVisualStyleBackColor = False
        ' 
        ' btnBlue
        ' 
        btnBlue.BackColor = Color.Blue
        btnBlue.Location = New Point(555, 329)
        btnBlue.Name = "btnBlue"
        btnBlue.Size = New Size(134, 29)
        btnBlue.TabIndex = 24
        btnBlue.UseVisualStyleBackColor = False
        ' 
        ' btnGreen
        ' 
        btnGreen.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnGreen.Location = New Point(711, 329)
        btnGreen.Name = "btnGreen"
        btnGreen.Size = New Size(134, 29)
        btnGreen.TabIndex = 25
        btnGreen.UseVisualStyleBackColor = False
        ' 
        ' btnShow
        ' 
        btnShow.Location = New Point(871, 405)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(134, 29)
        btnShow.TabIndex = 26
        btnShow.Text = "Show All"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' txtFontSize
        ' 
        txtFontSize.Location = New Point(231, 450)
        txtFontSize.Name = "txtFontSize"
        txtFontSize.Size = New Size(125, 27)
        txtFontSize.TabIndex = 27
        ' 
        ' lblFontSize
        ' 
        lblFontSize.AutoSize = True
        lblFontSize.Location = New Point(85, 457)
        lblFontSize.Name = "lblFontSize"
        lblFontSize.Size = New Size(69, 20)
        lblFontSize.TabIndex = 28
        lblFontSize.Text = "Font Size"
        ' 
        ' btnGeom
        ' 
        btnGeom.Location = New Point(871, 450)
        btnGeom.Name = "btnGeom"
        btnGeom.Size = New Size(134, 29)
        btnGeom.TabIndex = 29
        btnGeom.Text = "Go to Geometry Class"
        btnGeom.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1354, 551)
        Controls.Add(btnGeom)
        Controls.Add(lblFontSize)
        Controls.Add(txtFontSize)
        Controls.Add(btnShow)
        Controls.Add(btnGreen)
        Controls.Add(btnBlue)
        Controls.Add(btnRed)
        Controls.Add(btnHideAll)
        Controls.Add(rchOutput)
        Controls.Add(btnClearAll)
        Controls.Add(btnAllCaps)
        Controls.Add(btnInput)
        Controls.Add(btnSmallcaps)
        Controls.Add(btnDisable)
        Controls.Add(btnEnable)
        Controls.Add(txtGradeLevel)
        Controls.Add(txtAddress)
        Controls.Add(txtBirthday)
        Controls.Add(txtAge)
        Controls.Add(txtLast)
        Controls.Add(txtMiddle)
        Controls.Add(txtFirst)
        Controls.Add(lblGradeLevel)
        Controls.Add(lblAddress)
        Controls.Add(lblBirthday)
        Controls.Add(lblAge)
        Controls.Add(lblLast)
        Controls.Add(lblMiddle)
        Controls.Add(lblFirst)
        Controls.Add(lblStudent)
        Name = "Form1"
        Text = "Student Information"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStudent As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGradeLevel As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtMiddle As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtGradeLevel As TextBox
    Friend WithEvents btnEnable As Button
    Friend WithEvents btnDisable As Button
    Friend WithEvents btnSmallcaps As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents btnAllCaps As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents rchOutput As RichTextBox
    Friend WithEvents btnHideAll As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents txtFontSize As TextBox
    Friend WithEvents lblFontSize As Label
    Friend WithEvents btnGeom As Button
End Class
