ulang = 'Y'  # variabel untuk perulangan program

while ulang == 'Y' or ulang == 'y':

    print("\n")  # \n untuk memberi enter
    print("Menemukan bil. terbesar dari 3 inputan user\n")  # judul program

    # 1. siapkan variabel

    # variabel untuk bil. pertama
    bilPertama = int(input("Masukkan bilangan pertama : "))
    # variabel untuk bil. kedua
    bilKedua = int(input("Masukkan bilangan kedua : "))
    # variabel untuk bil. ketiga
    bilKetiga = int(input("Masukkan bilangan ketiga : "))

    if bilPertama > bilKedua:  # cek apakah bil. pertama lebih dari bil kedua
        bilMax = bilPertama  # jika iya variable bil. max diisi bilangan pada variable bil. pertama
    else:
        bilMax = bilKedua  # jika tidak variable bil. max diisi bilangan pada variable bil. kedua

    if bilMax > bilKetiga:  # cek apakah bil. max lebih dari bil ketiga
        bilMax = bilMax  # jika iya isi variable bil. max tetap
    else:
        bilMax = bilKetiga  # jika tidak variable bil. max diisi bilangan pada variable bil. ketiga

    print("Bilangan terbesar dari ke-3 inputan tersebut adalah : " +
          str(bilMax))  # cetak bilangan tebesar

    # berikan opsi pada user, apakah ingin mengulangi program atau tidak
    ulang = input("apakah anda ingin mengulangi ? Y/T : ")

    if ulang == 'T' or ulang == 't':  # jika user memasukkan T/t maka program dihentikan
        break
