using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ten = 10;
            const int hundred = 100;

            // Task 1 //
            Console.WriteLine("Task 1");

            const int numForFirstTask = 123;

            int firstNumberForFirstTask = numForFirstTask / hundred;
            int secondNumberForFirstTask = numForFirstTask / ten - firstNumberForFirstTask * ten;
            int thirdNumberForFirstTask = numForFirstTask - firstNumberForFirstTask * hundred - secondNumberForFirstTask * ten;
            int resultForFirstTask = firstNumberForFirstTask + secondNumberForFirstTask + thirdNumberForFirstTask;
            Console.WriteLine($"The sum of the digits of the number {numForFirstTask} is: {resultForFirstTask}");
            Console.WriteLine("Please press Enter to continue.");
            Console.ReadLine();

            // Task 2 //
            Console.WriteLine("Task 2");

            Console.Write("Please write x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Please write y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Please write radius: ");
            int radius = int.Parse(Console.ReadLine());

            bool stateForSecondTask = Math.Pow(x1, 2) + Math.Pow(x1, 2) < Math.Pow(radius, 2);

            Console.Write("Result:");
            Console.WriteLine(stateForSecondTask);
            Console.WriteLine("Please press Enter to continue.");
            Console.ReadLine();

            // Task 3 //
            Console.WriteLine("Task 3");

            Console.Write("Please write number: ");
            int numForSecondTask = int.Parse(Console.ReadLine());

            int firstNumberForThirdTask = numForSecondTask / hundred;
            int secondNumberForThirdTask = numForSecondTask / ten - firstNumberForThirdTask * ten;
            int thirdNumberForThirdTask = numForSecondTask - firstNumberForThirdTask * hundred - secondNumberForThirdTask * ten;

            bool stateForThirdTask = secondNumberForThirdTask <= firstNumberForThirdTask && secondNumberForThirdTask > thirdNumberForThirdTask;

            Console.Write("Result:");
            Console.WriteLine(stateForThirdTask);
            Console.WriteLine("Please press Enter to continue.");
            Console.ReadLine();

            // Task 4 //
            Console.WriteLine("Task 4");

            Console.Write("Please write number: ");
            int numberForForthTask = int.Parse(Console.ReadLine());

            int firstNumberForForthTask = numberForForthTask / hundred;
            int secondNumberForForthTask = numberForForthTask / ten - firstNumberForForthTask * ten;
            int thirdNumberForForthTask = numberForForthTask - firstNumberForForthTask * hundred - secondNumberForForthTask * ten;

            int resultForForthTask = thirdNumberForForthTask * hundred + secondNumberForForthTask * ten + firstNumberForForthTask;

            Console.Write("Result:");
            Console.WriteLine(resultForForthTask);
            Console.WriteLine("Please press Enter to continue.");
            Console.ReadLine();

            // Task 5 //
            Console.WriteLine("Task 5");

            Console.Write("Please write number: ");
            double numberForFifthTask = double.Parse(Console.ReadLine());
            int temp = (int)numberForFifthTask;

            bool stateForFifthTask = numberForFifthTask % temp == 0;

            Console.Write("Result:");
            Console.WriteLine(stateForFifthTask);
            Console.WriteLine("Please press Enter to end.");
            Console.ReadLine();
        }
    }
}
