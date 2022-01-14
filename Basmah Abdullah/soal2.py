# -*- coding: utf-8 -*-
"""
Created on Fri Jan 14 11:29:06 2022

@author: WINDOWS 10
"""

# 1 judul program


def main():
    print("\n")
    print("Nama \t : Basmah Abdullah\n")
    print("NIM \t : 21081000012\n")
    print("Kelas \t : 1D\n")
    # cetak judul program
    print('program menentukan nilai maksimum tiga bilangan')

# 2 input user

    # input user
    a = int(input('masukkan bilangan ke-1: '))
    b = int(input('masukkan bilangan ke-2: '))
    c = int(input('masukkan bilangan ke-3: '))

# 3 menentukan nilai maks

    # menentukan nilai terbesar
    if a > b:
        if a > c:
            maks = a
    else:
        if b > c:
            maks = b
        else:
            maks = c

    print('Nilai yang terbesar adalah: %d' % maks)


if __name__ == ' __main__':
    main()
