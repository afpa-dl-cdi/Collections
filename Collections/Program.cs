﻿using System;
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
            afficherTableau<string>(data);

            // ************utilisation d'une methode à plusieurs génériques ************
            testPlusieursGenerics<int, string>(5, "cinq");


            // ***************** LISTES ************
            List<int> uneListe = new List<int>();
            uneListe.Add(0);
            uneListe.Add(1);
            uneListe.Add(6);
            uneListe.Reverse();
            uneListe.Insert(1, 8);
            Console.WriteLine(uneListe.Average());


            // *************** FIFO / file ***************
            Console.WriteLine("-- Elements de ma liste -- ");
            // Le principe de la FIFO (First In First Out) et de géréer les éléments comme dans une file d'attente.
            //C'est le cas de l'imprimante qui ne sortira les impressions que par ordre d'arrivée. 
            // Les méthodes de cette liste particulière "Queue" sont donc adaptées au principe de FIFO
            Queue<string> imprimante = new Queue<string>();

            // Pour ajouter un élément : 
            imprimante.Enqueue("page index");
            imprimante.Enqueue("page sommaire");
            imprimante.Enqueue("chapitre un");
            Console.WriteLine("Impression à la position 1 : {0} " , imprimante.ElementAt(1)); // il est possible de trouver un élément avec son index

            //Pour sortir les éléménets 
            while (imprimante.Count > 0)
            {
                string impressionEnCours = imprimante.Dequeue();
                Console.WriteLine(impressionEnCours);
            }
            Console.WriteLine("Nombre d'impression restante : {0}",imprimante.Count); // ma file sera de nouveau à zero


            // *************** LIFO / Pile **************
            // Le principe de la LIFO (Last In First Out) est d'empiler des éléments et de les désempiler
            //C'est le cas par exemple de modèle OSI (modèle réseau) qui "empile" les informations de la couche applicative à la couche matérielle depuis un équipement
            // pour être dépiler par l'équipement suivant de la couche matérielle à la couche applicative
            // Pour l'instant restons simple et imaginons une pile de crèpe préparée au fur et à mesure...
            Stack<string> pile = new Stack<string>();
            pile.Push("crepe nature");
            pile.Push("crepe au sucre");
            pile.Push("crepe à la confiture");
            pile.Push("crepe au chocolat");

            // je peux parcourir ma pile 
            Console.WriteLine("-- affichage de ma pile -- ");
            foreach (var item in pile)
            {
                Console.WriteLine(item);
            }

            // maintenant nous vidons la pile 
            Console.WriteLine("-- extraction de ma pile -- ");
            while ( pile.Count > 0)
            {
                string crepe = pile.Pop();
                Console.WriteLine(crepe);
            }

            Console.WriteLine("Nombre de crepe restante : {0}", pile.Count); // ma pile sera de nouveau à zero


            // *************** DICTIONNAIRE *************
            Dictionary<string, string> entreprise = new Dictionary<string, string>();

            // Ajout au dictionnaire 
            entreprise.Add("Hervé", "responsable machine à café");
            entreprise.Add("Robert", "chef de service");
            entreprise.Add("Brigitte", "Secrétaire de direction");
            // variante 
            entreprise["Jean"] = "technicien";

            // Pour voir toutes les entrées de notre dictionnaire
            foreach (KeyValuePair<string, string> element in entreprise)
            {
                string nom = element.Key;
                string fonction = element.Value;
                Console.WriteLine("Nom: {0}, Fonction: {1}", nom, fonction);
                var personne = element;
                Console.WriteLine(personne);
            }


            // **************** LISTE CHAINEE ************
            // Une liste chainée est caractérisée par une référence au chiffre suivant et au chiffre précédent.  
            //Chacune des extrémités est référencée par la valeur null
            LinkedList<int> nombres = new LinkedList<int>();
            int[] entiers = { 10, 8, 6, 4, 2 };

            // pour rentrer des valeurs (méthode simpliste)
            foreach (int nombre in entiers)
            {
                nombres.AddLast(nombre);
            }

            // pour lire les valeurs (méthode simpliste ) 
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            // pour trouver un noeud (node) 
            LinkedListNode<int> node = nombres.Find(6);
            //Grâce au noeud, il est possible de trouver le précédent et le suivant 
            Console.WriteLine("node précédent : {0}", node.Previous.Value);
            Console.WriteLine("node suivant : {0}", node.Next.Value);

            // il est possible de faire partir le noeud du tout début de la liste chainée
            node = nombres.First;
            Console.WriteLine("deuxième valeur : {0}", node.Next.Value);

            // ou depuis la fin 
            node = nombres.Last;
            Console.WriteLine(" avant dernière valeur : {0}", node.Previous.Value);

            //Grâce au linkedlistnode, il est possible de parcourir la liste 
            for (LinkedListNode<int> lknode = nombres.Last; lknode != null; lknode = lknode.Previous) // pour parcourir la liste en sens inverse nous serions partis de Last en faisant un lnode.Previous
            {
                Console.WriteLine(node.Value);
            }
        }

            /// <summary>
            /// Afficheur de tableau générique
            /// </summary>
            /// <typeparam name="Ti"></typeparam>
            /// <param name="tableau"></param>
            public static void afficherTableau<Ti>(Ti[] tableau)
            {
                foreach (Ti item in tableau)
                {
                    System.Console.WriteLine("{0}", item);
                }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="Ti"></typeparam>
        /// <typeparam name="Tj"></typeparam>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        public static void testPlusieursGenerics<Ti, Tj>(Ti item1, Tj item2)
        {
            Console.WriteLine(item1.GetType());
            Console.WriteLine(item2.GetType());

        }
    }
}
