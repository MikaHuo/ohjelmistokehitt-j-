internal class Program
{
    private static void Main(string[] args)
    {
        string sana;
        Console.WriteLine("Etsi lauseesta pisin sana: ");
        Console.Write(" Anna lause: ");
        sana = Console.ReadLine();
        string[] osa = sana.Split(' ');
        string pisin = osa[0];
        for (int i = 1; i < osa.Length; i++) 
        { 
            if (osa[i].Length > pisin.Length) 
            {
                pisin = osa[i];
            }
        }
        Console.WriteLine(" Lause jonka annoit oli {0}, Ja pisin sana oli {1}" , sana, pisin);
       
    }
}