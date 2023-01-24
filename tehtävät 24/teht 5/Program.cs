internal class Program
{
    private static void Main(string[] args)
    {
        int luku;
        Double merkki;
        string sana, teksti;
        1paluu:
        Console.WriteLine(" Anna luku kirjain(d/i/s) tai sana: ");
        teksti= Console.ReadLine();
        if( teksti == "d" || teksti == "i" || teksti == "s" || teksti == "D" || teksti == "I" || teksti == "S")
        {
            switch( teksti ) 
            {
                case"i":
                case "I":
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

            }
        }
    }
}