// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

namespace polymorphsim
{
    class program
    {
        static void Main(string[] args)
        {
           hayvan hayvan = new hayvan();
           hayvan.isim = "aaa";
           hayvan.konus();
           
           kedi kedi = new kedi();
           kedi.isim = "minnoş";
           kedi.konus();
           

           hayvan köpek = new köpek(); //böyle de yazılabilir
           köpek.isim = "karabaş";
           köpek.konus();
           
        }
    }
}

