Public Class Form1
    Private Sub btnHideAll_Click(sender As Object, e As EventArgs) Handles btnHideAll.Click
        btnAllCaps.Visible = False
        btnBlue.Visible = False
        btnClearAll.Visible = False
        btnDisable.Visible = False
        btnEnable.Visible = False
        btnGreen.Visible = False
        btnInput.Visible = False
        btnRed.Visible = False
        btnSmallcaps.Visible = False
        txtAddress.Visible = False
        txtAge.Visible = False
        txtBirthday.Visible = False
        txtFirst.Visible = False
        txtFontSize.Visible = False
        txtGradeLevel.Visible = False
        txtLast.Visible = False
        txtMiddle.Visible = False
        lblAddress.Visible = False
        lblAge.Visible = False
        lblBirthday.Visible = False
        lblFirst.Visible = False
        lblFontSize.Visible = False
        lblGradeLevel.Visible = False
        lblLast.Visible = False
        lblMiddle.Visible = False
        lblStudent.Visible = False
        rchOutput.Visible = False
        btnGeom.Visible = False
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        btnAllCaps.Visible = True
        btnBlue.Visible = True
        btnClearAll.Visible = True
        btnDisable.Visible = True
        btnEnable.Visible = True
        btnGreen.Visible = True
        btnInput.Visible = True
        btnRed.Visible = True
        btnSmallcaps.Visible = True
        txtAddress.Visible = True
        txtAge.Visible = True
        txtBirthday.Visible = True
        txtFirst.Visible = True
        txtFontSize.Visible = True
        txtGradeLevel.Visible = True
        txtLast.Visible = True
        txtMiddle.Visible = True
        lblAddress.Visible = True
        lblAge.Visible = True
        lblBirthday.Visible = True
        lblFirst.Visible = True
        lblFontSize.Visible = True
        lblGradeLevel.Visible = True
        lblLast.Visible = True
        lblMiddle.Visible = True
        lblStudent.Visible = True
        btnGeom.Visible = True
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        btnGeom.Enabled = True
    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        btnGeom.Enabled = False
    End Sub

    Private Sub btnSmallcaps_Click(sender As Object, e As EventArgs) Handles btnSmallcaps.Click
        Dim First, Last, Middle, Output As String

        First = txtFirst.Text.ToLower
        Last = txtLast.Text.ToLower
        Middle = txtMiddle.Text.ToLower
        Output = Last + "," + " " + First + " " + Middle
        rchOutput.Text = Output
    End Sub

    Private Sub btnAllCaps_Click(sender As Object, e As EventArgs) Handles btnAllCaps.Click
        Dim First, Last, Middle, Output As String

        First = txtFirst.Text.ToUpper
        Middle = txtMiddle.Text.ToUpper
        Last = txtLast.Text.ToUpper
        Output = Last + "," + " " + First + " " + Middle
        rchOutput.Text = Output
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim Last, First, Middle, Age, Birthday, Address, GradeLvl As String

        Dim Size As Integer

        Integer.TryParse(txtFontSize.Text, Size)
        rchOutput.Font = New Font(rchOutput.Font.Name, Size, rchOutput.Font.Style, rchOutput.Font.Unit)


        Last = txtLast.Text
        First = txtFirst.Text
        Middle = txtMiddle.Text
        Age = txtAge.Text
        Birthday = txtBirthday.Text
        Address = txtAddress.Text
        GradeLvl = txtGradeLevel.Text


        rchOutput.Text = Last + "," + " " + First + " " + Middle + " " + " " + "||" + " " + Age + " " + "||" + " " + Birthday + " " + "||" + " " + Address + " " + "||" + " " + GradeLvl




    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtFontSize.Text = " "
        txtAddress.Text = " "
        txtAge.Text = " "
        txtBirthday.Text = " "
        txtFirst.Text = " "
        txtGradeLevel.Text = " "
        txtLast.Text = " "
        txtMiddle.Text = " "
        rchOutput.Text = " "
        txtFirst.Focus()
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        rchOutput.BackColor = (Color.Red)
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        rchOutput.BackColor = (Color.Blue)


    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        rchOutput.BackColor = (Color.Green)
    End Sub
End Class
