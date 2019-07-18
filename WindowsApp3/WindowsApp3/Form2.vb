Public Class FORM2
    Dim Y As Boolean = False

    Dim z As String = " O"
    Dim blank As Integer = 9
    Dim p1_played As integer=0
    Dim p1_won As Integer = 0
    Dim p2_won As Integer = 0
    Dim p1_lose As Integer=0
    Dim p2_lose As Integer=0
    Dim p1_draw As Integer=0




    Private Sub Box_Click(sender As Object, e As EventArgs) Handles Box1.Click, Box7.Click, Box6.Click, Box5.Click, Box4.Click, Box3.Click, Box2.Click, Box9.Click, Box8.Click
        sender.text = z
        Y = Not Y
        z = IIf(Y, " X", " O")
        blank = blank - 1
        evaluate()
        If blank = 0 Then
            reset()
           p1_played=p1_played+1
            p1_draw=p1_draw+1

            blank = 9
            MsgBox("DRAW", MsgBoxStyle.OkCancel)
        End If
        evaluate()
    End Sub
    Public Sub evaluate()


        If (Box1.Text = " O" And Box4.Text = " O" And Box7.Text = " O") Then
            p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

            reset()
            MsgBox("player 1 won")
        ElseIf (Box1.Text = " X" And Box4.Text = " X" And Box7.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1


             reset()
            MsgBox("player 2 won")
        End If


        If (Box2.Text = " O" And Box5.Text = " O" And Box8.Text = " O") Then
             p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

            reset()
            MsgBox("player 1 won")
        ElseIf (Box2.Text = " X" And Box5.Text = " X" And Box8.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1

              reset()
            MsgBox("player 2 won")
        End If


        If (Box3.Text = " O" And Box6.Text = " O" And Box9.Text = " O") Then
            
             p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

                reset()
            MsgBox("player 1 won")
        ElseIf (Box3.Text = " X" And Box6.Text = " X" And Box9.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1

            reset()
            MsgBox("player 2 won")
        End If


        If (Box1.Text = " O" And Box2.Text = " O" And Box3.Text = " O") Then
             p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

            reset()
            MsgBox("player 1 won")
        ElseIf (Box1.Text = " X" And Box2.Text = " X" And Box3.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1

            reset()
            MsgBox("player 2 won")
        End If


        If (Box4.Text = " O" And Box5.Text = " O" And Box6.Text = " O") Then
             p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

            reset()
            MsgBox("player 1 won")
        ElseIf (Box4.Text = " X" And Box5.Text = " X" And Box6.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1

            reset()
            MsgBox("player 2 won")
        End If


        If (Box7.Text = " O" And Box8.Text = " O" And Box9.Text = " O") Then
             p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

            reset()
            MsgBox("player 1 won")
        ElseIf (Box7.Text = " X" And Box8.Text = " X" And Box9.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1

            reset()
            MsgBox("player 2 won")
        End If


        If (Box1.Text = " O" And Box5.Text = " O" And Box9.Text = " O") Then
             p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

            reset()
            MsgBox("player 1 won")
        ElseIf (Box1.Text = " X" And Box5.Text = " X" And Box9.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1

            reset()
            MsgBox("player 2 won")
        End If


        If (Box3.Text = " O" And Box5.Text = " O" And Box7.Text = " O") Then
             p1_played=p1_played+1
            p1_won =p1_won+1
            p2_lose=p2_lose+1

            reset()
            MsgBox("player 1 won")
        ElseIf (Box3.Text = " X" And Box5.Text = " X" And Box7.Text = " X") Then
            p1_played=p1_played+1
            p2_won = p2_won + 1
            p1_lose =p1_lose+1

            reset()
            MsgBox("player 2 won")
        End If

        Form3.TextBox3.Text = p1_played

        Form3.TextBox7.Text = p1_played

        Form3.TextBox4.Text = p1_won

        Form3.TextBox5.Text = p1_lose

        Form3.TextBox6.Text = p1_draw

        Form3.TextBox8.Text = p2_won

        Form3.TextBox9.Text = p2_lose

        Form3.TextBox10.Text = p1_draw








    End Sub
    Public Sub reset()
        Box1.Text = "  "
        Box2.Text = "  "
        Box3.Text = "  "
        Box4.Text = "  "
        Box5.Text = "  "
        Box6.Text = "  "
        Box7.Text = "  "
        Box8.Text = "  "
        Box9.Text = "  "
        blank = 9

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub

End Class
