namespace lokanta;

public class vipmasa : masa
{
    public override void masahazirla()    //abstract
    {
        Console.WriteLine("vip masa " +masanumarasi+ " hazırlanıyor...");
    }

    public override void siparisal()
    {
        Console.WriteLine("vip masa " +masanumarasi+ " için sipariş alınıyor...");
    }
}