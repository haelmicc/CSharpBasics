using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4
{
    class Program
    {
        private static readonly int Distance = 1000;

        static void Main(string[] args)
        {
            var raeder = new Rad[4];
            raeder[0] = new Rad(RadTyp.HL);
            raeder[1] = new Rad(RadTyp.HR);
            raeder[2] = new Rad(RadTyp.VL);
            raeder[3] = new Rad(RadTyp.VR);

            var auto = new Auto(raeder);

            for (int km = 0; km < Distance; km++)
            {
                auto.Fahr1Km();
            }

            Console.ReadKey();
        }
    }
}
