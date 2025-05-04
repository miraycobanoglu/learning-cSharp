using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulodevi
{
    public class kisi
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int yas { get; set; }
        public string cinsiyet { get; set; }
        public int maas { get; set; }

      
    }
    
        public class ogretmen : kisi
        {
            public string brans { get; set; }
            public void bilgiGoster()
            {
                Console.WriteLine("ogretmen adı :" + ad);
                Console.WriteLine("ogretmen soyadı:" + soyad);
                Console.WriteLine("ogretmen cinsiyet:" + cinsiyet);
                Console.WriteLine("ogretmen yasi :" + yas);
                Console.WriteLine("ogretmen maasi :" + maas);
                Console.WriteLine("ogretmen bransı :" + brans);

            }

        }
        
        public class personel : kisi
        {
            public string isi { get; set; }
            public void bilgiGoster()
            {
                Console.WriteLine("personel adı :" + ad);
                Console.WriteLine("personel soyadı:" + soyad);
                Console.WriteLine("personel cinsiyet:" + cinsiyet);
                Console.WriteLine("personel yasi :" + yas);
                Console.WriteLine("personel maasi :" + maas);
                Console.WriteLine("personel alani:" +isi);

            }

        }
    
        public class ogrenci : kisi
        {
            public string bolum { get; set; }
            public void bilgiGoster()
            {
                Console.WriteLine("personel adı :" + ad);
                Console.WriteLine("personel soyadı:" + soyad);
                Console.WriteLine("personel cinsiyet:" + cinsiyet);
                Console.WriteLine("personel yasi :" + yas);
                Console.WriteLine("personel maasi :" + maas);
                Console.WriteLine("personel alani:" +bolum);

            }

        }

        
    internal class Program
    {
        static void Main()
        {
            ogretmen ogretmen = new ogretmen();


            ogretmen.ad = "ugur";
            ogretmen.soyad = "akbulut";
            ogretmen.cinsiyet = "erkek";
            ogretmen.brans = "bilgisayar";
            ogretmen.yas = 35;
            ogretmen.maas = 75000;
            

            personel personel = new personel();

            personel.ad = "ayşe";
            personel.soyad = "yıldız";
            personel.cinsiyet = "kadın";
            personel.isi = "araştırma görevlisi";
            personel.yas = 25;
            personel.maas = 55000;
            

            ogrenci ogrenci = new ogrenci();
            
            ogrenci.ad = "miray";
            ogrenci.soyad = "cobanoglu";
            ogrenci.cinsiyet = "kiz";
            ogrenci.bolum = "muhendslik";
            ogrenci.yas = 21;
            ogrenci.maas = 60000;
            

            

            ogretmen.bilgiGoster();
            Console.WriteLine("  ");
            personel.bilgiGoster();
            Console.WriteLine("  ");
            ogrenci.bilgiGoster();
            Console.WriteLine("  ");

            
        }
    }
}