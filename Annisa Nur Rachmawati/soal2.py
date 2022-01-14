

print("\n")
print("Nama \t : Annisa Nur Rachmawati\n")
print("NIM \t : 21081000005\n")
print("Kelas \t : 1D\n")
# cetak judul program
print('program menentukan nilai maksimum tiga bilangan Cara Pertama\n')
 
# input user

# menyiapkan variabel untuk bilangan pertama
a = int(input('masukan bilangan ke-1: '))

# menyiapkan variabel untuk bilangan kedua
b = int(input('masukan bilangan ke-2: '))

# menyiapkan variabel untuk bilangan ketiga
c = int(input('masukan bilangan ke-3: '))
 
# menenukan nilai terbesar

# memeriksa apakah variabel a lebih besar dari variabel b
if a > b:
    # jika iya maka variabel maks diisi variabel a
    maks = a
else :
    # jika tidak maka variabel maks diisi variabel b
    maks = b

# memeriksa apakah variabel maks lebih besar dari variabel c
if maks > c :
    # jika iya maka variabel maks tetap
    maks = maks
else :
    # jika tidak maka variabel maks diisi variabel c
    maks = c
 
# cetak bilangan terbesar
print('Nilai yang terbesar adalah: %d' % maks)