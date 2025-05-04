namespace sınavanımiray;

public class miraymusteri: miraycalısan
{
    public int koltuksecim;

    public miraymusteri(string ad, string soyad) : base(ad, soyad)
    {
    }


    public override void bilgilerigoster()
    {
        Console.WriteLine("ad: " +ad + "  Soyad: " +soyad + "  koltuk: " +koltuksecim);
    }
}