// Dokumentasi Resmi C# dari Microsoft:
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-9.0
// Alternatif: https://www.w3schools.com/cs/index.php && https://youtube.com/playlist?list=PLa6D44cKrtoN9guvynhwiCIdUJ0CJkAMB&si=1gcf-tNfFlBbvom-

// String
// Untuk menyimpan serangkaian karakter / teks
string nama = "Eka";

// Untuk mencetak hasil ke console
Console.WriteLine("Nama saya " + nama);
// String interpolation
Console.WriteLine($"Nama saya {nama}"); // Memanggil variabel di dalam string gunakan $

// Char
// Untuk menyimpan karakter tunggal. Karakter menggunakan single quotes/tanda petik satu sbg atributnya.
char karakter = 'A';

// Integer
// Size = 4 byte. Dapat menyimpan angka mulai dari -2,147,483,648 sampai 2,147,483,647
int angka = 12;

// Long
// Size = 8 byte. Digunakan untuk menyimpan angka dengan nominal yg cukup besar, Mulai dari -9,223,372,036,854,775,808 hingga 9,223,372,036,854,775,807
// Biasanya digunakan untuk program yang berkaitan dengan presisi yang tinggi (misal perbankan & perusahaan besar spt Microsoft)
long price = 120987;

// Double
// Size = 8 byte. Untuk menyimpan angka pecahan. Dapat menyimpan angka desimal 15 digit.
double harga = 45.89;

// Float
// Size = 4 byte. Untuk menyimpan angka pecahan. Dapat menyimpan angka desimal 6 sampai 7 digit.
float ukuran = 23.5F;

// Decimal
decimal ketinggian = 50.65M;

// Boolean
bool statusMahasiswa = true;

// List
// Koleksi data yang digunakan untuk menyimpan sekumpulan elemen dengan ukuran dinamis.
// Memiliki method seperti (Add, Remove, Clear)
// List harus dilooping menggunakan foreach untuk mengeluarkan hasilnya
List<int> number = [1,2,3];

// Jika data dinamis (integer, double, string) gunakan dynamic
List<dynamic> list = ["Fasilkom", 2025, 35.9, 45.98M];

number.Add(angka); // Untuk menambahkan value ke dalam list

foreach (int item in number)
{
    Console.WriteLine(item);
}


// Array
// Struktur data yang digunakan untuk menyimpan sekumpulan elemen dengan ukuran tetap dan tipe data yang sama.
// Elemen dalam array diakses menggunakan index & seperti list, untuk mengeluarkan hasilnya harus dilooping menggunakan foreach.
// Penggunaan: untuk data statis yang ukurannya sudah diketahui saat program dijalankan.
int[] number2 = {};

foreach (int item in number2)
{
    Console.WriteLine(item);
}

// ++i => Prefix: angkanya ditambahkan dulu, kemudian nilainya baru dipakai dalam sebuah ekspresi
// Contoh:
int t = 2;
int hasil = ++t; // t jadi 3 dulu, baru nilai dari hasil = 3

// i++ => Postfix: nilai variabel dipakai dulu, kemudian baru ditambahkan
int u = 2;
int result = u++; // result = 2 dulu, kemduian u nilainya jadi 3
int x = 2;
Console.WriteLine($"Nilai x postfix = {x++}"); 
Console.WriteLine($"Nilai x asli = {x}");
Console.WriteLine($"Nilai x prefix = {++x}");

Console.WriteLine($"Nilai x sekarang = {x}");


// For Loop
for (int a = 1;  a< 5; a++)
{
    Console.WriteLine(a);
}

// While Loop
int b = 0;
while (b < 10) 
{
    Console.WriteLine(b);
    b++;
}

// Menggunakan console write saja kalimat akan menjadi satu bari
Console.Write("Kalimat menggunakan console write");
Console.Write("Kalimat menggunakan console write");

// Perkondisian (if else)
int kecepatanMaksimal = 100;
int kecepatanStandard = 60;

int kecepatan = 75;

if (kecepatan < kecepatanMaksimal )
{
    Console.WriteLine("Kecepatan dalam batas aman");
} else if (kecepatan == kecepatanStandard )
{
    Console.WriteLine("Kecepatan dalam batas standard");
} else
{
    Console.WriteLine("Kecepatan melebihi batas aman");
}

// Switch case
// Untuk memilih salah satu dari banyak blok kode yang akan dieksekusi. Alternatif dari if else.
int nilaiMahasiswa = 85;

switch (nilaiMahasiswa)
{
    case 85:
        Console.WriteLine("Nilai A");
        break;
    case 75:
        Console.WriteLine("Nilai AB");
        break;
    default:
        Console.WriteLine("Nilai tidak valid");
        break;
}

// Casting variabel
// Mengubah dari satu tipe data ke tipe data yang lain
double variabel1 = 3.146789;

// Explisit casting
int variabel2 = (int)variabel1;
Console.WriteLine($"Hasil dari casting : {variabel2}");

string variabel3 = Convert.ToString(variabel2);
decimal variabel4 = Convert.ToDecimal(variabel3);


// Untuk menerima inputan gunakan Console ReadLine
string namaUser = Console.ReadLine();
Console.WriteLine("Masukkan nama : ");
Console.WriteLine($"Nama user adalah : {namaUser}");


// Deklarasi variabel / inisiasi variabel jika nilainya belum diketahui
int tinggiBadan;
tinggiBadan = 179;



