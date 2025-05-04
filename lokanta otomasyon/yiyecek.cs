
namespace lokanta
{
    public class yiyecek
    {
        public string yemekAd {  get; set; } 
        public int yemekFiyat {  get; set; }

        public yiyecek(string yemekAd, int yemekFiyat)
        {
            this.yemekAd = yemekAd;
            this.yemekFiyat = yemekFiyat;
        }

       
    }
}
