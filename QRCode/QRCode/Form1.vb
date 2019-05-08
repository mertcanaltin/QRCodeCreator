Imports BarcodeLib
Imports DataMatrix
Imports ThoughtWorks.QRCode.Codec
Public Class Form1
    Private QRKod As New QRCodeEncoder
    Private QRimg As Image
    Private Sub QRKodOlusturButton_Click(sender As Object, e As EventArgs) Handles QRKodOlusturButton.Click
        Dim Veri As String = VeriTextBox1.Text
        If Not String.IsNullOrWhiteSpace(Veri) Then
            'VERİ TÜRÜ
            If MetinRadioButton1.Checked Then
                QRKod.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC
            ElseIf SayiRadioButton2.Checked Then
                QRKod.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC
            Else
                QRKod.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE

            End If
            'ÖLÇEĞİ AYARLA 
            QRKod.QRCodeScale = olcekNumericUpDown1.Value
            'versyon ayarı 
            QRKod.QRCodeVersion = versiyonNumericUpDown2.Value
            'hata düzeltme ayarı 

            Select Case hataDuzeltmeComboBox1.SelectedItem
                Case "L"
                    QRKod.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
                Case "M"
                    QRKod.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M

                Case "Q"
                    QRKod.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q

                Case "H"
                    QRKod.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H

                Case Else

            End Select

            QRKod.QRCodeBackgroundColor = ArkaZeminRengiButton.BackColor
            QRKod.QRCodeForegroundColor = KodRengiButton.BackColor

            Try
                QRimg = QRKod.Encode(Veri, System.Text.Encoding.UTF8)
                QRKODPictureBox.Image = QRimg
                HashCodeLabel.Text = "Hash Kod:" & QRKod.GetHashCode
            Catch ex As Exception
                MessageBox.Show("Hata Oluştu oluşan hata: " & ex.Message, "Hata")
            End Try

        Else
            MessageBox.Show("QR Kod oluşturulacak veri boş veya boşluk olmamalıdır.", "veri hatası warning !")
        End If

    End Sub
    Private Function TRtoEn(Metin As String) As String
        Dim TR As String = "öçşığüÖÇŞİĞÜ"
        Dim EN As String = "ocsiguOCSIGU"

        For i = 0 To TR.Length - 1
            Metin = Metin.Replace(TR(i), EN(i))
        Next
        Return Metin.ToUpper
    End Function



    Private Sub VeriTextBox1_TextChanged(sender As Object, e As EventArgs)
        veriTextBox1.Text = TRtoEn(veriTextBox1.Text)
    End Sub

    Private Sub KodRengiButton_Click(sender As Object, e As EventArgs) Handles KodRengiButton.Click
        ColorDialogQRCode.Color = KodRengiButton.BackColor
        If ColorDialogQRCode.ShowDialog = DialogResult.OK Then
            KodRengiButton.BackColor = ColorDialogQRCode.Color
        End If
    End Sub

    Private Sub ArkaZeminRengiButton_Click(sender As Object, e As EventArgs) Handles ArkaZeminRengiButton.Click
        ColorDialogQRCode.Color = ArkaZeminRengiButton.BackColor
        If ColorDialogQRCode.ShowDialog = DialogResult.OK Then
            ArkaZeminRengiButton.BackColor = ColorDialogQRCode.Color
        End If
    End Sub

    Private Sub veriTextBox1_Leave(sender As Object, e As EventArgs) Handles veriTextBox1.Leave
        veriTextBox1.Text = TRtoEn(veriTextBox1.Text)
    End Sub

    Private Sub QRKoduKaydetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QRKoduKaydetToolStripMenuItem.Click
        If QRKODPictureBox.Image IsNot Nothing Then
            If SaveFileDialogQRCODE.ShowDialog = DialogResult.OK Then
                Dim Dosya As String = SaveFileDialogQRCODE.FileName
                If SaveFileDialogQRCODE.FilterIndex = 1 Then
                    QRKODPictureBox.Image.Save(Dosya, Imaging.ImageFormat.Jpeg)
                Else
                    QRKODPictureBox.Image.Save(Dosya, Imaging.ImageFormat.Png)
                End If
            End If
        End If
    End Sub
End Class
