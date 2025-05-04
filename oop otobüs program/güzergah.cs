namespace sınavanımiray;

public class miraygüzergah
{
    public string baslangic { get; set; }

    private int ucret;

    public int Ucret
    {
        get{return ucret;}
        set { ucret = value; }
    }
    
    public string varis { get; set; }

    public miraygüzergah(string baslangic, string varis, int ucret)
    {
        this.baslangic = baslangic;
        this.varis = varis;
        this.ucret = ucret;
    }

    public void güzergahbilgileri()
    {
        Console.WriteLine("başlangıç: " + baslangic + "  varış: " + varis + "  ücret: " + Ucret);
    }
}