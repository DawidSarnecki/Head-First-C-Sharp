using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryVsOrderedDictionary
{
    class Implementation
    {
        private Dictionary<int, String> SomeDictionary {get; set;}

        private OrderedDictionary SomeOrderedDctionary {get; set;}

        public Implementation()
        {
            this.SomeDictionary = new Dictionary<int, string>();
            this.SomeOrderedDctionary = new OrderedDictionary();

           
            for (int i = 0; i < 100; i++)
            {
                SomeDictionary.Add(i, (i*2).ToString());
                SomeOrderedDctionary.Add(i, (i*2).ToString());
            }

            Console.WriteLine("SomeDictionary");
            foreach (var item in SomeDictionary)
            {
                Console.WriteLine($"key: {item.Key}; value: {item.Value}");
            }


            Console.WriteLine("SomeOrderedDctionary");
            foreach (DictionaryEntry item in SomeOrderedDctionary)
            {
                Console.WriteLine($"key: {item.Key}; value: {item.Value}");
            }

        }

    }
}
