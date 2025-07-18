Module AgeGroup
    Public Sub agegroup(data As SearchData)

        Select Case data.AgeData
            Case 0
                data.FirstNumData = Nothing
                data.LastNumData = Nothing
            Case 1
                data.FirstNumData = 0
                data.LastNumData = 29
            Case 2
                data.FirstNumData = 30
                data.LastNumData = 59
            Case 3
                data.FirstNumData = 60
                data.LastNumData = 110
        End Select

    End Sub

End Module
