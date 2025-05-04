using System.Runtime.CompilerServices;

namespace uygulama1
{

public class yönetici : calisan
{
    public int sorumluKisiSayisi { get; set; }
    
    public yönetici(int id, string soyad, string isim) : base(id, soyad, isim)
    {
    }

    public void zamYap(int zamMiktari)
    {
        Console.WriteLine(isim + " " +zamMiktari + "tl calisanlara zam yapiyor...");
    }
  }
}