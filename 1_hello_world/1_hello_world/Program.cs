using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Write -> direct on same line.
// writeline -> print on the new line.
// Readline -> take input (cin) 
// commnets = /**/ , // 
// 

/* 
 * 
// Data types in c#
 interger -> int vname 4bytes;
 long -> 8bytes
 decimal values -> float vname 4bytes;
 dobule -> 8 bytes   
 charchter -> char a = 'A' 2bytes;
 Boolean -> bool vname = ture / false 1 bit;
 string -> string vname = "Harry" 2bytes per char;
 */


namespace _1_hello_world
{
    internal class Program

    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Moring " + name);
        }

        static float Avgerage(int a, int b , int c)
        {
            int s = a + b + c;
            return s / 3;
        }
        static void Main(string[] args)
        {
            //int harry = 34;
            //Console.WriteLine("Hello world " + harry);

            //Console.WriteLine("Enter your name : ");
            //string input = Console.ReadLine();
            //Console.WriteLine( input + " is a nice guy ");

            // float and double problem 
            //float k = 3.4; this will thorugh an error / warning but thing is F after the float values helps -> by deafult it will through the double as float.
            //double m = 3.444D; // good practice D not nessery at the all.
            //float k = 3.2F;

            // --- Type casting ---
            // char to int to long to float to double 

            // 1.--Explecite casting--
            // done by the user in side the code 
            // there also methods for it we can use to have , 
            // in built in the  

            // int a = (int)3.5;
            //Console.WriteLine(a);
            //char x = 'x';
            //int y = x; // asci value 
            //float z = y;
            //double xy = z;
            //Console.WriteLine(z);

            // 2. implecite typecasting 
            // done by the compiler at the execution time 
            //float a = 1.3334 -> int ? 

            //float a = Convert.ToInt32(3.333);
            //Convert.ToInt32();
            //Convert.ToBoolean();


            // ----String Conversion priority----
            //Console.WriteLine("How many candies you want ? : ");
            //string candy = Console.ReadLine();
            //Console.WriteLine("You will get 2 extra candies " + (Convert.ToInt32(candy )+ 2));

            // --- opertators in c# --- 
            // 1.Arithmatic Opertaors 
            // 2.Assingment Operators 
            // 3.Logical Operators
            // 4.Comparison Operatiors 


            //int a = Math.Max(34, 78);
            //int a = Math.Min(34, 78);
            //double a = Math.Sqrt(36);
            //Console.WriteLine(a);
            //string methods 
            //string hello = "Hello world this is harry ";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello , "Your are nice ");
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(5));
            //Console.WriteLine(string.Concat(hello, "Your are nice "));
            // \ escape charcter.

            //string name = "krushna";
            //Console.WriteLine($"Hello  {name}");

            // if else
            //int age = 96;

            //if (age > 90)
            //{
            //    Console.WriteLine("You go to bed");
            //}

            //else if (age > 18)
            //{
            //    Console.WriteLine("You can drive");
            //}


            //else
            //{
            //    Console.WriteLine("Please finish your high school");
            //}

            // switch cases
            //int age = 7;

            //switch (age)
            //{
            //    case < 18:
            //        Console.WriteLine("Please wait for an year");
            //        break;
            //    case > 18 and < 60 :
            //        Console.WriteLine("You are okay");
            //        break;

            //    default:
            //        Console.WriteLine("dont die!");
            //        break;
            //}

            // loops in c#

            // --- while 
            //int i = 0;

            //while (i < 1 )
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine(i);
            //Console.WriteLine("____Do__While_______");
            // ---- Do While ----
            //int b = 0;
            //do
            //{
            //    Console.WriteLine(b);
            //    b++;
            //} while (b < 1 );
            //Console.WriteLine(b);


            //for (int i = 0; i < 5; i++)
            //{
            //    if(i == 2)
            //    {

            //    continue;
            //    }
            //    Console.WriteLine(i);
            //    //break -> Leave this loop forever
            //    //continue -> Leave this particular iteration.
            //}
            //Greet("Krushna");
            //Console.WriteLine(Avgerage(3, 3, 3));
            //Console.WriteLine(Avgerage(3, 3, 3));
            ////Console.WriteLine(Avgerage(3, 3)); overloading

            // --- methods in the C#
            // Functions 

            // ---OOPS--- Classes and Object.

            Player tommy = new Player();
            Console.WriteLine(tommy.getHealth());
            tommy.setHealth(10);
            Console.WriteLine(tommy.getHealth());

            Console.ReadLine();
        }
    }
}
