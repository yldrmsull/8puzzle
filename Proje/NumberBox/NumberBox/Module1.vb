Module Module1
      Sub CheckButton(ByRef Butt1 As Button, ByRef Butt2 As Button)
            If Butt2.Text = "" Then
                  Butt2.Text = Butt1.Text
                  Butt1.Text = ""
            End If
      End Sub
    Sub CheckSolved()
        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And Form1.Button3.Text = "3" And
        Form1.Button4.Text = "4" And Form1.Button5.Text = "5" And Form1.Button6.Text = "6" And
        Form1.Button7.Text = "7" And Form1.Button8.Text = "8" And Form1.Button9.Text = "" Then
            MsgBox("Oyun Bitti! Oyunu: " + CStr(Form1.Count) + "Hamlede tamamladınız!")
            Form1.Count = 0
        Else
            Form1.Count = Form1.Count + 1
        End If

    End Sub
    Sub Mix()
        Dim a(8), i, j, rn As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 8
            Randomize()
            rn = CInt(Int((8 * Rnd()) + 1))
            For j = 1 To i
                If (a(j) = rn) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = rn
                i = i + 1
            End If
        Loop
        Form1.Button1.Text = a(1)
        Form1.Button2.Text = a(2)
        Form1.Button3.Text = a(3)
        Form1.Button4.Text = a(4)
        Form1.Button5.Text = a(5)
        Form1.Button6.Text = a(6)
        Form1.Button7.Text = a(7)
        Form1.Button8.Text = a(8)
        Form1.Button9.Text = ""



    End Sub
End Module
