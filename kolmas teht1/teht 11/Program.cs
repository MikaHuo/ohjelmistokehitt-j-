internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hei vaan anna ikäsi: ");
        int ika = int.Parse(Console.ReadLine);
         if (ika < 15)
        { 
            Console.Write(" Herttinen että sinulla on vielä matkaa ikä ihmisiin ");
        }
         else if (ika < 30)
        { 
            Console.Write(" Mentävä se on metsään kasvamaan ");
        }
         else
        { 
            Console.Write(" Haudan partaalla");
        }
    }