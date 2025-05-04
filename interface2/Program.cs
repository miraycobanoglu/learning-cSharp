//soru: Etçil ve otçul hayvanlar tanımlatılacak. Kalıtım komutu kullanılcak.
 
//İnterface Komutu:
 
//İnterface de istenildiği kadar tanımlama yazılabilir, fakat kod blokları oluşturulamaz.
//Kodlar class komutu içerisinde yazılır. İnterface de kalıtım yapılamaz.
  
public interface IArabaSur
    {
        void Calistir();
        void Sur();
        void Parket();
        //void VitesDegistir(int vites);
        int vitesdeğis(int vites);
        void Durdur();
    }
    public class Araba : IArabaSur
    {
        public void Calistir()
        {
            Console.WriteLine("Araba Çalıştırıldı.. Haydi Bismillah ");
        }
        public void Sur()
        {
            Console.WriteLine("Fazla Hız Yapmadan Sürmeye Devam");
        }
        public void Parket()
        {
            Console.WriteLine("Park Etme İşlemi Yapılıyor Dikkat Edin");
        }

        public void vitesdeğis(int vites)
        {
            Console.WriteLine(vites.ToString() + " . vitese geçildi hızını ona göre ayarla ");
        }

        public void Durdur()
        {
            Console.WriteLine("Okula geldik : ) hadi geçmiş olsun....");
        }

        public void Vitesdeğis(int i)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void main (string[] args)
        {
            Araba ford = new Araba();
            ford.Calistir();
            ford.Vitesdeğis(2);
            ford.Sur();
            ford.Parket();
            ford.Durdur();
            Console.ReadKey();
        }
    }

 
//Soru: İki adet araç tanımlatılacak, araçlara ait özellikler interface komutu içine yazılacak.
//Araçların özellikleri ekrana yazdırılacak.
 
 public interface IAracOzellikleri
    {
        string Marka { get; }
        string Model { get; }
        int Hız { get; set; }
        double Fiyat { get; set; }
        int Gosterge(int deger);
        // interface içinde yazacağımız method'lar içinde kod yazamayız 
        // kod kısmını bu interface 'i kenisine uygulamış (implementa) sınıf içerisinde yazmalıyız
        void Bilgiler();
    }
    public interface IAracPuan
    {
        double AracPuani(double puan);
    }
    public class Mercedes : IAracOzellikleri
    {
        private string marka = "Mercedes";
        private string model = "A Serisi";
        private int hiz;
        private double fiyat;
        public string Marka
        {
            // Mercedes sınıfında marka değişemeyeceği için set tanımlamadık
            // sadece model ve marka sını okuyabiliyoruz
            get { return marka; }
        }
        public string Model
        {
            get { return model; }
        }
        public int Hız
        {
            // Mercedes sınıfımızın hız özelliğini atayabiliriz
            get { return hiz; }
            set { hiz = value; }
        }
        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public int Gosterge(int deger)
        {
            return (deger);
        }
        public void Bilgiler()
        {
            Console.WriteLine("Marka : " + Marka);
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("Fiyat : " + Fiyat);
            Console.WriteLine("Hız : " + Hız);
            Console.WriteLine("Gösterge : " + Gosterge(340));
        }
    }
    // Bir sınıf birden çok interface i uygulayabilir
    public class Bmw : IAracOzellikleri, IAracPuan
    {
        // Bmw sınıfı oldugu için marka ve model 
        // değişkenlerimizi statik tanımladık
        private string marka = "Bmw";
        private string model = "X5";
        private int hiz;
        private double fiyat;
        public double AracPuani(double puan)
        {
            // gerekli işlmeler interface içerisinde değil 
            // tanımladığımız sınıf içerisinde yapılmalıdır
            return puan * 3.6;
        }
        public string Marka
        {
            get
            {
                return marka;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
        }
        public int Hız
        {
            get
            {
                return hiz;
            }
            set
            {
                hiz = value;
            }
        }
        public double Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                fiyat = value;
            }
        }
        public int Gosterge(int deger)
        {
            return deger;
        }
        public void Bilgiler()
        {
            Console.WriteLine("Marka : " + Marka);
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("Fiyat : " + Fiyat);
            Console.WriteLine("Hız : " + Hız);
            Console.WriteLine("Gösterge : " + Gosterge(300));
            Console.WriteLine("Puan : " + AracPuani(2000));
        }
        class Program
        {
            static void Main(string[] args)
            {
                Mercedes mcd = new Mercedes();
                mcd.Fiyat = 2000;
                mcd.Hız = 280;
                mcd.Bilgiler();
                Console.WriteLine("");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("");
                Bmw bmw = new Bmw();
                bmw.Fiyat = 2500;
                bmw.Hız = 290;
                bmw.Bilgiler();
                Console.ReadLine();
            }
        }
    }
