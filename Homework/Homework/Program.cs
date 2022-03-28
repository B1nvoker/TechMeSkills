using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lesson1

            #region Task1
            Console.Write("Найдите площадь и периметр квадрата заданного квадрата.\nПожалуйста введите значение стороны квадрата: ");

            int side = int.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь равна: {Lesson1.GetArea(side)}\nПериметр равен: {Lesson1.GetPerimetr(side)} ");
            Console.ReadLine();
            #endregion

            #region Task2
            Console.WriteLine("Найдите площадь и периметр заданного прямоугольника.\nПожалуйста введите значение сторон прямоугольника:");

            Console.Write("Введите длину прямоугольника: ");
            int heigth = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            int wide = int.Parse(Console.ReadLine());

            Console.WriteLine($"Площадь равна: {Lesson1.GetArea(heigth, wide)}\nПериметр равен: {Lesson1.GetPerimetr(heigth, wide)} ");
            Console.ReadLine();
            #endregion

            #region Task3
            Console.WriteLine("Найдите синус, косинус, тангенс и котангенс угла BAC заданного прямоугольного треугольника.\nПожалуйста введите значения сторон прямоугольного треугольника");

            Console.Write("Введите длину катета АВ: ");
            double AB = double.Parse(Console.ReadLine());

            Console.Write("Введите длину катета BC: ");
            double BC = double.Parse(Console.ReadLine());

            Console.Write("Введите длину гипотенузы AC: ");
            double AC = double.Parse(Console.ReadLine());

            if (Math.Pow(AB, 2) + Math.Pow(BC, 2) == Math.Pow(AC, 2))
            {
                Console.WriteLine($"Синус равен: {Lesson1.GetSin(AB, BC, AC)}");
                Console.WriteLine($"Косинус равен: {Lesson1.GetCos(AB, BC, AC)}");
                Console.WriteLine($"Таннгенс равен: {Lesson1.GetTg(AB, BC, AC)}");
                Console.WriteLine($"Котангенс равен: {Lesson1.GetCtg(AB, BC, AC)}");
            }
            else
            {
                Console.WriteLine("Полученный треугольник не прямоугольный, попробуйте в следующий раз");
                Console.ReadLine();
                Console.Clear();
            }
            #endregion

            #endregion

            #region Lesson2

            #endregion
        }
    }
}
