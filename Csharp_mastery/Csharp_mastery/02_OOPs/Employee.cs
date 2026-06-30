using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_mastery._02_OOPs
{
    internal class Employee
    {

        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }


        public Employee()
           
        {
            //Console.WriteLine("I am Employees constructor ");
        }

        public virtual void Work()
        {
            Console.WriteLine("Empolye working ");
        }

        //public Employee(string name)
        //{
        //    //Console.WriteLine(name);
        //}
    }
}
