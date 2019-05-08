<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.QRKodİslemleriButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.QRKoduKaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRKoduOkuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HashCodeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainerQRCode = New System.Windows.Forms.SplitContainer()
        Me.QRKodOlusturButton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ArkaZeminRengiButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.KodRengiButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.hataDuzeltmeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.versiyonNumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.olcekNumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ByteRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.SayiRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.MetinRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.QRKODPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ColorDialogQRCode = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialogQRCODE = New System.Windows.Forms.SaveFileDialog()
        Me.veriTextBox1 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainerQRCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerQRCode.Panel1.SuspendLayout()
        Me.SplitContainerQRCode.Panel2.SuspendLayout()
        Me.SplitContainerQRCode.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.versiyonNumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.olcekNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.QRKODPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QRKodİslemleriButton1, Me.HashCodeLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'QRKodİslemleriButton1
        '
        Me.QRKodİslemleriButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QRKoduKaydetToolStripMenuItem, Me.QRKoduOkuToolStripMenuItem})
        Me.QRKodİslemleriButton1.Image = Global.QRCode.My.Resources.Resources.Qr_Code
        Me.QRKodİslemleriButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.QRKodİslemleriButton1.Name = "QRKodİslemleriButton1"
        Me.QRKodİslemleriButton1.Size = New System.Drawing.Size(123, 20)
        Me.QRKodİslemleriButton1.Text = "QR Kod İşlemleri"
        '
        'QRKoduKaydetToolStripMenuItem
        '
        Me.QRKoduKaydetToolStripMenuItem.Image = Global.QRCode.My.Resources.Resources.kaydet
        Me.QRKoduKaydetToolStripMenuItem.Name = "QRKoduKaydetToolStripMenuItem"
        Me.QRKoduKaydetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.QRKoduKaydetToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.QRKoduKaydetToolStripMenuItem.Text = "QR Kodu Kaydet"
        '
        'QRKoduOkuToolStripMenuItem
        '
        Me.QRKoduOkuToolStripMenuItem.Image = Global.QRCode.My.Resources.Resources.oku
        Me.QRKoduOkuToolStripMenuItem.Name = "QRKoduOkuToolStripMenuItem"
        Me.QRKoduOkuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.QRKoduOkuToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.QRKoduOkuToolStripMenuItem.Text = "QR Kodu Oku"
        '
        'HashCodeLabel
        '
        Me.HashCodeLabel.Name = "HashCodeLabel"
        Me.HashCodeLabel.Size = New System.Drawing.Size(61, 17)
        Me.HashCodeLabel.Text = "Hash Kod:"
        '
        'SplitContainerQRCode
        '
        Me.SplitContainerQRCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerQRCode.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerQRCode.Name = "SplitContainerQRCode"
        '
        'SplitContainerQRCode.Panel1
        '
        Me.SplitContainerQRCode.Panel1.Controls.Add(Me.QRKodOlusturButton)
        Me.SplitContainerQRCode.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainerQRCode.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainerQRCode.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainerQRCode.Panel2
        '
        Me.SplitContainerQRCode.Panel2.Controls.Add(Me.QRKODPictureBox)
        Me.SplitContainerQRCode.Size = New System.Drawing.Size(800, 428)
        Me.SplitContainerQRCode.SplitterDistance = 403
        Me.SplitContainerQRCode.TabIndex = 1
        '
        'QRKodOlusturButton
        '
        Me.QRKodOlusturButton.Image = Global.QRCode.My.Resources.Resources.Qr_Code
        Me.QRKodOlusturButton.Location = New System.Drawing.Point(35, 337)
        Me.QRKodOlusturButton.Name = "QRKodOlusturButton"
        Me.QRKodOlusturButton.Size = New System.Drawing.Size(101, 43)
        Me.QRKodOlusturButton.TabIndex = 6
        Me.QRKodOlusturButton.Text = "QR Kod Oluştur"
        Me.QRKodOlusturButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.QRKodOlusturButton.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.ArkaZeminRengiButton)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.KodRengiButton)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 251)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(394, 80)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "QR KOD RENGİ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Arka Zemin Rengi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kod Rengi"
        '
        'ArkaZeminRengiButton
        '
        Me.ArkaZeminRengiButton.BackColor = System.Drawing.Color.White
        Me.ArkaZeminRengiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArkaZeminRengiButton.Location = New System.Drawing.Point(266, 21)
        Me.ArkaZeminRengiButton.Name = "ArkaZeminRengiButton"
        Me.ArkaZeminRengiButton.Size = New System.Drawing.Size(75, 49)
        Me.ArkaZeminRengiButton.TabIndex = 1
        Me.ArkaZeminRengiButton.Text = " "
        Me.ArkaZeminRengiButton.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(267, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KodRengiButton
        '
        Me.KodRengiButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.KodRengiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KodRengiButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.KodRengiButton.Location = New System.Drawing.Point(88, 22)
        Me.KodRengiButton.Name = "KodRengiButton"
        Me.KodRengiButton.Size = New System.Drawing.Size(75, 48)
        Me.KodRengiButton.TabIndex = 0
        Me.KodRengiButton.Text = " "
        Me.KodRengiButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.hataDuzeltmeComboBox1)
        Me.GroupBox3.Controls.Add(Me.versiyonNumericUpDown2)
        Me.GroupBox3.Controls.Add(Me.olcekNumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 177)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 72)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Qr Kod Ayarları"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(9, 97)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(388, 77)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'hataDuzeltmeComboBox1
        '
        Me.hataDuzeltmeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hataDuzeltmeComboBox1.FormattingEnabled = True
        Me.hataDuzeltmeComboBox1.Items.AddRange(New Object() {"L", "M", "Q", "H"})
        Me.hataDuzeltmeComboBox1.Location = New System.Drawing.Point(270, 39)
        Me.hataDuzeltmeComboBox1.Name = "hataDuzeltmeComboBox1"
        Me.hataDuzeltmeComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.hataDuzeltmeComboBox1.TabIndex = 5
        '
        'versiyonNumericUpDown2
        '
        Me.versiyonNumericUpDown2.Location = New System.Drawing.Point(144, 40)
        Me.versiyonNumericUpDown2.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.versiyonNumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.versiyonNumericUpDown2.Name = "versiyonNumericUpDown2"
        Me.versiyonNumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.versiyonNumericUpDown2.TabIndex = 4
        Me.versiyonNumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'olcekNumericUpDown1
        '
        Me.olcekNumericUpDown1.Location = New System.Drawing.Point(9, 40)
        Me.olcekNumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.olcekNumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.olcekNumericUpDown1.Name = "olcekNumericUpDown1"
        Me.olcekNumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.olcekNumericUpDown1.TabIndex = 3
        Me.olcekNumericUpDown1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hata Düzeltme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Versiyon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ölçek"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ByteRadioButton3)
        Me.GroupBox2.Controls.Add(Me.SayiRadioButton2)
        Me.GroupBox2.Controls.Add(Me.MetinRadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(397, 53)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Veri"
        '
        'ByteRadioButton3
        '
        Me.ByteRadioButton3.AutoSize = True
        Me.ByteRadioButton3.Location = New System.Drawing.Point(230, 19)
        Me.ByteRadioButton3.Name = "ByteRadioButton3"
        Me.ByteRadioButton3.Size = New System.Drawing.Size(46, 17)
        Me.ByteRadioButton3.TabIndex = 2
        Me.ByteRadioButton3.Text = "Byte"
        Me.ByteRadioButton3.UseVisualStyleBackColor = True
        '
        'SayiRadioButton2
        '
        Me.SayiRadioButton2.AutoSize = True
        Me.SayiRadioButton2.Location = New System.Drawing.Point(122, 19)
        Me.SayiRadioButton2.Name = "SayiRadioButton2"
        Me.SayiRadioButton2.Size = New System.Drawing.Size(45, 17)
        Me.SayiRadioButton2.TabIndex = 1
        Me.SayiRadioButton2.Text = "Sayı"
        Me.SayiRadioButton2.UseVisualStyleBackColor = True
        '
        'MetinRadioButton1
        '
        Me.MetinRadioButton1.AutoSize = True
        Me.MetinRadioButton1.Checked = True
        Me.MetinRadioButton1.Location = New System.Drawing.Point(9, 19)
        Me.MetinRadioButton1.Name = "MetinRadioButton1"
        Me.MetinRadioButton1.Size = New System.Drawing.Size(51, 17)
        Me.MetinRadioButton1.TabIndex = 0
        Me.MetinRadioButton1.TabStop = True
        Me.MetinRadioButton1.Text = "Metin"
        Me.MetinRadioButton1.UseVisualStyleBackColor = True
        '
        'QRKODPictureBox
        '
        Me.QRKODPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QRKODPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.QRKODPictureBox.Name = "QRKODPictureBox"
        Me.QRKODPictureBox.Size = New System.Drawing.Size(393, 428)
        Me.QRKODPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QRKODPictureBox.TabIndex = 3
        Me.QRKODPictureBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.veriTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 118)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veri"
        '
        'ColorDialogQRCode
        '
        Me.ColorDialogQRCode.AnyColor = True
        Me.ColorDialogQRCode.FullOpen = True
        '
        'SaveFileDialogQRCODE
        '
        Me.SaveFileDialogQRCODE.Filter = "JPG Dosyası|*.jpg|PNG Dosyası|.png "
        Me.SaveFileDialogQRCODE.Title = "QR Kodu Kaydet"
        '
        'veriTextBox1
        '
        Me.veriTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.veriTextBox1.Multiline = True
        Me.veriTextBox1.Name = "veriTextBox1"
        Me.veriTextBox1.Size = New System.Drawing.Size(391, 96)
        Me.veriTextBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SplitContainerQRCode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "QR KOD OLUŞTURUCU V1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainerQRCode.Panel1.ResumeLayout(False)
        Me.SplitContainerQRCode.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerQRCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerQRCode.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.versiyonNumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.olcekNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.QRKODPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents HashCodeLabel As ToolStripStatusLabel
    Friend WithEvents QRKodİslemleriButton1 As ToolStripDropDownButton
    Friend WithEvents SplitContainerQRCode As SplitContainer
    Friend WithEvents QRKoduKaydetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRKoduOkuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents hataDuzeltmeComboBox1 As ComboBox
    Friend WithEvents versiyonNumericUpDown2 As NumericUpDown
    Friend WithEvents olcekNumericUpDown1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ByteRadioButton3 As RadioButton
    Friend WithEvents SayiRadioButton2 As RadioButton
    Friend WithEvents MetinRadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QRKodOlusturButton As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ArkaZeminRengiButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents KodRengiButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents QRKODPictureBox As PictureBox
    Friend WithEvents ColorDialogQRCode As ColorDialog
    Friend WithEvents SaveFileDialogQRCODE As SaveFileDialog
    Friend WithEvents veriTextBox1 As TextBox
End Class
