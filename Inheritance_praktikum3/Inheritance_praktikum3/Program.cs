using Inheritance_praktikum3;

class App
{
    public static void Main()
    {
        Danu danu = new Danu("Lurus", "hitam", "sawo matang", 170);
        danu.Berbicara();
        // child class juga bisa memanggil method parent classnya
        //danu.Deskripsi();
        PersegiPanjang persegiPanjang = new PersegiPanjang();
        persegiPanjang.panjang = 30;
        persegiPanjang.lebar = 5;
        persegiPanjang.HitungLuas();
        Console.WriteLine($"Nilai panjang = {persegiPanjang.CekPanjang()} cm");
    }
}

//class BangunDatar
//{
//    public int panjang;
//    public int lebar;
//}

class PersegiPanjang : BangunDatar
{
    public void HitungLuas()
    {
        Console.WriteLine($"Luas persegi panjang = {panjang * lebar} cm2");
    }

    public int CekPanjang()
    {
        return panjang;
    }
}


class Manusia
{
    public string warnaRambut;
    public string warnaKulit;
    public int tinggiBadan;

    public Manusia(string warnaRambut, string warnaKulit, int tinggiBadan)
    {
        this.warnaRambut = warnaRambut;
        this.warnaKulit = warnaKulit;
        this.tinggiBadan = tinggiBadan;
    }

    public void Deskripsi()
    {
        Console.WriteLine($"Saat ini saya memiliki tinggi badan {tinggiBadan}");
    }
}

class Danu : Manusia
{
    public string bentukRambut;

    public Danu(string bentukRambut, string warnaRambut, string warnaKulit, int tinggiBadan) : base(warnaRambut, warnaKulit, tinggiBadan)
    {
        this.bentukRambut = bentukRambut;
    }

    public void Berbicara()
    {
        // memanggil method parent class
        base.Deskripsi();
        Console.WriteLine($"Saya adalah Danu, saya memiliki bentuk rambut {bentukRambut}, saya memiliki warna rambut {warnaRambut}");
    }
}
