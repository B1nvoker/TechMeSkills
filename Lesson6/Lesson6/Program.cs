using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] initArray(int heigth, int wide)
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

            void printArray(int[,] array)
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

            int writeArrayHeigth()
            {
                Console.Write("\nWrite a number heigth of array:");
                int arrayheigth = int.Parse(Console.ReadLine());
                return arrayheigth;
            }

            int writeArrayWide()
            {
                Console.Write("\nWrite a number wide of array:");
                int arraywide = int.Parse(Console.ReadLine());

                return arraywide;
            }

            // 1) Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива NxM. Изменяющиеся элементы должны образовать "рамочку" толщиной в 1 элемент.

            //Примечание: здесь "NxM" означает, что массив прямоугольный, произвольного размера. Наиболее наглядно такие задачи показывают себя на массивах, например, 5x8.


            void task1()
            {
                Console.Write("Task 1\n");
                int[,] array = initArray(writeArrayHeigth(), writeArrayWide());
                Console.WriteLine($"\nArray: ");
                printArray(array);

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i == 0 || i == array.GetLength(0) - 1 || j == 0 || j == array.GetLength(1) - 1)
                        {
                            array[i, j] *= -1;
                        }
                    }
                }
                Console.WriteLine($"\nResult array: ");
                printArray(array);
                Console.ReadLine();
            }


            //2) Заполнить матрицу 9x9 таблицей умножения:
            //1 2 3 ...  9
            //2 4 6 ... ...
            //3 6 9 ... ...
            //4.8 ... ... ...
            //9 .... .... 81
            void task2()
            {
                Console.Write("Task 2\n");
                int[,] array = new int[9, 9];

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        int k = i + 1;
                        int n = j + 1;
                        array[i, j] = n++ * k;
                    }
                }
                Console.WriteLine($"\nResult array: ");
                printArray(array);
                Console.ReadLine();
            }



            //3) Заполнить квадратную матрицу NxN (произвольного размера) нулями и единицами так, как расположены клетки на шахматной доске, где 0 - "черное", 1 - "белое". Левое нижнее поле на шахматной доске всегда черное. Обратите внимание - нумерация элементов массива идет сверху вниз, и слева направо. То есть, левое нижнее поле - это поле в последней строке и 0-м столбце.

            void task3()
            {

                Console.Write("Task 3\n");
                int n = writeArrayHeigth();
                int[,] array = new int[n, n];
                int temp = 1;
                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (temp % 2 != 0)
                        {
                            array[i, j] = 0;
                        }
                        else
                        {
                            array[i, j] = 1;
                        }
                        temp++;
                    }
                    if (n % 2 == 0)
                    {
                        temp++;
                    }
                }
                Console.WriteLine($"\nResult array: ");
                printArray(array);
                Console.ReadLine();
            }


            //4) Зрительный зал театра имеет N рядов по M мест в каждом ряду. Их можно представить в виде двумерного массива NxM. Если место занято - в массиве стоит значение "1". Если свободно - "0". Образец массива задать вручную, инициализацией в момент создания. На готовом массиве проверить соблюдение "антиковидного правила" (нет двух занятых мест в одном ряду, расположенных рядом, но пропусков может быть сколько угодно). Сделать по оптимальному алгоритму (если нашли два занятых кресла рядом в одном ряду - прервать циклы обхода матрицы).

            void task4()
            {
                Console.Write("Task 4\n");
                int[,] array = new int[9, 10] {
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 1 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0, 1, 1 } };

                int temp = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1) - 1; j++)
                    {
                        if (array[i, j] == 1)
                        {
                            if (array[i, j + 1] == 1)
                            {
                                temp = 1;
                                break;
                                
                            }
                        }
                    }
                    if (temp == 1)
                    {
                        Console.WriteLine("Плохо сидят");
                        break;
                        
                    }
                }
                if (temp == 1)
                {
                    Console.WriteLine("Плохо сидят");
                }
                Console.ReadLine();
            }

            //5) Фирма имеет 10 магазинов. Доходы каждого магазина за полугодие (6 месяцев с номерами 0-5) хранятся в двумерном вещественном массиве. Заполнить массив случайными вещественными числами. Высчитать:
            //а) суммарный доход по каждому магазину;
            //б) средний доход по каждому месяцу;
            //в) мин. и макс. доход за весь период.
            //Примечание: для получения вещественного случайного числа можно использовать rnd.NextDouble(), но он даст только случайное вещественное число между 0 и 1 (например, 0.53457623123123). Для получения нужного вам вещественного числа, его можно умножить на большое целое число. Так вы получите уже большое вещественное число.


            //6) Найти количество элементов массива, которые больше всех своих соседей одновременно. 
            //Примечание: соседями элемента считать только 4 потенциальных соседа: на 1 выше, на 1 ниже, на 1 левее и на 1 правее. Обязательно учесть выход за границы массива! При определении критерия, считать сумму соседей для каждого элемента, даже для элемента [0;0] (у него, кстати, будет всего два соседа - [0; 1] и [1; 0]).


            //7) Заполнить массив из символов (char) указанным образом (см. рисунок 1).


            //8) Реализовать перемножение матриц целых чисел. Примеры не сложно найти в сети. Важно их понять и адаптировать для ваших двух произвольных массивов. Проверить входное условие перемножения (число столбцов 1-го массива == числу строк 2-го массива).

            //task1();
            //task2();
            //task3();
            task4();
        }
    }
}
