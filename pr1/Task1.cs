using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr1
{
    public class Product
    {
        public string Name;
        public string NamePlace;
        public decimal Price;

        public string SetName
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Некоректне введення");
                }
                else
                {
                    Name = value;
                }
            }
        }

        public string SetNamePlace
        {
            get { return NamePlace; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Некоректне введення");
                }
                else
                {
                    NamePlace = value;
                }
            }
        }

        public decimal SetPrice
        {
            get { return Price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ціна не може бути менше 0");
                }
                else
                {
                    Price = value;
                }
            }
        }
        public Product(string name, string namePlace, decimal price)
        {
            Name = name;
            NamePlace = namePlace;
            Price = price;
        }
        public override string ToString()
        {
            return $"Product Name: {Name}, Place of Sale: {NamePlace}, Price: {Price} UAH";
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ NamePlace.GetHashCode() ^ Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Product other)
            {
                if (obj == null || obj.GetType() != GetType()) 
                {
                    return false;
                }
                return Name == other.Name &&
                       NamePlace == other.NamePlace &&
                       Price == other.Price;
            }
            return false;
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
        public string SetAgeCategory
        {
            get { return AgeCategory; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Некоректне введення");
                }
                else
                {
                    AgeCategory = value;
                }
            }
        }

        public string SetManufacturingPlace
        {
            get { return ManufacturingPlace; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Некоректне введення");
                }
                else
                {
                    ManufacturingPlace = value;
                }
            }
        }
       

        public override string ToString()
        {
            return $"{base.ToString()}, Age Category: {AgeCategory}, Manufacturing Place: {ManufacturingPlace}";
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ NamePlace.GetHashCode() ^ Price.GetHashCode() ^ AgeCategory.GetHashCode() ^ ManufacturingPlace.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Toy other)
            {
                if (obj == null || obj.GetType() != GetType()) 
                {
                    return false;
                }
                return base.Equals(other) &&
                       AgeCategory == other.AgeCategory &&
                       ManufacturingPlace == other.ManufacturingPlace;
            }
            return false;
        }
    }
}
