using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEtermax
{


    //Create a function that returns the simplified version of a fraction.


    //Simplify("4/6") ➞ "2/3"

    //Simplify("10/11") ➞ "10/11"

    //Simplify("100/400") ➞ "1/4"

    //Simplify("8/4") ➞ "2"


    //        Notes
    //A fraction is simplified if there are no common factors(except 1) between the numerator and the denominator.For example, 4/6 is not simplified, since 4 and 6 both share 2 as a factor.
    //If improper fractions can be transformed into integers, do so in your code (see example #4).

    public class SimplifiedFractions
    {

        public string Simplify(string fraction) {

            var split = fraction.Split('/');
            int first;
            int second;

            if (!int.TryParse(split[0], out first) || !int.TryParse(split[1], out second)) {
                throw new Exception("Los valores no son numeros");
            }
            
            //Depende que es lo que queremos hacer
            if (second == 0)
                return fraction;

            //if(second == 0){
            //throw new Exception("No se puede dividir por 0");
            //}

            if (first % second == 0)
                return (first / second).ToString();

            int divisor =  first < second ? first : second;

            while (divisor >= 2) {

                if (first % divisor == 0 && second % divisor == 0)
                {
                    first /= divisor;
                    second /= divisor;
                    divisor = first < second ? first : second;
                }
                else {
                    divisor--;
                }

            }
          

            return $"{first}/{second}";
        }
    }
}
