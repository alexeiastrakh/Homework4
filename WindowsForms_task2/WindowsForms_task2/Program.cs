using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_task2
{
    abstract public class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
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
                throw new Exception("figure cannot exist");
            }
        }

        public override double Perimeter()
        {
            return this.a + this.b + this.c;
        }

        public override double Area()
        {
            double p = (double)(this.a + this.b + this.c) / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }
    }

    public class Circle : Figure
    {
        private double radius;

        public Circle(double r)
        {
            if (r > 0)
            {
                this.radius = r;
            }
            else
            {
                throw new Exception("Values less than or equal to 0");
            }

        }

        public override double Perimeter()
        {
            return this.radius * 2 * Math.PI;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
    }

    public class Rectangle : Figure
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                throw new Exception("Values less than or equal to 0");
            }

        }

        public override double Perimeter()
        {
            return 2 * this.a + 2 * this.b;
        }

        public override double Area()
        {
            return this.a * this.b;
        }
    }

    public class Square : Figure
    {
        private double side;
        public Square(double a)
        {
            if (a > 0)
            {
                this.side = a;
            }
            else
            {
                throw new Exception("Values less than or equal to 0");
            }
        }

        public override double Perimeter()
        {
            return 4 * this.side;
        }


        public override double Area()
        {
            return this.side * this.side;
        }
    }

    public class Rhombus : Figure
    {
        private double A;
        private double ang;

        public Rhombus(double A, double ang)
        {
            if (A > 0 && ang > 0)
            {
                this.A = A;
                this.ang = ang;
            }
            else
            {
                throw new Exception("Values less than or equal to 0");
            }
        }

        public override double Perimeter()
        {
            return 4 * this.A;
        }

        public override double Area()
        {
            return Math.Pow(this.A, 2) * Math.Sin(this.ang);
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
