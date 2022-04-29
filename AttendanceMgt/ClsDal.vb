Imports System.Data
Imports System.Data.SqlClient
Public Class ClsDal
    Dim sqlCon As SqlConnection
    Dim dbCmd As SqlCommand
    Dim sqlConnStr As String = "Server=LAPTOP-ICCNP7F2\SQLEXPRESS_GUR;Database=AttendDB;User Id=sa;Password=gurpreet@123;"

    Sub ClsDAL()
        MsgBox("Connection Successful", MsgBoxStyle.Information)
    End Sub

    Public Function getDataTable(ByVal strSQL As String) As DataTable
        Dim sqlAdp As SqlDataAdapter
        sqlAdp = New SqlDataAdapter
        Dim dt As DataTable
        dt = New DataTable
        sqlCon = New SqlConnection(sqlConnStr)
        dbCmd = New SqlCommand(strSQL, sqlCon)
        sqlCon.Open()
        sqlAdp.SelectCommand = dbCmd
        sqlAdp.Fill(dt)
        sqlCon.Close()
        Return dt
    End Function

    Public Function ExecuteCommand(ByVal strSql As String) As Boolean


        Try
            dbCmd = New SqlCommand
            sqlCon = New SqlConnection(sqlConnStr)
            sqlCon.Open()
            dbCmd.CommandText = strSql
            dbCmd.CommandTimeout = 3600
            dbCmd.Connection = sqlCon
            dbCmd.ExecuteNonQuery()
            sqlCon.Close()
            Return True
        Catch ex As Exception
            sqlCon.Close()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
