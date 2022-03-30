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
            for (int i = 0; i < array.Length; i++) 
            {
                    Console.Write($"{array[i]}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void printArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)     
            {
                Console.Write($"{Math.Round(array[i],2)}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
