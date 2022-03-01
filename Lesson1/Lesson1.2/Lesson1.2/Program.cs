using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._2
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

                Console.WriteLine("Найдите площадь и периметр заданного прямоугольника.\n" +
                "\nПожалуйста введите значение сторон прямоугольника:\n");

                Console.Write("Введите длину квадрата: ");
                int heigth = int.Parse(Console.ReadLine());

                Console.Write("Введите ширину квадрата: ");
                int wide = int.Parse(Console.ReadLine());

                Console.WriteLine("\nЗаданный квадрат:");

                for (int i = 0; i < wide; i++)
                {
                    stars = "";
                    for (int j = 0; j < heigth; j++)
                    {
                        stars += star;
                    }
                    Console.WriteLine(stars);
                }

                Console.WriteLine("\nДля получения ответов нажмите клавишу  Enter");
                Console.ReadLine();

                Console.WriteLine("Ответы:\n");
                Console.WriteLine("Площадь квадрата равна: " + heigth * wide);
                Console.WriteLine("Периметр квадрата равен: " + (heigth + wide) * 2);

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
