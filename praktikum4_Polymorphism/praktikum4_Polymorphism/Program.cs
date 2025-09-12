
////// Overloading
////class Matematika
////{
////    public int Penjumlahan(int angka1, int angka2)
////    {
////        return angka1 + angka2;
////    }

////    public double Penjumlahan(double angka1000, double angka2, double angka3)
////    {
////        return angka1000 + angka2 + angka3;
////    }
////}


//////using praktikum4_Polymorphism;

////class Polymorphism
////{
////    public static void Main()
////    {
////        //Console.WriteLine(Matematika.Penjumlahan(4, 8));
////        //Console.WriteLine(Matematika.Penjumlahan(15.4, 95.6, 47.3));

////        // tanpa static (harus membuat obyek)
////        // static => melekat pada class
////        Matematika opt = new Matematika();

////        //Console.WriteLine(opt.Penjumlahan(4, 12));
////        //Console.WriteLine(opt.Penjumlahan(4.5, 12.6, 35.4));

////        Hewan kucing1 = new Kucing();
////        kucing1.jumlahKaki = 4;
////        kucing1.Bersuara();

////        //Hewan hewan = new Hewan();
////        //hewan.Bersuara();

////        //Sapi sapi = new Sapi();
////        //sapi.Bersuara();

////    }
////}

////// Overriding

////class Hewan
////{
////    public int jumlahKaki;
////    public virtual void Bersuara()
////    {
////        Console.WriteLine("Hewan Bersuara");
////    }
////}

////class Kucing : Hewan
////{
////    public override void Bersuara()
////    {
////        Console.WriteLine($"Meow meow meow, jumlah kakiku {jumlahKaki}");
////    }
////}

//////class Sapi : Hewan
//////{
//////    public void Bersuara()
//////    {
//////        Console.WriteLine("Sapi Bersuara");
//////    }
//////}
/////
////class Matematika
////{
////    public static int Tambah(int a, int b)
////    {
////        return a + b;
////    }
////    public static double Tambah(double a, double b, double c)
////    {
////        return a + b + c;
////    }
////    public static string Tambah(string a, string b, string c, string d)
////    { 
////        return a + b + c + d; 
////    }
////}
////class Polymorphism
////{
////    public static void Main()
////    {
////        //Console.WriteLine($"Method 1 = {Matematika.Tambah(2, 3)}");
////        //Console.WriteLine($"Method 2 = {Matematika.Tambah(2.1, 3.2, 4.4)}");
////        //Console.WriteLine($"Method 3 = {Matematika.Tambah("Namaku"," ", "Adya",":)")}");

////        List<string> list = ["Adya", "Danu", "Djonathan"];
////        //Console.WriteLine(list);
////        foreach (string nama in list)
////        {
////            Console.WriteLine(nama);
////        }
////    }
////}


//class Kendaraan
//{
//    public virtual void info()
//    {
//        Console.WriteLine( "Kendaraan bisa ditumpangi");
//    }
//}

//class Mobil : Kendaraan
//{
//    public override void info()
//    {
//        Console.WriteLine(" Mobil : ini adalah kendaraan Mobil");
//    }
//}

//class Motor : Kendaraan
//{
//    public override void info()
//    {
//        Console.WriteLine(" Motor : ini adalah kendaraan Motor");

//    }
//}

//class program
//{
//    public static void Main()
//    {
//        //List<Kendaraan> daftarkendaraan = new List<Kendaraan>();
//        //daftarkendaraan.Add(new Mobil());
//        //daftarkendaraan.Add(new Motor());
//        //foreach (Kendaraan k in daftarkendaraan)
//        //{
//        //    k.info();

//        //}
//        Random random = new Random();
//        var data = random.Next(1000, 1100);
//        Console.WriteLine(data);
//    }
//}

////        List<string> list = ["Adya", "Danu", "Djonathan"];
////        //Console.WriteLine(list);
////        foreach (string nama in list)
///
class Hewan
{
    public virtual void Bersuara()
    {
        Console.WriteLine("Hewan Bersuara");
    }
    public virtual void Bersuara(string s)
    {
        Console.WriteLine($" hewan bernama {s}");
    }
    public virtual void Bersuara(int x)
    {
        Console.WriteLine($"hewan berkaki {x}");
    }
}

class Anjing : Hewan
{
    public override void Bersuara()
    {
        Console.WriteLine("Guk guk");
    }
    public override void Bersuara(string s)
    {
        Console.WriteLine($"guk guk hewan bernama {s}");
    }
    public override void Bersuara(int x)
    {
        Console.WriteLine($"guk guk hewan berkaki {x}");
    }
}

class Kucing : Hewan
{
    public override void Bersuara()
    {
        Console.WriteLine("Meong");
    }
    public override void Bersuara(string s)
    {
        Console.WriteLine($"meong, hewan bernama {s}");
    }
    public override void Bersuara(int x)
    {
        Console.WriteLine($"meong hewan berkaki {x}");
    }
}

class program
{
    static void Main()
    {
        Anjing anjing = new Anjing();
        anjing.Bersuara();
        anjing.Bersuara("esa");
        anjing.Bersuara(4);

        Kucing kucing = new Kucing();
        kucing.Bersuara();
        kucing.Bersuara("reza");
        kucing.Bersuara(4);
    }
}