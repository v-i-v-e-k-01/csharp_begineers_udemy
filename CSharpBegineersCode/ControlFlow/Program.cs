//Section 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


using Conditonals; // fot Season enum at line 56


namespace ControlFlow
{
    // ********************** Section 5: Control Flow **********************
    public class Program
    {
        static void Main(string[] args)
        {
            //// if /else
            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("Its morning");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("Its afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("Its evening");
            //}

            //bool isGoldCustomer = true;

            ////float price;
            ////if (isGoldCustomer)
            ////{
            ////    price = 19.95f;
            ////}
            ////else
            ////{
            ////    price = 29.95f;
            ////}

            //// OR
            ////float price = (isGoldCustomer) ? 19.95f : 29.95f;

            ////Console.WriteLine(price);


            //////////////////////////////////////////////////////////////////////////////////

            //// switch cases

            //var season = Season.Spring;

            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("Its autumn");
            //        break;

            //    case Season.Summer:
            //        Console.WriteLine("Its summer");
            //        break;

            //    // If two cases have same output, club as follows
            //    case Season.Spring:
            //    case Season.Winter:
            //        Console.WriteLine("Its Spring or Winter");
            //        break;

            //    default:
            //        Console.WriteLine("Season not known");
            //        break;

            //}


            //////////////////////////////////////////////////////////////////////////////////

            //-------Exercise 1 Section 5--------


            ////Q1
            ////Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            //Console.WriteLine("Enter a number between 1 and 10");
            //int inputVal= Convert.ToInt32(Console.ReadLine());
            //if(inputVal>0 &&  inputVal<=10)
            //{
            //    Console.WriteLine("Valid"); 
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}


            ////////////////////////////////////////////////////////////////////////////////


            ////Q2
            ////Write a program which takes two numbers from the console and displays the maximum of the two.

            //try
            //{
            //    Console.WriteLine("Enter first number:");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter second number:");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    bool isNum1Greater;
            //    if (num1 > num2)
            //    {
            //        isNum1Greater = true;
            //    }
            //    else
            //    {
            //        isNum1Greater = false;
            //    }
            //    switch (isNum1Greater)
            //    {
            //        case true:
            //            Console.WriteLine(string.Format("First number, {0} is greater", num1));
            //            break;
            //        case false:
            //            if (num1 < num2)
            //            {
            //                Console.WriteLine(string.Format("Second number, {0} is greater", num2));
            //            }
            //            else if (num1 == num2)
            //            {
            //                Console.WriteLine("Both are equal");
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input");
            //            break;
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input");
            //}


            ////////////////////////////////////////////////////////////////////////////////


            ////Q3
            //// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            //Console.WriteLine("Enter width:");
            //float width = Convert.ToSingle(Console.ReadLine());  //.NET calls float as -> Single

            //Console.WriteLine("Enter height:");
            //float height = Convert.ToSingle(Console.ReadLine());

            //if (width > height)
            //{
            //    Console.WriteLine("Landscape");
            //}
            //else if (width < height)
            //{
            //    Console.WriteLine("Portrait");
            //}
            //else
            //{
            //    Console.WriteLine("Square Layout");
            //}


            ////////////////////////////////////////////////////////////////////////////////


            ////Q4
            //// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

            //Console.WriteLine("Enter speed limit:");
            //float speedLimit = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Enter speed:");
            //float speed = Convert.ToSingle(Console.ReadLine());
            //int demeritPoints;

            //demeritPoints = (speed > speedLimit) ? (int)(speed - speedLimit) / 5 : 0;

            //if (demeritPoints > 12)
            //{
            //    Console.WriteLine("License Suspended");
            //}
            //else
            //{
            //    Console.WriteLine("Speed OK");
            //    Console.WriteLine("Demerit points: " + demeritPoints);
            //}



            ////////////////////////////////////////////////////////////////////////////////


            ////for loop

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}


            ////////////////////////////////////////////////////////////////////////////////

            ////foreach loop

            //var name = "John Smith";

            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //Console.WriteLine();

            //var numbers = new int[] {1,2,3,4};

            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}


