Public Class Form1
    Private Sub GİRİŞYAP_Click(sender As Object, e As EventArgs) Handles GİRİŞYAP.Click
        boşkontrol()

    End Sub
    Public Sub kontrol()

        If (TextBox1.Text = "YÖNETİCİ") Then
            TextBox2.Text = "123"
            Me.Hide()
            Form2.Show()
        Else

            MsgBox("KULLANICI ADI VEYA ŞİFRE HATALIDIR LÜTFEN TEKRAR DENEYİNİZ",
            MsgBoxStyle.Critical, "HATA")
        End If



    End Sub
    Public Sub boşkontrol()
        If TextBox1.Text = "" Then
            MsgBox("BOŞ BIRAKILAN ALANLARI DOLDURUNUZ",
                   MsgBoxStyle.Critical, "HATA")

        ElseIf TextBox2.Text = "" Then

            MsgBox("BOŞ BIRAKILAN ALANLARI DOLDURUNUZ",
                   MsgBoxStyle.Critical, "HATA")
        Else
            kontrol()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
