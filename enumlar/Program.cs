// See https://aka.ms/new-console-template for more information

using enumlar;

internal class Program
{
    public static void Main(string[] args)
    {
        Musteri musteri = new Musteri(1, "enes", "bayram", "erkek", "enes.bayram@gmail.com");
        MusteriDurum donendurum = musteri.musteriEkle(musteri);

        if (donendurum == MusteriDurum.kayitBasarili)
        {
            Console.WriteLine("kayıt başarılı");
        }
    }
   
    
}