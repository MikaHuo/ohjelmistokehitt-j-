internal class Program
{
    private static void Main(string[] args)
    {
        double far = 78;
        double sel = (far - 32) / 1.8;
        Console.WriteLine(Math.Round(sel,2));
    }
}