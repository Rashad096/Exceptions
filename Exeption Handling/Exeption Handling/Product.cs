using System;
using System.Collections.Generic;
using System.Text;

namespace Exeption_Handling
{
    internal class Product
    {
        public Product(string name,double price)
        {
            Name = name;
            Price = price;

        }

        public string Name;
        public double Price;


        public string GetInfo()
        {
            return $"Name: {Name}   Pice: {Price}";
        }
    }
}
