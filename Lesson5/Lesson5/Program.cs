using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson5
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initArray(int len)
            {
                Random rnd = new Random();

                int[] array = new int[len];

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

            int writeLengthOfArray()
            {
                Console.Write("\nWrite a number of element in array: ");
                int arrayLength = int.Parse(Console.ReadLine());

                return arrayLength;
            }

            //1) Посчитать количества нечетных и четных элементов массива.Не путать с нечетными и четными индексами.

            void task1()
            {
                Console.WriteLine("Task 1\nПосчитать количества нечетных и четных элементов массива.Не путать с нечетными и четными индексами.");

                int arrayLength = writeLengthOfArray();

                int[] arr = initArray(arrayLength);
                printArray(arr);

                int sumOfEvenNumbers = 0,
                    sumOfOddNumbers = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    _ = arr[i] % 2 == 0 ? sumOfEvenNumbers++ : sumOfOddNumbers++;
                }

                Console.WriteLine($"\nEven Numbers: {sumOfEvenNumbers}");
                Console.WriteLine($"Odd Numbers: {sumOfOddNumbers}");
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
            }

            //2) Каждый третий элемент массива заменить суммой двух предыдущих элементов.

            void task2()
            {
                Console.WriteLine("Task 2\nКаждый третий элемент массива заменить суммой двух предыдущих элементов.");

                int arrayLength = writeLengthOfArray();

                int[] arr = initArray(arrayLength);
                printArray(arr);

                for (int i = 2; i < arr.Length; i += 3)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];
                }

                Console.WriteLine("\nResult: ");
                printArray(arr);
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
            }

            //3) Слить два целочисленных массива в один(должен получиться третий массив).

            void task3()
            {
                Console.WriteLine("Task 3\nСлить два целочисленных массива в один(должен получиться третий массив");

                int arraysLength = writeLengthOfArray();

                int[] firstArr = initArray(arraysLength);
                Console.WriteLine("\nFirst array: ");
                printArray(firstArr);

                Thread.Sleep(1000);

                int[] secondArr = initArray(arraysLength);
                Console.WriteLine("\nSecond array: ");
                printArray(secondArr);

                int[] resultArr = new int[firstArr.Length + secondArr.Length];

                int tempForFirstArr = 0,
                    tempForSecondArr = 0,
                    tempForResultArray = firstArr.Length;

                while (tempForFirstArr < firstArr.Length)
                {
                    resultArr[tempForFirstArr] = firstArr[tempForFirstArr];
                    resultArr[tempForResultArray] = secondArr[tempForSecondArr];
                    tempForFirstArr++;
                    tempForSecondArr++;
                    tempForResultArray++;
                }

                Console.WriteLine("\nResult array: ");
                printArray(resultArr);
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
            }


            //4) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 1 2 3 4 5 - 4 5 1 2 3

            void task4()
            {
                Console.WriteLine("Task 4\nПоменять местами первую и вторую половину массива");

                int arrayLength = writeLengthOfArray();

                int[] arr = initArray(arrayLength);
                printArray(arr);


                for (int j = 0; j < arr.Length / 2; j++)
                {
                    int tmp = arr[arr.Length - 1];

                    for (var i = arr.Length - 1; i != 0; --i)
                    {
                        arr[i] = arr[i - 1];
                    }

                    arr[0] = tmp;
                }

                Console.WriteLine("\nResult: ");
                printArray(arr);
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
            }

            //5) Циклически двинуть массив вправо на 1 элемент.Например: 1 2 3 4 5-> 5 1 2 3 4.А после этого сделать циклический сдвиг вправо на N элементов.

            void task5()
            {
                Console.WriteLine("Task 5\nПоменять местами первую и вторую половину массива");

                int arrayLength = writeLengthOfArray();

                Console.Write("\nВведите на сколько элементов хотите сдвинуть массив");
                int n = int.Parse(Console.ReadLine());

                int[] arr = initArray(arrayLength);
                printArray(arr);


                for (int j = 0; j < n; j++)
                {
                    int tmp = arr[arr.Length - 1];

                    for (var i = arr.Length - 1; i != 0; --i)
                    {
                        arr[i] = arr[i - 1];
                    }

                    arr[0] = tmp;
                }

                Console.WriteLine("\nResult: ");
                printArray(arr);
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
            }

            //6) Преобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот. Сделать за O(N / 2).

            void task6(){

                Console.WriteLine("Task 6\nПреобразовать массив так, чтобы на четных позициях стояли элементы с нечетных позиций, и наоборот");

                int arrayLength = writeLengthOfArray();

                int[] arr = initArray(arrayLength);
                printArray(arr);

                for (int i=0; i < arr.Length; i+=2)
                {
                    int tempEven = arr[i];
                    int tempOdd = arr[i + 1];
                    arr[i] = tempOdd;
                    arr[i + 1] = tempEven;
                }

                Console.WriteLine("\nResult: ");
                printArray(arr);
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();

            }

            //7) В массиве из целочисленных элементов(включая отрицательные) вычислить: а) минимальный по модулю элемент массива;
            //б) сумму элементов, расположенных после первого нулевого элемента(элемента, равного нулю). Сделать одним проходом цикла!

            void task7(){

                Console.WriteLine("Task 7\nВ массиве из целочисленных элементов(включая отрицательные) вычислить: а) минимальный по модулю элемент массива;б) сумму элементов, расположенных после первого нулевого элемента(элемента, равного нулю). Сделать одним проходом цикла!");

                int arrayLength = writeLengthOfArray();

                int[] arr = initArray(arrayLength);

                printArray(arr);

                int min = arr[0],
                    sum = 0;
                bool flag = false;

                for (int i = 0; i < arr.Length; i++) 
                {
                    if (Math.Abs(arr[i]) < Math.Abs(min)) 
                    {
                        min = arr[i];
                    }
                    if (arr[i] == 0)
                    {
                        flag = true;
                    }
                    if (flag)
                    {
                        sum += arr[i];
                    }
                }

                Console.WriteLine("\nResult: ");
                printArray(arr);
                Console.Write("\nMin: ");
                Console.WriteLine(min);
                Console.Write("\nSum: ");
                Console.WriteLine(sum);
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
            }

            //8) Отсортировать массив по возрастанию алгоритмом вставок(insert).
            //Определить для себя вариацию алгоритма для сортировки по убыванию(реализовывать не обязательно).

            //9) Отсортировать массив по возрастанию алгоритмом выборки(select).
            //Определить для себя вариацию алгоритма для сортировки по убыванию(реализовывать не обязательно).
            /*task1();
            task2();
            task3();
            task4();
            task5();
            task6();*/
            task7();

        }
    }
}
