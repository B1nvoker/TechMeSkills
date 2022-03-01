using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string star = " *";
            string stars = "";

            bool mainState = true;

            while (mainState)
            {
                bool anotherState = true;

                Console.WriteLine("Найдите синус, косинус, тангенс и котангенс угла BAC заданного прямоугольного треугольника.\n" +
                "Пожалуйста введите значения сторон прямоугольного треугольника\n");

                Console.Write("Введите длину катета АВ: ");
                double AB = double.Parse(Console.ReadLine());

                Console.Write("Введите длину катета BC: ");
                double BC = double.Parse(Console.ReadLine());

                Console.Write("Введите длину гипотенузы AC: ");
                double AC = double.Parse(Console.ReadLine());

                double cof = BC / AB;

                if (Math.Pow(AB, 2) + Math.Pow(BC, 2) == Math.Pow(AC, 2))
                {
                    Console.WriteLine("\nЗаданный треугольник:");
                    Console.WriteLine("\nА");
                    Console.WriteLine(star);

                    for (int i = 1; i <= AB - 1; i++)
                    {
                        stars = "";
                        for (int j = 1; j <= (i + 1) * cof; j++)
                        {
                            stars += star;
                        }
                        Console.WriteLine(stars);
                    }

                    string namesOfCorners = "B";
                    for (int i = 0; i < stars.Length; i++)
                    {
                        namesOfCorners += " ";
                    }
                    namesOfCorners += " C";
                    Console.WriteLine(namesOfCorners);

                    Console.WriteLine("\nДля получения ответов нажмите клавишу Enter");
                    Console.ReadLine();

                    Console.WriteLine("Ответы:\n");
                    Console.WriteLine("Синус угла BAC равен: " + Math.Round(BC / AC, 2));
                    Console.WriteLine("Косинус угла BAC равен: " + Math.Round(AB / AC, 2));
                    Console.WriteLine("Тангенс угла BAC равен: " + Math.Round(BC / AB, 2));
                    Console.WriteLine("Котангенс угла BAC равен: " + Math.Round(AB / AC, 2));


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
                else
                {
                    Console.WriteLine("Полученный треугольник не прямоугольный, попробуйте в следующий раз");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
