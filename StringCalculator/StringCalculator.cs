using System;

namespace TDDProject
{
    internal class StringCalculator
    {
        public StringCalculator()
        {
        }

        internal int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var total = 0;

            foreach (var number in numbers.Split(','))
            {
                {
                    total += int.Parse(number);
                }
            }
            return total;
        }
    }
}
