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
        private static double findDiscriminant(double firstNumber, double secondNumber, double thirdNumber)
        {
            return Math.Pow(secondNumber, 2) - (4 * firstNumber * thirdNumber);
        }
        private static double[] findIfTwoRoots(double firstNumber, double secondNumber, double Discriminant)
        {
            double[] roots = new double[2];
            double resulFirst = (-secondNumber + Math.Sqrt(Discriminant)) / (2 * firstNumber);
            roots[0] = resulFirst;
            double resulSecond = (-secondNumber - Math.Sqrt(Discriminant)) / (2 * firstNumber);
            roots[1] = resulSecond;
            return roots;
        }
        private static double[] findIfOneRoots(double firstNumber, double secondNumber)
        {
            double[] root = new double[1];
            root[0] = -secondNumber / (2 * firstNumber);
            return root;
        }
        public static double[] findRoots(double firstNumber, double secondNumber, double thirdNumber)
        {
            double Discriminant = findDiscriminant(firstNumber, secondNumber, thirdNumber);

            if (Discriminant != 0)
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
        public static string renameNumbersAsStrind(int number)
        {
            int ten = 10;

            int dozens = number / ten;
            int units = number - dozens * ten;

            if (dozens == 1)
            {
                units = 0;
            }

            string result = "Ноль";

            switch (number)
            {
                case 11:
                    return "Одиннадцать";
                case 12:
                    return "Двенадцать";
                case 13:
                    return "Тринадцать";
                case 14:
                    return "Четырнадцать";
                case 15:
                    return "Пятнадцать";
                case 16:
                    return "Шестнадцать";
                case 17:
                    return "Семнадцать";
                case 18:
                    return "Восемнадцать";
                case 19:
                    return "Девятнадцать";
            }

            switch (dozens)
            {
                case 2:
                    result = "Двадцать";
                    break;
                case 3:
                    result = "Тридцать";
                    break;
                case 4:
                    result = "Сорок";
                    break;
                case 5:
                    result = "Пятьдесят";
                    break;
                case 6:
                    result = "Шестьдесят";
                    break;
                case 7:
                    result = "Семьдесят";
                    break;
                case 8:
                    result = "Восемьдесят";
                    break;
                case 9:
                    result = "Девяносто";
                    break;
            }

            switch (units)
            {
                case 1:
                    return result += " один";
                case 2:
                    return result += " два";
                case 3:
                    return result += " три";
                case 4:
                    return result += " четыре";
                case 5:
                    return result += " пять";
                case 6:
                    return result += " шесть";
                case 7:
                    return result += " семь";
                case 8:
                    return result += " восемь";
                case 9:
                    return result += " девять";
            }
            return result;
        }
        public static void lesson3()
        {

            // Task 5 //


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
