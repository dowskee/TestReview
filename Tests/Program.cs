using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Say someone wants you to define a value. 
            //The first thing you need to do is assign an initial value;
            //-----------------------
            //bool ContinueProgram = true; 
            //-----------------------
            //output is another thing to focus on. Say we have the following code:
            //int Index = 5; 
            //while (Index < 15)
            //{
            //    Index++; //5 + 1 is 6. Because there are two increments, once we reach 14, the loop will come back once again to get 15
            //    Console.WriteLine(Index); //the output will be displaying numbers between 6 and 15
            //}
            //----------------------
            //say the above code was written like this instead: 
            //int Index = 5; 
            //while (Index < 15)
            //{
            //    Index++; //5 + 1 is 6. 
            //    if (Index%3 == 0) is 6 divisible by 3? Yes. There is no remainder ( == 0). How about 7? No, this will have a remainder
            //    Console.WriteLine(Index); //the output will be displaying 6, 9, 12, 15 (numbers divisible by 3 with no remainder)
            //}
            //-----------------------------
            //say the above code was written like this instead: 
            //int Index = 1; 
            //while (Index > 14)
            //{
            //    Index++; //1 is not greater than 14, so the program will not run. 
            //    if (Index%3 == 0) 
            //    Console.WriteLine(Index);
            //}
            //-----------------------
            //for (int i = 0; i < 10; i++) // i = 0, and 0 is less than 10. Then it dips in to the loop and increments to 2. 
            //    //until we get to 9, which is less than 10, then it is incremented by 2, getting 11.At this point the code will stop.
            //{
            //    Console.WriteLine(i + 2); //the code will output from 2 to 11
            //}
            //-----------------------
            //int Input = 21;
            //if (Input %2 == 0)
            //Console.WriteLine("Even"); //this will only print if the input is divisible by 2, as there are no brackets for the if statment. 
            //if will only print multiple lines if they are in brackets. 
            //Console.WriteLine("The number is" + Input); //the output will be "The number is 21"
            //---------------------------
            //write a C# program to count the positive numbers
            //int [] Numbers = {1, -1, -2, 0, 5, -6, 7};

            //int Count = 0;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] > 0)
            //        Count++;
            //}
            //Console.WriteLine(Count); //will print 3
            //---------------------------
            //int[] Numbers = { 1, -1, -2, 0, 5, -6, 7 };

            //int Sum = 0;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    if (Numbers[i] > 0)
            //        Sum = Sum + Numbers[i];
            //}
            //Console.WriteLine(Sum); //will print sum of the positive numbers (13)
            //----------------------------
            //string Input = "Hello World!";
            //count vowels in this string (similar to an array)
            //int Count = 0;

            //for (int i = 0; i < Input.Length; i++)
            //{
            //    if (Input[i] == 'a' || Input[i] == 'e' || Input[i] == 'i' || Input[i] == 'o' || Input[i] == 'u')
            //        Count++;
            //}
            //Console.WriteLine(Count);//this will output 3, for the counting of the 3 vowels in the string.
            //-------------------------------
            //understand value and reference types
            //understand syntax error, runtime(exceptions), and logical errors
            //understand validation as first line of defense, and try/catch as second line of defense
            //--------------------------------
            //Console.WriteLine("Please enter your grade:");
            //char grade = char.Parse(Console.ReadLine());
            //switch (grade)
            //{
            //    case 'a':
            //    case 'A': //will read either lower case or upper case A, with introduction of an additional case
            //        Console.WriteLine("You did excellent!");
            //        break;
            //    case 'b':
            //        Console.WriteLine("You did good!");
            //        break;
            //    case 'c':
            //        Console.WriteLine("You did ok.");
            //        break;
            //    case 'd':
            //        Console.WriteLine("You could've done better smh.");
            //        break;
            //    case 'f':
            //        Console.WriteLine("What are you.. an idiot?");
            //        break;
            //    default:
            //        Console.WriteLine("Please enter a valid grade.");
            //        break;
            //}
            //Console.WriteLine($"Your grade is {grade}");
        }
    }
}
