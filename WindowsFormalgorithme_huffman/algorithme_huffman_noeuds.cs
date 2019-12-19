using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithme_huffman
{
 
        public class noeuds
        {
            /// Obtient/Définit le code ASCII de la feuille(Noeud)
            public byte ASCIICode;
            /// Obtient/Définit le nombre d'occurence du code ASCII dans le document à compresser
            public long Count;
            /// Obtient/Définit le Noeud parent (Contient la somme des variables Count des Noeuds Gauche et Droit)
            public noeuds parent;
            /// Obtient/Définit le Noeud de gauche (bit = 0)
            public noeuds LNode;
            /// Obtient/Définit le Noeud de droite (bit = 1)
            public noeuds RNode;
            /// Obtient/Définit le codage huffman de la feuille (="" si ce n'est pas une feuille)
            public string CodeWord = "";
            /// Constructeur basique d'un noeud sans valeur
            public noeuds()
            {
                this.ASCIICode = 0;
                this.Count = -1;
                this.parent = null;
                this.LNode = null;
                this.RNode = null;
            }
            /// Constructeur d'une feuille sans parent
            /// <param name="valeur">Code ASCII de la feuille</param>
            /// <param name="occurence">Nombre d'occurence du code ASCII</param>



            public noeuds(int valeur, long occurence)
            {
                this.ASCIICode = (byte)valeur;
                this.Count = occurence;
                this.parent = null;
                this.LNode = null;
                this.RNode = null;
            }
      
            /// Constructeur d'un noeud provenant de la fusion de deux noeuds (aucun code ASCII car pas une feuille)
            /// <param name="left">Noeud gauche (bit = 0)</param>
            /// <param name="right">Noeud droit (bit = 1)</param>
            public noeuds(ref noeuds left, ref noeuds right)
            {
                this.parent = null;
                this.ASCIICode = 0;
                this.Count = left.Count + right.Count;
                this.LNode = left;
                this.RNode = right;
            }

            public int HasLRChildren()
            {
                int result = 0;

                if (this.LNode != null)
                {
                    result = 1;
                }
                if (this.RNode != null)
                {
                    if (result == 1)
                    {
                        result++;
                    }
                    result++;
                }

                return result;
          }
    }
}
