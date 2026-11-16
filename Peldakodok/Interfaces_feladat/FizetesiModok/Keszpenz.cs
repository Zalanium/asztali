using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat.FizetesiModok
{
    //implementálja a IFizetésiRendszer interfészt
    internal class Keszpenz : IFizetesiRendszer
    {
        public int Egyenleg { get; set; }

        public bool Fizetes(int osszeg)
        {
            if (Egyenleg >= osszeg)
            {
                Egyenleg -= osszeg;
                Console.WriteLine("Sikeres készpénzes fizetés");
                return true;
            }
            else
            {
                Console.WriteLine("Sikertelen készpénzes fizetés");
                return false;
            }
        }
    }
}
