using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Helper
    {
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)     // обход строк
            {
                    Console.Write($"{array[i]}\t");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
