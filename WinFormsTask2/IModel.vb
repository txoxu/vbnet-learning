
Public Interface IModel
    Sub Destroy(selectId As Integer)
    Sub Update(data As PersonData)
    Sub Add(data As PersonData)
    Function RowSelect(SelectId As Integer) As DataTable
    Function FormRefresh() As DataTable
    Function Search(data As SearchData) As DataTable
    Function result_return(ByVal query As String) As DataTable
    Sub result_no(ByVal query As String)
End Interface
