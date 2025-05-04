using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml;

namespace lokanta
{
    public class Program
    {
        static void Main(string[] args)
        {
            int toplamFiyat = 0;
            string siparisler = " ";
            int masasecim;
            int vipmasaucret = 350;
            int ikramfiyat = 0;
            int masaucret = 50;
            
            Console.Write("masa: ");
            int masanumara = Convert.ToInt32(Console.ReadLine());
            normalmasa normalmasa = new normalmasa();  //masa classı abstract class olduğu için masa masa = new masa(); yapmadık
            normalmasa.masanumarasi = masanumara;
            vipmasa vipmasa = new vipmasa();
            vipmasa.masanumarasi= masanumara;
            
            while(true){
            Console.WriteLine("1- normal masa");
            Console.WriteLine("2- vip masa");
            masasecim = Convert.ToInt32(Console.ReadLine());
            
            if (masasecim == 1)
            {
                normalmasa.masahazirla();
                toplamFiyat += normalmasa.masaucret(50);
                break;
            }

            if (masasecim == 2)
            {
                vipmasa.masahazirla();
                toplamFiyat += vipmasaucret + vipmasa.masaucret(50);
                break;
            }
            else
            {
               Console.WriteLine("yanlış seçim yaptınız tekrar deneyiniz...");
            }

            continue;
            }
            
            
                Console.WriteLine("ilgilenen garson: ");
                string isim;
                string soyad;
                int id;
                Console.Write("isim: ");
                isim = Console.ReadLine();
                Console.Write("soyad: ");
                soyad = Console.ReadLine();
                while(true){
                Console.Write("id: ");
                id = Convert.ToInt32(Console.ReadLine());
                garson garson = new garson(2458);
                polgarson polgarson = new polgarson(2458);  //polimorfizm
                polgarson.isim = isim;
                polgarson.soyad = soyad;
                
                if (id == garson.ID && masasecim == 1)
                {
                    polgarson.bilgileriGoster();
                    normalmasa.siparisal();
                    break;
                }

                if (id == garson.ID && masasecim == 2)
                {
                    polgarson.bilgileriGoster();
                    vipmasa.siparisal();
                    break;
                }
                else
                {
                    Console.WriteLine("yanlış id tekrar deneyiniz...");
                }
                continue;
                }
                
                
            cesitler.corba domates = new cesitler.corba("domates çorbası", 130); 
            cesitler.corba mercimek = new cesitler.corba("mercimek çorbası", 140);
            cesitler.corba tavuksuyu = new cesitler.corba("tavuk suyu çorbası", 150);
          
            
            
            cesitler.anaYemek alinazik = new cesitler.anaYemek("ali nazik",450);
            cesitler.anaYemek makarna = new cesitler.anaYemek ("makarna",320);
            cesitler.anaYemek hamburger = new cesitler.anaYemek ("hamburger",250);
            
            
            cesitler.tatli sütlac = new cesitler.tatli("sütlaç",200);
            cesitler.tatli cremebrule = new cesitler.tatli("cremebrule",300);
            cesitler.tatli cheesecake = new cesitler.tatli("cheesecake",200);
            
            
            while(true)
            {
               // Console.Clear();
            Console.WriteLine("1. çorba");
            Console.WriteLine("2. ana yemek");
            Console.WriteLine("3. tatlı");
            Console.WriteLine("4- menü siparişini bitir");
           
            int secim = Convert.ToInt32(Console.ReadLine());
            
            if (secim == 1)
            {
                Console.Clear();
                string[] corbalar = { "Domates", "Mercimek", "Tavuk Suyu" };

                for (int i = 0; i < corbalar.Length; i++)
                {
                    Console.WriteLine(i+1+"-"+corbalar[i]);
                } 
                int corbasecim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(corbalar[corbasecim-1]+" Seçtiniz");
                Console.WriteLine("adedi giriniz:");
                int adet = Convert.ToInt32(Console.ReadLine());

                if (corbasecim == 1)
                {
                    toplamFiyat += domates.yemekFiyat*adet;
                    siparisler += corbalar[corbasecim-1] + " " + domates.yemekFiyat + " TL  " + "X" + adet + "\n";
                } else if (corbasecim == 2)
                {
                    toplamFiyat += mercimek.yemekFiyat*adet;
                    siparisler += corbalar[corbasecim-1] + " " + mercimek.yemekFiyat + " TL  " + "X" + adet + "\n";
                }else if (corbasecim == 3)
                {
                    toplamFiyat+= tavuksuyu.yemekFiyat*adet;
                    siparisler += corbalar[corbasecim-1] + " " + mercimek.yemekFiyat + " TL  " + "X" + adet + "\n";
                }
                else
                {
                    Console.WriteLine("yanlış seçim yaptınız tekrar deneyiniz.");
                }
                continue;
            }
            

            if (secim == 2)
            {
                Console.Clear();
                string[] anayemek = { "ali nazik", "Makarna", "hamburger" };

                for (int i = 0; i < anayemek.Length; i++)
                {
                    Console.WriteLine(i+1+"-"+anayemek[i]);
                } 
                int anayemeksecim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(anayemek[anayemeksecim-1]+" Seçtiniz");
                Console.WriteLine("Adedi giriniz:");
                int adet = Convert.ToInt32(Console.ReadLine());

                if (anayemeksecim == 1)
                {
                    toplamFiyat += alinazik.yemekFiyat*adet;
                    siparisler += anayemek[anayemeksecim-1] + " " + alinazik.yemekFiyat + " TL  " + "X" + adet + "\n";
                } else if (anayemeksecim == 2)
                {
                    toplamFiyat += makarna.yemekFiyat*adet;
                    siparisler += anayemek[anayemeksecim-1] + " " + makarna.yemekFiyat + " TL  " + "X" + adet + "\n";
                }else if (anayemeksecim == 3)
                {
                    toplamFiyat+= hamburger.yemekFiyat*adet;
                    siparisler += anayemek[anayemeksecim-1] + " " + hamburger.yemekFiyat + " TL  " + "X" + adet + "\n";
                }
                else
                {
                    Console.WriteLine("yanlış seçim yaptınız tekrar deneyiniz.");
                }
                continue;
            
            }
            if (secim == 3)
            {
                Console.Clear();
                string[] tatli= { "sutlac", "cremebrule", "cheesecake" };

                for (int i = 0; i < tatli.Length; i++)
                {
                    Console.WriteLine(i+1+"-"+tatli[i]);
                } 
                int tatlisecim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine(tatli[tatlisecim-1]+" Seçtiniz");
                Console.WriteLine("adedi giriniz:");
                int adet = Convert.ToInt32(Console.ReadLine());

                if (tatlisecim == 1)
                {
                    toplamFiyat += sütlac.yemekFiyat*adet;
                    siparisler += tatli[tatlisecim-1] + " " + sütlac.yemekFiyat + " TL  " + "X" + adet + "\n";
                } else if (tatlisecim == 2)
                {
                    toplamFiyat += cremebrule.yemekFiyat*adet;
                    siparisler += tatli[tatlisecim-1] + " " + cremebrule.yemekFiyat + " TL  " + "X" + adet + "\n";
                }else if (tatlisecim == 3)
                {
                    toplamFiyat+= cheesecake.yemekFiyat*adet;
                    siparisler += tatli[tatlisecim-1] + " " + cheesecake.yemekFiyat  + "  TL  " + "X" + adet + "\n";
                }
                else
                {
                    Console.WriteLine("Yanlış seçim yaptınız tekrar deneyiniz.");
                }
                continue;
            }

            if (secim==4)
            {
                
                break;
            }
            else
            {
                Console.WriteLine("yanlış seçim yaptınız tekrar deneyiniz.");
            }
                
            }
            
            while (true)
            {
            ikramlikmeze ikramlikmeze = new ikramlikmeze();
            ikramlikicecek ikramlikicecek = new ikramlikicecek();
            ikramlikmeze.mezefiyat = 200;
            ikramlikicecek.icecekfiyat = 100;
            Console.WriteLine("ikramlık seçimi: ");
            Console.WriteLine("1-ikramlık meze");
            Console.WriteLine("2-ikramlık içecek");
            Console.WriteLine("3-ikramlık içecek ve meze");
            Console.WriteLine("4-ikramlık yok");
            int ikramsecim = Convert.ToInt32(Console.ReadLine());
            if (ikramsecim == 1)
            {
                ikramlikmeze.ekle();
                ikramfiyat += ikramlikmeze.mezefiyat;
                toplamFiyat += ikramlikmeze.mezefiyat;
                break;
            }
            else if (ikramsecim == 2)
            {
                ikramlikicecek.ekle();
                ikramfiyat += ikramlikicecek.icecekfiyat;
                toplamFiyat += ikramlikicecek.icecekfiyat;
                break;
            }
            else if (ikramsecim == 3)
            {
                ikramlikicecek.ekle();
                ikramlikmeze.ekle();
                ikramfiyat += ikramlikmeze.mezefiyat + ikramlikicecek.icecekfiyat;
                toplamFiyat += ikramlikmeze.mezefiyat +ikramlikicecek.icecekfiyat;
                break;
            }
            else if (ikramsecim == 4)
            {
                ikramlikicecek.sil();
                ikramlikmeze.sil();
                break;
            }
            else
            {
                Console.WriteLine("yanlış seçim yaptınız tekrar deneyiniz.");
                break;
            }
            continue;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("masa adisyon: ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("masa: " + masanumara);
            Console.WriteLine("Siparişler : \n" +siparisler);
            Console.WriteLine("ikramlar : " +ikramfiyat + "TL");
            if (masasecim == 2)
            {
                Console.WriteLine("vip masa ücreti: " +vipmasaucret + "TL");
            }
            Console.WriteLine("masa hizmet bedeli: " +masaucret + "TL");
            Console.WriteLine("Toplam Sipariş Tutarı: " +toplamFiyat + "TL");
            
        }
    }
} 

