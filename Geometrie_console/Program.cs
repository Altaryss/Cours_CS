using System;
using System.Collections.Generic;
using Geometrie;

namespace Geometrie_console
{
    class Program
    {
        static void Main(string[] args)
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
                Console.WriteLine($"-- {item.CalculerPerimetre()}");
            }

            var poly = new Triangle(p1, p2, p3);
            // Afficher le premier point
            Console.WriteLine(poly[0]);

            for (int i = 0; i < poly.Count; i++)
            {
                Console.WriteLine($"f - Entrée :{poly[i]}");
            }

            foreach (var item in poly)
            {
                Console.WriteLine($"fe - Entrée : {item}");
            }

            Console.WriteLine(poly.CalculerPerimetre());
            Console.WriteLine(poly.EstEquilateral);

            if (poly.EstEquilateral)
            {
                Console.WriteLine("Il est équilatéral !");
            } else
            {
                Console.WriteLine("Il est rectangle");
            }

            Console.ReadKey();
        }
    }
}
