internal class Program
{
    private static void Main(string[] args)
    {
        int luku;
        Console.WriteLine("Selvitä onko luku parillinen vai pariton");
        paluu:
        try
        {
            luku = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)        
        {
            Console.WriteLine(ex);
            Console.WriteLine(" Antamasi luku ei ollut kokonais luku! Tarkasta syöte! ");
           goto paluu;
        }
        switch (luku % 2) 
        {
            case 0: Console.WriteLine(" Antamasi luku on PARILLINEN");
                break;
            case 1: Console.WriteLine(" Antamsi luku on PARITON");
                break;
        }
             
    }
}