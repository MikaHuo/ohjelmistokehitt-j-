internal class Program
{
    private static void Main()
    {
        int a = 4;
        int b = 5;
        int plus, minus, kerto;
        double jako;
        plus = a + b;
        minus = a - b;
        kerto = a * b;
        jako = (double)a / b;

        Console.WriteLine(a + " ja " + b + " pluslasku on " + plus);
        Console.WriteLine(a + " ja " + b + " miinuslasku on " + minus);
        Console.WriteLine(a + " ja " + b + " kertolasku on " + kerto);
        Console.WriteLine(a + " ja " + b + " jakolasku on " + jako);
    }
}