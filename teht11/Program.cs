using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("GIB LENGTH");
            string str = Console.ReadLine();
            length = int.Parse(str);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("");
                for (int j = i; j < length; j++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
