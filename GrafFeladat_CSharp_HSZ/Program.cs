using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp_HSZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var graf = new Graf(6);

            graf.Hozzaad(0, 1);
            graf.Hozzaad(1, 2);
            graf.Hozzaad(0, 2);
            graf.Hozzaad(2, 3);
            graf.Hozzaad(3, 4);
            graf.Hozzaad(4, 5);
            graf.Hozzaad(2, 4);

            Console.WriteLine(graf);
            graf.SzelessegiBejar(1);
            Console.WriteLine("-");
            graf.MelysegiBejar(6);
            Console.WriteLine(graf.Osszefuggo());
            Dictionary<int, int> szinezes = graf.MohoSzinezes();
            foreach (var item in szinezes)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.ReadLine();
        }
    }
}
