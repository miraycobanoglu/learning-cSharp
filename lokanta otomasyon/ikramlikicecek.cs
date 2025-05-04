namespace lokanta;

public class ikramlikicecek : Iikramlik
{
    public int icecekfiyat {  get; set; }
    public void ekle()
    {
        Console.WriteLine("ikramlık icecek eklendi");
    }

    public void sil()
    {
        Console.WriteLine("ikramlık icecek eklenmedi");
    }

    public int fiyat(int fiyaticecek)
    {
        return fiyaticecek;
    }
}