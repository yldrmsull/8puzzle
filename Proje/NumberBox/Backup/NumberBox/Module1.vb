Module Module1
      Sub CheckButton(ByRef Butt1 As Button, ByRef Butt2 As Button)
            If Butt2.Text = "" Then
                  Butt2.Text = Butt1.Text
                  Butt1.Text = ""
            End If
      End Sub
    Sub CheckSolved()
        If Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And Form1.Button3.Text = "3" And _
        Form1.Button4.Text = "4" And Form1.Button5.Text = "5" And Form1.Button6.Text = "6" And _
        Form1.Button7.Text = "7" And Form1.Button8.Text = "8" And Form1.Button9.Text = "9" And _
        Form1.Button10.Text = "10" And Form1.Button11.Text = "11" And Form1.Button12.Text = "12" And _
        Form1.Button13.Text = "13" And Form1.Button14.Text = "14" And Form1.Button15.Text = "15" Then
            MsgBox("Oyun Bitti! Oyunu: " + CStr(Form1.Count) + "Hamlede tamamladınız!")
        Else
            Form1.Count = Form1.Count + 1
        End If

    End Sub
    Sub Mix()
        Dim a(15), i, j, rn As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            rn = CInt(Int((15 * Rnd()) + 1))
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
        Form1.Button9.Text = a(9)
        Form1.Button10.Text = a(10)
        Form1.Button11.Text = a(11)
        Form1.Button12.Text = a(12)
        Form1.Button13.Text = a(13)
        Form1.Button14.Text = a(14)
        Form1.Button15.Text = a(15)
        Form1.Button16.Text = ""



    End Sub
End Module
