Module mod_globals_a189289
    Public myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;
Data Source=DB_SPORTRIMS_MARKET_A189289.accdb;Persist Security Info=False;"
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)

    Public Function run_sql_query(mysql As String) As DataTable

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception

            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try

        Return mydatatable

    End Function
End Module
