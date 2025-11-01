//asosiasi (HANYA TEMAN)

class program
{
    static void Main(string[] args)
    {

        zaki zaki = new zaki { nama = "zaki" };
        zaki.menikah();
        //aku zaki = new aku {nama = "zaki"};
        //zaki.pasangan();


        //doi kumala = new doi { nama = "kumala"};
        //Console.WriteLine(kumala.nama);
        //dia febyan = new dia { nama = "febyan" };
        //zaki.pasangan(kumala);
        //febyan.Namadoi = kumala;
        //febyan.info();

    }
}

class aku
{
    public string nama { get; set; }
    // cuman teman
    public void pasangan()
    {
        //Console.WriteLine($"nama saya {nama} dan nama doi saya {namadoi.nama}");
        Console.WriteLine("Saya jomblo karena dia udah confess");
    }
}


class latifatul
{
    public string nama { get; set; }
}

// komposisi
class zaki
{
    public string nama { get; set; }
    // kepemilikan
    public latifatul Namadoi = new latifatul { nama = "latifatul" };

    //public void info()
    //{
    //    Console.WriteLine($"saya {nama} punya pacar namanya {Namadoi.nama}");
    //}

    public void menikah()
    {
        Console.WriteLine($"saya {nama} menikah dengan {Namadoi.nama}");
    }


}