

//abstract classların interface'e göre kullanımı bu örnekte daha mantıklı olacaktır


using uygulamaAbstract1;

public class Program
{
    public static void Main(string[] args)
    {
        ocak ocak = new ocak();
        Console.WriteLine(ocak.gunSaati());
        
        subat subat = new subat();
        Console.WriteLine(subat.gunSaati());
        
        mart mart = new mart();
        Console.WriteLine(mart.gunSaati());

    }
}


//bu kötü bi yöntem on iki kez saati yazdırırız 
//uygulamaAbstract2 de abstract ile yapıcaz daha iyi bir yöntem