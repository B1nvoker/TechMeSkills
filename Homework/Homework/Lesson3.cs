using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Lesson3
    {
        public static int countTwoNumbers(int firstNumber, int secondNumber)
        {
            int result;

            if (firstNumber != secondNumber)
            {
                if (firstNumber < secondNumber)
                {
                    result = firstNumber - secondNumber;
                }
                else
                {
                    result = secondNumber + firstNumber;
                }
            }
            else
            {
                result = firstNumber * secondNumber;
            }
            return result;
        }
        public static int getWhatQuarterIsNumberIn(int firstNumber, int secondNumber)
        {
            if (firstNumber > 0 && secondNumber > 0)
            {
                return 1;
            }
            if (firstNumber < 0 && secondNumber > 0)
            {
                return 4;
            }
            if (firstNumber > 0 && secondNumber < 0)
            {
                return 2;
            }
            if (firstNumber < 0 && secondNumber < 0)
            {
                return 3;
            }
            if (firstNumber == 0 && secondNumber == 0)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }
        public static int[] sortTreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int [] numbers = new int[3];
            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                numbers[0] = firstNumber;

                if (secondNumber < thirdNumber)
                {
                    numbers[1] = secondNumber;
                    numbers[2] = thirdNumber;
                }
                else
                {
                    numbers[1] = thirdNumber;
                    numbers[2] = secondNumber;
                }
            }
            else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
            {
                numbers[0] = secondNumber;

                if (firstNumber < thirdNumber)
                {
                    numbers[1] = firstNumber;
                    numbers[2] = thirdNumber;
                }
                else
                {
                    numbers[1] = thirdNumber;
                    numbers[2] = firstNumber;
                }
            }
            else if (thirdNumber <= secondNumber && thirdNumber <= firstNumber)
            {
                numbers[0] = thirdNumber;

                if (secondNumber < firstNumber)
                {
                    numbers[1] = secondNumber;
                    numbers[2] = firstNumber;
                }
                else
                {
                    numbers[1] = firstNumber;
                    numbers[2] = secondNumber;
                }
            }
            return numbers;
        }
        private static double findDiscriminant(int firstNumber, int secondNumber, int thirdNumber)
        {
            return Math.Pow(secondNumber, 2) - (4 * firstNumber * thirdNumber);
        }
        private static double[] findIfTwoRoots(int firstNumber, int secondNumber, double Discriminant)
        {
            double[] roots = new double[2];
            double resulFirst = (-secondNumber + Math.Sqrt(Discriminant)) / (2 * firstNumber);
            roots[0] = resulFirst;
            double resulSecond = (-secondNumber - Math.Sqrt(Discriminant)) / (2 * firstNumber);
            roots[1] = resulSecond;
            return roots;
        }
        private static double[] findIfOneRoots(int firstNumber, int secondNumber)
        {
            double[] root = new double[1];
            root[0] = -secondNumber / (2 * firstNumber);
            return root;
        }
        public static double[] findRoots(int firstNumber, int secondNumber)
        {
            
            if (findDiscriminant(firstNumber, secondNumber) != 0)
            {
                if (Discriminant < 0)
                { 
                    return null;
                }
                else
                {
                    return findIfTwoRoots(firstNumber, secondNumber, Discriminant); 
                }
            }
            else
            {
                return findIfOneRoots(firstNumber, secondNumber);

            }
        }
        public static void lesson3()
        {

            // Task 5 //

            Console.WriteLine("Task 5");

            int ten = 10;

            Console.WriteLine("Write number");
            int firstNumberForFifthTask = int.Parse(Console.ReadLine());

            int dozens = firstNumberForFifthTask / ten;
            int units = firstNumberForFifthTask - dozens * ten;

            if (dozens == 1)
            {
                units = 0;
            }


            switch (firstNumberForFifthTask)
            {
                case 11:
                    Console.Write("Одиннадцать");
                    break;
                case 12:
                    Console.Write("Двенадцать");
                    break;
                case 13:
                    Console.Write("Тринадцать");
                    break;
                case 14:
                    Console.Write("Четырнадцать");
                    break;
                case 15:
                    Console.Write("Пятнадцать");
                    break;
                case 16:
                    Console.Write("Шестнадцать");
                    break;
                case 17:
                    Console.Write("Семнадцать");
                    break;
                case 18:
                    Console.Write("Восемнадцать");
                    break;
                case 19:
                    Console.Write("Девятнадцать");
                    break;
            }

            switch (dozens)
            {
                case 2:
                    Console.Write("Двадцать");
                    break;
                case 3:
                    Console.Write("Тридцать");
                    break;
                case 4:
                    Console.Write("Сорок");
                    break;
                case 5:
                    Console.Write("Пятьдесят");
                    break;
                case 6:
                    Console.Write("Шестьдесят");
                    break;
                case 7:
                    Console.Write("Семьдесят");
                    break;
                case 8:
                    Console.Write("Восемьдесят");
                    break;
                case 9:
                    Console.Write("Девяносто");
                    break;
            }

            switch (units)
            {
                case 1:
                    Console.WriteLine(" один");
                    break;
                case 2:
                    Console.WriteLine(" два");
                    break;
                case 3:
                    Console.WriteLine(" три");
                    break;
                case 4:
                    Console.WriteLine(" четыре");
                    break;
                case 5:
                    Console.WriteLine(" пять");
                    break;
                case 6:
                    Console.WriteLine(" шесть");
                    break;
                case 7:
                    Console.WriteLine(" семь");
                    break;
                case 8:
                    Console.WriteLine(" восемь");
                    break;
                case 9:
                    Console.WriteLine(" девять");
                    break;

            }

            Console.ReadLine();

            // Task 6 //

            Console.WriteLine("Task 6");

            Console.WriteLine("Write first number(a)");
            double firstNumberForSixthTask = double.Parse(Console.ReadLine());

            Console.WriteLine("Write second number(b)");
            double secondNumberForSixthTask = double.Parse(Console.ReadLine());

            Console.WriteLine("Write third number(c)");
            double thirdNumberForSixthTask = double.Parse(Console.ReadLine());

            bool state = firstNumberForSixthTask + secondNumberForSixthTask > thirdNumberForSixthTask && firstNumberForSixthTask + thirdNumberForSixthTask > secondNumberForSixthTask && secondNumberForSixthTask + thirdNumberForSixthTask > firstNumberForSixthTask;

            if (state)
            {
                Console.WriteLine("Triangle exists");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Triangle doesn't exists");
                Console.ReadLine();
            }

            // Task 7 //

            Console.WriteLine("Task 7");

            Console.WriteLine("Write X");

            double firstNumberForSeventhTask = double.Parse(Console.ReadLine());

            double result = 0;

            if (firstNumberForSeventhTask < -7 && firstNumberForSeventhTask > 6)
            {
                Console.WriteLine("функция не определена");
                Console.ReadLine();
            }
            else
            {
                if (firstNumberForSeventhTask >= -7 && firstNumberForSeventhTask < -6)
                {
                    result = -3;
                }
                else if (firstNumberForSeventhTask >= -6 && firstNumberForSeventhTask < -3)
                {
                    result = firstNumberForSeventhTask + 3;
                }
                else if (firstNumberForSeventhTask >= -3 && firstNumberForSeventhTask < 0)
                {
                    result = Math.Sqrt(9 - Math.Pow(firstNumberForSeventhTask, 2));
                }
                else if (firstNumberForSeventhTask >= 0 && firstNumberForSeventhTask < 3)
                {
                    result = 3 - firstNumberForSeventhTask;
                }
                else if (firstNumberForSeventhTask >= 3 && firstNumberForSeventhTask <= 6)
                {
                    result = firstNumberForSeventhTask - 3;
                }
                Console.WriteLine($"Y = {result}");
                Console.ReadLine();
            }
        }  
    }
}
