
using Klasser;

class Program
{
    static void Main(string[] args)
    {
        Namn Mame = new Namn();

        Console.Write("Ange Ditt För och Efternamn: ");
        Mame.Förnamn = (Console.ReadLine());

        Console.WriteLine("Ditt Namn är: " + Mame.Förnamn);
        Console.ReadKey();

        Ålder Age = new Ålder();

        Console.Write("Ange dagen du är född (i siffror): ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Ange Månaden du är Född (i siffror): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Ange Året du är Född (i siffror): ");
        int year = int.Parse(Console.ReadLine());


        DateTime födelsedatum = new DateTime(year, month, day);

        DateTime idag = DateTime.Today;
        int ålder = idag.Year - födelsedatum.Year;



        Console.WriteLine("Ditt Födelsedatum är: " + födelsedatum);
        Console.WriteLine("Du är " + ålder + "År Gammal");
        Console.WriteLine("Du är Myndig: ");

        Console.ReadLine();



    }

}