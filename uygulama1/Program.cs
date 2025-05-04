using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama1
{
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("calisan uygulamasina hosgeldiniz...");
        Console.WriteLine("1-yazilimci islemleri");
        Console.WriteLine("2-yönetici islemleri");
        Console.WriteLine("3-cikis icin q'ya basin");
        
        string islem= Console.ReadLine();

        switch (islem)
        {
            case "1":
                yazilimci yazilimci = new yazilimci(1, "cobanoglu", "miray", "c#,c++,c");
                Console.WriteLine("yazilimci islemi seciniz:");
                Console.WriteLine("1-format at");
                Console.WriteLine("2-yazilimcinin bilgilerini gosteriniz... ");
                Console.WriteLine("3-cikis icin q'ya basin");
                
                string islem2 = Console.ReadLine();

                if (islem2 == "1")
                {
                    Console.WriteLine("isletim sistemi giriniz:");
                    string isletimSistemi = Console.ReadLine();
                    yazilimci.formatAt(isletimSistemi);
                }else if (islem2 == "2")
                {
                    yazilimci.bilgileriGoster();
                }
                else if(islem2=="q")
                {
                    Console.WriteLine("yazilimci islemlerinden cikis yapiliyor...");
                    break;
                }

                break;
            
            case "2":
                yönetici yönetici = new yönetici(2, "cobanoglu", "ayse");
                Console.WriteLine("yönetici islemi seciniz:");
                Console.WriteLine("1-sorumlu kişi sayısı");
                Console.WriteLine("2-yönetici bilgilerini gosteriniz... ");
                Console.WriteLine("3-zam miktarını gösteriniz");
                string islem3 = Console.ReadLine();
                if (islem3 == "1")
                {
                    yönetici.sorumluKisiSayisi = 11;
                }else if (islem3 == "2")
                {
                    yönetici.bilgileriGoster();
                }else if(islem3=="3")
                {
                    yönetici.zamYap(5000);
                }else if (islem3 == "q")
                {
                  Console.WriteLine("yazilimci islemlerinden cikis yapiliyor...");  
                  break;
                }
                break;


            case "3":
                if (islem == "q")
                {
                    Console.WriteLine("programdan cikiliyor...");
                    break;
                }

                break;
        }
    }
}
}