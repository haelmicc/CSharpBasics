using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Moq;

namespace Sample1
{
    class Foo
    {
        public void Bar(Action<int> action)
        {
            action.Invoke(4);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            var foo = new Foo();

            foo.Bar( Test );
            foo.Bar( i => { Console.WriteLine(i); });

            Console.ReadKey();
        }

        static void Test(int i)
        {
            Console.WriteLine(i);
        }
    }
}
