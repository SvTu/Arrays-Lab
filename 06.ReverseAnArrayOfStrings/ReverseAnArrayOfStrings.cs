using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
           
            int n = input.Length;

            n = ReverseStringArray(input, n);
           
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        private static int ReverseStringArray(string[] input, int n)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                string temp = input[i];
                input[i] = input[n - 1];
                input[n - 1] = temp;
                n--;
            }

            return n;
        }
    }
}
