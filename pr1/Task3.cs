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
            return $"Figure with area: {CalculateArea():F2}";
        }


        public override int GetHashCode()
        {
            return CalculateArea().GetHashCode();
        }
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"Rectangle: Width = {Width}, Height = {Height}, Area = {CalculateArea():F2}";
        }
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"Circle: Radius = {Radius}, Area = {CalculateArea():F2}";
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

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override string ToString()
        {
            return $"RightTriangle: Base = {Base}, Height = {Height}, Area = {CalculateArea():F2}";
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

        public override double CalculateArea()
        {
            return 0.5 * (Side1 + Side2) * Height;
        }

        public override string ToString()
        {
            return $"Trapezoid: Side1 = {Side1}, Side2 = {Side2}, Height = {Height}, Area = {CalculateArea():F2}";
        }
    }
}
