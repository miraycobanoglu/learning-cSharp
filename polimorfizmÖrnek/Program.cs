// See https://aka.ms/new-console-template for more information

namespace polimorfizmÖrnek
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("şekil uygulaması");
            
            
            
            Console.WriteLine("isim giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("kısa kenarı giriniz:");
            int kisakenar = int.Parse(Console.ReadLine());
            Console.WriteLine("uzun kenarı giriniz:");
            int uzunkenar = int.Parse(Console.ReadLine());
            
            dikdörtgen dikdörtgen = new dikdörtgen("isim", kisakenar, uzunkenar);
    
            dikdörtgen.sekilBilgileri();
            dikdörtgen.sekilHesapla();
            
            şekil şekil = new şekil(isim);
            şekil.sekilBilgileri();
            şekil.sekilHesapla();
        }
    }
}