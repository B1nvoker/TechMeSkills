using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Lesson4
    {
        public static int[] getArrOfNumbersDivOnNumber(int number)
        {
            int[] arr = new int[1000 / number];
            int j = 0;
            for (int i = number; i <= 1000; i += number)
            {
                arr[j] = i;
                j++;
            }
            return arr;
        }

        public static int getCountOfPositiveNumbersInArray(int number)
        {
            int result = 0;
            for (int i = 1; i < number / 2; i++)
            {
                if (Math.Pow(i, 2) < number)
                {
                    result++;
                }
            }
            return result;
        }

        public static int geLargestDivisor(int number)
        {
            int result = number / 2;

            while (number % result == 0)
            {
                result--;
            }
            return result;
        }

        public static int getSumOfNumbersThatDivOnSeven(int firstNumber, int secondNumber)
        {
            int result = 0;
            if (firstNumber > secondNumber)
            {
                for (int i = secondNumber; i < firstNumber; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }
            else if (firstNumber < secondNumber)
            {
                for (int i = firstNumber; i < secondNumber; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                result = firstNumber;
            }
            return result;
        }

        public static int getLargestGeneralDivider(int firstNumber, int secondNumber)
        {
            while (firstNumber != 0 || secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    if (secondNumber == 0)
                    { break; }
                    firstNumber = firstNumber % secondNumber;
                }
                else
                {
                    if (firstNumber == 0)
                    { break; }
                    secondNumber = secondNumber % firstNumber;
                }
            }
            return firstNumber + secondNumber;
        }

        public static int getNumberOfOddDigits(int number)
        {
            int temp = 1;
            int result = 0;
            while (temp < number)
            {
                int digit = number / temp % 10;
                if (digit % 2 != 0)
                {
                    result++;
                }
                temp *= 10;
            }
            return result;
        }
        public static void les4()
        {
            {
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
                    secondTempForSevenththTask /= 10;
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
                        if (digit == digit2)
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
}
