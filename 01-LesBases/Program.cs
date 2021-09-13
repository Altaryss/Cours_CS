using System;
using System.Text;

namespace _01_LesBases
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration de variables 

            int entier;
            entier = 8;

            int entier2 = 9;

            // inférence de type : var

            var entier3 = 10;

            #endregion

            #region tableaux

            var tab = new int[3];
            tab[0] = 1;
            tab[1] = 8;
            tab[2] = 91;

            // Déclaration rapide avec l'initialisateur de collection
            var tab2 = new int[] { 1, 8, 91 };

            // Tableau à plusieurs dimensions
            var tab2D = new int[3, 5];
            tab2D[0, 0] = 1;
            tab2D[2, 4] = 1;

            // Tableau de tableau
            var tabDeTab = new int[3][];
            tabDeTab[0] = new int[5];
            tabDeTab[1] = new int[2];
            tabDeTab[2] = new int[3];

            tabDeTab[0][0] = 12;
            tabDeTab[2][2] = 12;

            #endregion

            #region Structures conditionnelles

            if (true)
            {
                //...
            }

            if(true)
            {
                //...
            } else
            {
                //...
            }
            
            if (true)
            {
                //...
            } else if (true)
            {
                //...
            } else
            {
                //...
            }

            var nomDuChat = "Minou";
            switch (nomDuChat)
            {
                case "Mimi":
                        Console.WriteLine("Trop cute");
                    break;

                case "Minou":
                    Console.WriteLine("Un peu classique");
                    break;

                default:
                    Console.WriteLine("Et si on l'appelait M.Braux");
                    break;
            }

            #endregion

            #region Structures conditionnelles 2

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            var unTableau = new string[] { "Chat", "Chien" };
            // si le foreach contient var il décide lui même sinon elle s'écrit :
            // foreach (string item in unTableau) { Console.WriteLine(item); }
            foreach (var item in unTableau)
            {
                Console.WriteLine(item);
            }

            var PuissanceDe2 = 2;
            while (PuissanceDe2 < 200)
            {
                Console.WriteLine(PuissanceDe2);
                PuissanceDe2 *= 2;
            }

            do
            {
                //...
            } while (false);

            try
            {
                //...
            }
            catch (Exception)
            {
                // error
                throw;
            }

            #endregion

            #region Utilisation de la fonction

            var res = "banane";
            EcrireALEcranEtFaireUnePause(res);

            #endregion
        }

        #region Fonctions
        /// <summary>
        /// Affiche un message à l'écran puis fait une pause
        /// </summary>
        /// <param name="message">Le message à afficher</param>
        public static void EcrireALEcranEtFaireUnePause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();

            var resultat = ConcatenerDesChaines2("Minou", "Mimi", "Braux", "Reinold", "Meryle");
        }

        public static string ConcatenerDesChaines(string s1, string s2)
        {
            // Priviliégié le return $ au s1+s2 pour éviter les problèmes de mémoire
            // return String.Format("{0} {1}", s1, s2);
            return $"{s1} {s2}";
        }

        #region String Builder
        public static string ConcatenerDesChaines2(string s1, string s2, params string[] autresChaines) // autresChaines permet d'avoir un nombre indéfnie de chaines
        {
            // Pour faire de la concaténation propre, j'utilise string builder via usign "System.Text;"
            var sb = new StringBuilder();
            // On définie nos paramètres
            sb.Append($"{s1} {s2}");
            // Et on définie les autresChaines  via un foreach ceux ci peuvent être infinie
            foreach (var item in autresChaines)
            {
                sb.Append($"{item}");
            }
            // Puis on return le resultat
            return sb.ToString();
        }

        #endregion

        #endregion
    }
}