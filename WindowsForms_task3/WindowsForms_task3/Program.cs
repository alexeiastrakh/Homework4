using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms_task3
{
   public abstract class Triangle
        {
            private double a;
            private double b;
            private double angle;

            public Triangle(double a, double b, double angle)
            {
                if (a < 0 || b < 0 || angle < 0)
                {
                    throw new Exception("value less than or equal to 0");
                }
                double c = Math.Round(Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle)), 2);
                if (a < b + c && b < a + c && c < a + b)
                {
                    this.a = a;
                    this.b = b;
                    this.angle = angle;
                }
                else
                {
                    throw new Exception("Triangle does not exist");
                }
            }

            protected static double ConvertDegreesToRadians(int degrees)
            {
                return Math.Round((degrees * Math.PI) / 180, 2);
            }
            public virtual double Perimeter()
            {
                double c = Math.Round(Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle)), 2);
                double perimeter = a + b + c;
                return perimeter;
            }

            public virtual double Area()
            {
                double area = 0.5 * a * b * Math.Sin(angle);
                return area;
            }
        }
        public class RectangularTriangle : Triangle
        {
            private double a;
            private double b;
            public RectangularTriangle(double a, double b) : base(a, b, ConvertDegreesToRadians(90))
            {
                this.a = a;
                this.b = b;
            }

            public override double Perimeter()
            {
                double c = Math.Round(Math.Sqrt(a * a + b * b), 2);
                double perimeter = a + b + c;
                return perimeter;
            }

            public override double Area()
            {
                double area = Math.Round(0.5 * a * b, 2);
                return area;
            }
        }

        public class IsoscelesTriangle : Triangle
        {
            private double side;
            private double angle;

            public IsoscelesTriangle(double side, int angle) : base(side, side, ConvertDegreesToRadians(angle))
            {
                this.side = side;
                this.angle = ConvertDegreesToRadians(angle);
            }

            public override double Area()
            {
                double area = Math.Round(side * side * 0.5 * Math.Cos(angle), 2);
                return Math.Round(area, 2);
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



