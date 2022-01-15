# variabel default ulang berisi Y agar dapat menjalankan perulangan pertama kali
ulang = "Y"

# perulangan while berjalan ketika variabel ulang berisi Y/y
while ulang == "Y" or ulang == "y":

    # data diri
    print("Nama\t: Ilham Soejud Alkahfiardy\n")
    print("NIM\t: 21081000005\n")
    print("Kelas\t: 1D\n")

    # judul program
    print("Menampilkan jumlah/frekuensi kemunculan/banyaknya dari input item yang diberikan")

    # variabel bilangan untuk menyimpan inputan angka dari user
    # di casting ke int karena tipe data awalnya String, maka diubah ke int dengan cara di casting dengan int
    bilangan = int(input("Masukkan bilangan yang ingin dicari jumlah nya : "))

    # variabel barisBilangan untuk menyimpan angka acak
    barisBilangan = [4, 7, 3, 2, 1, 6, 7, 8, 1]

    # variabel default frekuensi berisi 0
    frekuensi = 0

    # perulangan untuk mencocokkan tiap elemen pada array barisBilangan dengan angka inputan user
    for i in range(len(barisBilangan)):

        # jika terdapat kecocokan angka maka frekuensi + 1
        if bilangan == barisBilangan[i]:
            frekuensi = frekuensi + 1

    # jika pencocokan elemen selesai, maka cetak ada berapa jumlah bilangan yang sama dengan inputan
    print("jumlah bilangan " + str(bilangan) +
          " ada " + str(frekuensi) + " jumlah")

    # memberi pilihan kepada user apakah ingin mengulangi program atau tidak dengan menginputkan Y/T
    ulang = input("Apakah anda ingin mengulangi program? Y/T : ")

    # jika user menginputkan T maka program akan berhenti
    if ulang == "T" or ulang == "t":
        break
