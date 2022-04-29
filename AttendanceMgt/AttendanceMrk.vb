Public Class FrmAttendance
    Dim status As String
    Private Sub TxtStudId_Leave(sender As Object, e As EventArgs) Handles TxtStudId.Leave
        DisplayData()
    End Sub
    Private Sub DisplayData()
        If TxtStudId.Text = "" Then Exit Sub
        Dim str As String = "SELECT * FROM attendance WHERE StudId = " & TxtStudId.Text
        Dim dtStud As DataTable
        Dim dal As ClsDal
        dal = New ClsDal
        dtStud = dal.getDataTable(str)
        If dtStud.Rows.Count > 0 Then
            TxtStudName.Text = dtStud.Rows(0).Item("StudName")
            TxtCls.Text = dtStud.Rows(0).Item("class")
            TxtSub.Text = dtStud.Rows(0).Item("sub")
            TxtTchrName.Text = dtStud.Rows(0).Item("TeacherName")

        End If
    End Sub

    Private Sub BtnSaveAtt_Click(sender As Object, e As EventArgs) Handles BtnSaveAtt.Click
        Dim sql As String
        sql = "Insert into attendance(StudId,StudName,class,sub,TeacherName,attendStts,DateDay)"
        sql += "Values(" + Val(TxtStudId.Text).ToString + ",'" + TxtStudName.Text + "','" + TxtCls.Text + "','" + TxtSub.Text + "','" + TxtTchrName.Text + "','" + status + "','" + DateTimePicker1.Text + "')"
        Dim dal As ClsDal
        dal = New ClsDal
        dal.ExecuteCommand(sql)
        dal = Nothing
        MsgBox("Attendance Saved.", MsgBoxStyle.Information, "Saved")
    End Sub

    Private Sub RBtnPrsnt_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnPrsnt.CheckedChanged
        status = "P"
    End Sub

    Private Sub RBtnAb_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnAb.CheckedChanged
        status = "A"
    End Sub

    Private Sub BntClose_Click(sender As Object, e As EventArgs) Handles BntExit.Click
        Me.Hide()
    End Sub

    Private Sub BtnClr_Click(sender As Object, e As EventArgs) Handles BtnClr.Click
        TxtStudId.Text = ""
        TxtStudName.Text = ""
        TxtCls.Text = ""
        TxtSub.Text = ""
        TxtTchrName.Text = ""
        RBtnAb.Checked = False
        RBtnPrsnt.Checked = False

    End Sub
End Class