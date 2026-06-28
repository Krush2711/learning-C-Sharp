// Basics of c-sharp

// Task 1 
//Console.Write("Enter your name : ");
//string name = Console.ReadLine();
//Console.Write("Enter your age : ");
//int age = Convert.ToInt32( Console.ReadLine());
//Console.Write("Enter your clg : ");
//string clg = Console.ReadLine();
//Console.Write("Enter your cgpa : ");
//double cgpa = Convert.ToDouble( Console.ReadLine());



//Console.WriteLine("-------Studnet Details------");
//Console.WriteLine($"Name : {name}");
//Console.WriteLine($"Age : {age}");
//Console.WriteLine($"Collage : {clg}");
//Console.WriteLine($"CGPA : {cgpa}");

// Task 2 -> BMI Caclulator

//Console.Write("Enter your name : ");
//string name = Console.ReadLine();
//Console.Write("Enter weight : ");
//double weight = Convert.ToDouble( Console.ReadLine());
//Console.Write("Enter height : ");
//double height = Convert.ToDouble( Console.ReadLine());

//double bmi = weight / (height * height);


//Console.WriteLine("-------BMI Report------");
//Console.WriteLine($"Name : {name}");
//Console.WriteLine($"Weight : {weight}");
//Console.WriteLine($"Height : {height}");
//Console.WriteLine($"BMI : {Math.Round(bmi , 2)}");
//Console.Write("Report : ");

//if(18.5 > bmi)
//{
//    Console.Write("Uderweight");
//}
//else if (24.9 > bmi)
//{
//    Console.Write("Normal");
//}
//else
//{
//    Console.Write("Overweight");

//}


//// Task -> 3 Studnet result system
//Console.Write("Enter your name : ");
//string name = Console.ReadLine();

//Console.Write("Enter Maths marks : ");
//int maths = Convert.ToInt32( Console.ReadLine());

//Console.Write("Enter English marks : ");
//int English = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter Marathi marks : ");
//int Marathi = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter Science marks : ");
//int Science = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter History marks : ");
//int History = Convert.ToInt32(Console.ReadLine());


//int total = maths + English + Marathi + Science + History;
//int avg = total / 5;

//Console.WriteLine($" Your Total marks is : {total}");
//Console.WriteLine($" Your Avg marks is : {avg}");


//if ((maths < 35) || (English < 35) || (History < 35 )||( Marathi < 35) || (Science < 35) )

//{
//    Console.WriteLine("You have failed in exams.");
//}
//else
//{

//switch (avg)
//{
//    case > 90:
//        Console.WriteLine("Grade obtain is 'A'.");
//        break;

//    case > 80:
//        Console.WriteLine("Grade obtain is 'B'.");
//        break;
//    case > 70: 
//        Console.WriteLine("Grade obtain is 'C'.");
//        break;
//    case > 60:
//        Console.WriteLine("Grade obtain is 'D'.");
//        break;


//    default:
//        Console.WriteLine("You are failed.");
//            break;

//}
//}

// Task 4 -> stududent attendecnce 

//Console.Write("Enter the number of the studnets : ");
//int stud_count = Convert.ToInt16(Console.ReadLine());

//int present = 0;
//int absent = 0;

//for (int i = 1; i <= stud_count; i++)
//{
//    Console.Write($"Studnet No. {i} is presnet ? : ");
//    char inp = Convert.ToChar(Console.ReadLine());

//    if (inp == 'P' || inp == 'p')
//    {
//        present++;
//    }
//    else if (inp == 'A' || inp =='a')
//    {
//        absent++;
//    }

//    else
//    {
//        Console.WriteLine("Enter the vaild input again ! ");
//        i = i - 1;
//    }
//}

//Console.WriteLine($"total studnet count {stud_count}");
//Console.WriteLine($"Present studnet count {present}");
//Console.WriteLine($"Absnet studnet count {absent}");




// Last task -> studnet analysis 


Console.Write("Enter the number of the studnets : ");
int stud_count = Convert.ToInt16(Console.ReadLine());

int[] marks = new int[stud_count];

for (int i = 0; i < stud_count; i++ )
{
    Console.Write($"Enter the Studnet No." +
        $" {i+1} Marks : ");
    int inp = Convert.ToInt16(Console.ReadLine());

    marks[i] = inp;
    
}
int total = 0;
int lowest = 999;
int highest = 0;
int fail = 0;

for (int i = 0; i < stud_count; i++ )
{
    total = total + marks[i];
    Console.WriteLine($"Studnet {i+1} : {marks[i]}");
    if(highest <= marks[i])
    {
        highest = marks[i];
    }
    if(lowest >= marks[i])
    {
        lowest = marks[i];
    }

    if (marks[i] < 35)
    {
        fail++;
    }
}

Console.WriteLine($"Avg marks is : {total / stud_count}.");
Console.WriteLine($"Lowest marks is : {lowest}.");
Console.WriteLine($"Highest marks is : {highest}.");
Console.WriteLine($"failed studnet number is  : {fail}.");

Console.WriteLine($"Pass studnet nuber is {stud_count - fail}.");

Console.ReadLine();



