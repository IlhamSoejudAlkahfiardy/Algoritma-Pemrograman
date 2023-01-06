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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnim = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cbojk = New System.Windows.Forms.ComboBox()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.txtalamatasal = New System.Windows.Forms.RichTextBox()
        Me.txtkotaasal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtalamatmalang = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboagama = New System.Windows.Forms.ComboBox()
        Me.txtlulussma = New System.Windows.Forms.TextBox()
        Me.cboprogram = New System.Windows.Forms.ComboBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.cbokelas = New System.Windows.Forms.ComboBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnkosongkan = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1. NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2. NAMA LENGKAP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3. JENIS KELAMIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "4. TGL LAHIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "5. ALAMAT ASAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "6. KOTA ASAL"
        '
        'txtnim
        '
        Me.txtnim.Location = New System.Drawing.Point(160, 33)
        Me.txtnim.Name = "txtnim"
        Me.txtnim.Size = New System.Drawing.Size(160, 20)
        Me.txtnim.TabIndex = 6
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(160, 62)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(160, 20)
        Me.txtnama.TabIndex = 7
        '
        'cbojk
        '
        Me.cbojk.FormattingEnabled = True
        Me.cbojk.Items.AddRange(New Object() {"LAKI-LAKI", "PEREMPUAN"})
        Me.cbojk.Location = New System.Drawing.Point(160, 90)
        Me.cbojk.Name = "cbojk"
        Me.cbojk.Size = New System.Drawing.Size(160, 21)
        Me.cbojk.TabIndex = 8
        '
        'dtplahir
        '
        Me.dtplahir.CustomFormat = "yyyy-MM-dd"
        Me.dtplahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtplahir.Location = New System.Drawing.Point(160, 119)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(160, 20)
        Me.dtplahir.TabIndex = 9
        '
        'txtalamatasal
        '
        Me.txtalamatasal.Location = New System.Drawing.Point(160, 152)
        Me.txtalamatasal.Name = "txtalamatasal"
        Me.txtalamatasal.Size = New System.Drawing.Size(200, 73)
        Me.txtalamatasal.TabIndex = 10
        Me.txtalamatasal.Text = ""
        '
        'txtkotaasal
        '
        Me.txtkotaasal.Location = New System.Drawing.Point(160, 234)
        Me.txtkotaasal.Name = "txtkotaasal"
        Me.txtkotaasal.Size = New System.Drawing.Size(100, 20)
        Me.txtkotaasal.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(396, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "7. ALAMAT MALANG"
        '
        'txtalamatmalang
        '
        Me.txtalamatmalang.Location = New System.Drawing.Point(524, 33)
        Me.txtalamatmalang.Name = "txtalamatmalang"
        Me.txtalamatmalang.Size = New System.Drawing.Size(193, 74)
        Me.txtalamatmalang.TabIndex = 13
        Me.txtalamatmalang.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "8. AGAMA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "9. TAHUN LULUS SMA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "10. PROGRAM KELAS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(396, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "11. EMAIL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(396, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "12. KELAS"
        '
        'cboagama
        '
        Me.cboagama.FormattingEnabled = True
        Me.cboagama.Items.AddRange(New Object() {"ISLAM", "KRISTEN", "KATOLIK", "HINDU", "BUDHA", "KEPERCAYAAN"})
        Me.cboagama.Location = New System.Drawing.Point(524, 119)
        Me.cboagama.Name = "cboagama"
        Me.cboagama.Size = New System.Drawing.Size(160, 21)
        Me.cboagama.TabIndex = 19
        '
        'txtlulussma
        '
        Me.txtlulussma.Location = New System.Drawing.Point(524, 154)
        Me.txtlulussma.Name = "txtlulussma"
        Me.txtlulussma.Size = New System.Drawing.Size(160, 20)
        Me.txtlulussma.TabIndex = 20
        '
        'cboprogram
        '
        Me.cboprogram.FormattingEnabled = True
        Me.cboprogram.Items.AddRange(New Object() {"REGULER", "AKSELERASI"})
        Me.cboprogram.Location = New System.Drawing.Point(524, 188)
        Me.cboprogram.Name = "cboprogram"
        Me.cboprogram.Size = New System.Drawing.Size(160, 21)
        Me.cboprogram.TabIndex = 21
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(524, 222)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(160, 20)
        Me.txtemail.TabIndex = 22
        '
        'cbokelas
        '
        Me.cbokelas.FormattingEnabled = True
        Me.cbokelas.Items.AddRange(New Object() {"3A", "3B", "3C", "4A", "4B", "4C"})
        Me.cbokelas.Location = New System.Drawing.Point(524, 256)
        Me.cbokelas.Name = "cbokelas"
        Me.cbokelas.Size = New System.Drawing.Size(160, 21)
        Me.cbokelas.TabIndex = 23
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(280, 326)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(127, 39)
        Me.btnrefresh.TabIndex = 24
        Me.btnrefresh.Text = "Refresh List"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(147, 326)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(127, 39)
        Me.btnsimpan.TabIndex = 25
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnkosongkan
        '
        Me.btnkosongkan.Location = New System.Drawing.Point(14, 326)
        Me.btnkosongkan.Name = "btnkosongkan"
        Me.btnkosongkan.Size = New System.Drawing.Size(127, 39)
        Me.btnkosongkan.TabIndex = 26
        Me.btnkosongkan.Text = "Kosongkan Form"
        Me.btnkosongkan.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(13, 371)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1028, 306)
        Me.ListView1.TabIndex = 27
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 689)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnkosongkan)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.cbokelas)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.cboprogram)
        Me.Controls.Add(Me.txtlulussma)
        Me.Controls.Add(Me.cboagama)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtalamatmalang)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtkotaasal)
        Me.Controls.Add(Me.txtalamatasal)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.cbojk)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnim)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnim As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cbojk As System.Windows.Forms.ComboBox
    Friend WithEvents dtplahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtalamatasal As System.Windows.Forms.RichTextBox
    Friend WithEvents txtkotaasal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtalamatmalang As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboagama As System.Windows.Forms.ComboBox
    Friend WithEvents txtlulussma As System.Windows.Forms.TextBox
    Friend WithEvents cboprogram As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents cbokelas As System.Windows.Forms.ComboBox
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnkosongkan As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView

End Class
