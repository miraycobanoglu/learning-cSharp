

// uygulamaAbstract1 dekinin abstract class kullnarak yapımı


using uygulamaAbstract2;

public class Program
{
    public static void Main(string[] args)
    {
        ocak ocak = new ocak();
        Console.WriteLine("ocak gün saati: " +ocak.gunSaati());
        Console.WriteLine("ocak kaçıncı ay: " +ocak.kacinciAy());

        subat subat = new subat();
        Console.WriteLine("şubat gün saati: " +subat.gunSaati());

        mart mart = new mart();
        Console.WriteLine("mart gün saati: " +mart.gunSaati());
    }
}