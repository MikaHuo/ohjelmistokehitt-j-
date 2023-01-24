internal class Program
{
    private static void Main(string[] args)
    {
        int eka, toka;
        Console.WriteLine("Anna kaksi kokonais lukua järjestäkseen ne suuruus järjestykseen! ");
        go:
        try 
        {
            Console.WriteLine(" Anna ensimmäinen luku: ");
            eka = int.Parse(Console.ReadLine());
            Console.WriteLine(" Anna toinen luku: ");
            toka = int.Parse(Console.ReadLine());   
        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex);
            Console.WriteLine(" Anna kokonaisluku ");
            goto go;
        }
            if(eka > toka)
        {
            Console.WriteLine(" Järjestys {0}, {1}", eka, toka);
        }
            else 
        {
            Console.WriteLine(" Järjestys {0}, {1}", toka, eka);
        }
        }
}