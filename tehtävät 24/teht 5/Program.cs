internal class Program
{
    private static void Main(string[] args)
    {
        int luku;
        Double merkki;
        string sana, teksti;
        alkupalu:
        Console.WriteLine(" Anna luku kirjain(d/i/s) tai sana: ");
        teksti= Console.ReadLine();
        if( teksti == "d" || teksti == "i" || teksti == "s" || teksti == "D" || teksti == "I" || teksti == "S")
        {
            switch( teksti ) 
            {
                case"s":
                case "S":
                    Console.Write("Syötä kirjain: ");
                    sana = Console.ReadLine();
                    sana += "*";
                    Console.WriteLine("Uusi merkkijono on: " + sana);
                break;
                case "d":
                case "D":
                dalku:
                    Console.Write(" Syötä double luku: ");
                    try
                    {
                        merkki = double.Parse(Console.ReadLine());
                        Console.WriteLine("Annoit luvun " + merkki + " ja tulos on " + (merkki + 1));
                    }
                        catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(" Anna d luku: ");
                        goto dalku;
                    }
                        break;
                case "i":
                case "I":
                ialku:
                    Console.Write(" Anna kokonaisluku: ");
                    try
                    {
                        luku = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Annoin luvun " + luku + " ja tulos on " + (luku + 1));
                    }       
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(" Ole hyvä ja anna kokonaisluku! ");
                        goto ialku;
                    }
                    break;
                    default:
                    Console.WriteLine("Tarkasta antamasi tiedot, jossakin on virhe!");
                    break;
            }
        }         
                    else
        { 
                    Console.WriteLine(" Anna vain kirjain: (d/i/s): ");
                    goto alkupalu;
    }
}