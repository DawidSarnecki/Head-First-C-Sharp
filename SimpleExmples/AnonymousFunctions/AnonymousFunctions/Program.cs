///source: https://docs.microsoft.com/pl-pl/dotnet/csharp/programming-guide/statements-expressions-operators/anonymous-functions


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnonymousFunctions;

namespace AnonymousFunctions
{
    class Program
    {

        static void Main(string[] args)
        {

            Example example = new Example();

            
            // Calling delegate with few methods
            string text = "test";
            Example.ExampleDelegateWithoutArguments ExampleDelegateWithoutArguments = () => { Console.WriteLine("I'm a delegate initialized using lambda expresions but without params."); };
            Example.ExampleDelegate ExampleDelegate = (x) => x = text;
                                                      {Console.WriteLine("I'm a delegate initialized using lambda expresions but without 1 param."+text); };
                                                      {Console.WriteLine("Second method " + text); };

            Console.ReadKey();
        }
    }
}
