namespace lokanta
{
    public class cesitler
    {
    public class corba : yiyecek   //inheritance
    {
        public corba(string yemekAd, int yemekFiyat) : base (yemekAd, yemekFiyat)  //constructor
        {
        }
    }
    
    public class anaYemek : yiyecek
    { 
        public anaYemek(string yemekAd, int yemekFiyat) : base(yemekAd, yemekFiyat)
        {
        }
    }
    
    public class tatli : yiyecek 
    {
        public tatli(string yemekAd, int yemekFiyat) : base(yemekAd, yemekFiyat)
        {
        }
    }
    }
}