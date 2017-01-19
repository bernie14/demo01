using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("anna ikasi: ");
            string ika = Console.ReadLine();
            num = int.Parse(ika);

            if (num < 18)
            {
                Console.WriteLine("olet alaikäinen");
            }

            if (num > 18 && num < 65)
            {
                Console.WriteLine("olet aikuinen");
            }

            if (num > 65)
            {
                Console.WriteLine("olet seniori");
            }
        }
    }
}