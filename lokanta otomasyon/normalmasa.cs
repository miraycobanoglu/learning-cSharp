namespace lokanta;

public class normalmasa : masa  
{
    public override void masahazirla()   //abstract
    {
        Console.WriteLine("normal masa " + masanumarasi + " hazırlanıyor...");
    }

    public override void siparisal()
    {
        Console.WriteLine("normal masa " + masanumarasi + " için sipariş alınıyor...");
    }
}