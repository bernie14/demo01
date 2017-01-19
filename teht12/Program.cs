using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numtable;
            int num;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Gib number " + (i+1));
                string str = Console.ReadLine();
                num = int.Parse(str);
                numtable[i] = num;
            }

            for (int j = 4; j < 5; j--)
            {
                Console.WriteLine(numtable[j]);
            }
        }
    }
}
