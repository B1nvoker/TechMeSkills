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
        public static int getReverseOfNumber(int number)
        {
            int temp = 1;
            int digits = (int)Math.Log10(number);
            int temp2 = (int)Math.Pow(10, digits);
            int result = 0;
            while (temp < number)
            {
                int digit = number / temp % 10;
                result += digit * temp2;
                temp *= 10;
                temp2 /= 10;
            }
            return result;
        }
        public static void getNumbersSumOfDigits(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int temp = 1;
                int sumOfEvenNumbers = 0;
                int sumOfOddDigits = 0;

                while (temp <= i)
                {
                    int digit = i / temp % 10;
                    if (digit % 2 == 0)
                    {
                        sumOfEvenNumbers += digit;
                    }
                    else
                    {
                        sumOfOddDigits += digit;
                    }

                    temp *= 10;
                }
                if (sumOfEvenNumbers > sumOfOddDigits)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static bool getTrueIfTheSameDigits(int firstNumber, int secondNumber)
        {
            bool result = false;
            int firstTemp= 1;
            int secondTemp = 1;

            while (firstTemp <= firstNumber)
            {
                int digit = firstNumber / firstTemp % 10;
                while (secondTemp <= secondNumber)
                {
                    int digit2 = secondNumber / secondTemp % 10;
                    secondTemp *= 10;
                    if (digit == digit2)
                    {
                        result = true;
                        return result;
                    } 
                }
                if (result)
                {
                    break;
                }
                secondTemp = 1;
                firstTemp *= 10;
            }
            return result;
        }
    }
}
