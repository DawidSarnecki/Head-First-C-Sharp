using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ReplacingTheRightMethodByDelegate
{
    class Program
    {
        private static string HelloDelegate(int numberToPrint)
        {
            return $" Hello, your number is: {numberToPrint}.";
            
        }

        private static string HelloDelegateWithString(string numberToPrint)
        {
            return $" Hello, your number is: {numberToPrint}.";

        }
        static void Main(string[] args)
        {

            /// The two correct ways for make instance of delegate
            ConvertToString methodUsingDelegate1 = new ConvertToString(HelloDelegate);
            ConvertToString methodUsingDelegate = HelloDelegate;

            /// There is a mistake becouse the methed HelloDelegateWithString has a wrong signature (expected is string, actual is int)
            //ConvertToString methodUsingDelegate1 = new ConvertToString(HelloDelegateWithString);

            ConvertToInt methodUsingDelegateSecond = new ConvertToInt(HelloDelegateWithString);
            Console.WriteLine(methodUsingDelegate(152));
            Console.WriteLine(methodUsingDelegate1(152));
            Console.WriteLine(methodUsingDelegateSecond("sto"));

            Console.ReadKey();

        }
    }
}
