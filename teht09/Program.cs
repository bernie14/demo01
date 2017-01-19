using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            do
            {
                Console.WriteLine("Gib number: ");
                string str = Console.ReadLine();
                num = int.Parse(str);
                sum = sum + num;
            } while (num > 0);
            Console.WriteLine("The sum is " + sum + " you fagit");
        }
    }
}