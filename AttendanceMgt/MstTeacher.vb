Public Class FrmTeacher
    Dim ActionFlag As String
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        TxtTchrId.Text() = ""
        ClearData()
        ActionFlag = "new"
    End Sub
    Sub ClearData()
        TxtTchrName.Text() = ""
        CmbSub.Text() = ""
        CmbCls.Text() = ""
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ActionFlag = "edit"
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim str As String
        If ActionFlag = "new" Then
            str = "INSERT INTO MstTeacher(TeacherId, TeacherName, class, sub) "
            str += "VALUES(" + Val(TxtTchrId.Text).ToString + ",'" + TxtTchrName.Text + "','" + CmbCls.Text + "','" + CmbSub.Text + "') "
        Else
            str = "UPDATE MstTeacher SET TeacherName='" + TxtTchrName.Text + "',class='" + CmbCls.Text + "',sub='" + CmbSub.Text + "' WHERE TeacherId=" + Val(TxtTchrId.Text).ToString + ";"
        End If
        Dim dal As ClsDal
        dal = New ClsDal()
        dal.ExecuteCommand(str)
        dal = Nothing
        MsgBox("Record Saved Successfully", MsgBoxStyle.Information, "Saved!")
        BtnAdd_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Dim str As String = "DELETE FROM MstTeacher WHERE TeacherId=" & TxtTchrId.Text
        Dim dal As ClsDal
        dal = New ClsDal()
        dal.ExecuteCommand(str)
        MsgBox("Record Deleted!", MsgBoxStyle.Information, "Deleted!")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
    End Sub
End Class