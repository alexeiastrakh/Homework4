using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms_task1
{
    public class Triangle
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Values less than or equal to 0");
            }
            if (a < b + c && b < a + c && c < a + b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("triangle does not exist");
            }

        }

        public double A
        {
            get { return a; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Values less than or equal to 0");
                }
                else
                {
                    a = value;
                }
            }
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Values less than or equal to 0");
                }
                else
                {
                    b = value;
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Values less than or equal to 0");
                }
                else
                {
                    c = value;
                }
            }
        }
        public double AngleA()
        {
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b));
        }
        public double AngleB()
        {
            return Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * c * b));
        }
        public double AngleC()
        {
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c));
        }
        public double Perimeter()
        {
            return a + b + c;
        }
    }

    public class EquilateralTriangle : Triangle
    {
        public double square;

        public EquilateralTriangle(double side)
            : base(side, side, side)
        {
            if (side < 0)
            {
                throw new Exception("Values less than or equal to 0");
            }
        }
        public double PerimeterEquilateralTriangle()
        {
            return a + b + c;
        }
        public double SquareEquilateralTriangle()
        {
            return a * a * Math.Sqrt(3) / 4;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
