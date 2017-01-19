using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool leapyear;
            Console.WriteLine("Gib me number you faget: ");
            string str = Console.ReadLine();
            year = int.Parse(str);

            if(year % 4 == 0 && year % 400 == 0)
            {
                Console.WriteLine("That's a fucking leap year you dipshit, how the fuck do you even need a fucking program to check it???");
            }
            else
            {
                Console.WriteLine("Not a leap year, git gud pls");
            }
        }
    }
}