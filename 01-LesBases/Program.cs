using System;
using System.Text;

namespace _01_LesBases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Commentaire
            /*
             * sur plusieurs
             * lignes
             * */

            //ranger le code dans des régions
            #region Déclaration de variables

            int entier;
            entier = 8;

            int entier2 = 9;

            //inférence de type : var
            var entier3 = 10;



            #endregion

            #region tableaux

            var tab = new int[3];
            tab[0] = 1;
            tab[1] = 8;
            tab[2] = 91;

            //déclaration rapide
            //avec l'initialisateur de collection
            var tab2 = new int[] { 1, 8, 91 };


            //tableaux à plusieurs dimensions
            var tab2D = new int[3, 5];
            tab2D[0, 0] = 1;
            tab2D[2, 4] = 1;

            //tableau de tableau
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
            if (true)
            {
                //...
            }
            else
            {
                //...
            }
            if (true)
            {

            }
            else if (true)
            {

            }
            else
            {

            }

            var nomDuChat = "Minou";
            switch (nomDuChat)
            {
                case "Mimi":
                    Console.WriteLine("Awww trop cute");
                    break;
                case "Minou":
                    Console.WriteLine("Un peu classique");
                    break;
                default:
                    Console.WriteLine("Et si on l'appelait M.Braux ?");
                    break;
            }

            #endregion

            #region boucles

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            var puissanceDe2 = 2;
            while (puissanceDe2 < 200)
            {
                Console.WriteLine(puissanceDe2);
                puissanceDe2 *= 2;
            }

            var cpt = 0;
            while (cpt < 10)
            {
                //je devrais faire un for non ?
                //...
                cpt++;
            }

            do
            {

            } while (false);


            //pour parcourir tous types de collection
            var unTableau = new string[] { "Mimi", "Minou" };
            foreach (var item in unTableau)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Utilisation de fonctions

            //Appel
            EcrireALEcranEtFaireUnePause("Coucou");

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

            var resultat = ConcatenerDesChaines2("Minou", "Mimi", "Braux", "Reinold", "Adde");

        }

        public static string ConcatenerDesChaines(string s1, string s2)
        {
            //return String.Format("{0} {1}",s1,s2);
            return $"{s1} {s2}";
        }
        public static string ConcatenerDesChaines2(string s1, string s2
                                            , params string[] autresChaines)
        {
            //pour faire de la concaténation propre, j'utilise un string builder
            var sb = new StringBuilder();
            sb.Append($"{s1} {s2}");

            foreach (var item in autresChaines)
            {
                sb.Append($" {item}");
            }

            return sb.ToString();
        }
        #endregion
    }
}
