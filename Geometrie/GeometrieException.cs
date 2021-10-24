using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class GeometrieException : Exception
    {
        public TypesDeForme Type { get; private set; }

        public GeometrieException(string message, TypesDeForme unType)
            :base(message)
        {
            Type = unType;
        }
    }

    public enum TypesDeForme
    {
        Cercle, Triangle, Polygone, Quadrilatere
    }
}
