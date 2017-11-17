using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class Bar
    {
        ~Bar()
        {
            Console.WriteLine("dtor ~Bar()");
        }
    }

    public class Foo
    {
        private Bar _bar;
        public Bar Bar
        {
            get { return this._bar; }
        }


        public Foo(Bar bar)
        {
            this._bar = bar;
        }

        ~Foo()
        {
            Console.WriteLine("dtor ~Foo()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var bar = new Bar();
            var foo = new Foo(bar);

            var bar2 = foo.Bar;

            bar = null;
            foo = null;
            GC.Collect();

            Console.ReadKey();

        }
    }
}
