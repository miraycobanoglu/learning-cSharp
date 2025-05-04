namespace uygulama1
{

public class yazilimci : calisan
{
    private string diller;
   
    public yazilimci(int id, string soyad, string isim, string diller) : base(id, soyad, isim)
    {
        this.diller = diller;
    }

    public void formatAt(string isletimSistemi)
    {
        Console.WriteLine(isim + "suanda" + " " +isletimSistemi +"isletim sistemine format atiyor...");
    }
    
}
}