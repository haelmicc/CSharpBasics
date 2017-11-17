using System;
using System.Linq;

namespace Sample1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // var ints = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.ToList();

            var items = new[] { "A", "B", "C", "D", "E", "F", "G", "H" }.ToList();

            var result = items.Select(i => new { Item = i, Index = items.IndexOf(i) })
                             .GroupBy(dummy => dummy.Index / 3, dummy => dummy.Item);

            foreach(var group in result)
            {
                foreach(var item in group)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey(); 
        }
    }
}
