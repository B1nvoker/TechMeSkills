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
        public static int[,] initArray(int heigth, int wide)
        {
            Random rnd = new Random();

            int[,] array = new int[heigth, wide];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 101);
                }
            }
            return array;
        }

        public static void printArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)     // обход строк
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static int writeArrayHeigth()
        {
            Console.Write("\nWrite a number heigth of array:");
            int arrayheigth = int.Parse(Console.ReadLine());
            return arrayheigth;
        }

        public static int writeArrayWide()
        {
            Console.Write("\nWrite a number wide of array:");
            int arraywide = int.Parse(Console.ReadLine());

            return arraywide;
        }
    }
}
