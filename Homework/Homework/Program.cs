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
        #region Task6
        private static void checkIftriagle()
        {
            Console.WriteLine("Task 6");

            Console.WriteLine("Write first number(a)");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Write second number(b)");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Write third number(c)");
            double thirdNumber = double.Parse(Console.ReadLine());

            bool state = Lesson3.checkIfTriagle(firstNumber, secondNumber, thirdNumber);

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
        }
        #endregion
        #region Task7
        private static void whereYInGraph()
        {
            Console.WriteLine("Task 7");

            Console.WriteLine("Write X");

            double firstNumber= double.Parse(Console.ReadLine());
            string res = Lesson3.whereYInGraph(firstNumber);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        #endregion

        #endregion

        #region Lesson4

        #region Task1
        private static void getNumbersDivideOnNumber()
        {
            Console.WriteLine("Task 1");

            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());

            int[] arr = Lesson4.getArrOfNumbersDivOnNumber(number);

            Helper.printArray(arr);
        }
        #endregion
        #region Task2
        private static void getCountOfPositiveNumbersInArray()
        {
            Console.WriteLine("\nTask 2\n");
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            int result = Lesson4.getCountOfPositiveNumbersInArray(number);
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion
        #region Task3
        private static void geLargestDivisor()
        {
            Console.WriteLine("\nTask 3\n");
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            int result = Lesson4.geLargestDivisor(number);
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion
        #region Task4
        private static void getSumOfNumbersThatDivOnSeven()
        {
            Console.WriteLine("\nTask 4\n");
            Console.Write("Write first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int result = Lesson4.getSumOfNumbersThatDivOnSeven(firstNumber, secondNumber);
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion
        #region Task5
        private static void hetLargestGeneralDivider()
        {
            Console.WriteLine("\nTask 5\n");
            Console.Write("Write first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int result = Lesson4.getLargestGeneralDivider(firstNumber, secondNumber);
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion
        #region Task7
        private static void getNumberOfOddDigits()
        {
            Console.WriteLine("\nTask 7\n");
            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());
            int result = Lesson4.getNumberOfOddDigits(number);
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion
        #region Task8
        private static void getReverseOfNumber()
        {
            Console.WriteLine("\nTask 8\n");
            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());
            int result = Lesson4.getReverseOfNumber(number);
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #region Task9
        private static void getNumbersSumOfDigits()
        {
            Console.WriteLine("\nTask 9\n");
            Console.Write("Write number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Result: ");
            Lesson4.getNumbersSumOfDigits(number);
            Console.ReadLine();
        }
        #endregion

        #region Task10
        private static void getTrueIfTheSameDigits()
        {
            Console.WriteLine("\nTask 10\n");
            Console.Write("Write first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            bool result = Lesson4.getTrueIfTheSameDigits(firstNumber, secondNumber);
            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        #endregion

        #endregion

        #region Lesson5



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
            //checkIftriagle();
            //whereYInGraph();
            #endregion
            #region Lesson4
            //getNumbersDivideOnNumber();
            //getCountOfPositiveNumbersInArray();
            //geLargestDivisor();
            //getSumOfNumbersThatDivOnSeven();
            //hetLargestGeneralDivider();
            //getNumberOfOddDigits();
            //getReverseOfNumber();
            //getNumbersSumOfDigits();
            //getTrueIfTheSameDigits();
            #endregion
            #region Lesson5



            #endregion


        }
    }
}
