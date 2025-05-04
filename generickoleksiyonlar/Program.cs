// See https://aka.ms/new-console-template for more information

using generickoleksiyonlar;

internal class Program
{
    public static void Main(string[] args)
    {
        List<musteri> musteriler = new List<musteri>();
        musteriler.Add(new musteri(1,"enes","bayram"));
        musteriler.Add(new musteri(2,"miray","coban"));

        foreach (musteri m in musteriler)
        {
            Console.WriteLine(m);
        }
    }
}

