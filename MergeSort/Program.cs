using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMergeSort();

            Console.ReadLine();
        }

        private static void TestMergeSort()
        {
            int[] numbers = { 105, 86, 77, 98, 1000, 1, 0, 3 };
            numbers.DoMergeSort();

            foreach (int number in numbers)
                Console.Write(number + " ");
        }
    }
}
