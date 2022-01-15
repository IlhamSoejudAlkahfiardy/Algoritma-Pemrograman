# variabel ulang berisi Y agar perulangan while pada program dapat berjalan
ulang = "Y"

# perulangan while guna menjalankan program apabila isi variabel ulang = Y
while ulang == 'Y' or ulang == 'y':

    # data diri
    print("Nama \t : Ilham Soejud Alkahfiardy")
    print("NIM \t : 21081000005")
    print("Kelas \t : 1D\n")

    # judul program
    print("Menjumlahkan 2 array dengan dimensi yang sama")

    # membuat 2 variabel array
    array1 = [1, 3, 4]
    array2 = [3, 4, 1]

    # menjumlahkan array1 dengan array2 sesuai dimensinya, kemudian disimpan apda variabel array 3
    array3 = [array1[0] + array2[0], array1[1] +
              array2[1], array1[2] + array2[2]]

    # cetak isi dari array 1
    print(array1)

    # cetak isi dari array 2
    print(array2)

    # cetak isi dari array 3
    print("isi dari array 3 adalah : " + str(array3))

    # beri pilihan pada user apakah ingin mengulangi program atau berhenti
    ulang = input("Apakah anda ingin mengulangi program? Y/T : ")

    # apabila user menginputkan T/t maka program akan berhenti
    if ulang == 'T' or ulang == 't':
        break
