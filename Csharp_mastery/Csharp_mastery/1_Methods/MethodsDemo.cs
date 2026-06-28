using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Csharp_mastery._1_Methods
{
        internal class MethodsDemo
        {
            public static void Run()
            {
            // PrintBanner();
            //Console.Write("Enter the name of user : ");
            //string s = Console.ReadLine();
            //GreetBanner(s);

            // 3rd 
            //Console.Write("Enter the frist number : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number : ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int sum = Sum(a, b);
            //Console.WriteLine($"Sum of the numbers is {sum}");

            //  4th _> stundet marks 

            Console.Write("Enter Maths marks : ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter English marks : ");
            int English = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Marathi marks : ");
            int Marathi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Science marks : ");
            int Science = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter History marks : ");
            int History = Convert.ToInt32(Console.ReadLine());

            double percnet  = Avg(maths, History, Marathi, Science, English);

            Console.WriteLine($"Percantage is : {percnet}");
            Console.WriteLine($"Grade  is : {Grade(percnet)}");
            Console.WriteLine($"Reuslt  is : {IsPassed(maths, History, Marathi, Science, English)}");


         }

        public static double Avg(int a, int b , int c , int d, int f)
        {
            
             double ans =   (( a + b + c + d + f) / 5 );
            return ans;
        }

        public static bool IsPassed(int a, int b, int c, int d, int f)
        {
            if (a < 35 || b < 35 || c < 35  || d < 35 || f < 35 )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static char Grade(double avg)
        {
            switch (avg)
            {

                case > 90:
                    return 'A';
                case > 80:
                    return 'B';
                case > 70:
                    return 'C';
                case > 60:
                    return 'D';
                
                default:
                    return 'F';
            }
        }
        
        public static int Sum(int a , int b)
            {
                return a + b;
            }

            public static void PrintBanner()
            {
                Console.WriteLine("================================================");
                Console.WriteLine(" ------------ C# Method Practice -------------- ");
                Console.WriteLine("================================================");
            }

            public static void GreetBanner(string name)
            {
                Console.WriteLine("================================================");
                Console.WriteLine($" Welcome , {name} !");
                Console.WriteLine("Have a great day learning C#.");
                Console.WriteLine("================================================");
            }
        }
}