            ////////////////////////////////////////////////////////////////////////////////

            ////while loop

            //var i = 0; //initialise

            //while (i <= 10) //condition
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;      //operation
            //}

            //string input;

            //while (true)
            //{

            //    Console.Write("Type your name: ");
            //    input = Console.ReadLine();


            //    //if (String.IsNullOrWhiteSpace(input))
            //    //{
            //    //    break;
            //    //}
            //    //Console.WriteLine("@Echo: " + input);

            //    //OR


            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }
            //    break; 


            //}

            ////////////////////////////////////////////////////////////////////////////////

            //Random class

            var random = new Random();

            ////printing random numbers between 1 and 10 (both inclusive)
            //for (var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 10));
            //}

            ////////////////////////////////////////////////////////////////////////////////


            ////printing random characters 'a' to 'z'

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.Write((char)random.Next(97, 122)); //97='a'  122='z'
            //    //OR
            //    Console.Write((char)('a'+random.Next(0,26)));
            //}

            //Console.WriteLine();


            ////////////////////////////////////////////////////////////////////////////////

            //// storing random characters into a string

            //// cannot create a string and iterate modification as its immutable
            //// so we store in array one by one, and then combine to form string

            //const int pwdLength = 10;
            //var buffer = new char[pwdLength];

            //for(var i=0; i<pwdLength; i++)
            //{
            //    buffer[i] = (char)('a' + random.Next(0, 26));
            //}

            //var outputStr = new string(buffer); //input char array directly to form string 

            //Console.WriteLine(outputStr);

            ////////////////////////////////////////////////////////////////////////////////


            //-------Exercise 2 Section 5--------

            ////Q1 
            ////Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

            //int count = 0;
            //for(int i=1;i<=100;i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}

            //Console.WriteLine(string.Format("{0} numbers between 1 and 100 are divisible by 3",count));

            ////////////////////////////////////////////////////////////////////////////////


            ////Q2
            ////Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number to add or \"ok\" to exit");
            //    var inputVal = Console.ReadLine();
            //    if (inputVal == "ok")
            //    {
            //        break;
            //    }

            //    try
            //    {
            //        sum += Convert.ToInt32(inputVal);
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid Input");
            //    }

            //}

            //Console.WriteLine("Sum: " + sum);


            ////////////////////////////////////////////////////////////////////////////////


            ////Q3
            ////Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            //Console.WriteLine("Enter a number:");
            //int inputVal = Convert.ToInt32(Console.ReadLine());
            //int res = 1;
            //for (int i = inputVal; i > 1; i--)
            //{
            //    res = res * i;
            //}

            //Console.WriteLine(string.Format("{0}! = {1}", inputVal, res));

            ////////////////////////////////////////////////////////////////////////////////

            ////Q4
            ////Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //int randomVal = random.Next(1, 10);
            ////Console.WriteLine(randomVal);
            //bool didGuessRight = false;
            //Console.WriteLine("Guess the number. You have 4 chances.");

            //for (int i = 1; i <= 4; i++)
            //{
            //    try
            //    {
            //        int inputVal = Convert.ToInt32(Console.ReadLine());
            //        if (inputVal == randomVal)
            //        {
            //            Console.WriteLine("You won");
            //            didGuessRight = true;
            //            break;
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid Input");

            //    }
            //}

            //if (!didGuessRight)
            //{
            //    Console.WriteLine("You lost");
            //}


            ////////////////////////////////////////////////////////////////////////////////

            //Q5
            // Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            Console.WriteLine("Enter a series of numbers separated by comma: ");
            string inputStr = Console.ReadLine();

            var numList = new int[inputStr.Length];

            numList = Array.ConvertAll(inputStr.Split(','), int.Parse);
            // first input is converted to array of strings using .Split(),
            // the resultant array is passed to Array.ConvertAll() as input and the conversion function to convert each element into integer
            // as arrays are immutable, we store the resultant into new array numList

            int max = int.MinValue;

            for (int i = 0; i < numList.Length; i++)
            {
                if (numList[i] > max)
                {
                    max = numList[i];
                }
            }

            Console.WriteLine("Max value: " + max);
        }
    }
}