using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initArray()
            {
                Random rnd = new Random();
                int[] array = new int[20];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(-100, 101);
                }
                return array;
            }
            void printArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}  ");
                }
                Console.WriteLine("");
            }

            //1) Посчитать количества нечетных и четных элементов массива.Не путать с нечетными и четными индексами.

            void task1()
            {
                Console.WriteLine("Task 1");
                int[] arr = initArray();
                int sumOfEvenNumbers = 0;
                int sumOfOddNumbers = 0;
                printArray(arr);

                for (int i = 0; i < arr.Length; i++)
                {
                    _ = arr[i] % 2 == 0 ? sumOfEvenNumbers++ : sumOfOddNumbers ++;
                }

                Console.WriteLine($"\nEven Numbers: {sumOfEvenNumbers}");
                Console.WriteLine($"Odd Numbers: {sumOfOddNumbers}");
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();
            }

            //2) Каждый третий элемент массива заменить суммой двух предыдущих элементов.

            void task2()
            {
                Console.WriteLine("Task 2");
                int[] arr = initArray();
                printArray(arr);

                for (int i = 2; i < arr.Length; i += 3)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }

                Console.WriteLine("\nResult: ");
                printArray(arr);
                Console.ReadLine();
            }

            //3) Слить два целочисленных массива в один(должен получиться третий массив).

            void task3()
            {
                Console.WriteLine("Task 3");
                int[] firstArr = initArray();
                int[] secondArr = initArray();
                printArray(firstArr);
                printArray(secondArr);



                Console.ReadLine();
            }


            //4) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 1 2 3 4 5 - 4 5 1 2 3

            //5) Циклически двинуть массив вправо на 1 элемент.Например: 1 2 3 4 5-> 5 1 2 3 4.А после этого сделать циклический сдвиг вправо на N элементов.

            //(очевидная подсказка: завернуть циклический сдвиг вправо на 1 элемент в еще один цикл на N итераций).

            //6) Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот. Сделать за O(N / 2).

            //7) В массиве из целочисленных элементов(включая отрицательные) вычислить: а) минимальный по модулю элемент массива;
            //б) сумму элементов, расположенных после первого нулевого элемента(элемента, равного нулю). Сделать одним проходом цикла!

            //8) Отсортировать массив по возрастанию алгоритмом вставок(insert).
            //Определить для себя вариацию алгоритма для сортировки по убыванию(реализовывать не обязательно).

            //9) Отсортировать массив по возрастанию алгоритмом выборки(select).
            //Определить для себя вариацию алгоритма для сортировки по убыванию(реализовывать не обязательно).
            task1();
            task2();
            task3();
        }
    }
}
