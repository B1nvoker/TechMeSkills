using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Lesson1
    {
        public static int GetArea(int side)
        {
            return (int)Math.Pow(side, 2);
        }
        public static int GetArea(int heigth, int wide)
        {
            return heigth * wide;
        }

        public static int GetPerimetr(int side)
        {
            return side * 4;
        }
        public static int GetPerimetr(int heigth, int wide)
        {
            return (heigth + wide) * 2;
        }

        public static double GetSin(double AB, double BC, double AC)
        {
            return Math.Round(BC / AC, 2);
        }
        public static double GetCos(double AB, double BC, double AC)
        {
            return Math.Round(AB / AC, 2);
        }
        public static double GetTg(double AB, double BC, double AC)
        {
            return Math.Round(BC / AB, 2);
        }
        public static double GetCtg(double AB, double BC, double AC)
        {
            return Math.Round(AB / AC, 2);
        }
    }
}
