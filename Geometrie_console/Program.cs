using System;
using System.Collections.Generic;
using Geometrie;

namespace Geometrie_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var p1 = new Point(0, 0);
                var p2 = new Point(0, 2);
                var p3 = new Point(2, 2);
                var p4 = new Point(2, 0);

                var i = 2;
                var j = 9 / i;

                p1.CalculerDistance(p2);

                var tri = new Triangle(p1, p2, p3);
                var qua = new Quadrilatere(p1, p2, p3, p4);
                var cer = new Cercle(p1, 1);

                var listeDeFormes = new List<IForme>() { tri };
                foreach (var item in listeDeFormes)
                {
                    Console.WriteLine($"Périmètre: {item.CalculerPerimetre()}");
                    Console.WriteLine($"Aire: {item.CalculerAire()}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Une division par 0 s'est produite : {ex.Message}");
            }
            catch (GeometrieException ex)
            {
                Console.WriteLine($"Une erreur de géométrie s'est produite : {ex.Message}");
                Console.WriteLine($"Sur un objet de type : {ex.Type}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur inconnue s'est produite : {ex.Message}");
            }

            

            Console.ReadKey();
        }
    }
}
