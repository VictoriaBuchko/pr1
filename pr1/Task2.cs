using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            public double Weight;
            public bool IsPredator { get; set; } 

            public Animal(string name, double weight, bool isPredator)
            {
                Name = name;
                Weight = weight;
                IsPredator = isPredator;
            }

            public double SetWeight
            {
                get { return Weight; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Значення не може бути менше 0");
                    }
                    else
                    {
                        Weight = value;
                    }
                }
            }
            public override string ToString()
            {
                return $"Тварина: {Name},\n Вага: {Weight} kg,\n Хижак: {(IsPredator ? "Yes" : "No")}";
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
            public override string ToString()
            {
                return $"{base.ToString()},\n Забарвлення {StripePattern}";
            }
        }


        public class Crocodile : Animal
        {
            public double Length; 

            public Crocodile(string name, double weight, bool isPredator, double length)
               : base(name, weight, isPredator)
            {
                Length = length;
            }
            public double SetLength
            {
                get { return Length; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Значення не може бути менше 0");
                    }
                    else
                    {
                        Length = value;
                    }
                }
            }
         
            public override string ToString()
            {
                return $"{base.ToString()},\n Довжина {Length} метрів";
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
            public int SetJumpDistance
            {
                get { return JumpDistance; }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Значення не може бути менше 0");
                    }
                    else
                    {
                        JumpDistance = value;
                    }
                }
            }
            public override string ToString()
            {
                return $"{base.ToString()},\n Стрибок {JumpDistance} метрів";
            }
        }
    }
}
