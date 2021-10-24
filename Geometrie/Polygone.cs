using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    /// <summary>
    /// Représente un point dans un repère à 2 dimensions
    /// </summary>
    public abstract class Polygone : IForme, IEnumerable<Point>
    {
        /// <summary>
        /// Pour stocker les <see cref="Point"/>s en interne
        /// </summary>
        private List<Point> lesPoints;


        //indexeur
        /// <summary>
        /// Retourne le <see cref="Point"/> à l'index donné
        /// </summary>
        /// <param name="index">index du <see cref="Point"/> voulu</param>
        /// <returns>un <see cref="Point"/></returns>
        public Point this[int index]
        {
            get { return lesPoints[index]; }
            private set { lesPoints[index] = value; }
        }

        //pour aller avec et permettre de faire un for
        /// <summary>
        /// Retourne le nombre de points du polygone
        /// Utile pour faire un for avec l'indexeur !
        /// </summary>
        public int Count
        {
            get { return lesPoints.Count; }
        }

        /// <summary>
        /// Constructeur de Polygone
        /// 3 <see cref="Point"/>s minimum obligatoires
        /// </summary>
        /// <param name="a">1er <see cref="Point"/></param>
        /// <param name="b">2eme <see cref="Point"/></param>
        /// <param name="c">3eme <see cref="Point"/></param>
        /// <param name="autresPoints">D'autres <see cref="Point"/>s éventuels</param>
        public Polygone(Point a, Point b, Point c
                            , params Point[] autresPoints)
        {
            lesPoints = new List<Point>();
            lesPoints.Add(a);
            lesPoints.Add(b);
            lesPoints.Add(c);
            lesPoints.AddRange(autresPoints);
        }

        /// <summary>
        /// Calcul du périmètre du polygone
        /// </summary>
        /// <returns>le périmètre</returns>
        public virtual double CalculerPerimetre()
        {
            //Pour stocker le résultat à retourner
            double res = 0;

            //du premier point à l'avant dernier
            for (int i = 0; i < Count - 1; i++)
            {
                //j'ajoute la longueur de ce côté
                res += this[i].CalculerDistance(this[i + 1]);
            }
            //je ferme le polygone (côté du 1er point au dernier)
            res += this[0].CalculerDistance(this[Count - 1]);

            //Et voilà :)
            return res;
        }

        public abstract double CalculerAire();

        /// <summary>
        /// Pour pouvoir faire un foreach sur le polygone
        /// imposé par l'implémentation de l'interface <see cref="IEnumerable{Point}"/>
        /// </summary>
        /// <returns>Une énumération de <see cref="Point"/>s</returns>
        public IEnumerator<Point> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this[i];
            }
        }
        /// <summary>
        /// Vielle syntaxe imposée par l'interface <see cref="IEnumerable{Point}"/>
        /// On retourne simplement la méthode <see cref="GetEnumerator"/> développée au dessus
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public override string ToString() => $"[{string.Join(";", this)}]";
    }
}
