using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        #region Lesson1

        #region Task1
        private static void getAreaAndPerimetrSquare()
        {
            Console.WriteLine("Task 1");
            Console.Write("Найдите площадь и периметр квадрата заданного квадрата.\nПожалуйста введите значение стороны квадрата: ");

            int side = int.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь равна: {Lesson1.GetArea(side)}\nПериметр равен: {Lesson1.GetPerimetr(side)} ");
            Console.ReadLine();
        }
        #endregion
        #region Task2
        private static void getAreaAndPerimetrRectangle()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Найдите площадь и периметр заданного прямоугольника.\nПожалуйста введите значение сторон прямоугольника:");

            Console.Write("Введите длину прямоугольника: ");
            int heigth = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            int wide = int.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь равна: {Lesson1.GetArea(heigth, wide)}\nПериметр равен: {Lesson1.GetPerimetr(heigth, wide)} ");
            Console.ReadLine();
        }
        #endregion
        #region Task3
        private static void getSinCosTgCtgOfЕriangle()
        {
            Console.WriteLine("Task 3");
            Console.WriteLine("Найдите синус, косинус, тангенс и котангенс угла BAC заданного прямоугольного треугольника.\nПожалуйста введите значения сторон прямоугольного треугольника");

            Console.Write("Введите длину катета АВ: ");
            double AB = double.Parse(Console.ReadLine());

            Console.Write("Введите длину катета BC: ");
            double BC = double.Parse(Console.ReadLine());

            Console.Write("Введите длину гипотенузы AC: ");
            double AC = double.Parse(Console.ReadLine());

            if (Math.Pow(AB, 2) + Math.Pow(BC, 2) == Math.Pow(AC, 2))
            {
                Console.WriteLine($"Синус равен: {Lesson1.GetSin(BC, AC)}");
                Console.WriteLine($"Косинус равен: {Lesson1.GetCos(AB, AC)}");
                Console.WriteLine($"Таннгенс равен: {Lesson1.GetTg(AB, BC)}");
                Console.WriteLine($"Котангенс равен: {Lesson1.GetCtg(AB, AC)}");
            }
            else
            {
                Console.WriteLine("Полученный треугольник не прямоугольный, попробуйте в следующий раз");
                Console.ReadLine();
                Console.Clear();
            }
        }
        #endregion

        #endregion

        #region Lesson2

        #region Task1
        private static void getSumOfDigitsOfNumber()
        {
            Console.WriteLine("Task 1");

            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());

            int[] arrayOfDigitsOfNumber = Lesson2.getArrayOfDigitsOfNumber(number);
            int sumOfDigitsOfArray = Lesson2.getSumOfDigitsOfNumber(arrayOfDigitsOfNumber);

            Console.WriteLine($"The sum of the digits of the number {number} is: {sumOfDigitsOfArray}");
            Console.ReadLine();
        }
        #endregion
        #region Task2
        private static void didTheShotHitTheTarget()
        {
            Console.WriteLine("Task 2");

            Console.Write("Please write x1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Please write y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Please write radius: ");
            int radius = int.Parse(Console.ReadLine());

            bool state = Lesson2.didTheShotHitTheTarget(x1, y1, radius);

            Console.Write($"Result: {state}");
            Console.ReadLine();
        }
        #endregion
        #region Task3
        private static void comparisonOfNumbersOfChills()
        {
            Console.WriteLine("Task 3");

            Console.Write("Please write number: ");
            int number = int.Parse(Console.ReadLine());

            int[] arrayOfDigitsOfNumber = Lesson2.getArrayOfDigitsOfNumber(number);
            bool state = Lesson2.didTheSecondNumberMoreThanFirstAndLessThanThird(arrayOfDigitsOfNumber);

            Console.WriteLine($"Result {state}");
            Console.ReadLine();
        }

        #endregion
        #region Task4
        private static void reverseFirstAndLastNumber()
        {
            Console.WriteLine("Task 4");

            Console.Write("Please write number: ");
            int number = int.Parse(Console.ReadLine());

            int[] arrayOfDigitsOfNumber = Lesson2.getArrayOfDigitsOfNumber(number);
            int result = Lesson2.reverseFirstAndLastNumber(arrayOfDigitsOfNumber);

            Console.Write($"Result: {result}");
            Console.ReadLine();
        }

        #endregion
        #region Task5
        private static void checkZeroFractionalPart()
        {
            Console.WriteLine("Task 5");

            Console.Write("Please write number: ");
            double number = double.Parse(Console.ReadLine());

            bool state = Lesson2.didZeroFractionalPart(number);

            Console.Write($"Result: {state}");
            Console.ReadLine();
        }

        #endregion

        #endregion

        #region Lesson3

        #region Task1
        private static void countTwoNumber()
        {
            Console.WriteLine("Task 1");

            Console.Write("Write first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Write second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = Lesson3.countTwoNumbers(firstNumber, secondNumber);

            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
        #endregion
        #region Task2
        private static void getWhatQuarterIsNumberIn()
        {
            Console.WriteLine("Task 2");

            Console.WriteLine("Write first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int result = Lesson3.getWhatQuarterIsNumberIn(firstNumber, secondNumber);

            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
        #endregion
        #region Task3
        private static void sortTreeNumbers()
        {
            Console.WriteLine("Task 3");

            Console.WriteLine("Write first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Write third number");
            int thirdNumber = int.Parse(Console.ReadLine());

            int[] numbers = Lesson3.sortTreeNumbers(firstNumber, secondNumber, thirdNumber);

            Helper.printArray(numbers);
        }
        #endregion
        #region Task4
        private static void findRoots()
        {
            Console.WriteLine("Task 4");

            Console.Write("Write first number(a): ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Write second number(b): ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Write third number(c): ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double[] numbers = Lesson3.findRoots(firstNumber, secondNumber, thirdNumber);

            if (numbers == null)
            {
                Console.WriteLine("No roots");
                Console.ReadLine();
            }
            else
            {
                Helper.printArray(numbers);
            }
        }
        #endregion
        #region Task5
        private static void renameNumbersAsString()
        {
            Console.WriteLine("Task 5");

            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());
            string result = Lesson3.renameNumbersAsStrind(number);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #endregion
        static void Main(string[] args)
        {
            #region Lesson1
            //getAreaAndPerimetrSquare();
            //getAreaAndPerimetrRectangle();
            //getSinCosTgCtgOfЕriangle();
            #endregion
            #region Lesson2
            //getSumOfDigitsOfNumber();
            //didTheShotHitTheTarget();
            //comparisonOfNumbersOfChills();
            //reverseFirstAndLastNumber();
            //checkZeroFractionalPart();
            #endregion
            #region Lesson3
            //countTwoNumber();
            //getWhatQuarterIsNumberIn();
            //sortTreeNumbers();
            //findRoots();
            //renameNumbersAsString();
            #endregion


        }
    }
}
