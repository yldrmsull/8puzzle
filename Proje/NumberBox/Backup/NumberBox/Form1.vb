Public Class Form1
      Public Count As Integer
      Dim i As Integer = 5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CheckButton(Button1, Button2)
        CheckButton(Button1, Button5)
        CheckSolved()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CheckButton(Button2, Button1)
        CheckButton(Button2, Button3)
        CheckButton(Button2, Button6)
        CheckSolved()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CheckButton(Button3, Button2)
        CheckButton(Button3, Button4)
        CheckButton(Button3, Button7)
        CheckSolved()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CheckButton(Button4, Button3)
        CheckButton(Button4, Button8)
        CheckSolved()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CheckButton(Button5, Button1)
        CheckButton(Button5, Button6)
        CheckButton(Button5, Button9)
        CheckSolved()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CheckButton(Button6, Button2)
        CheckButton(Button6, Button5)
        CheckButton(Button6, Button10)
        CheckButton(Button6, Button7)
        CheckSolved()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        CheckButton(Button7, Button3)
        CheckButton(Button7, Button6)
        CheckButton(Button7, Button11)
        CheckButton(Button7, Button8)
        CheckSolved()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        CheckButton(Button8, Button4)
        CheckButton(Button8, Button7)
        CheckButton(Button8, Button12)
        CheckSolved()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        CheckButton(Button9, Button5)
        CheckButton(Button9, Button10)
        CheckButton(Button9, Button13)
        CheckSolved()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        CheckButton(Button10, Button6)
        CheckButton(Button10, Button9)
        CheckButton(Button10, Button11)
        CheckButton(Button10, Button14)
        CheckSolved()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        CheckButton(Button11, Button7)
        CheckButton(Button11, Button10)
        CheckButton(Button11, Button15)
        CheckButton(Button11, Button12)
        CheckSolved()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        CheckButton(Button12, Button8)
        CheckButton(Button12, Button11)
        CheckButton(Button12, Button16)
        CheckSolved()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        CheckButton(Button13, Button9)
        CheckButton(Button13, Button14)
        CheckSolved()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        CheckButton(Button14, Button13)
        CheckButton(Button14, Button10)
        CheckButton(Button14, Button15)
        CheckSolved()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        CheckButton(Button15, Button14)
        CheckButton(Button15, Button11)
        CheckButton(Button15, Button16)
        CheckSolved()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        CheckButton(Button16, Button12)
        CheckButton(Button16, Button15)
        CheckSolved()
    End Sub
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Mix()
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
