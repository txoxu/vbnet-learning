
Public Interface IModel
        Function IdSelect(selectId As Integer) As DataTable
        Function FormRefresh() As DataTable
    Function Search(keyword As String, dateKeyword As String) As DataTable
    Sub Destroy(selectId As Integer)
    Sub update(data As DataDto)
    Sub Add(data As DataDto)
    Sub sql_start()
        Sub sql_close()
        Function sql_result_return(ByVal query As String) As DataTable
        Function sql_result_no(ByVal query As String)
    End Interface
