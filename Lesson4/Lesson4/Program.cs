using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        /*
        1) Пользователь вводит одно число(A). Вывести все числа от 1 до 1000, которые делятся на A.
        2) Пользователь вводит одно число(A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        3) Пользователь вводит одно число(A). Вывести наибольший делитель(кроме самого A) числа A.
        4) Пользователь вводит два числа(A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        5) Пользователь вводит два числа.Найти их наибольший общий делитель используя алгоритм Евклида.
        6) Пользователь вводит целое положительное число, которое является кубом целого числа N.Найдите число N методом половинного деления.
        7) Пользователь вводит одно число произвольной длины(5-8 цифр). Найти количество нечетных цифр этого числа.
        8) Пользователь вводит одно число.Найти число, которое является зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321. Просьба массивами и строками не пользоваться.
        9) Пользователь вводит целое положительное  число(N). Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        10) Пользователь вводит два числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        */


        static void Main(string[] args)
        {

            Console.WriteLine("Task 1\n");
            Console.Write("Write a number: ");
            int numberForFirstTask = int.Parse(Console.ReadLine());
            Console.Write("Result: ");
            for (int i = 1; i <= 1000; i++)
            {
                if (i % numberForFirstTask == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadLine();

            Console.WriteLine("\nTask 2\n");
            Console.Write("Write a number: ");
            int numberForSecondTask = int.Parse(Console.ReadLine());
            int resultForSecondTask = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (Math.Pow(i,2) < numberForSecondTask)
                {
                    resultForSecondTask++;
                }
            }
            Console.Write("Result: ");
            Console.WriteLine(resultForSecondTask);
            Console.ReadLine();

            Console.WriteLine("\nTask 3\n");
            Console.Write("Write a number: ");
            int numberForThirdTask = int.Parse(Console.ReadLine());
            int number = numberForThirdTask - 1;
            for (; number > 0; number--)
            {
                if (numberForThirdTask % number == 0)
                {
                    break;
                }
            }
            Console.Write("Result: ");
            Console.WriteLine(number);
            Console.ReadLine();

            Console.WriteLine("\nTask 4\n");
            Console.Write("Write first number: ");
            int firstNumberForForthTask = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int secondNumberForForthTask = int.Parse(Console.ReadLine());
            int resultForForthTask = 0;
            if(firstNumberForForthTask > secondNumberForForthTask)
            {
                for(int i = secondNumberForForthTask; i < firstNumberForForthTask; i++)
                {
                    if(i % 7 == 0)
                    {
                        resultForForthTask += i;
                    }
                }
            }
            else if (firstNumberForForthTask < secondNumberForForthTask) 
            {
                for (int i = firstNumberForForthTask; i < secondNumberForForthTask; i++)
                {
                    if (i % 7 == 0)
                    {
                        resultForForthTask += i;
                    }
                }
            }
            else
            {
                resultForForthTask = firstNumberForForthTask;
            }
            Console.Write("Result: ");
            Console.WriteLine(resultForForthTask);
            Console.ReadLine();

            
            Console.WriteLine("\nTask 5\n");
            Console.Write("Write first number: ");
            int firstNumberForFifthTask = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int secondNumberForFifhTask = int.Parse(Console.ReadLine());

            while (firstNumberForFifthTask != 0 || secondNumberForFifhTask != 0)
            {
                if (firstNumberForFifthTask > secondNumberForFifhTask)
                {
                    if (secondNumberForFifhTask == 0)
                    { break; }
                    firstNumberForFifthTask = firstNumberForFifthTask % secondNumberForFifhTask;
                }
                else
                {
                    if (firstNumberForFifthTask == 0)
                    { break; }
                    secondNumberForFifhTask = secondNumberForFifhTask % firstNumberForFifthTask;
                }
            }
            Console.Write("Result: ");
            Console.WriteLine(firstNumberForFifthTask + secondNumberForFifhTask);
            Console.ReadLine();


            Console.WriteLine("\nTask 7\n");
            Console.Write("Write number: ");
            int numberForSevenththTask = int.Parse(Console.ReadLine());
            int tempForSevenththTask = 1;
            int resultForSevenththTask = 0;
            while(tempForSevenththTask < numberForSevenththTask)
            {
                int digit = numberForSevenththTask / tempForSevenththTask % 10;
                if (digit % 2 != 0)
                {
                    resultForSevenththTask++;
                }
                tempForSevenththTask *= 10;
            }
            Console.Write("Result: ");
            Console.WriteLine(resultForSevenththTask);
            Console.ReadLine();


            Console.WriteLine("\nTask 8\n");
            Console.Write("Write number: ");
            int numberForSevethTask = int.Parse(Console.ReadLine());
            int firstTempForSevenththTask = 1;
            int digits = (int)Math.Log10(numberForSevethTask);
            int secondTempForSevenththTask = (int)Math.Pow(10, digits);
            int resultForSeventhTask = 0;
            while (firstTempForSevenththTask < numberForSevethTask)
            {
                int digit = numberForSevethTask / firstTempForSevenththTask % 10;
                resultForSeventhTask += digit * secondTempForSevenththTask;
                firstTempForSevenththTask *= 10;
                secondTempForSevenththTask /=10;
            }
            Console.Write("Result: ");
            Console.WriteLine(resultForSeventhTask);
            Console.ReadLine();


            Console.WriteLine("\nTask 9\n");
            Console.Write("Write number: ");
            int numberForEighthTask = int.Parse(Console.ReadLine());
            Console.Write("Result: ");
            for (int i = 1; i <= numberForEighthTask; i++)
            {
                int firstTempForEighthththTask = 1;
                int sumOfEvenNumbers = 0;
                int sumOfOddDigits = 0;
                
                while (firstTempForEighthththTask <= i)
                {
                    int digit = i / firstTempForEighthththTask % 10;
                    if (digit % 2 == 0)
                    {
                        sumOfEvenNumbers += digit;
                    }
                    else
                    {
                        sumOfOddDigits += digit;
                    }

                    firstTempForEighthththTask *= 10;
                }
                if (sumOfEvenNumbers > sumOfOddDigits)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadLine();

            
            Console.WriteLine("\nTask 10\n");
            Console.Write("Write first number: ");
            int firstNumberForTenthTask = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int secondNumberForTenthTask = int.Parse(Console.ReadLine());
            bool result = false;
            int firstTempForTenthththTask = 1;
            int secondTempForTenthththTask = 1;

            while (firstTempForTenthththTask <= firstNumberForTenthTask)
            {
                int digit = firstNumberForTenthTask / firstTempForTenthththTask % 10;
                while (secondTempForTenthththTask <= secondNumberForTenthTask)
                {
                    int digit2 = secondNumberForTenthTask / secondTempForTenthththTask % 10;
                    secondTempForTenthththTask *= 10;
                    if(digit == digit2)
                    {
                        result = true;
                        break;  
                    }
                }
                if (result)
                {
                    break;
                }
                secondTempForTenthththTask = 1;
                firstTempForTenthththTask *= 10;
            }
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
