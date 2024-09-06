using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    public class Product
    {
        public string Name { get; set; }
        public string NamePlace { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string namePlace, decimal price)
        {
            Name = name;
            NamePlace = namePlace;
            Price = price;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Product name: {Name},/n place of sale: {NamePlace},/n unit price: {Price} UAH");
        }
    }

    public class Toy : Product
    {
        public string AgeCategory { get; set; }
        public string ManufacturingPlace { get; set; }

        public Toy(string name, string namePlace, decimal price, string ageCategory, string manufacturingPlace)
            : base(name, namePlace, price)
        {
            AgeCategory = ageCategory;
            ManufacturingPlace = manufacturingPlace;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Age Category: {AgeCategory}, Manufacturing Place: {ManufacturingPlace}");
        }
    }
}
