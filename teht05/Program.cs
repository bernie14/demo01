using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            Console.WriteLine("anna sekuntimäärä: ");
            string str = Console.ReadLine();
            sec = int.Parse(str);
            TimeSpan t = TimeSpan.FromSeconds(sec);
            Console.WriteLine("antamasi sekunnit voidaan ilmaista muodossa: " + t.Hours + " tuntia " + t.Minutes + " minuuttia " + t.Seconds + " sekuntia ");
        }
    }
}