Public Class frmKishanSital

    Private e As Object

    Private Sub btninfo_Click_2(sender As Object, e As EventArgs) Handles btninfo.Click
        MsgBox("Welcome. Hier kunt u een berekening maken van het Bedrag die u moet betalen door het gebruik te maken van alleen uw Begin en Eindstand ", MsgBoxStyle.Information, "Informatie")
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnCalculator.Click
        frmCalculator.Show()

    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Hier kunt u uw gegevens invullen ,zodat u uw bedrag kunt berekenen ", MsgBoxStyle.Information, "Informatie")
    End Sub

    Private Sub btnSluiten_Click(sender As Object, e As EventArgs) Handles btnSluiten.Click
        End
    End Sub

    Private Sub ComboboxFase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboboxFase.SelectedIndexChanged
        Dim Fase As String = ComboboxFase.Text
        Dim lblFasebedrag As String

        lblFasebedrag = 10 And 20 AndAlso 30
        Select Case Fase
            Case "1"
                lblFasebedrag = "10"
            Case "2"
                lblFasebedrag = "20"
            Case "3"
                lblFasebedrag = "30"

        End Select
        lblFaseValue.Text = lblFasebedrag
        ComboboxFase.SelectAll()


    End Sub

    Private Sub btnBerekenen_Click(sender As Object, e As EventArgs) Handles btnBerekenen.Click

        lblVerbruikValue.Text = Val(txtEind.Text) - Val(txtBegin.Text)
        lblRekeningValue.Text = Val(lblVerbruikValue.Text) * Val(0.15)
        Labeltotaal.Text = Val(lblFaseValue.Text) + (lblVerbruikValue.Text * 0.15)

        If Labeltotaal.Text > 200 Then
            Labeltotaal.BackColor = Color.Red
            MsgBox("Uw bedrag is hoger dan SRD 200; ", MsgBoxStyle.Critical, "Waarschuwing")

            System.Media.SystemSounds.Asterisk.Play()
        Else
            Labeltotaal.BackColor = Color.Aqua


        End If

    End Sub

    Private Sub frmKishanSital_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblbegin_Click(sender As Object, e As EventArgs) Handles lblbegin.Click

    End Sub

    Private Sub Fase_Click(sender As Object, e As EventArgs) Handles Fase.Click

    End Sub

    Private Sub lblFasebedrag_Click(sender As Object, e As EventArgs) Handles lblFasebedrag.Click

    End Sub

    Private Sub lblRekening_Click(sender As Object, e As EventArgs) Handles lblRekening.Click

    End Sub

    Private Sub lblVerbruik_Click(sender As Object, e As EventArgs) Handles lblVerbruik.Click

    End Sub

    Private Sub lblEindStand_Click(sender As Object, e As EventArgs) Handles lblEindStand.Click

    End Sub
End Class
