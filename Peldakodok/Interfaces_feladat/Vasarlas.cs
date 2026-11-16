using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_feladat
{
    internal class Vasarlas
    {
        public IFizetesiRendszer FizetesiRendszer { get; set; }

        public int Vegosszeg { get; set; }

        public Vasarlas(IFizetesiRendszer fizetesiRendszer)
        {
            FizetesiRendszer = fizetesiRendszer;
        }

        public void Fizetes()
        {
            if (FizetesiRendszer.Fizetes(Vegosszeg) == false)
            {
                if (FizetesiRendszer.Fizetes(Vegosszeg / 2))
                {
                    Console.WriteLine("Leárazásban vásárolt");
                }
                else
                {
                    Console.WriteLine("Sajnos megint sikertelen volt a vásárlás");
                }
            }
        }
    }
}
