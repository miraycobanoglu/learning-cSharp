namespace lokanta;

public class garson
{
    private int id;       //encapsulation
    public string soyad;
    public string isim;

    public garson(int ID)  //constructor
    {
        id = ID;
    }

    
    public int ID        //encapsulation
    {
        get { return id; }
        set { id = value; }
    }

    public virtual void bilgileriGoster()  //polimorfizm polgarson classında
    {
        Console.WriteLine("isim:" + isim +  "  soyad:" + soyad + "  id:" + id);
        
    }
}
    