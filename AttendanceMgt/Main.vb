Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnStudFrm.Click
        FrmStud.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnTchrFrm.Click
        FrmTeacher.Show()
    End Sub

    Private Sub BtnMrkAtt_Click(sender As Object, e As EventArgs) Handles BtnMrkAtt.Click
        FrmAttendance.Show()
    End Sub

    Private Sub BtnAttList_Click(sender As Object, e As EventArgs) Handles BtnAttList.Click
        FrmAttendanceList.Show()
    End Sub
End Class