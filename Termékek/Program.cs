using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termékek
{
    class Program
    {
        static void Main(string[] args)
        {
            Termek termek = new Termek(
                "aaabbb-001",
                "Monitor",
                50000,
                27,
                true,
                10);

            Console.WriteLine("A termék neve: {0}",termek.Megnevezes);

            Console.WriteLine("Termék nettó ára: {0}",termek.Netto());
            Console.WriteLine("Termék bruttó ára: {0}",termek.Brutto());
            termek.Akcios_e = false;
            if(termek.Akcios_e)
                Console.WriteLine("Termék kedvezményes ára: {0}",termek.Kedvezmeny());
            else
                Console.WriteLine("A termék nem kedvezményes!");

            Console.ReadKey();
        }
    }
}
