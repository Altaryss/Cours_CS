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
                var p1 = new Point(3, 4);
                var p2 = new Point(4, 0);
                var p3 = new Point(6, 5);
                var p4 = new Point(7, 8);

                var tri = new Triangle(p1, p2, p3);
                var qua = new Quadrilatère(p1, p2, p3, p4);
                var cer = new Cercle(p1, 3);

                var listeDeFormes = new List<iForme>() { tri, qua, cer };
                foreach (var item in listeDeFormes)
                {
                    Console.WriteLine($"- {item.CalculerPerimetre()}");
                    Console.WriteLine($"-- {item.CalculerAire()}");
                }
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine($"Une division par 0 s'est produite : {err.Message}");
            }
            catch (GeometrieException err)
            {
                Console.WriteLine($"Une erreur de géometrie s'est produite : {err.Message}");
                Console.WriteLine($"Sur un objet de type : {err.Type}");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Une erreur inconnue s'est produite : {err.Message}");
            }

            

            Console.ReadKey();
        }
    }
}
