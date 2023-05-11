

namespace UcakBiletRezervasyonu

// Uçak sınıfı tanımı
{

}

public class Ucak
{
    public string Model { get; set; }
    public string Marka { get; set; }
    public string SeriNo { get; set; }
    public int KoltukKapasitesi { get; set; }
}

// Lokasyon sınıfı tanımı
public class Lokasyon
{
    public string Ulke { get; set; }
    public string Sehir { get; set; }
    public string Havaalani { get; set; }
    public bool AktifPasif { get; set; }
}

// Rezervasyon sınıfı tanımı //
public class Rezervasyon
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime Tarih { get; set; }
    public TimeSpan Saat { get; set; }
    public int KoltukNo { get; set; }
}

// Program sınıfı tanımı //
class Program
{
    static void Main(string[] args)
    {
        // Uçak ve Lokasyon nesneleri oluşturma //
        Ucak ucak = new Ucak();
        ucak.Model = "Boeing 111";
        ucak.Marka = "Rain Airlines";
        ucak.SeriNo = "LN58797";
        ucak.KoltukKapasitesi = 178;

        Lokasyon lokasyon = new Lokasyon();
        lokasyon.Ulke = "Norvec";
        lokasyon.Sehir = "Oslo";
        lokasyon.Havaalani = "Oslo Gardermoen Havalimanı";
        lokasyon.AktifPasif = true;

        // Rezervasyon nesnesi oluşturma //
        Rezervasyon rezervasyon = new Rezervasyon();
        rezervasyon.Ad = "Yagmur";
        rezervasyon.Soyad = "Yılmaz";
        rezervasyon.Tarih = new DateTime(2024, 4, 11);
        rezervasyon.Saat = new TimeSpan(06, 30, 0);
        rezervasyon.KoltukNo = 16;

        // Uçak, Lokasyon ve Rezervasyon özellikleri //
        Console.WriteLine("Uçak Model: " + ucak.Model);
        Console.WriteLine("Uçak Marka: " + ucak.Marka);
        Console.WriteLine("Uçak Seri No: " + ucak.SeriNo);
        Console.WriteLine("Uçak Koltuk Kapasitesi: " + ucak.KoltukKapasitesi);

        Console.WriteLine("Lokasyon Ülke: " + lokasyon.Ulke);
        Console.WriteLine("Lokasyon Şehir: " + lokasyon.Sehir);
        Console.WriteLine("Lokasyon Havaalanı: " + lokasyon.Havaalani);
        Console.WriteLine("Lokasyon Aktif/Pasif Durumu: " + (lokasyon.AktifPasif ? "Aktif" : "Pasif"));

        Console.WriteLine("Rezervasyon Adı: " + rezervasyon.Ad);
        Console.WriteLine("Rezervasyon Soyadı: " + rezervasyon.Soyad);
        Console.WriteLine("Rezervasyon Tarihi: " + rezervasyon.Tarih.ToShortDateString());
        Console.WriteLine("Rezervasyon Saati: " + rezervasyon.Saat.ToString());
        Console.WriteLine("Rezervasyon Koltuk No: " + rezervasyon.KoltukNo);

        Console.ReadKey();
    }
}



