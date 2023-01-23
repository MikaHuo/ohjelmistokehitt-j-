using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        yles:
        int eka, toka;
        try
        {
            Console.WriteLine(" Anna Kokonailuku joka laske yhteen: ");
            eka = int.Parse(Console.ReadLine());
            Console.WriteLine(" Anna toinen kokonaisluku: ");
            toka = int.Parse(Console.ReadLine());
            Console.WriteLine(" Tulos on: " + (eka + toka));
            
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex);
            Console.WriteLine(" Tarkasta antamasi luku. Luku pitää olla kokonaisluku ");
            goto yles;
        }
        
    }
}