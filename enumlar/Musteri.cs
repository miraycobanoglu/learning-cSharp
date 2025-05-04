using System.Collections;

namespace enumlar;

public class Musteri
{
    public int id { get; set; }
    public string adi { get; set; }
    public string soyad { get; set; }
    public string cinsiyet { get; set; }
    public string email { get; set; }

    public Musteri(int id, string adi, string soyad, string cinsiyet, string email)
    {
        this.id = id;
        this.adi = adi;
        this.soyad = soyad;
        this.cinsiyet = cinsiyet;
        this.email = email;
    }

    public static ArrayList musteriler = new ArrayList();

    public MusteriDurum musteriEkle(Musteri M1)
    {
        musteriler.Add(M1);
        return MusteriDurum.kayitBasarili;
    }
}