using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEtermax
{

//   Find an Anagram of a String in Another String
//Create a function that takes two strings and determines if an anagram of the first string is in the second string. Anagrams of "bag" are "bag", "bga", "abg", "agb", "gab", "gba". Since none of those anagrams are in "grab", the answer is false. A "g", "a", and "b" are in the string "grab", but they're split up by the "r".

//Examples
//AnagramStrStr("car", "race") ➞ true

//AnagramStrStr("nod", "done") ➞ true

//AnagramStrStr("bag", "grab") ➞ false
//Notes
//Inputs will be valid strings in all lowercase letters.
//There exists a linear time algorithm for this.

    public class Anagram
    {
        public bool AnagramStrStr(string needle, string haystack) {

            List<char> arr1 = needle.ToCharArray().ToList();
            List<char> arr2 = haystack.ToCharArray().ToList();

            List<char> aux2 = new List<char>();
            aux2.AddRange(arr1);

            int aux = arr1.Count;
         
            List<int> index = new List<int>();


            for (int i = 0; i < arr2.Count; i++) {

               bool hayLetra = false;
               for(int j = 0; j < aux2.Count; j++)
               {
                    if (arr2[i] == aux2[j])
                    {
                        hayLetra = true;
                        index.Add(i);
                        aux2.RemoveAt(j);
                        break;
                    }
               }
                if (index.Count != 0 && !hayLetra)
                {
                    index.Clear();
                    aux2.AddRange(arr1);
                }

                if (index.Count == aux)
                    break;
            }

            if (index.Count != aux)
                return false;

            for (int i = 0; i < index.Count - 1; i++) {
                int valorActual = index[i];
                int valorSiguiente = index[i + 1];

                if (valorSiguiente != valorActual + 1)
                    return false;
            }
            return true;

        }
    }
}
