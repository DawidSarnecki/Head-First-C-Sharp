using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideMethods_JewelerStory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START");

            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);

            Console.WriteLine("FINISH");
            Console.ReadKey();
        }
    }
}
