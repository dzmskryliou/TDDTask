using System;
using System.Collections.Generic;
using System.Linq;

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

            var delimiters = new List<string> { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                var endOfDelimitersIndex = numbers.IndexOf('\n');
                var customDelimiter = numbers.Substring(2, endOfDelimitersIndex - 2);
                delimiters.Add(customDelimiter);
                numbers = numbers.Substring(endOfDelimitersIndex + 1);
            }

            var stringNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            var negativeNumbers = new List<int>();
            var sum = 0;

            foreach (var stringNumber in stringNumbers)
            {
                if (string.IsNullOrWhiteSpace(stringNumber))
                {
                    throw new Exception($"Invalid input: '{stringNumber}' is not a valid number.");
                }
                else if (int.TryParse(stringNumber, out var number))
                {
                    if (number < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                    else if (number <= 1000)
                    {
                        sum += number;
                    }
                }
                else
                {
                    throw new Exception($"Invalid input: '{stringNumber}' is not a number.");
                }
            }

            if (negativeNumbers.Any())
            {
                throw new Exception($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }

            return sum;
        }
    }
}
