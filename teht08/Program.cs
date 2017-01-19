using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("PUT THE 3 NUMBERS IN THE BAG");
            string str1 = Console.ReadLine();
            num1 = int.Parse(str1);
            string str2 = Console.ReadLine();
            num2 = int.Parse(str2);
            string str3 = Console.ReadLine();
            num3 = int.Parse(str3);

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("THE BIGGEST NUMBER IS " + num1);
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("THE BIGGEST NUMBER IS " + num2);
            }

            else if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine("THE BIGGEST NUMBER IS " + num3);
            }

            
        }
    }
}