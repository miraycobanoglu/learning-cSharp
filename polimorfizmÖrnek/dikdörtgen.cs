namespace polimorfizmÖrnek{

public class dikdörtgen : şekil
{
    public int kisakenar { get; set; }
    public int uzunkenar { get; set; }
    public dikdörtgen(string ISIM,int kisakenar, int uzunkenar) : base(ISIM)
    {
        this.kisakenar = kisakenar;
        this.uzunkenar = uzunkenar;
    }

    public override void sekilHesapla()
    {
        //base.sekilHesapla();
        Console.WriteLine(isim + "nin alanı" + (kisakenar*uzunkenar));
    }

    public override void sekilBilgileri()
    {
        Console.WriteLine(isim + "nin kısa kenar bilgileri:" + kisakenar);
        Console.WriteLine(isim + "nin uzun kenar bilgileri:" + uzunkenar);
    }
    
    


}
}