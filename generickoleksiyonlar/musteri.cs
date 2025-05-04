namespace generickoleksiyonlar;

public class musteri
{
    public int id {get; set;}
    public string adi {get; set;}
    public string soyadi {get; set;}

    public musteri(int id, string adi, string soyadi)
    {
        this.id = id;
        this.adi = adi;
        this.soyadi = soyadi;
    }

    public override string ToString()
    {
        return "id: "+this.id+ " "+"isim: "+this.adi+" "+"soyadi: "+this.soyadi;
    }
}