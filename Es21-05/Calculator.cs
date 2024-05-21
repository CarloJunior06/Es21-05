using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es21_05
{
    public class Calculator 
    {
        public int Add(string numbers)
        {
            int sum = 0;          
            if (numbers.Length == 0)
            {
                return sum;
            }
            List<char> delimiters = [ ',', '\n' ];
            if (numbers.StartsWith("//"))
            {
                char newdelimiter = numbers[2];
                delimiters.Add(newdelimiter);
                numbers = numbers.Substring(4); //remove 
            };
            string[] numbersString = numbers.Split(delimiters.ToArray());      
            try
            {   

                sum = numbersString.Sum(n => int.Parse(n));
                return sum;
            }
            catch 
            {
                throw new Exception("Invalid Input");
            }
        }
    }
}
