class Encapsulation
{
    public static void Main()
    {
        List <Produk> hehe = new List<Produk>();
        hehe.Add(new Produk("Air", 5.20, 10));
        hehe.Add(new Produk("Snack", 10.20, 20));

        foreach(Produk item in hehe)
        {
            item.TampilkanInfo();
        }


        //Mahasiswa mahasiswa = new Mahasiswa();
        //mahasiswa.IPK = null; 
        //Console.WriteLine(mahasiswa.GetIPK());


        //Console.WriteLine(mahasiswa.Nama = "Ariski Ade");
        //mahasiswa.SetNama("Ariski");
        //mahasiswa.SetIPK(3.98);
        //mahasiswa.InputIPK();

    }
}

class Produk
{
    private string _nama;
    double _harga;
    int _stok;

    public Produk(string nama, double harga, int stok)
    {
        _nama = nama;
        _harga = harga;
        _stok = stok;
    }

    public string nama
    {
        get { return _nama; }
    }
    public double harga
    {
        get { return _harga; }
        set
        {
            if ( value < 0 )
            {
                _harga = 0;
            }else
            {
                _harga = value;
            }
        }
    }
    public int stok
    {
        get { return _stok; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Nilai tidak boleh 0");
            }
            else
            {
                _stok = value;
            }
        }
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama produk = {_nama}");
        Console.WriteLine($"Harga produk = {_harga}");
        Console.WriteLine($"Stok produk = {_stok}");
    }



}

class Mahasiswa
{
    private string _nama; // field
    private string? _nim; // ? => bisa null (nullable)
    private double? _ipk;

    public string Nama // Property / Accessor => alat untuk mengakses field/atribut (kunci)
    {
        get { return _nama; }
        set { _nama = value; }
    }

    public double? IPK // Property IPK untuk mengubah nilai IPK
    {
        set { _ipk = UpdateIPK(value); }
    }

    private double? UpdateIPK(double? ipk)
    {
        if (ipk < 0 || ipk > 4.0)
        {
            throw new ArgumentException("Nilai IPK Invalid. Silahkan isi dengan benar!");
        }
        return _ipk = ipk;
    }

    public void SetNama(string nama)
    {
        _nama = nama;
        Console.WriteLine($"Nama mahasiswa: {_nama}");
    }
    public void SetIPK(double ipk)
    {
        if ( ipk >= 0 && ipk <= 4.0)
        {
            _ipk = ipk;
            //_ipk = null; // set value ke null
        } else
        {
            Console.WriteLine("Masukkan nilai IPK yang valid");
        }
    }
    public string GetIPK()
    {
        return $"IPK Mahasiswa {_ipk}";
    }

    public void InputIPK()
    {
        Console.Write("Masukkan IPK: "); // teks sejajar
        string IPK  = Console.ReadLine();
        SetIPK(double.Parse(IPK)); // Casting ke double (tipe data field)
    }
}