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
            int points;
            Console.Write("how many points did you have?: ");
            string line = Console.ReadLine();
            bool result = int.TryParse(line, out points);
            if (result == true)
            {
                // which number?
                switch (points)
                {
                    case 0:
                    case 1: Console.WriteLine("your grade is 0"); break;
                    case 2:
                    case 3: Console.WriteLine("your grade is 1"); break;
                    case 4:
                    case 5: Console.WriteLine("your grade is 2"); break;
                    case 6:
                    case 7: Console.WriteLine("your grade is 3"); break;
                    case 8:
                    case 9: Console.WriteLine("your grade is 4"); break;
                    case 10:
                    case 11:
                    case 12: Console.WriteLine("your grade is 5"); break;
                    default: Console.WriteLine("that's not a valid amount of points"); break;
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