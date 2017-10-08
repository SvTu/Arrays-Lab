using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseAnArrayOfIntegers
{
    class ReverseAnArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedArr = new int[n];
            int index = n - 1;

            for (int i = 0; i < n; i++)
            {
                reversedArr[i] = arr[index];
                index--;
            }

            foreach (var item in reversedArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
