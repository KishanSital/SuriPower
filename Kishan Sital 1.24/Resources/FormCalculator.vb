Public Class frmCalculator
    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim AnswerNumber As Single
    Dim ArithemeticProcess As String
    Private Sub lbl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnVermenigvuldiging.Click
        FirstNumber = Val(txt1.Text)
        txt1.Text = "0"
        ArithemeticProcess = "*"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txt1.Text = txt1.Text & "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txt1.Text = txt1.Text & "."
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        FirstNumber = Val(txt1.Text)
        txt1.Text = "0"
        ArithemeticProcess = "+"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt1.Text = txt1.Text & "1"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt1.Text = txt1.Text & "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt1.Text = txt1.Text & "3"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt1.Text = txt1.Text & "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt1.Text = txt1.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt1.Text = txt1.Text & "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt1.Text = txt1.Text & "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt1.Text = txt1.Text & "8"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt1.Text = txt1.Text & "9"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txt1.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnAftrekking.Click
        FirstNumber = Val(txt1.Text)
        txt1.Text = "0"
        ArithemeticProcess = "-"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDeling.Click
        FirstNumber = Val(txt1.Text)
        txt1.Text = "0"
        ArithemeticProcess = "/"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnGelijkaan.Click
        SecondNumber = Val(txt1.Text)
        If ArithemeticProcess = "+" Then
            AnswerNumber = FirstNumber + SecondNumber
        End If
        SecondNumber = Val(txt1.Text)
        If ArithemeticProcess = "-" Then
            AnswerNumber = FirstNumber - SecondNumber
        End If
        SecondNumber = Val(txt1.Text)
        If ArithemeticProcess = "*" Then
            AnswerNumber = FirstNumber * SecondNumber
        End If
        SecondNumber = Val(txt1.Text)
        If ArithemeticProcess = "/" Then
            AnswerNumber = FirstNumber / SecondNumber
        End If
        txt1.Text = AnswerNumber
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Calculator gemaakt door Sital Kishan ", MsgBoxStyle.Information, "Help By Sital Kishan")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If txt1.Text.Length > 0 Then
            txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1, 1)
        End If
    End Sub
End Class