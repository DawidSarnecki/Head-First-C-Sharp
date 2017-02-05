using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGeneric_Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck {Kind = KindOfDuck.Decoy, Size = 15},
                new Duck {Kind = KindOfDuck.Garganey, Size = 16},
                new Duck {Kind = KindOfDuck.Mallard, Size = 17},
                new Duck {Kind = KindOfDuck.Muscovy, Size = 19},
                new Duck {Kind = KindOfDuck.Strange, Size = 15}
            };

            ducks.Sort();
            PrintDocks(ducks);

            DuckComparerBySize bySize = new DuckComparerBySize();
            ducks.Sort(bySize);
            PrintDocks(ducks);

            DuckComparerByKind byKind = new DuckComparerByKind();
            ducks.Sort(byKind);
            PrintDocks(ducks);

            // console ReadKey
            Console.ReadKey();
          
        }

        public static void PrintDocks(List<Duck> dukcs)
        {
            foreach (Duck duck in dukcs)
                Console.WriteLine(duck.Size.ToString() + " cm, " + duck.Kind.ToString());
            Console.WriteLine("The end of dukcs");
        }
    }
}
