Public Class Form1
      Public Count As Integer
      Dim i As Integer = 5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckButton(Button1, Button2)
        CheckButton(Button1, Button4)
        CheckSolved()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CheckButton(Button2, Button1)
        CheckButton(Button2, Button5)
        CheckButton(Button2, Button3)
        CheckSolved()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CheckButton(Button3, Button2)
        CheckButton(Button3, Button6)

        CheckSolved()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CheckButton(Button4, Button1)
        CheckButton(Button4, Button5)
        CheckButton(Button4, Button7)
        CheckSolved()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CheckButton(Button5, Button2)
        CheckButton(Button5, Button4)
        CheckButton(Button5, Button6)
        CheckButton(Button5, Button8)
        CheckSolved()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CheckButton(Button6, Button3)
        CheckButton(Button6, Button5)
        CheckButton(Button6, Button9)
        CheckSolved()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CheckButton(Button7, Button4)
        CheckButton(Button7, Button8)

        CheckSolved()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        CheckButton(Button8, Button5)
        CheckButton(Button8, Button7)
        CheckButton(Button8, Button9)
        CheckSolved()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        CheckButton(Button9, Button6)
        CheckButton(Button9, Button8)

        CheckSolved()
    End Sub
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Mix()
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mix()
    End Sub
End Class
