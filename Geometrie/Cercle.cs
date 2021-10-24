using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    /// <summary>
    /// Représente un <see cref="Cercle"/> dans un repère à 2 dimensions
    /// </summary>
    public class Cercle : IForme
    {
        /// <summary>
        /// Centre du <see cref="Cercle"/>
        /// </summary>
        public Point Centre { get; set; }
        /// <summary>
        /// Rayon du <see cref="Cercle"/>
        /// </summary>
        public double Rayon { get; set; }

        /// <summary>
        /// Constructeur de <see cref="Cercle"/>
        /// </summary>
        /// <param name="centre"><see cref="Point"/> au centre du <see cref="Cercle"/></param>
        /// <param name="rayon">Rayon du <see cref="Cercle"/></param>
        public Cercle(Point centre, double rayon)
        {
            if (rayon <= 0)
                throw new GeometrieException("Le rayon doit être strictement positif"
                    , TypesDeForme.Cercle);
            
            Centre = centre;
            Rayon = rayon;
        }

        /// <summary>
        /// Méthode imposée par l'implémentation de l'interface <see cref="IForme"/>
        /// Calcule le périmètre du <see cref="Cercle"/>
        /// </summary>
        /// <returns>le périmètre</returns>
        public double CalculerPerimetre()
        {
            return 2 * Rayon * Math.PI;
        }

        /// <summary>
        /// Méthode imposée par l'implémentation de l'interface <see cref="IForme"/>
        /// Calcule l'aire du <see cref="Cercle"/>
        /// </summary>
        /// <returns>l'aire</returns>
        public double CalculerAire()
        {
            return Rayon * Rayon * Math.PI;
        }
    }
}
