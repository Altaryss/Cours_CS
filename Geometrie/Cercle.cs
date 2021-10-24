using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Cercle : iForme
    {
        public Point Centre { get; set; }
        public double Rayon { get; set; }

        public Cercle(Point centre, double rayon)
        {
            if (rayon <= 0)
                throw new GeometrieException("Le rayon doit être strictement positif", TypesDeForme.Cercle);

            Centre = centre;
            Rayon = rayon;
        }

        public double CalculerPerimetre()
        {
            return 2 * Rayon * Math.PI;
        }

        public double CalculerAire()
        {
            return Rayon * Rayon * Math.PI;
        }
    }
}
