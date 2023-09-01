Public Class splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblrprog.Text = PBLoading1.Value & "%"

        PBLoading1.Value += 1

        If PBLoading1.Value > 5 Then
            lbltxt.Text = "Starting App...Please wait"
        End If

        If PBLoading1.Value > 30 Then
            lbltxt.Text = "Free to Play Games.."
        End If

        If PBLoading1.Value > 50 Then
            lbltxt.Text = "play On:D"
        End If


        If PBLoading1.Value > 90 Then
            lbltxt.Text = "Launching Application.."
            Form1.Show()
            Me.Hide()
            Timer1.Dispose()
        End If
    End Sub
End Class