using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = Math.Max(input1.Length, input2.Length);
    
            for (int i = 0; i < length; i++)
            {
                int firstValue = input1[i % input1.Length];
                int secondtValue = input2[i % input2.Length];
                Console.Write("{0} ", firstValue + secondtValue);
            }
        }
    }
}