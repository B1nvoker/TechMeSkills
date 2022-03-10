using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 //
             Console.WriteLine("Task 1");
             
             Console.WriteLine("Write first number");
             int firstNumberForFirstTask = int.Parse(Console.ReadLine());

             Console.WriteLine("Write second number");
             int secondNumberForFirstTask = int.Parse(Console.ReadLine());

             int resultForFirstTask;

             if (firstNumberForFirstTask != secondNumberForFirstTask)
             {
                 if (firstNumberForFirstTask < secondNumberForFirstTask)
                 {
                     resultForFirstTask = firstNumberForFirstTask - secondNumberForFirstTask;
                 }
                 else
                 {
                     resultForFirstTask = secondNumberForFirstTask + firstNumberForFirstTask;
                 }
             }
             else
             {
                 resultForFirstTask = firstNumberForFirstTask * secondNumberForFirstTask;
             }
             Console.WriteLine($"Result: {resultForFirstTask}");
             Console.ReadLine();

            // Task 2 //

            Console.WriteLine("Task 2");
            
            Console.WriteLine("Write first number");
            int firstNumberForSecondTask = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second number");
            int secondNumberForSecondTask = int.Parse(Console.ReadLine());

            if(firstNumberForSecondTask > 0 && secondNumberForSecondTask > 0)
            {
                Console.WriteLine("Point located in first area");
            }
            if (firstNumberForSecondTask < 0 && secondNumberForSecondTask > 0)
            {
                Console.WriteLine("Point located in forth area");
            }
            if (firstNumberForSecondTask > 0 && secondNumberForSecondTask < 0)
            {
                Console.WriteLine("Point located in second area");
            }
            if (firstNumberForSecondTask < 0 && secondNumberForSecondTask < 0)
            {
                Console.WriteLine("Point located in third area");
            }
            if(firstNumberForSecondTask == 0 && secondNumberForSecondTask == 0)
            {
                Console.WriteLine("Point located in center");
            }
            Console.ReadLine();

            // Task 3 //

            Console.WriteLine("Task 3");

            Console.WriteLine("Write first number");
            int firstNumberForThirdTask = int.Parse(Console.ReadLine());

            Console.WriteLine("Write second number");
            int secondNumberForThirdTask = int.Parse(Console.ReadLine());

            Console.WriteLine("Write third number");
            int thirdNumberForThirdTask = int.Parse(Console.ReadLine());

            if (firstNumberForThirdTask <= secondNumberForThirdTask && firstNumberForThirdTask <= thirdNumberForThirdTask)
            {
                Console.Write(firstNumberForThirdTask);

                if (secondNumberForThirdTask < thirdNumberForThirdTask)
                {
                    Console.Write(secondNumberForThirdTask);
                    Console.Write(thirdNumberForThirdTask);
                }
                else
                {
                    Console.Write(thirdNumberForThirdTask);
                    Console.Write(secondNumberForThirdTask);
                }
            }
            else if (secondNumberForThirdTask <= firstNumberForThirdTask && secondNumberForThirdTask <= thirdNumberForThirdTask)
            {
                Console.Write(secondNumberForThirdTask);

                if (firstNumberForThirdTask < thirdNumberForThirdTask)
                {
                    Console.Write(firstNumberForThirdTask);
                    Console.Write(thirdNumberForThirdTask);
                }
                else
                {
                    Console.Write(thirdNumberForThirdTask);
                    Console.Write(firstNumberForThirdTask);
                }
            }
            else if (thirdNumberForThirdTask <= secondNumberForThirdTask && thirdNumberForThirdTask <= firstNumberForThirdTask)
            {
                Console.Write(thirdNumberForThirdTask);

                if (secondNumberForThirdTask < firstNumberForThirdTask)
                {
                    Console.Write(secondNumberForThirdTask);
                    Console.Write(firstNumberForThirdTask);
                }
                else
                {
                    Console.Write(firstNumberForThirdTask);
                    Console.Write(secondNumberForThirdTask);
                }
            }

            Console.ReadLine();

            // Task 4 //

            Console.WriteLine("Task 4");

            Console.WriteLine("Write first number(a)");
            double firstNumberForForthTask = double.Parse(Console.ReadLine());

            Console.WriteLine("Write second number(b)");
            double secondNumberForForthTask = double.Parse(Console.ReadLine());

            Console.WriteLine("Write third number(c)");
            double thirdNumberForForthTask = double.Parse(Console.ReadLine());

            double Discriminant = Math.Pow(secondNumberForForthTask, 2) - (4 * firstNumberForForthTask * thirdNumberForForthTask);

            if (Discriminant != 0)
            {
                if(Discriminant < 0)
                {
                    Console.WriteLine("No roots");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Two roots");
                    double resulFirstForForthTask = (-secondNumberForForthTask + Math.Sqrt(Discriminant)) / (2 * firstNumberForForthTask);
                    double resulSecondForForthTask = (-secondNumberForForthTask - Math.Sqrt(Discriminant)) / (2 * firstNumberForForthTask);
                    Console.WriteLine($"First: {resulFirstForForthTask}\nSecond: {resulSecondForForthTask}");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("One root");
                double resultForForthTask = -secondNumberForForthTask / (2 * firstNumberForForthTask);
                Console.WriteLine($"First: {resultForForthTask}");
                Console.ReadLine();
            }

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
