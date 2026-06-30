using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_mastery._02_OOPs
{
    internal class Car
    {
        public string Name;
        public string Model;
        public int Price;

        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Model);
            Console.WriteLine(Price);
        }
    }
}
