
Public Interface IModel
    Function IdSelect(selectId As Integer) As DataTable
    Function FormRefresh() As DataTable
    Function Search(data As SearchData) As DataTable
    Sub Destroy(selectId As Integer)
    Sub Update(data As SqlData)
    Sub Add(data As SqlData)
    Function result_return(ByVal query As String) As DataTable
    Sub result_no(ByVal query As String)
End Interface
