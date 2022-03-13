﻿using System;
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
            Console.WriteLine("Task 1");
            Console.WriteLine("Write a number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 1000; i++)
            {
                if (i % number == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
