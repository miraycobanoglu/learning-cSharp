// See https://aka.ms/new-console-template for more information

using static System.Console;

public class Program
{
    public static void Main(string[] args)
    {
        altsinif altsinif = new altsinif();  //temel sınıfı yapamayız çünkü o abstract
        altsinif.metot2();
        altsinif.metot1();
    }
}