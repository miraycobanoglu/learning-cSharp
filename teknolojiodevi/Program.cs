using System;

namespace Teknoloji
{
    class urun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public void UrunGoster()
        {
            Console.WriteLine( "Ürün:" +Ad +"Fiyat:" +Fiyat);
        }
    }

    class Telefon : urun
    {
        public string Marka { get; set; } 
        public void MarkaGoster()
        {
            Console.WriteLine("Marka:" +Marka);
        }
    }

    class Dizustu : urun
    {
        public string Islemci { get; set; }

        public void IslemciGoster()
        {
            Console.WriteLine("İşlemci:" +Islemci);
        }
    }

    class Program
    {
        static void Main()
        {
            Telefon telefon = new Telefon {Fiyat = 100, Marka = "x" };
            Dizustu dizustu = new Dizustu { Ad = "Oyun Laptopu", Fiyat = 1000, Islemci = "i9" };
            telefon.Ad="akıllı telefon";
            telefon.UrunGoster();
            telefon.MarkaGoster();
            dizustu.UrunGoster();
            dizustu.IslemciGoster();
        }
    }
}