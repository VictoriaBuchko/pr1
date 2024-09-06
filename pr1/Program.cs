using System.Xml.Linq;
using static pr1.Task2;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toy toy = new Toy("Лялька", "Іграшковий світ", 100, "12+", "Україна");
            toy.GetInfo();


            Console.WriteLine("\n\n2 Завдання");
            Tiger tiger = new Tiger("Тигр", 220.5, true, "Чорно-помаранчеві смуги");
            Crocodile crocodile = new Crocodile("Крокодил", 500.2, true, 5.5);
            Kangaroo kangaroo = new Kangaroo("Кенгуру", 85.0, false, 12);


            tiger.GetInfo();
            Console.WriteLine();
            crocodile.GetInfo();
            Console.WriteLine();
            kangaroo.GetInfo();
            Console.WriteLine("\n\n3 Завдання");

            Rectangle rectangle = new Rectangle(5, 10);
            Circle circle = new Circle(7);
            RightTriangle triangle = new RightTriangle(6, 8);
            Trapezoid trapezoid = new Trapezoid(4, 6, 5);


            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(circle.ToString());
            Console.WriteLine(triangle.ToString());
            Console.WriteLine(trapezoid.ToString());

        }
    }
}
