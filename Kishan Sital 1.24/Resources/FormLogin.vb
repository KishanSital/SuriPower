Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If TextBox1.Text = "Suri_Power" And TextBox2.Text = "$UR!100" Then
            MsgBox("U bent nu ingelogd ", MsgBoxStyle.Information, "Login")
            Hide()
            frmProgress.Show()

        Else
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Geen Gebruikersnaam en/of Password gevonden !!", MsgBoxStyle.Critical, "Error")
            Else
                If TextBox1.Text = "" Then
                    MsgBox("Geen Gebruikersnaam!", MsgBoxStyle.Critical, "Error")
                Else
                    If TextBox2.Text = "" Then
                        MsgBox("Geen Password gevonden!", MsgBoxStyle.Critical, "Error")
                    Else
                        MsgBox("Verkeerde Gebruikersnaam en/of Password!
Voor verdere informatie zie Help knop. ", MsgBoxStyle.Critical, "Error")

                    End If
                End If
            End If
        End If


    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("Hierbij bied ik u assistentie bij het inloggen.
                Gebruikersnaam:  Suri_Power
                Password :             $UR!100 ", MsgBoxStyle.Information, "Help By Sital Kishan")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
