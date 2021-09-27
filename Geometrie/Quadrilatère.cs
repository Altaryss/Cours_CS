using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Quadrilatère : Polygone
    {
        public bool EstUnParallelogramme { get; private set; }
        public bool EstUnLosange { get; private set; }
        public bool EstUnRectangle { get; private set; }
        public bool EstUnCarre { get; private set; }

        public Quadrilatère(Point a, Point b, Point c, Point d) :base(a,b,c,d)
        {
            var cote1 = this[0].CalculerDistance(this[0]);
            var cote2 = this[1].CalculerDistance(this[2]);
            var cote3 = this[2].CalculerDistance(this[3]);
            var cote4 = this[0].CalculerDistance(this[3]);
            var diagonale1 = this[0].CalculerDistance(this[2]);
            var diagonale2 = this[1].CalculerDistance(this[3]);

            EstUnParallelogramme = cote1 == cote3 && cote2 == cote4;
            EstUnLosange = cote1 == cote2 && cote2 == cote3 && cote3 == cote4;
            EstUnRectangle = EstUnParallelogramme && diagonale1 == diagonale2;
            EstUnCarre = EstUnLosange && EstUnRectangle;
        }
    }
}
