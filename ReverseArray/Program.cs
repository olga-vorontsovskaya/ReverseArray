using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584 };

            for (int i = arr.Length - 1; i >= 0;  i--) // arr.Length minus 1 leads to the last element of array
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
