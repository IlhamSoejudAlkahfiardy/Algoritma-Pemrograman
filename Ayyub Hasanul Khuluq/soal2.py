<<<<<<< HEAD
=======

>>>>>>> a4c6944eba288e0ac7bdfc0de5a49381cb2f09f5
# cetak judul program
print('program menentukan nilai maksimum tiga bilangan Cara Pertama\n')

# input user
a = int(input('masukan bilangan ke-1: '))
b = int(input('masukan bilangan ke-2: '))
c = int(input('masukan bilangan ke-3: '))

# menenukan nilai terbesar
if a > b:  # memeriksa apakah nilai a lebih besar dari pada b
    if a > c:  # memeriksa apakah nilai a lebih besar dari pada c
        maks = a  # jika iya variabel max di isi variabel a
else:
    if b > c:  # memeriksa apakah nilai b lebih besar dari pada c
        maks = b  # jika iya variabel max di isi variabel b
    else:
        maks = c  # jika iya variabel max di isi variabel c

print('Nilai yang terbesar adalah: %d' % maks)
