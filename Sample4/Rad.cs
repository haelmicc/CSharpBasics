using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4
{
    class Rad
    {
        private const int mtbfValue = 500000;

        private int _umdrehungen;
        private Auto _owner;
        private readonly RadTyp _typ;

        private Random _random;

        public Rad(RadTyp typ)
        {
            _typ = typ;
        }

        public void SetzeBesitzer(Auto owner)
        {
            _owner = owner;
            _random = new Random(Guid.NewGuid().GetHashCode());
        }

        public void Dreh()
        {
            _umdrehungen++;

            var random = _random.Next(0, mtbfValue);

            if(random == mtbfValue / 2)
            {
                // Console.WriteLine("Rad " + _typ + ": Problem nach " + _umdrehungen + " Umdrehungen" );

                // Das Auto bzw. meinen Besitzer informieren

                _owner.ProblemMitRad(_typ, _umdrehungen);
            }
        }
    }
}
