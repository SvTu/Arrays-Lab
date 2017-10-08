using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            string result = string.Empty;


            for (int i = 0; i < numbers.Length; i++)
            {
                double input = numbers[i];
                if (numbers[i] < 0)
                {
                    result = "negative";
                    numbers[i] = Math.Abs(numbers[i]);
                }
                else
                {
                    result = "positive";
                }
                numbers[i] += 0.5;
                numbers[i] = Math.Truncate(numbers[i]);

                if (result == "positive")
                {
                    Console.WriteLine("{0} => {1} ",input,  numbers[i]);
                }
                else
                {
                    Console.WriteLine("{0} => -{1}",input,  numbers[i]);
                }
            }
        }
    }
}