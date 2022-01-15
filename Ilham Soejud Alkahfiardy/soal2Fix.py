# variabel kunci perulangan program
ulang = "Y"

# perulangan program
while ulang == "Y" or ulang == "y":

    print("Mencari bilangan terbesar dari 3 inputan User\n")  # judul program

    # data diri
    print("Nama \t : Ilham Soejud Alkahfiardy")
    print("NIM \t : 21081000005")
    print("Kelas \t : 1D")

    # membuat variabel

    bilPertama = int(input("Masukkan bilangan pertama : "))
    bilKedua = int(input("Masukkan bilangan kedua : "))
    bilKetiga = int(input("Masukkan bilangan ketiga : "))

    # penyeleksian antar variabel

    # memeriksa apakah var bilPertama lebih besar daripada var bilKedua
    if bilPertama > bilKedua:
        # jika benar maka var bilMaks akan diisi dengan var bilPertama
        bilMaks = bilPertama

        # jika tidak maka var bilMaks akan diisi dengan var bilKedua
    else:
        bilMaks = bilKedua

    # memeriksa apakahvar bilMaks lebih besar daripada var bilKetiga
    if bilMaks > bilKetiga:

        # jika benar maka var bilMaks berisi tetap
        bilMaks = bilMaks

        # jika tidak maka var bilMaks akan diisi dengan var bilKetiga
    else:
        bilMaks = bilKetiga

    # cetak bilangan terbesar
    print("\nBilangan terbesar dari 3 inputan yaitu : " + str(bilMaks))

    # variabel ulang, untuk memberi pilihan kepada user untuk mengulangi program atau tidak
    ulang = input("\nApakah anda ingin mengulangi program? Y/T : ")

    if ulang == "T" or ulang == "t":
        break
