// See https://aka.ms/new-console-template for more information

using interface1;
using static System.Console;

public class Program
{
    public static void Main(string[] args)
    {
        musteriController musteriController = new musteriController();
        musteriController.musteriEkle(new sqlServer());
        musteriController.musteriEkle(new mySql());
    }
}