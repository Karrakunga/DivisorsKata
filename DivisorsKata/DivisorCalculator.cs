using System.Collections.Generic;
using System.Linq;

namespace DivisorsKata
{
    public class DivisorCalculator
    {
        public int[] Calculate(int inputNumber)
        {

            var divisors = new List<int>();

            for (var numberLessThanOrEqualToInput = inputNumber;
                numberLessThanOrEqualToInput > 0;
                numberLessThanOrEqualToInput--)
            {
                if (inputNumber % numberLessThanOrEqualToInput == 0)
                    divisors.Add(numberLessThanOrEqualToInput);
            }
            return divisors.OrderBy(number => number).ToArray();
        }
    }
}

