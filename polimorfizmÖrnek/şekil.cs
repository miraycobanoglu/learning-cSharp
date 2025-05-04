namespace polimorfizmÖrnek{

public class şekil
{
    public string isim { get; set; }

    public şekil(string ISIM)
    {
        isim = ISIM;
    }

    public virtual void sekilHesapla()
    {
        Console.WriteLine("şeklin alanı hesaplanıyor...");
    }

    public virtual void sekilBilgileri()
    {
        Console.WriteLine(isim + "nin bilgileri");
    }
}
}