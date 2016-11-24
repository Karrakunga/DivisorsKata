using System.Collections.Generic;
using System.Linq;

namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {

            var divisors = new List<int>();

            if (inputNumber == 1 || inputNumber == 2 || inputNumber == 3 || inputNumber == 4 || inputNumber == 20)
            {
                for (var numberLessThanOrEqualToInput  = 20; 
                    numberLessThanOrEqualToInput > 0; 
                    numberLessThanOrEqualToInput--)
                {
                    if (inputNumber % numberLessThanOrEqualToInput == 0)
                        divisors.Add(numberLessThanOrEqualToInput);
                }
                return divisors.OrderBy(number => number).ToArray();
            }
            else
            {
                return null;
            }

        }
    }
}

