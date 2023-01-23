internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine( "Kello luuppi");
        for (int h = 0; h < 24; h++)
        {
            for (int m = 0; m < 60; m++)
            {
                for (int s = 0; s < 60; s++) 
                {
                    Console.WriteLine("{0}:{1}:{2}", h, m, s);
                }
            }
        }
    }
}