using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4
{
    class Auto
    {
        private int _kmStand;
        private Rad[] _raeder;

        public Auto(Rad[] raeder)
        {
            _raeder = raeder;

            foreach(var rad in _raeder)
            {
                rad.SetzeBesitzer(this);
            }
        }

        public void Fahr1Km()
        {
            // alle Raeder drehen sich bis 1 km erreicht ist, 500 mal pro km 

            for(int umdrehung = 0; umdrehung < 500; umdrehung++)
            {
                foreach(var rad in _raeder)
                {
                    rad.Dreh();
                }
            }

            _kmStand++;
        }

        public void ProblemMitRad(RadTyp typ, int umdrehungen)
        {
            Console.WriteLine("Auto: Probleme mit Rad " + typ + ": Umdrehungen=" + umdrehungen);
        }

    }
}
