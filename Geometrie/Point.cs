using System;

namespace Geometrie
{
    /// <summary>
    /// Représente un point dans un repère à 2 dimensions
    /// </summary>
    public class Point
    {
        #region champs et accesseurs
        //champ
        private int x;

        //Accesseur (ou propriété)
        /// <summary>
        /// Abscisse du point
        /// </summary>
        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        //accesseur simplifié
        /// <summary>
        /// Ordonnée du point
        /// </summary>
        public int Y { get; private set; }

        #endregion

        #region constructeur

        /// <summary>
        /// Construit un point
        /// </summary>
        /// <param name="abscisse">Abscisse du point (X)</param>
        /// <param name="ordonnee">Ordonnée du point (Y)</param>
        public Point(int abscisse, int ordonnee)
        {
            X = abscisse;
            Y = ordonnee;
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Retourne une représentation sous forme de <see cref="string"/> du <see cref="Point"/>
        /// </summary>
        /// <returns>la chaine de caractères</returns>
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        //comme ça ne fait qu'un return quelque fois
        //vous le verrez comme ça
        //public override string ToString() => $"({X};{Y})";

        /// <summary>
        /// Calcule la distance du <see cref="Point"/> courant (this) par rapport à un autre <see cref="Point"/>
        /// </summary>
        /// <param name="autrePoint">Autre <see cref="Point"/></param>
        /// <returns>la distance entre les 2 <see cref="Point"/></returns>
        public double CalculerDistance(Point autrePoint)
        {
            if (autrePoint == null)
                throw new ArgumentException("L'autre point ne peut pas être null","autrePoint");

            return Math.Sqrt(Math.Pow(X - autrePoint.X, 2) + Math.Pow(Y - autrePoint.Y, 2));
        }
        #endregion
    }
}
