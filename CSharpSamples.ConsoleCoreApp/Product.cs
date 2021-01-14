using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples.ConsoleCoreApp
{
    class Product
    {
        public Product()   //Construction Class
        {
        }

        public Product(string name, decimal price)     //Construction Class
        {
            this.Name = name;
            this.UnitPrice = price;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string MainImg { get; set; }
    }
}
