Public Class FrmStud
    Dim actionFlag As String

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ClearData()
        TxtStudId.Text = ""
        actionFlag = "New"

    End Sub
    Sub ClearData()

        TxtStudName.Text = ""
        CmbCls.Text = ""
        CmbSub.Text = ""
        TxtTchrName.Text = ""
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim SQL As String
        If actionFlag = "New" Then
            If TxtStudId.Text = "" Then
                MsgBox("Please enter the student ID", MsgBoxStyle.Critical, "Incomplete Info!")
                Exit Sub
            End If
            SQL = "INSERT INTO MstStud(StudId,StudName,class,sub,TeacherName)"
            SQL += "VALUES(" + Val(TxtStudId.Text).ToString + ",'" + TxtStudName.Text + "','" + CmbCls.Text + "','" + CmbSub.Text + "','" + TxtTchrName.Text + "')"
        Else
            SQL = "UPDATE MstStud SET StudName='" + TxtStudName.Text + "',class='" + CmbCls.Text + "',sub='" + CmbSub.Text + "',TeacherName='" + TxtTchrName.Text + "' WHERE StudId= " + Val(TxtStudId.Text).ToString + ";"
        End If
        Dim dal As ClsDal
        dal = New ClsDal
        dal.ExecuteCommand(SQL)
        dal = Nothing
        MsgBox("Record Saved.", MsgBoxStyle.Information, "Saved!")
        BtnAdd_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        actionFlag = "edit"
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim str As String = "DELETE FROM MstStud WHERE StudId=" & TxtStudId.Text
        Dim dal As ClsDal
        dal = New ClsDal
        dal.ExecuteCommand(str)
        MsgBox("Record Deleted.", MsgBoxStyle.Information, "Deleted!")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
    End Sub
End Class


