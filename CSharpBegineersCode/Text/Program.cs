//Section 8

using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text; //used for StringBuilder() class
using System.Threading;
using Text.Animal;

namespace Text
{
    internal class Program
    {
        // ************************ Section 8: Working with text ************************ 
        static void Main(string[] args)
        {
            ////Trim()
            //var fullName = "Mosh Hamedani  ";
            //Console.WriteLine("Trim:'{0}'", fullName.Trim());

            ////ToUpper()
            //Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            ////IndexOf()
            //var index = fullName.IndexOf(" ");

            ////Substring()
            //var firstName = fullName.Substring(0, index);
            //// Substring(startIndex, number_of_characters);
            //var lastName = fullName.Substring(index + 1);

            //Console.WriteLine("First Name: " + firstName);
            //Console.WriteLine("Last Name: " + lastName);

            ////OR
            ////Split()
            //var nameSplitted = fullName.Split(' ');
            //Console.WriteLine("First Name: " + nameSplitted[0]);
            //Console.WriteLine("Last Name: " + nameSplitted[1]);

            ////Replace()
            //var newName = fullName.Replace("Mosh", "Moshpit");
            ////as string is immutable all methods applied creates a new string
            //// here we store that new string in newName

            //Console.WriteLine(newName);


            ////isNullOrEmpty()
            //if (String.IsNullOrEmpty(null))
            //{
            //    Console.WriteLine("Invalid");
            //}

            ////isNullOrWhiteSpace()
            //if (String.IsNullOrWhiteSpace(" "))
            //{
            //    Console.WriteLine("Invalid");
            //}


            ////Convert string to number

            //var str = "24";
            //var age = Convert.ToByte(str);
            //Console.WriteLine("Age: " + age);


            ////Convert number to string

            //float price = 29.95f;
            //Console.WriteLine(price.ToString("C0"));


            ////////////////////////////////////////////////////////////////

            //// Summarizing strings

            ////refer StringUtility Class file

            //var sentence = "This is going to be a really really really long text.";
            //const int maxLength = 18;

            //var summary = StringUtility.SummarizeText(sentence, maxLength);
            //Console.WriteLine("Summary: "+summary);



            /////////////////////////////////////////////////////////////////////////////


            ////StringBuilder()

            //var builder = new StringBuilder();

            ////builder.Append('-', 10);
            ////builder.AppendLine();
            ////builder.Append("Header");
            ////builder.AppendLine();
            ////builder.Append('-', 10);

            ////Console.WriteLine(builder);

            ////builder.Replace('-', '+');
            ////Console.WriteLine(builder);

            ////builder.Remove(0, 10);
            ////Console.WriteLine(builder);

            ////builder.Insert(0, new string('-', 10));
            ////Console.WriteLine(builder);


            ////OR

            //builder
            //    .Append('-', 10)
            //    .AppendLine()
            //    .Append("Header")
            //    .AppendLine()
            //    .Append('-', 10)
            //    .Replace('-', '+')
            //    .Remove(0, 10)
            //    .Insert(0, new string('-', 10));

            //Console.WriteLine(builder);


            //Console.WriteLine(builder[0]);


            /////////////////////////////////////////////////////////////////////////////

            //--------------------- Exercise 1: Section 8 --------------------- 

            ////Q1
            ////Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //Console.WriteLine("Enter numbers separated by hyphen: ");
            //var numbers = Array.ConvertAll(Console.ReadLine().Split('-'), int.Parse);


            //int tempNum = numbers[0];
            //int iter;
            //for (iter=1; iter < numbers.Length; iter++)
            //{
            //    if (numbers[iter] == tempNum + 1)
            //        tempNum++;
            //    else
            //        break;
            //}

            //bool areConsecutive = (iter==numbers.Length) ? true : false;
            //if (areConsecutive)
            //{
            //    Console.WriteLine("Consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("Not Consecutive");
            //}


            /////////////////////////////////////////////////////////////////////////////

            ////Q2
            ////Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            //Console.WriteLine("Enter numbers separated by hyphen: ");
            //var inputVal = Console.ReadLine();

            //if (!String.IsNullOrWhiteSpace(inputVal))
            //{
            //    var numbers = Array.ConvertAll(inputVal.Split('-'), int.Parse);

            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        var lastIndex = Array.LastIndexOf(numbers, numbers[i]);
            //        if (lastIndex != -1 && lastIndex != i)
            //        {
            //            Console.WriteLine("Duplicate");
            //            break;
            //        }
            //    }
            //}


            /////////////////////////////////////////////////////////////////////////////


            ////Q3
            ////Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

            //Console.WriteLine("Enter a time value in 24 hr format (eg. 19:00): ");

            //var time = Console.ReadLine();
            //var timeSplit = time.Split(':');

            //bool isValid = true;
            //if (!String.IsNullOrWhiteSpace(time) && timeSplit.Length == 2)
            //{
            //    foreach (var t in timeSplit)
            //    {
            //        var num = Convert.ToInt32(t);
            //        if (num / 100 != 0 || t.Length != 2)
            //            isValid = false;
            //    }
            //    int hr = Convert.ToInt32(timeSplit[0]);
            //    int min = Convert.ToInt32(timeSplit[1]);
            //    if (!((min >= 0 && min < 60) && (hr >= 0 && hr < 24)))
            //    {
            //        isValid = false;
            //    }
            //}
            //else
            //{
            //    isValid = false;
            //}

            //if (isValid)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Time");
            //}


            /////////////////////////////////////////////////////////////////////////////


            ////Q4
            ////Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Console.WriteLine("Enter words separated by space: ");
            ////var res = new StringBuilder();
            ////var inputVal = Console.ReadLine().ToLower();
            ////var wordLength = 1;
            ////int i;
            ////if (!String.IsNullOrWhiteSpace(inputVal))
            ////{
            ////    var inputStr = inputVal.ToCharArray();
            ////    for (i = 1; i < inputStr.Length; i++)
            ////    {
            ////        if (inputStr[i] == ' ' && wordLength!=0)
            ////        {
            ////            res.Append(Convert.ToChar(inputStr[i - wordLength] + 'A' - 'a'));
            ////            res.Append(inputStr, i - wordLength + 1, wordLength - 1);
            ////            wordLength = -1;

            ////        }
            ////        wordLength++;

            ////    }
            ////    if (wordLength != 0)
            ////    {
            ////        res.Append(Convert.ToChar(inputStr[i - wordLength] + 'A' - 'a'));
            ////        res.Append(inputStr, i - wordLength + 1, wordLength - 1);
            ////    }
            ////    Console.WriteLine(res);
            ////}

            ////OR

            //var inputStr = Console.ReadLine().ToLower();

            //var res = new StringBuilder();
            //if (!String.IsNullOrWhiteSpace(inputStr))
            //{
            //    foreach (var word in inputStr.Split(' '))
            //    {
            //        var wordWithPascalCase = char.ToUpper(word[0]) + word.Substring(1);
            //        res.Append(wordWithPascalCase);
            //    }
            //    Console.WriteLine(res.ToString());
            //}

            /////////////////////////////////////////////////////////////////////////////

            ////Q5
            ////Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

            //Console.WriteLine("Enter an English word: ");
            //var word = Console.ReadLine();
            //var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            //int count = 0;

            //foreach (char c in word)
            //{
            //    foreach (char c2 in vowels)
            //    {
            //        if (c == c2) count++;
            //    }
            //}
            //Console.WriteLine("Vowels count: " + count);



            /////////////////////////////////////////////////////////////////////////////

            //Procedural programming
            //separating input output from processing, putting processing into functions (applying to Q1-5)



            ////Q1

            //Console.WriteLine("Enter numbers separated by hyphen: ");
            //var inputVal = Console.ReadLine();
            //if (!String.IsNullOrWhiteSpace(inputVal))
            //{
            //    if (AreConsecutive(inputVal))
            //    {
            //        Console.WriteLine("Consecutive");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Consecutive");
            //    }
            //}


            /////////////////////////////////////////////////////////////////////////////


            ////Q2
            //Console.WriteLine("Enter numbers separated by hyphen: ");
            //var inputVal = Console.ReadLine();

            //if (!String.IsNullOrWhiteSpace(inputVal))
            //{
            //    if (HasDuplicates(inputVal))
            //    {
            //        Console.WriteLine("Duplicate");
            //    }

            //}


            /////////////////////////////////////////////////////////////////////////////

            ////Q3

            //Console.WriteLine("Enter a time value in 24 hr format (eg. 19:00): ");

            //var time = Console.ReadLine();


            //if (IsValidTime(time))
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Time");
            //}


            /////////////////////////////////////////////////////////////////////////////

            ////Q4

            //Console.WriteLine("Enter words separated by space: ");
            //var inputStr = Console.ReadLine().ToLower();

            //if (!String.IsNullOrWhiteSpace(inputStr))
            //{
            //    Console.WriteLine(ToPascalCase(inputStr));
            //}


            /////////////////////////////////////////////////////////////////////////////

            //Q5

            Console.WriteLine("Enter an English word: ");
            Console.WriteLine("Vowels count: "+VowelCount(Console.ReadLine()));



        }


        
        public static bool AreConsecutive(string inputVal)
        {
            var numbers = Array.ConvertAll(inputVal.Split('-'), int.Parse);
            int tempNum = numbers[0];
            int iter;
            for (iter = 1; iter < numbers.Length; iter++)
            {
                if (numbers[iter] == tempNum + 1)
                    tempNum++;
                else
                    break;
            }

            return (iter == numbers.Length) ? true : false;
        }

