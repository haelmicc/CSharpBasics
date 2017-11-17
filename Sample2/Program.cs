using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();

            for(int i = 0; i < 10; i++)
            {
                var copy = i;
                Action action = () =>
                {
                    Console.WriteLine(copy);
                };

                actions.Add(action);
            }

            foreach(var action in actions)
            {
                action();
            }

            Console.ReadKey();
        }
    }
}
