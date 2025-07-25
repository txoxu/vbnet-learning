Public Class Form1
    Private WithEvents mWidget As Widget
    Private mblnCancel As Boolean

    Private Sub mWidget_PercentDone(Percent As Single, ByRef Cancel As Boolean) Handles mWidget.PercentDone
        lblPercentDone.Text = CInt(100 * Percent) & "%"
        My.Application.DoEvents()
        If mblnCancel Then Cancel = True
    End Sub

    Private Sub Button2_Click(
    ByVal sender As Object,
    ByVal e As System.EventArgs
) Handles Button2.Click
        mblnCancel = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        mWidget = New Widget
    End Sub

    Private Sub Button1_Click(
    ByVal sender As Object,
    ByVal e As System.EventArgs
) Handles Button1.Click
        mblnCancel = False
        lblPercentDone.Text = "0%"
        lblPercentDone.Refresh()
        mWidget.LongTask(12.2, 0.33)
        If Not mblnCancel Then lblPercentDone.Text = CStr(100) & "%"
    End Sub
End Class
