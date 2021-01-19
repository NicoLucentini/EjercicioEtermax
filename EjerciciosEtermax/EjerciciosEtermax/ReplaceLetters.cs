using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEtermax
{
    /*
    Create a function that takes a string and replaces
    each letter with its appropriate position in the alphabet. 
    "a" is 1, "b" is 2, "c" is 3, etc, etc.

    AlphabetIndex("Wow, does that work?")
    ➞ "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11"

    AlphabetIndex("The river stole the gods.")
    ➞ "20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19"

    AlphabetIndex("We have a lot of rain in June.")
    ➞ "23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5"
    
     */

    public class ReplaceLetters
    {
        public string Replace(String text)
        {
            List<String> letters = new List<String>(){"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t","u", "v", "w", "x", "y", "z" };
            
            Char[] textChart = text.ToCharArray();
            List<String> indexTextInLetters = new List<String> ();

            foreach (var letter in textChart)
            {
                String letterString = letter.ToString();
                if (letters.IndexOf(letterString.ToLower()) != -1)
                    indexTextInLetters.Add((letters.IndexOf(letterString.ToLower()) + 1).ToString());
            }
            return String.Join(" ", indexTextInLetters);
        }

    }
}
