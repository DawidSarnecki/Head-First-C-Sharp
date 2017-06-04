using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctions
{
    class Example
    {
        public Example() {

            this.FistWayOfDelegateSyntax("FistWayOfDelegateSyntax: I'm delegate initialized with a named method.");
            this.SecondWayOfDelegateSytntax("SecondWayOfDelegateSytntax: I'm delegate initialized with inline code, called an anonymous method");
            this.ThirdwAyOfDElegateSyntax("ThirdwAyOfDElegateSyntax: I'm delegate initialized with a lambda expression.");
            this.exampleWithoutParams();
        }


        public delegate void ExampleDelegate(string textValue);

        static void ShowText(string text)
        {
            Console.WriteLine(text);
        }


        // 1. way:
        //Original syntax required initialization with a named method.
        ExampleDelegate FistWayOfDelegateSyntax = new ExampleDelegate(ShowText);

        //2. way
        // C# 2.0: initialization with inline code, called an "anonymous method." This
        // method takes a specific as an input parameter (in our example is string).
        ExampleDelegate SecondWayOfDelegateSytntax = delegate (string anyText) { Console.WriteLine(anyText); };


        //3. way
        // C# 3.0. A delegate can be initialized with a lambda expression. 
        //The lambda also takes a string
        // as an input parameter (x). The type of x is inferred by the compiler.
        ExampleDelegate ThirdwAyOfDElegateSyntax = (x) => { Console.WriteLine(x); };

        public delegate void ExampleDelegateWithoutArguments();
        ExampleDelegateWithoutArguments exampleWithoutParams = () => { Console.WriteLine("I'm a delegate initialized using lambda expresions but without params."); };


    }
}
