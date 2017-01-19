using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            double pituus, litrat, hinta;
            Console.WriteLine("anna matkan pituus: ");
            string str = Console.ReadLine();

            pituus = double.Parse(str);
            litrat = (pituus / 100) * 7.02;
            hinta = litrat * 1.595;

            Console.WriteLine("bensaa kuluu " + litrat + " litraa, kustannus " + hinta + " euroa");
        }
    }
}