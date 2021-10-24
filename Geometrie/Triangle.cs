using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Triangle : Polygone
    {
        public bool EstIsocele { get; private set; }
        public bool EstEquilateral { get; private set; }

        public Triangle(Point a, Point b, Point c) :base(a,b,c)
        {
            var cote1 = this[0].CalculerDistance(this[1]);
            var cote2 = this[1].CalculerDistance(this[2]);
            var cote3 = this[2].CalculerDistance(this[2]);

            EstIsocele = cote1 == cote2 || cote2 == cote3 || cote1 == cote3;
            EstEquilateral = cote1 == cote2 && cote2 == cote3;
        }

        public override double CalculerAire()
        {
            var a = this[0].CalculerDistance(this[1]);
            var b = this[1].CalculerDistance(this[2]);
            var c = this[2].CalculerDistance(this[3]);
            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
