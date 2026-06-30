using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_mastery._02_OOPs
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock {  get; set; }


        public void UpdatePrice (double  price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Price = price;
        }

        public void AddStock(int quntity )
        {
            if(quntity <= 0 )
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Stock = Stock + quntity;

        }

    }
}
