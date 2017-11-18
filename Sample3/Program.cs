using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample3
{
    class Program
    {
        static Int64 Counter;

        static void Main(string[] args)
        {
            var t = new Thread(Go);
            t.Start();

            while(true)
            {
                //var copy = Counter;
                var copy = Interlocked.Read(ref Counter);

                if(copy != 0 &&
                   copy != Int64.MaxValue)
                {
                    Console.WriteLine("{0:X}", copy);
                }
            }
        
            Console.ReadKey();
        }

        private static void Go()
        {
            while(true)
            {
                //Counter = 0;
                //Counter = Int64.MaxValue;

                var replaced = Interlocked.CompareExchange(ref Counter, 0, Int64.MaxValue);

                replaced = Interlocked.CompareExchange(ref Counter, Int64.MaxValue, 0);

            }
        }
    }
}
