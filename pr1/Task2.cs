using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Task2
    {
        public class Animal
        {
            public string Name { get; set; }
            public double Weight { get; set; }
            public bool IsPredator { get; set; } 

            public Animal(string name, double weight, bool isPredator)
            {
                Name = name;
                Weight = weight;
                IsPredator = isPredator;
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Тварина: {Name},\n Вага: {Weight} кг,\n Хижак: {(IsPredator ? "Так" : "Ні")}");
            }
        }

        public class Tiger : Animal
        {
            public string StripePattern { get; set; } 

            public Tiger(string name, double weight, bool isPredator, string stripePattern)
                : base(name, weight, isPredator)
            {
                StripePattern = stripePattern;
            }
            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Тип смуг: {StripePattern}");
            }
        }


        public class Crocodile : Animal
        {
            public double Length { get; set; } 

            public Crocodile(string name, double weight, bool isPredator, double length)
                : base(name, weight, isPredator)
            {
                Length = length;
            }
            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Довжина: {Length} метрів");
            }
        }


        public class Kangaroo : Animal
        {
            public int JumpDistance { get; set; } 


            public Kangaroo(string name, double weight, bool isPredator, int jumpDistance)
                : base(name, weight, isPredator)
            {
                JumpDistance = jumpDistance;
            }

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Довжина стрибка: {JumpDistance} метрів");
            }
        }
    }
}
