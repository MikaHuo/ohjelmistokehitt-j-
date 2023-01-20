internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" Anna luku joka kertoa 1-10 ");
        int kerto;
        paluu:
        try
        {
            kerto = Int32.Parse(Console.ReadLine());
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(" Anna kokonais luku! ");
            goto paluu;
        }
        for (int i = 1; i < 11; i++) 
           
            Console.WriteLine(" Kerto lasku kymmeneen: " + i * kerto);
    }
}