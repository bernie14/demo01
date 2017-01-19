using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a number
            int num1, num2, num3;
            Console.Write("give 3 numbers: ");
            string line1 = Console.ReadLine();
            num1 = int.Parse(line1);
            string line2 = Console.ReadLine();
            num2 = int.Parse(line2);
            string line3 = Console.ReadLine();
            num3 = int.Parse(line3);

            int summa = num1 + num2 + num3;
            double keskiarvo = summa / 3;

            Console.WriteLine("summa on " + summa);
            Console.WriteLine("keskiarvo on " + keskiarvo);

            // wait for enter
            Console.ReadLine();
        }
    }
}