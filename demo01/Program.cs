using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask a number
            int number;
            Console.Write("Gib number: ");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out number);
            if (result == true)
            {
                // which number?
                switch (number)
                {
                    case 1: Console.WriteLine("yksi"); break;
                    case 2: Console.WriteLine("kaksi"); break;
                    case 3: Console.WriteLine("kolme"); break;
                    default: Console.WriteLine("joku muu luku"); break;
                }
            }
            else
            {
                Console.WriteLine("not an integrer value");
            }
            // wait for enter
            Console.ReadLine();
        }
    }
}