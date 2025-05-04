// See https://aka.ms/new-console-template for more information



/* bir otobüs firmasına ait bir program tasarlanmak istenmektedir. her otobüste 2 şöför ve 2 muavin bulunmaktadır.
 müşterilerin bilgileri, güzergah bilgileri ve ücret bilgileri yapılacak uygulamada tutulmak istenmektedir.
 müşteriye isteğine göre bilet satışı yapılacaktır. nesneye yönelik programlama ilkelerine göre çözüm */





using System.Net;
using sınavanımiray;
using static System.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        miraycalısan sofor1 = new miraycalısan("mehmet", "cobanoglu");
        Console.WriteLine("şöför 1 ");
        sofor1.bilgilerigoster();
        miraycalısan muavin1 = new miraycalısan("zeynep","taşolar");
        Console.WriteLine("şöför 1 in muavini");
        muavin1.bilgilerigoster();
        
        miraycalısan sofor2 = new miraycalısan("sevval", "bakırhan");
        Console.WriteLine("şöför 2 ");
        sofor2.bilgilerigoster();
        Console.WriteLine("şöför 2 nin muavini ");
        miraycalısan muavin2 = new miraycalısan("adem","cansız");
        muavin2.bilgilerigoster();
        Console.WriteLine("******************************");
        durak:                                              
        Console.WriteLine("şöför ve muavin seçimi yapınız: (1 ya da 2)");
        int secim =Convert.ToInt32(Console.ReadLine());
        if (secim == 1)
        {
            soformuavinsecim secimler = new soformuavinsecim();
            secimler.secim1();
        }
        else if (secim == 2)
        {
            soformuavinsecim secimler = new soformuavinsecim();
            secimler.secim2();
        }else
        {
            goto durak;
        }
        
         
        
        
        Console.WriteLine("güzergah başlangıç noktasını seçin: ");
        string baslangicsecim = Console.ReadLine();
        Console.WriteLine("varış noktasında seçiniz: ");
        string varissecim = Console.ReadLine();
        miraygüzergah güzergah = new miraygüzergah(baslangicsecim, varissecim, 1200);
        Console.WriteLine("******************************");
        
        
        Console.Write("adınızı giriniz: ");
        string ad = Console.ReadLine();
        Console.Write("soyadınızı giriniz: ");
        string soyad = Console.ReadLine();
        miraymusteri musteri = new miraymusteri(ad, soyad);
        Console.Write("koltuk seçiniz (1-20) = "); 
        musteri.koltuksecim = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("******************************");

       Console.WriteLine("yolculuk özetiniz: ");
       Console.WriteLine("şöför ve muavininiz: " +secim);
       Console.Write("güzergah ve ücret bilginiz: ");
       güzergah.güzergahbilgileri();
       Console.WriteLine("bilet sahibi ve koltuk bilginiz: ");
       musteri.bilgilerigoster();
    }
    
}