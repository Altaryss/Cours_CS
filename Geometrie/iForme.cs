using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    /// <summary>
    /// Définit une forme
    /// Permet d'imposer l'implémentation de ces deux méthodes à toutes les classes qui implémentent cette interface
    /// </summary>
    public interface IForme
    {
        public double CalculerPerimetre();
        public double CalculerAire();

    }
}
