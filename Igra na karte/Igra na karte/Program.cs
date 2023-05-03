using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra_na_karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi igrače karte (Vrijednosti 1 do 13)!");
            int karta, zbroj=0;
            do
            { 
                karta = Convert.ToInt32(Console.ReadLine());
                zbroj = zbroj + karta;
            } while (zbroj != 31 || zbroj > 31);
            if (zbroj == 31)
            {
                Console.WriteLine("Pobijedili ste");
            }
            else
            {
                Console.WriteLine("izgubili ste!");
            }
        }
    }
}
