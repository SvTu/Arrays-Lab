using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddle1_2or3Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
            }
            else if (input.Length % 2 == 0)
            {
                Console.WriteLine("{{ {0}, {1} }}", input[input.Length / 2 - 1], input[input.Length / 2]);
            }
            else
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", input[input.Length / 2 - 1], input[input.Length / 2], input[input.Length / 2 + 1]);
            }
        }
    }
}
