using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Lesson2
    {
        public static int[] getArrayOfDigitsOfNumber(int number)
        {
            int[] digits = new int[number.ToString().Length];
            int temp = 1;
            int i = 0;

            while (temp < number)
            {
                int digit = number / temp % 10;
                digits[i] = digit;
                temp *= 10;
                i++;
            }
            return digits;
        }
        public static int getSumOfDigitsOfNumber(int[] arrOfDigits)
        {
            int sum = 0;
            foreach (int i in arrOfDigits)
            {
                sum += i;
            }
            return sum;
        }
        public static bool didTheShotHitTheTarget(int x1, int y1, int radius)
        {
            return Math.Pow(x1, 2) + Math.Pow(y1, 2) < Math.Pow(radius, 2);
        }
        public static bool didTheSecondNumberMoreThanFirstAndLessThanThird(int[] arrOfDigitsOfNumber)
        {
            return arrOfDigitsOfNumber[1] <= arrOfDigitsOfNumber[2] && arrOfDigitsOfNumber[1] > arrOfDigitsOfNumber[0];
        }
        public static int reverseFirstAndLastNumber(int[] arrOfDigitsOfNumber)
        {
            return arrOfDigitsOfNumber[0] * 100 + arrOfDigitsOfNumber[1] * 10 + arrOfDigitsOfNumber[2];
        }
        public static bool didZeroFractionalPart(double number)
        {
            return number % (int)number == 0;
        }
    }
}
