
using System.Data;

namespace Pankki;


    public class Pankkitili
    {
        private readonly string m_asiakkaanNimi;
        private double m_saldo;

        public Pankkitili() { }

        public Pankkitili(string nimi, double summa)
        {
            m_asiakkaanNimi = nimi;
            m_saldo = summa;
        }
        public double Saldo { get { return m_saldo; } }
        public string Nimi { get { return m_asiakkaanNimi; } }

        public void Otto(double summa)
        {
            if (summa > m_saldo || summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo -= summa;
        }
        public void Pano(double summa)
        {
            if (summa < 0)
            {
                throw new ArgumentOutOfRangeException("summa");
            }
            m_saldo += summa;
        }
        private static void Main(string[] args)
        {
            Pankkitili pt = new Pankkitili(" Mika Huotari", 2540.21);
           pt.Pano(300);
            pt.Otto(64.50);
            Console.WriteLine("nykyinen saldo {0} euroa", pt.Saldo);
        }
    }
