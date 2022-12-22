using System;
using System.Collections.Generic;
using System.Text;

namespace Exeption_Handling
{
    internal class Notebook:Product
    {
        public Notebook(string name,double price):base(name,price) 
        {

        }

        public Notebook(string name, double price,byte ram):base(name,price)
        {
            RAM= ram;
        }
        public byte RAM;
    }
}
