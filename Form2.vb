Imports System.Threading

Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Guna2PictureBox4.Visible = True Then
            Guna2PictureBox4.Visible = False
            Guna2PictureBox5.Visible = True
        ElseIf Guna2PictureBox5.Visible = True Then
            Guna2PictureBox5.Visible = False
            Guna2PictureBox6.Visible = True
        ElseIf Guna2PictureBox6.Visible = True Then
            Guna2PictureBox6.Visible = False
            Guna2PictureBox4.Visible = True

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class