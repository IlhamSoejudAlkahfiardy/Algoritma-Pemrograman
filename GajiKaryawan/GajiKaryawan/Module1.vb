Imports System.Console
Imports System.IO
Module Module1

    Dim jabatan() As String
    Dim statusKep() As String
    Dim status() As String
    Dim gajiGol() As Integer
    Dim tunjIstri() As Double
    Dim tunjAnak As Double
    Dim gajiBruto As Integer
    Dim potKoperasi As Integer
    Dim biayaJabatan As Integer
    Dim danaPensiun As Integer
    Dim gajiNetto As Integer

    Dim nama As String
    Dim golongan As Integer
    Dim jabatanInput As String
    Dim statusKepInput As String
    Dim jk As String
    Dim kawin As String
    Dim jmlAnak As Integer
    Dim gajiPokok As Integer
    Dim jmlTunjIstri As Double
    Dim jmlTunjAnak As Double

    Dim ulangGol As Boolean
    Dim ulangJabatan As Boolean
    Dim ulangStatusKep As Boolean
    Dim ulangJk As Boolean
    Dim ulangStatusKawin As Boolean


    Sub Main()

        jabatan = {"KEPALA", "MANAGER", "UMUM"}
        statusKep = {"TETAP", "HONORER"}
        gajiGol = {1500000, 2500000, 3500000}
        tunjIstri = {0.01, 0.03, 0.05}
        tunjAnak = 0.01
        gajiBruto = 0
        potKoperasi = 5000
        jmlAnak = 0
        jmlTunjIstri = 0
        biayaJabatan = 0
        danaPensiun = 0

        ulangGol = True
        ulangJabatan = True
        ulangStatusKep = True
        ulangJk = True
        ulangStatusKawin = True

        WriteLine("Pendataan Data Gaji Karyawan")
        WriteLine("============================")
        WriteLine()

        Write("> Masukkan nama anda : ")
        nama = ReadLine()

        Do While ulangGol = True
            WriteLine()
            Write("> Masukkan data golongan anda (1/2/3) : ")
            golongan = ReadLine()

            If golongan > 3 Then
                WriteLine()
                WriteLine("Masukkan golongan anda dengan benar!")
                ulangGol = True
            Else
                ulangGol = False
            End If
        Loop

        Do While ulangJabatan = True
            WriteLine()
            Write("> Masukkan jabatan anda (KEPALA/MANAGER/UMUM) : ")
            jabatanInput = UCase(ReadLine())

            For i = 0 To jabatan.Length - 1
                If jabatan(i) = jabatanInput Then
                    ulangJabatan = False
                    Exit For
                End If
            Next

            If ulangJabatan = True Then
                WriteLine()
                WriteLine("Jabatan anda tidak ada!")
            End If
        Loop

        Do While ulangStatusKep = True
            WriteLine()
            Write("> Masukkan status kepegawaian anda (TETAP/HONORER) : ")
            statusKepInput = UCase(ReadLine())

            For i = 0 To statusKep.Length - 1
                If statusKep(i) = statusKepInput Then
                    ulangStatusKep = False
                    Exit For
                End If
            Next

            If ulangStatusKep = True Then
                WriteLine()
                WriteLine("Masukkan status kepegawaian anda dengan benar!")
            End If
        Loop

        Do While ulangJk = True
            WriteLine()
            Write("> Masukkan jenis kelamin anda (LAKI-LAKI/PEREMPUAN) : ")
            jk = UCase(ReadLine())

            If jk = "LAKI-LAKI" Then
                ulangJk = False
            ElseIf jk = "LAKI LAKI" Then
                ulangJk = False
            ElseIf jk = "LAKI - LAKI" Then
                ulangJk = False
            ElseIf jk = "PEREMPUAN" Then
                ulangJk = False
            Else
                WriteLine("Masukkan jenis kelamin anda dengan benar!")
            End If

        Loop

        Do While ulangStatusKawin = True
            WriteLine()
            Write("> Masukkan status kawin anda (KAWIN/JOMBLO) : ")
            kawin = UCase(ReadLine())

            If kawin = "KAWIN" Then
                Write("> Berapa jumlah anak anda : ")
                jmlAnak = jmlAnak + ReadLine()

                WriteLine("Status kawin anda : " & kawin)
                WriteLine("Jumlah anak anda : " & jmlAnak)
                ulangStatusKawin = False
            ElseIf kawin = "JOMBLO" Then
                WriteLine("Status kawin anda : " & kawin)
                ulangStatusKawin = False
            Else
                WriteLine()
                WriteLine("Masukkan status perkawinan dengan benar!")
                ulangStatusKawin = True
            End If
        Loop

        process()
        tampil()
        print()
    End Sub

    Sub process()
        'Gaji pokok
        gajiPokok = gajiGol(golongan - 1)

        'Tunjangan istri
        If jk = "LAKI-LAKI" And kawin = "KAWIN" Or jk = "LAKI LAKI" And kawin = "KAWIN" Or jk = "LAKI - LAKI" And kawin = "KAWIN" Then
            jmlTunjIstri = jmlTunjIstri + (tunjIstri(golongan - 1) * gajiPokok)
        End If

        'Tunjangan anak
        If kawin = "KAWIN" And jmlAnak > 0 Then
            jmlTunjAnak = tunjAnak * gajiPokok
            If jmlAnak <= 2 Then
                jmlTunjAnak = jmlTunjAnak * jmlAnak
            Else
                jmlTunjAnak = jmlTunjAnak * 2
            End If
        End If

        'Gaji bruto
        gajiBruto = gajiPokok + jmlTunjAnak + jmlTunjIstri

        'Potongan koperasi
        If statusKepInput = "TETAP" Then
            potKoperasi = potKoperasi
        Else
            potKoperasi = 0
        End If

        'Biaya jabatan
        If jabatanInput = "KEPALA" Then
            biayaJabatan = biayaJabatan + (0.005 * gajiPokok)
        ElseIf jabatanInput = "MANAGER" Then
            biayaJabatan = biayaJabatan + (0.003 * gajiPokok)
        End If

        'Dana pensiun
        If jabatanInput = "KEPALA" And statusKepInput = "TETAP" Then
            danaPensiun = danaPensiun + (0.005 * gajiPokok)
        ElseIf jabatanInput = "MANAGER" And statusKepInput = "TETAP" Then
            danaPensiun = danaPensiun + (0.003 * gajiPokok)
        End If

        'Gaji netto
        gajiNetto = gajiBruto - (potKoperasi + biayaJabatan + danaPensiun)
    End Sub

    Sub tampil()
        Clear()
        WriteLine()
        WriteLine("----------------------------")
        WriteLine("     SLIP GAJI: " & nama)
        WriteLine("----------------------------")
        WriteLine("1. Golongan          : " & golongan)
        WriteLine("2. Jabatan           : " & jabatanInput)
        WriteLine("3. Status Pegawai    : " & statusKepInput)
        WriteLine("4. Jenis Kelamin     : " & jk)
        WriteLine("5. Status Kawin      : " & kawin)
        WriteLine("6. Jumlah Anak       : " & jmlAnak)
        WriteLine("7. Gaji Pokok        : Rp  " & FormatNumber(Convert.ToInt32(gajiPokok)), 0, TriState.True, 0)
        WriteLine("8. Tunjangan Istri   : Rp  " & FormatNumber(Convert.ToInt32(jmlTunjIstri)), 0, TriState.True, 0)
        WriteLine("9. Tunjangan Anak    : Rp  " & FormatNumber(Convert.ToInt32(jmlTunjAnak)), 0, TriState.True, 0)
        WriteLine("        Gaji Bruto   : Rp  " & FormatNumber(Convert.ToInt32(gajiBruto)), 0, TriState.True, 0)
        WriteLine("10. Potongan Koperasi: Rp  " & FormatNumber(Convert.ToInt32(potKoperasi)), 0, TriState.True, 0)
        WriteLine("11. Biaya Jabatan    : Rp  " & FormatNumber(Convert.ToInt32(biayaJabatan)), 0, TriState.True, 0)
        WriteLine("12. Dana Pensiun     : Rp  " & FormatNumber(Convert.ToInt32(danaPensiun)), 0, TriState.True, 0)
        WriteLine("        Gaji Netto   : Rp  " & FormatNumber(Convert.ToInt32(gajiNetto)), 0, TriState.True, 0)
        WriteLine("----------------------------")
        WriteLine()
        WriteLine("Slip gaji anda telah tersimpan pada komputer")
    End Sub

    Sub print()
        Dim mydate As String = DateTime.Now.ToString("dd'-'MM'-'yyyy-HH-mm-ss")
        Dim filename As String

        filename = "Slip Gaji " & nama & " " & mydate & ".txt"

        Dim myWriter As StreamWriter

        myWriter = My.Computer.FileSystem.OpenTextFileWriter("D:\KULIAH\Matkul\Semester 3\Algoritma Struktur Data\UTS\" & filename, True)

        myWriter.WriteLine("----------------------------")
        myWriter.WriteLine("     SLIP GAJI: " & nama)
        myWriter.WriteLine("----------------------------")
        myWriter.WriteLine("1. Golongan          : " & golongan)
        myWriter.WriteLine("2. Jabatan           : " & jabatanInput)
        myWriter.WriteLine("3. Status Pegawai    : " & statusKepInput)
        myWriter.WriteLine("4. Jenis Kelamin     : " & jk)
        myWriter.WriteLine("5. Status Kawin      : " & kawin)
        myWriter.WriteLine("6. Jumlah Anak       : " & jmlAnak)
        myWriter.WriteLine("7. Gaji Pokok        : Rp " & FormatNumber(Convert.ToInt32(gajiPokok)), 0, TriState.True, 0)
        myWriter.WriteLine("8. Tunjangan Istri   : Rp  " & FormatNumber(Convert.ToInt32(jmlTunjIstri)), 0, TriState.True, 0)
        myWriter.WriteLine("9. Tunjangan Anak    : Rp  " & FormatNumber(Convert.ToInt32(jmlTunjAnak)), 0, TriState.True, 0)
        myWriter.WriteLine("        Gaji Bruto   : Rp  " & FormatNumber(Convert.ToInt32(gajiBruto)), 0, TriState.True, 0)
        myWriter.WriteLine("10. Potongan Koperasi: Rp  " & FormatNumber(Convert.ToInt32(potKoperasi)), 0, TriState.True, 0)
        myWriter.WriteLine("11. Biaya Jabatan    : Rp  " & FormatNumber(Convert.ToInt32(biayaJabatan)), 0, TriState.True, 0)
        myWriter.WriteLine("12. Dana Pensiun     : Rp  " & FormatNumber(Convert.ToInt32(danaPensiun)), 0, TriState.True, 0)
        myWriter.WriteLine("        Gaji Netto   : Rp  " & FormatNumber(Convert.ToInt32(gajiNetto)), 0, TriState.True, 0)
        myWriter.WriteLine("----------------------------")
        myWriter.WriteLine()
        myWriter.Close()
    End Sub

End Module