        public static bool HasDuplicates(string inputVal)
        {
            var numbers = Array.ConvertAll(inputVal.Split('-'), int.Parse);

            for (int i = 0; i < numbers.Length; i++)
            {
                var lastIndex = Array.LastIndexOf(numbers, numbers[i]);
                if (lastIndex != -1 && lastIndex != i)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsValidTime(string time)
        {
            var timeSplit = time.Split(':');

            if (!String.IsNullOrWhiteSpace(time) && timeSplit.Length == 2)
            {
                foreach (var t in timeSplit)
                {
                    var num = Convert.ToInt32(t);
                    if (num / 100 != 0 || t.Length != 2)
                        return false;
                }
                int hr = Convert.ToInt32(timeSplit[0]);
                int min = Convert.ToInt32(timeSplit[1]);
                if (!((min >= 0 && min < 60) && (hr >= 0 && hr < 24)))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        public static string ToPascalCase(string inputStr)
        {
            var res = new StringBuilder();
            foreach (var word in inputStr.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.Substring(1);
                res.Append(wordWithPascalCase);
            }
            return res.ToString();
        }

        public static int VowelCount(string word)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            foreach (char c in word)
            {
                foreach (char c2 in vowels)
                {
                    if (c == c2) count++;
                }
            }
            return count;
        }
    }

}