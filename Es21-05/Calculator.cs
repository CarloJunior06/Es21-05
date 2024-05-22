using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es21_05
{
    public class Calculator
    {
        public string[] CustomSplit(string input)
        {
            List<char> delimiters = [',', '\n'];
            if (input.StartsWith("//"))
            {
                char newdelimiter = input[2];
                delimiters.Add(newdelimiter);
                input = input.Substring(4);

            }
            return input.Split(delimiters.ToArray());
        }
            public int Add(string numbers)
            {
                int sum = 0;
                if (numbers.Length == 0)
                {
                    return sum;
                }
                string[] numbersString = CustomSplit(numbers);
                var negatives = numbersString.Where(n => n.Contains('-'));
                if (negatives.Count() != 0)
                    throw new Exception($"negatives not allowed: {negatives.Aggregate((c, n) => $"{c}, {n}")}");

                try
                {

                    sum = numbersString.Select(int.Parse).Where(n => n <= 1000).Sum();
                    return sum;
                }
                catch
                {
                    throw new Exception("Invalid Input");
                }
            }
    }
} 
