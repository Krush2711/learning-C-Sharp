using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Csharp_mastery._02_OOPs
{
    internal class Studnet
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Invalid Name");
                    return;
                }

                name = value;
            }
        }
        public int age;
        public double cgpa;

        public Studnet()
            //: this("unknown", -1, -1)
        {
            //Console.WriteLine("Student object created successfully.");
        }

        public Studnet(string name)
        {
            this.name = name;
        }
        public Studnet(string name, int age, double cgpa)
        {
            this.name = name;
            this.age = age;
            this.cgpa = cgpa;
        }

        public void Display( )
        {
            
            
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(cgpa);
        }
    }

}
