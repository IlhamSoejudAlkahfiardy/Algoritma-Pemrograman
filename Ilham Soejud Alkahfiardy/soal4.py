def pengurutan(bilangan):
    # peulangan pertama untuk
    for i in range(len(bilangan)-1):
        for j in range(len(bilangan)-1):
            if(bilangan[j] > bilangan[j+1]):
                # menukar variabel
                bilangan[j], bilangan[j+1] = bilangan[j+1], bilangan[j]
    # mengembalikan variabel bilangan
    return bilangan


ulang = "Y"

while ulang == "Y" or ulang == "y":
    a = int(input("Masukkan bilangan pertama : "))
    b = int(input("Masukkan bilangan kedua : "))
    c = int(input("Masukkan bilangan ketiga : "))

    bilangan = [a, b, c]
    print("Bilangan yang tidak berurutan : ", bilangan)

    # Menjalankan fungsi pengurutan
    print("bilangan yang berurutan adalah : ", pengurutan(bilangan))

    ulang = input("Apakah anda ingin mengulangi program kembali? (Y/T) : ")

    if ulang == "T" or ulang == "t":
        break
