using Managemen;
using System.Reflection.Metadata;

class App
{
    public static void Main(string[] args)
    {
        //Manusia agus = new Manusia();

        //agus.warnaRambut = "Pink muda";
        //agus.warnaKulit = "Sawo Matang";
        //agus.bentukHidung = "Pesek";

        ////agus.Berjalan();

        ////agus.Melempar("batu");

        ////agus.Menampilkan();
        ////agus.Melempar("batu");


        ////Manusia.bersuara();

        ////kalkulator kalkulator1 = new kalkulator();

        ////kalkulator1.tambah();

        //Console.WriteLine(kalkulator.Tambah(1,3));

        // LIVE CODE
        //Mobil bmw = new Mobil();
        //bmw.warna = "merah";
        //bmw.kecepatan = 10;
        //bmw.jalan(100);
        //bmw.TampilkanInfo();

        Laptop advan = new Laptop("Advan", 16);
        Laptop dell = new Laptop("Dell", 8);
        Laptop lenovo = new Laptop("Dell", 8);
        advan.TampilkanInfo();
        Console.WriteLine($"jumlah objek dibuat: {Laptop.jumlahLaptop}");

        Perpustakaan.Buku buku1 = new Perpustakaan.Buku("MTK", "yanto", 2020);
        buku1.TampilkanInfo();
        PerpusManager yani = new PerpusManager();
        PerpusManager.HitungDenda(3);

    }
}

// LIVE CODE 1
class Mobil
{
    public string warna = "Merah";
    public int kecepatan = 0;

    public int jalan(int kmh)
    {
        return kecepatan = kmh + kecepatan;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Mobil berwarna {warna} dan kecepatannya {kecepatan}");
    }
}


// LIVE CODE 2
class Laptop
{
    public string merk;
    public int ram;
    public static int jumlahLaptop;

    public Laptop(string merk, int ram)
    {
        this.merk = merk;
        this.ram = ram;
        jumlahLaptop++;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Laptop merk {merk} punya ram {ram}");
    }
}

// LIVE CODE 3
namespace Perpustakaan
{
    class Buku
    {
        public string judul;
        public string penulis;
        public int tahunTerbit;
        public Buku(string judul, string penulis, int tahunTerbit)
        {
            this.judul = judul;
            this.penulis = penulis;
            this.tahunTerbit = tahunTerbit;
        }
        public void TampilkanInfo()
        {
            Console.WriteLine("Informasi Buku:");
            Console.WriteLine("Judul buku: " + judul);
            Console.WriteLine("Penulis: " + penulis);
            Console.WriteLine("Tahun Terbit: " + tahunTerbit);
        }

    }
}

namespace Managemen
{
    class PerpusManager
    {
        public static void HitungDenda(int hariTerlambat)
        {
            int dendaPerHari = 2000;
            int totalDenda = hariTerlambat * dendaPerHari;
            Console.WriteLine("Total denda: Rp " + totalDenda);
        }
    }
}


class Manusia
{
    public string warnaKulit;
    public string warnaRambut = "Hitam";
    public string bentukHidung;


    //public Manusia(string warnaKulit, string _warnaRambut, string bentukHidung)
    //{
    //    this.warnaKulit = warnaKulit;
    //    this.warnaRambut = _warnaRambut;
    //    this.bentukHidung = bentukHidung;
    //}


    public static void bersuara()
    {
        Console.WriteLine("manusia bersuara");
    }
    public void Menampilkan()
    {
        Console.WriteLine($"manusia itu memiliki {warnaKulit}, {warnaRambut}, {bentukHidung} ");
    }
    public void Berjalan()
    {
        Console.WriteLine($"" +
            $"Manusia Berjalan memiliki rambut berwarna {warnaRambut} " +
            $" dengan warna kulit {warnaKulit} dan hidungnya {bentukHidung}");
    }

    public string Berlari()
    {
        return "Memiliki rambut berwarna" + warnaRambut;
    }

    public void Melempar( string benda)
    {
        Console.WriteLine("Manusia Melempar benda"+ benda);
    }

}

static class kalkulator

{
    public static int Tambah(int a, int b)
    {
        return a + b;
    }
}