namespace lokanta;

public class polgarson : garson
{
    public polgarson(int ID) : base(ID)  
    {
    }

    public override void bilgileriGoster()    //polimorfizm
    {
        Console.WriteLine("garson adı: " + isim +  "  soyadı: " + soyad);
    }
}