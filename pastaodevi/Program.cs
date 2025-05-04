using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasta
{
    internal class Program
    {
        class pasta
        {
            public pasta()
            {
                mesaj = "Teşekkürler";
            }

            public string cesit { get; set; }
            public string malzeme { get; set; }
            private int fiyat;
            public int Fiyat{
                get { return fiyat; }
                set{
                    if (value < 100)
                        fiyat = 100;
                    else
                        fiyat = value;
                } 
            }
            private int kat;
            public int Kat {
                get { return kat; }
                set{
                    kat = value;
                    fiyat = kat * 100;
                } 
            }
            public string renk { get; set; }
            public string mesaj { get; set; }
        }
        class musteri
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            
        }
        static void Main(string[] args)
        {
            pasta pasta = new pasta();
            pasta.renk = "cilekli";
            pasta.cesit = "antep fıstıklı";
            pasta.malzeme = "kakaolu";
            pasta.Fiyat = 100;
            pasta.Kat = 2;
            Console.WriteLine("Renk= " + pasta.renk + " " + "Çeşit= " + pasta.cesit + " " + "Malzeme= " + pasta.malzeme + " " + "Kat= " + pasta.Kat +" "+ "Fiyat= " + pasta.Fiyat);
            Console.WriteLine(pasta.mesaj);
           
            
            musteri bir = new musteri();
            bir.Ad = "miray";
            bir.Soyad = "çobanoğlu";
            
            Console.WriteLine(bir.Ad+" "+bir.Soyad+" ");
        }
    }
}