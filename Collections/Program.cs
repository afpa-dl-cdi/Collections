using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ********* UTLISATION D UNE CLASSE GENERIQUE **************** 
            Generic<int> genericInt = new Generic<int>();
            genericInt.Add(5);
            genericInt.Add(3);
            Console.WriteLine(genericInt.Get(0));

            Generic<string> genericString = new Generic<string>();
            genericString.Add("Un mot");
            Console.WriteLine(genericString.Get(0));

            // ************** UTILISATION D UNE METHODE GENERIQUE **********
            string[] data = { "un", "deux", "trois" };
            afficherTableau<string>(data);  // dans notre cas la classe est aussi générique mais aurait pu ne pas l'être. Nous aurions appelé Generic.afficherTableau<string>(data);


            // ***************** LISTES ************
            List<int> uneListe = new List<int>();
            uneListe.Add(0);
            uneListe.Add(1);
            uneListe.Add(6);
            uneListe.Reverse();
            uneListe.Insert(1, 8);
            Console.WriteLine(uneListe.Average());


            // *************** FIFO / file ***************
            Queue<string> imprimante = new Queue<string>();

            // *************** LIFO / Pile **************
            Stack<int> pile = new Stack<int>();

            // *************** DICTIONNAIRE *************



            // **************** LISTE CHAINEE ************

        }

            /// <summary>
            /// Afficheur de tableau
            /// </summary>
            /// <typeparam name="Ti"></typeparam>
            /// <param name="tableau"></param>
            public static void afficherTableau<Ti>(Ti[] tableau)
            {
                foreach (Ti item in tableau)
                {
                    System.Console.WriteLine(item);
                }
            }
    }
}
