# variabel ulang berisi Y untuk menjalankan perulangan program
ulang = "Y"

# perulangan program yang berjalan apabila variabel ulang berisi Y/y
while ulang == "Y" or ulang == "y":

    # data diri
    print("Nama \t : Ilham Soejud Alkahfiardy")
    print("NIM \t : 21081000005")
    print("Kelas \t : 1D")

    # menyiapkan variabel sebagai penampung inputan user
    a = int(input("\nMasukkan bilangan pertama : "))
    b = int(input("Masukkan bilangan kedua : "))
    c = int(input("Masukkan bilangan ketiga : "))

    # inputan user dimasukkan dalam variabel array bilangan
    bilangan = [a, b, c]

    # cetak variabel array bilangan yaitu berisi bilangan tidak berurutan
    print("Bilangan yang tidak berurutan : ", bilangan)

    # perulangan pertama
    for i in range(len(bilangan)-1):
        for j in range(len(bilangan)-1):
            if(bilangan[j] > bilangan[j+1]):
                # menukar variabel
                bilangan[j], bilangan[j+1] = bilangan[j+1], bilangan[j]

    # cetak variabel bilangan yang berhasil diurutkan
    print("bilangan yang berurutan adalah : " + str(bilangan))

    # beri pilihan kepada user apakah ingin mengulangi program atau tidak
    ulang = input("Apakah anda ingin mengulangi program kembali? (Y/T) : ")

    # apabila user menginputkan T/t makan program akan berhenti
    if ulang == "T" or ulang == "t":
        break
