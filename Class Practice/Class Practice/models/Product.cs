using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Practice.models
{
    internal class Product
    {
        public int No;
        public string Name;
        public int price;
        public int count;

        public Product(int No, string Name, int price, int count)

        {
            this.No = No;
            this.Name = Name;
            this.price = price;
            this.count = count;
        }
    }
}
