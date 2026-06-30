using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Csharp_mastery._02_OOPs
{
    internal class OOPsDemo
    {
        public static void Run()
        {
            //    Studnet s1 = new Studnet();
            //    s1.Name = "Krushna";
            //s1.age = 21;
            //s1.cgpa = 9.7;

            //Studnet s2 = new Studnet("Yash");
            //s2.age = 20;
            //s2.cgpa = 7.4;

            //Studnet s3 = new Studnet("vaibhavi", 20, 9.9);

            //Studnet s4 = new Studnet();

            //s1.Display();
            //s2.Display();
            //s4.Display();

            //Car c1 = new Car();
            //c1.Name = "BMW";
            //c1.Model = "M3";
            //c1.Price = 19000000;

            //Car c2 = new Car();
            //c2.Name = "Tata";
            //c2.Model = "Herier";
            //c2.Price = 2000000;

            //Car c3 = new Car();
            //c3.Name = "Toyota";
            //c3.Model = "supra";
            //c3.Price = 40000000;

            //c1.Display();
            //Console.WriteLine();
            //c2.Display();
            //Console.WriteLine();
            //c3.Display();

            // Access Modifers 

            //BankAccount a1 = new BankAccount();
            //a1.AccountHolder = "krushna";
            //Console.WriteLine(a1.AccountHolder);
            //a1.Deposite(1000);
            //a1.WithDraw(300);
            //a1.CheckBalance();
            //a1.Balance = 90; Severity	Code	Description	Project	File	Line	Suppression State
            //Error(active)  CS0122  'BankAccount.Balance' is inaccessible due to its protection level   Csharp_mastery D:\kanini\phase 2 - backend\Csharp_mastery\Csharp_mastery\02_OOPs\OOPsDemo.cs   53


            //  Encapsulation 
            // set and get 
            //Employee E1 = new Employee();
            //E1.Name = "Kruhsna";
            //E1.Salary = 1000000;
            //E1.Department = "ML";
            //Console.WriteLine(E1.Name);
            //Console.WriteLine(E1.Salary);
            //Console.WriteLine(E1.Department);

            //Product p1 = new Product();
            //p1.Name = "nirma";
            //p1.Price = 140;
            //p1.Stock = 90;

            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p1.Price);
            //Console.WriteLine(p1.Stock);

            //p1.UpdatePrice(180);
            //p1.AddStock(10);
            //Console.WriteLine(p1.Stock);
            //Console.WriteLine(p1.Price);


            Devloper D = new Devloper();
            //D.Name = "Nutan";
            //D.Salary = 50000;
            //D.Department = "Tester";
            //D.ProgramingLanguage = "Python";
            D.Work();
        }
    }
}
