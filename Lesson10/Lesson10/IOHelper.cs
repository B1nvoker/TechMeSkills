using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class IOHelper
    {
        public int SaveInput(int min_value, int max_value, string message)
        {
            return new int();
        }
        public double SaveInput(double min_value, double max_value, string message)
        {
            return new double();
        }
        public (double, double) inputPoint(string message)
        {
            double x1 = 1;
            double y1 = 1;
            
            return  (x1, y1);
        }
        void Line(int length)
        {
            Console.WriteLine($"The length of line: {length}");
        }
        int TextMenu(string[] menu_items)
        {
            return new int();
        }
        int[] GenerateIntArray(int size, int min, int max)
        {
            Random rnd = new Random();

            int[] mas = new int[size];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                    mas[i] = rnd.Next(min, max);
            }
            return mas;
        }
        double[] GenerateDoubleArray(int size, double min, double max)
        {
            Random rnd = new Random();

            double[] mas = new double[size];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                mas[i] = rnd.NextDouble() * (max - min) + min;
            }
            return mas;
        }
        int[,] GenerateIntMatrix(int rows, int cols, int min, int max)
        {
            Random rnd = new Random();

            int[,] mas = new int[rows, cols];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(min, max);
                }
            }
            return mas;
        }
        double[,] GenerateDoubleMatrix(int rows, int cols, double min, double max)
        {
            Random rnd = new Random();

            double[,] mas = new double[rows, cols];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.NextDouble() * (max - min) + min;
                }
            }
            return mas;
        }
        void PrintArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        void PrintArray(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        void PrintArray(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        void PrintArray(double[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
