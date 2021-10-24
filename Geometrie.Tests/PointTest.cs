using System;
using Xunit;

namespace Geometrie.Tests
{
    /// <summary>
    /// Classe de test de la classe <see cref="Point"/>
    /// </summary>
    public class PointTest
    {
        /// <summary>
        /// Valide le construtceur de <see cref="Point"/>
        /// </summary>
        [Fact]
        public void Point_ValiderConstructeur()
        {
            var abs = 3;
            var ord = 4;

            var p = new Point(abs, ord);

            Assert.NotNull(p);
            Assert.IsType<Point>(p);
            Assert.Equal(abs, p.X);
            Assert.Equal(ord, p.Y);
        }
    }
}
