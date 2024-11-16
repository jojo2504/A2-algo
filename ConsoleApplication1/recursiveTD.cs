using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class recursiveTD
    {
        /// <summary>
        /// Factorielle Non terminale
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Factorielle(int n)
{
            return n>0 ? n * Factorielle(n-1) : 1 ;
        }

        /// <summary>
        /// Factorielle terminale
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static int Factorielle_Terminale(int n, int result = 1)
        {
            return n>0 ? Factorielle_Terminale(n - 1, result * n) : result;
        }

        /// <summary>
        /// Memoized Fibbonachi avec un helper pour initialiser le set
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibbonachi(int n)
        {
            HashSet<int> memoize = new HashSet<int>();
            int helper(int number)
            {
                if (number <= 1) return number;
                if (!memoize.Contains(number)) memoize.Add(number);
                return helper(number - 1) + helper(number - 2);
            }
            return helper(n);
        }

        /// <summary>
        /// Inverse une chaîne de caractère
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="chain"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string Inversion(string chain, int index = 0)
        {
            if (index > chain.Length - 1) return "";
            return Inversion(chain, index+1) + chain[index];
        }

        /// <summary>
        /// Retourne si la chaîne est un palindrome
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="chain"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool Palindrome(string chain, int index = 0)
        {
            if (chain[index] != chain[chain.Length - 1 - index])
            {
                return false;
            }
            if (index > chain.Length / 2)
            {
                return true;
            }
            return Palindrome(chain, index+1);
        }

        /// <summary>
        /// Retourne l'index de l'élémenet le plus grand du tableau
        /// Time Complexity : O(N)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="currentMax"></param>
        /// <param name="maxIndex"></param>
        /// <returns></returns>
        public static int MaxIndex(int[] array, int index = 0, double currentMax = Double.NegativeInfinity, int maxIndex = 0)
        {
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            if (index > array.Length - 1)
            {
                return maxIndex;
            }

            if (array[index] > currentMax)
            {
                currentMax = array[index];
                maxIndex = index;
            }
            return MaxIndex(array, index+1, currentMax, maxIndex);
        }
        
        /// <summary>
        /// Recherche dichotomique d'un élément dans un tableau 
        /// Time Complexity : O(log(N))
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int RechDichoRecursif(int[] array, int element)
        {   
            int Helper(int[] harray, int hleft, int hright)
            {
                if (hleft > hright){
                    return -1;
                }
                int mid = (hleft + hright) / 2;
                if (harray[mid] == element)
                {
                    return mid;
                }
                if (harray[mid] > element){
                    return Helper(harray, hleft, mid-1);
                }
                else {
                    return Helper(harray, mid+1, hright);
                }
            }
            return Helper(array, 0, array.Length-1);
        }

        /// <summary>
        /// Implémentation du tri fusion grâce au l'algorithme diviser pour régner
        /// Time Complexity : O(N(log(N)))
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] TriFusion(int[] array)
        {
            if (array == null || array.Length <= 1) {
                return array;
            }
    
            int longueur = array.Length;
            int milieu = longueur / 2;

            int[] gauche = new int[milieu];
            int[] droite = new int[longueur - milieu];
            
            for (int index = 0; index < milieu; index++) {
                gauche[index] = array[index];
            }
            
            for (int index = milieu; index < longueur; index++) {
                droite[index - milieu] = array[index];
            }
    
            // Appels récursifs pour trier les sous-tableaux
            gauche = TriFusion(gauche);
            droite = TriFusion(droite);
    
            // Fusion des deux sous-tableaux triés
            int i = 0, j = 0, k = 0;
    
            // Tant qu'il reste des éléments dans les deux sous-tableaux
            while (i < gauche.Length && j < droite.Length) {
                if (gauche[i] <= droite[j]) {
                    array[k] = gauche[i];
                    i++;
                } else {
                    array[k] = droite[j];
                    j++;
                }
                k++;
            }
    
            // Copie des éléments restants du sous-tableau gauche
            while (i < gauche.Length) {
                array[k] = gauche[i];
                i++;
                k++;
            }
    
            // Copie des éléments restants du sous-tableau droit
            while (j < droite.Length) {
                array[k] = droite[j];
                j++;
                k++;
            }
    
            return array;
        }

        /// <summary>
        /// Ecris une solution au problème du jeu des tours d'Hanoi
        /// O(2^N)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="auxiliary"></param>
        public static void Hanoi(int n, char source, char destination, char auxiliary)
        {
            if (n == 1)
            {
                Console.WriteLine($"Déplacer le disque 1 de {source} à {destination}");
                return;
            }

            Hanoi(n - 1, source, auxiliary, destination);
            Console.WriteLine($"Déplacer le disque {n} de {source} à {destination}");
            Hanoi(n - 1, auxiliary, destination, source);
        }
    }
}