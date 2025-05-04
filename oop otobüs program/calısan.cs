namespace sınavanımiray;

public class miraycalısan
{

    public string ad{get;set;}
    public string soyad{get;set;}

    public miraycalısan(string ad,string soyad)
    {
        this.ad = ad;
        this.soyad = soyad;
    }

    public virtual void bilgilerigoster()
    {
        Console.WriteLine("Ad :" +ad);
        Console.WriteLine("Soyad :" +soyad);
    }
}
