using Interfaces_feladat.FizetesiModok;

namespace Interfaces_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANKKÁRTYÁS VÁSÁRLÁS");

            Bankkartya bankkartya = new Bankkartya();
            bankkartya.Egyenleg = 1000;

            Vasarlas vasarlas1 = new Vasarlas(bankkartya);
            vasarlas1.Vegosszeg = 2000;
            vasarlas1.Fizetes();


            Console.WriteLine();
            Console.WriteLine("KÉSZPÉNZES VÁSÁRLÁS");

            Keszpenz keszpenz = new Keszpenz();
            keszpenz.Egyenleg = 1000;

            Vasarlas vasarlas2 = new Vasarlas(keszpenz);
            vasarlas2.Vegosszeg = 500;
            vasarlas2.Fizetes();


            Console.WriteLine();
            Console.WriteLine("REVOLUTOS VÁSÁRLÁS");

            Revolut revolut = new Revolut();
            revolut.Egyenleg = 1000;

            Vasarlas vasarlas3 = new Vasarlas(revolut);
            vasarlas3.Vegosszeg = 3000;
            vasarlas3.Fizetes();
        }
    }
}
