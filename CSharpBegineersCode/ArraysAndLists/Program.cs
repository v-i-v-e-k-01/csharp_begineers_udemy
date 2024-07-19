//Section 6

using System;


using System.Collections.Generic;
//used for generic data types like LIST


namespace ArraysAndLists
{
    //************************* Section 6: Arrays and Lists *************************
    internal class Program
    {
        static void Main(string[] args)
        {

            //////Arrays



            //var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            ////Length

            //Console.WriteLine(numbers.Length);
            ////Length is a property




            //// IndexOf()
            //var index = Array.IndexOf(numbers, 9); //Array.IndexOf(inputArr, value, startIndex, endIndex);

            //Console.WriteLine("Index of 9: " + index);




            ////Clear()
            //Array.Clear(numbers, 0, 2);
            ////Array.Clear(inputArray, startIndex, number_of_elements_to_clear);
            //// Clears means replaces values with zero

            //Console.WriteLine("Effect of Array.Clear(): ");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            ////Copy()

            //var anotherArr = new int[3];
            //Array.Copy(numbers, anotherArr, 3);
            //// Array.Copy(sourceArr, destArr, no_of_elements_to_copy);
            //Console.WriteLine("Effect of Array.Copy(): ");
            //foreach (var num in anotherArr)
            //{
            //    Console.WriteLine(num);
            //}




            ////Sort()

            //Array.Sort(numbers);

            ////Array.Sort(inputArray, startIndex, length);

            //Console.WriteLine("Effect of Array.Sort(): ");
            //foreach(var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}




            ////Reverse()

            //Array.Reverse(numbers);
            ////Array.Reverse(inputArray);

            //Console.WriteLine("Effect of Array.Reverse(): ");
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            ///////////////////////////////////////////////////////////////////////////


            ////Lists


            //var numbers = new List<int>() { 1, 2, 3, 4 };

            ////Add()
            //numbers.Add(1);
            ////obj.Add(inputVal);


            ////AddRange()
            //numbers.AddRange(new int[3] { 5, 6, 7 }); //Add an array or list to given list
            ////obj.AddRange(Enumerable_obj_input); -- input can be any enumerable object like Array and List
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine();



            ////IndexOf()
            //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            ////obj.IndexOf(inputVal, startIndex, number_of_elements_to_check;
            //// returns first occurence of inputVal



            ////LastIndexOf()
            //Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));



            ////Count Method
            //// obj.Count;
            //Console.WriteLine("Count: " + numbers.Count);



            ////Remove()
            ////obj.Remove(valToRemove);
            //numbers.Remove(5);
            //Console.WriteLine("After removing 5: ");
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            ////Removing all instances of 1
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == 1)
            //    {
            //        numbers.Remove(numbers[i]);
            //    }
            //}
            //Console.WriteLine("After removing all instances of 1: ");
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            ////Clear()
            ////obj.Clear()

            //numbers.Clear();
            //Console.WriteLine("Count after clearing all elements using Clear(): " + numbers.Count);


            //////////////////////////////////////////////////////////////////////////////////////

            ////--------------- Exercise 1 Section 6 -----------------

            ////Q1
            //// When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
            //// --If no one likes your post, it doesn't display anything.
            //// --If only one person likes your post, it displays: [Friend's Name] likes your post.
            //// --If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //// --If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //// Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).
            //// Depending on the number of names provided, display a message based on the above pattern.

            //var names = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Enter name of person or press Enter if finished: ");
            //    var inputVal = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(inputVal))
            //    {
            //        break;
            //    }

            //    names.Add(inputVal);

            //}

            //var count = names.Count;
            //switch (count)
            //{
            //    case 0:
            //        Console.WriteLine();
            //        break;
            //    case 1:
            //        Console.WriteLine(string.Format("{0} likes your post", names[0]));
            //        break;
            //    case 2:
            //        Console.WriteLine(string.Format("{0} and {1} like your post", names[1], names[0]));
            //        break;
            //    default:
            //        Console.WriteLine(string.Format("{0}, {1} and {2} others like your post", names[count-1], names[count - 2], count - 2));
            //        break;
            //}



            ////Q2 
            ////Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

            //Console.WriteLine("Enter your name: ");
            //var name = Console.ReadLine();

            ////var nameArr = new char[name.Length];
            ////for(int i=0;i<name.Length;i++)
            ////{
            ////    nameArr[i] = name[i];
            ////}

            ////OR
            //var nameArr=name.ToCharArray();

            //Array.Reverse(nameArr);

            //string revName = new string(nameArr);  // new string object takes char array input and converts to new string

            //Console.WriteLine("Reversed name: \n"+revName);


            ////Q3
            ////Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //Console.WriteLine("Enter 5 distinct numbers: ");

            //var numArr = new int[5];
            //int inputVal;
            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    inputVal = Convert.ToInt32(Console.ReadLine());
            //    if(numArr.Contains(inputVal))
            //    {
            //        Console.WriteLine("Number already present. Enter another number.");
            //        i--;
            //        continue;
            //    }
            //    numArr[i]= inputVal;
            //}

            //Array.Sort(numArr);
            //Console.WriteLine("Sorted array of distinct numbers entered:");
            //foreach (var num in numArr)
            //{
            //    Console.WriteLine(num);
            //}



            ////Q4
            ////Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

            //var numbers = new List<int>();
            //while (true)
            //{
            //    Console.WriteLine("Enter a number or type \"Quit\": ");
            //    var input = Console.ReadLine();
            //    if (input.ToLower() == "quit")
            //    {
            //        break;
            //    }
            //    numbers.Add(Convert.ToInt32(input));
            //}

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int lastIndex = numbers.LastIndexOf(numbers[i]);
            //    while (lastIndex != i)
            //    {
            //        numbers.Remove(numbers[lastIndex]);
            //        lastIndex = numbers.LastIndexOf(numbers[i]);
            //    }
            //}

            //Console.WriteLine("Unique numbers entered: ");
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //Q5
            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
            var numbers = new List<int>();
            while(true)
            {
                Console.WriteLine("Enter list of numbers separated by commas: ");
                var input = Array.ConvertAll( Console.ReadLine().Split(','),int.Parse);

                if (input.Length < 5)
                {
                    Console.WriteLine("Invalid List, try again");
                    continue;
                }

                numbers.AddRange(input);
                for (int i = 0; i < numbers.Count; i++)
                {
                    int lastIndex = numbers.LastIndexOf(numbers[i]);
                    while (lastIndex != i)
                    {
                        numbers.Remove(numbers[lastIndex]);
                        lastIndex = numbers.LastIndexOf(numbers[i]);
                    }
                }
                break;
            }

            Console.WriteLine("The three smallest numbers are: ");

            numbers.Sort();

            for(int i=0;i<3;i++)
            {
                
                Console.WriteLine(numbers[i]);
            }


        }
    }
}
