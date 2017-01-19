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
            Console.WriteLine("Give me your desired number of lines of fucking stars");
            string str = Console.ReadLine();
            length = int.Parse(str);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("\n\nWhy would you want to print stars? Most worthless program I've ever seen.");
        }
    }
}