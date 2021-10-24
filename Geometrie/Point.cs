using System;

namespace Geometrie
{
    public class Point
    {
        #region Champs & Accesseurs

        // Champs privée
        private int x;

        // Accesseur (ou propriété), accès à un champs privée
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        // Accesseur simplifié
        public int Y { get; set; }

        #endregion

        #region Constructeur
        /// <summary>
        /// Construit un Point
        /// </summary>
        /// <param name="abscisse">Abscisse</param>
        /// <param name="ordonnee">Ordonnée</param>
        public Point(int abscisse, int ordonnee)
        {
            X = abscisse;
            Y = ordonnee;
        }

        #endregion

        #region Méthodes

        // Constructeur
        public override string ToString()
        {
            return $"({X};{Y})";
        }
        // Comme ça ne fait qu'un return quelque fois
        // Vous le verrez comme ça 
        // public override string ToString() => $"({X};{Y})";

        public double CalculerDistance(Point autrePoint) => 
            Math.Sqrt(Math.Pow(X - autrePoint.X, 2) * Math.Pow(Y - autrePoint.Y, 2));

        #endregion
    }
}