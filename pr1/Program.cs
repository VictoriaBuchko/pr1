using System.Xml.Linq;
using static pr1.Task2;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toy toy = new Toy("Лялька", "Іграшковий світ", 100, "12+", "Україна");
            Console.WriteLine(toy.ToString());

            Toy toy1 = new Toy("Lego", "Іграшковий світ", 1000, "3+", "Україна");
            Toy toy2 = new Toy("Lego", "Іграшковий світ", 1000, "3+", "Україна");

            //Продивляємося який хеш код у кожної іграшки 
            Console.WriteLine($"Хеш код toy: {toy.GetHashCode()}");
            Console.WriteLine($"Хеш код toy1: {toy1.GetHashCode()}");
            Console.WriteLine($"Хеш код toy2: {toy2.GetHashCode()}");
            //Порівнюємо хеш код
            Console.WriteLine($"Хеш код toy1 равен ли toy2: {toy1.GetHashCode() == toy2.GetHashCode()}");
            Console.WriteLine($"Хеш код toy равен ли toy2: {toy.GetHashCode() == toy2.GetHashCode()}");

            //Використання перевірок у сетерах 
            Toy toy3 = new Toy("Lego", "Іграшковий світ", 1000, "3+", "Україна");
            Console.WriteLine(toy3.ToString());

            toy3.AgeCategory = "5+";
            toy3.ManufacturingPlace = "Германія";
            toy3.Price = 1200;

            Console.WriteLine(toy3.ToString());

            //Перевіряємо чи спіпадають характеристики об'єкта за допомогою метода Equals
            if (toy1.Equals(toy2))
            {
                Console.WriteLine("Дорівнюють ");
            }
            else
            {
                Console.WriteLine("Не дорівнюють");
            }


            Console.WriteLine("\n\n2 Завдання");
            Tiger tiger = new Tiger("Тигр", 220.5, true, "Чорно-помаранчеві смуги");
            Crocodile crocodile = new Crocodile("Крокодил", 500.2, true, 5.5);
            Kangaroo kangaroo = new Kangaroo("Кенгуру", 85.0, false, 12);



            Console.WriteLine(tiger.ToString());
            Console.WriteLine();

            Console.WriteLine(crocodile.ToString());
            Console.WriteLine();

            Console.WriteLine(kangaroo.ToString());


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
