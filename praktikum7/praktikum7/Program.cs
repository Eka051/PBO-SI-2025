// Abstrac




abstract class Hantu
{
    public string nama {  get; set; }

    public abstract void Menakuti();

    public abstract void Menghilang();

    public void info()
    {
        Console.WriteLine($"nama hantu {nama}");
    }
}


class kuntilanak : Hantu
{
    public override void Menakuti()
    {
        Console.WriteLine($"{nama} sedang menakuti seseorang");
    }

    public override void Menghilang()
    {
        Console.WriteLine($"{nama} sedang menghilang");
    }
}


abstract class produk
{
    public abstract void TambahProduk();
    
    public abstract void HapusProduk();
}

class marketplace : produk
{
    public override void TambahProduk()
    {
        Console.WriteLine("produk di tambahkan di database");
    }

    public override void HapusProduk()
    {
        Console.WriteLine("produk di hapus dari database");
    }
}


// Interface

public interface IHubungan
{
    void Setia();
    void MenerimaApaAdanya();
    void AkuGakMauKaloGaSamaKamu();
}

public interface ISifat
{
    void ActOfService();
    void SoftSpoken();
}

public class Adya : IHubungan, ISifat
{
    public void ActOfService()
    {
        Console.WriteLine("Adya akan selalu perhatian");
    }

    public void SoftSpoken()
    {
        Console.WriteLine("Adya selalu soft spoken");
    }

    public void Setia()
    {
        Console.WriteLine("Aku beneran setia sama kamu");
    }

    public void MenerimaApaAdanya()
    {
        Console.WriteLine("Aku menerima kamu apa adanya");
    }

    public void AkuGakMauKaloGaSamaKamu()
    {
        Console.WriteLine("Aku ga bisa hidup tanpa kamu");
    }
}

class Danu : IHubungan
{
    public void Setia()
    {
        Console.WriteLine("Aku lebih memilih dia daripada kamu");
    }

    public void MenerimaApaAdanya()
    {
        Console.WriteLine("Aku menerima kamu kalo ada apanya");
    }

    public void AkuGakMauKaloGaSamaKamu()
    {
        Console.WriteLine("Dia lebih menarik daripada kamu");
    }
}


class Program
{
    static void Main(string[] args)
    {
        //kuntilanak kuntilanak1 = new kuntilanak { nama = "kuntilanak jinak" };
        //kuntilanak1.Menakuti();
        //kuntilanak1.info();

        IHubungan adya = new Adya(); // Janji ke hubungannya
        adya.Setia();

        ISifat adyaSifat = new Adya(); // Menepati janji ke interface sifatnya
        adyaSifat.SoftSpoken();
        

        //Adya adya1 = new Adya();  // Janji ke diri sendiri
        //adya1.Setia();

        //IHubungan danu = new Danu(); // Janji di awal saja, tapi isinya tidak sesuai ekspetasi
        //danu.Setia();
    }
}


