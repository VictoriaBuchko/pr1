using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public abstract class Figure
    {
        public abstract double CalculateArea();

        public override string ToString()
        {
            return $"Плоша фігури: {CalculateArea():F2}";
        }

    }

    public class Rectangle : Figure
    {
        public double Width; 
        public double Height;
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double SetWidth
        {
            get { return Width; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Width = value;
                }
            }
        }

        public double SetHeight
        {
            get { return Height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Height = value;
                }
            }
        }
        

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Квадрат: Ширина = {Width}, Висота = {Height}, Площа = {CalculateArea():F2}";
        }
    }

    public class Circle : Figure
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double SetRadius
        {
            get { return Radius; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Radius = value;
                }
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Круг: Радіус = {Radius}, Площа = {CalculateArea():F2}";
        }
    }

    public class RightTriangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
        public double SetBase
        {
            get { return Base; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Base = value;
                }
            }
        }

        public double SetHeight
        {
            get { return Height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Height = value;
                }
            }
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override string ToString()
        {
            return $"Правильний трикутник: Основа = {Base}, Висота = {Height}, Площа = {CalculateArea():F2}";
        }
    }

    public class Trapezoid : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Height { get; set; }

        public Trapezoid(double side1, double side2, double height)
        {
            Side1 = side1;
            Side2 = side2;
            Height = height;
        }

        public double SetSide1
        {
            get { return Side1; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Side1 = value;
                }
            }
        }

        public double SetSide2
        {
            get { return Side2; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Side2 = value;
                }
            }
        }

        public double SetHeight
        {
            get { return Height; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Значення не може бути менше 0");
                }
                else
                {
                    Height = value;
                }
            }
        }
        public override double CalculateArea()
        {
            return 0.5 * (Side1 + Side2) * Height;
        }

        public override string ToString()
        {
            return $"Трапеція: Основа перша = {Side1}, Основа друга = {Side2}, Висота = {Height}, Площа = {CalculateArea():F2}";
        }
    }
}
