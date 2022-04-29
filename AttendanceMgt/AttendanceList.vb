Public Class FrmAttendanceList
    Dim sqlConnStr As String
    Private Sub FrmAttendanceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayData()
    End Sub
    Private Sub displayData()
        Dim strSql As String = "Select * from attendance"
        Dim dtStud As DataTable
        Dim dal As ClsDal
        dal = New ClsDal
        dtStud = dal.getDataTable(strSql)
        GrdInfo.DataSource = dtStud
    End Sub

    Private Sub BtnSrch_Click(sender As Object, e As EventArgs) Handles BtnSrch.Click
        Dim str As String = "Select * From attendance WHERE StudId= " & TxtStudId.Text
        Dim dal As ClsDal
        dal = New ClsDal
        Dim dtStud As DataTable
        dtStud = dal.getDataTable(str)
        GrdInfo.DataSource = dtStud
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
    End Sub
End Class