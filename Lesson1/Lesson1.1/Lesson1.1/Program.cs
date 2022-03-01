using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string star = " *";
            string stars;

            bool mainState = true;

            while (mainState)
            {
                bool anotherState = true;

                Console.WriteLine("Найдите площадь и периметр квадрата заданного квадрата.\n" +
                "\nПожалуйста введите значение стороны квадрата\n");

                int side = int.Parse(Console.ReadLine());

                Console.WriteLine("\nЗаданный квадрат:");

                for (int i = 0; i < side; i++)
                {
                    stars = "";
                    for (int j = 0; j < side; j++)
                    {
                        stars += star;
                    }
                    Console.WriteLine(stars);
                }

                Console.WriteLine("\nДля получения ответов нажмите клавишу Enter");
                Console.ReadLine();

                Console.WriteLine("Ответы:\n");
                Console.WriteLine("Площадь квадрата равна: " + Math.Pow(side, 2));
                Console.WriteLine("Периметр квадрата равен: " + side * 4);

                while (anotherState)
                {
                    Console.WriteLine("\nХотите попробывать решить еще раз? (Да/Нет)");
                    string answer = Console.ReadLine();
                    Console.Clear();

                    if (answer == "Нет")
                    {
                        anotherState = false;
                        mainState = false;
                    }
                    else if (answer == "Да")
                    {
                        anotherState = false;
                    }
                }
            }
        }
    }
}

