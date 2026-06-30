using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Csharp_mastery._02_OOPs
{
    internal class Devloper : Employee
    {
        public string ProgramingLanguage;

        //public Devloper()
        //    : base() 
        //{
        //    Console.WriteLine("Devloper");
        //}
        //public Devloper(string name )
        //    : base (name)
        //{
        //    Console.WriteLine(name);
        //}

        public  void  Work()
        {
            Console.WriteLine("I am devloper");
        }
    }
}
