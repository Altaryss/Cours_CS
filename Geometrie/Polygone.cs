using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public abstract class Polygone : iForme, IEnumerable<Point>
    {
        private List<Point> lesPoints;

        // Indexeur, permet d'accèder aux points en lecture sans modification ni suppression
        public Point this[int index]
        {
            get { return lesPoints[index]; }
            private set { lesPoints[index] = value; }
        }

        // Pour aller avec et permettre de faire un for
        public int Count
        {
            get { return lesPoints.Count; }
        }

        public Polygone(Point a, Point b, Point c, params Point[] autresPoints)
        {
            lesPoints = new List<Point>();
            lesPoints.Add(a);
            lesPoints.Add(b);
            lesPoints.Add(c);
            lesPoints.AddRange(autresPoints);
        }

        public double CalculerPerimetre()
        {
            double res = 0;
            // Du premier point à l'avant dernier
            for (int i = 0; i < Count - 1; i++)
            {
                // ajout de la longueur du coté
                res += this[i].CalculerDistance(this[i + 1]);
            }
            // Je ferme le polygone
            res += this[0].CalculerDistance(this[Count - 1]);

            return res;
        }

        public double CalculerAire()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pour pouvoir faire un foreach sur le polygone
        /// imposé par l'implémentation de l'interface 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<Point> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                // yield attends avant de renvoyer contrairement au return qui envoie tout d'un coup
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
