//Section 1-4

using System;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;


using PrimAndNonPrimTypes.Math;



namespace PrimAndNonPrimTypes
{
    //// ************************ Section 2 and 3 (Intro and Primitive types and Expressions) *************************
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //byte number;
    //        //number = 255;
    //        //int count = 10;
    //        //float totalPrice = 20.95f;
    //        //char character = 'A';
    //        //string firstName = "Mosh";
    //        //bool isWorking = true;
    //        //Console.WriteLine("Hello World");
    //        //Console.WriteLine(number);
    //        //Console.WriteLine(count);
    //        //Console.WriteLine(totalPrice);
    //        //Console.WriteLine(character);
    //        //Console.WriteLine(firstName);
    //        //Console.WriteLine(isWorking);
    //        ////var isTrue = true;


    //        //Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);



    //        //TYPE CONVERSION



    //        ////Compatible data types------------

    //        // data types of same group are compatible with each other :

    //        //numbers group: (byte, short, int, long, float, double, decimal)
    //        // characters group : (char)
    //        // strings group: (string)
    //        // boolean group: (bool)



    //        ////Convert to Larger -- when data types to which converted is larger than current
    //        //// a.k.a implicit conversion

    //        //byte b1 = 1;
    //        //int i1 = b1;
    //        //Console.WriteLine(i1);

    //        //int i2 = 4000;
    //        //float f1 = i2;
    //        //Console.WriteLine(f1);



    //        //// Convert to Smaller -- when data types to which converted is smaller than current
    //        //// a.k.a explicit conversion 


    //        //int i = 1000;
    //        //byte b = (byte)i; //casting or typecasting
    //        //Console.WriteLine(b);

    //        //float f2 = 4.25f;
    //        //int i3 = (int)f2;
    //        //Console.WriteLine(i3);







    //        ////Incompatible data types-----------------

    //        // data types of different groups are incompatible with each other

    //        // We use Convert Class or .Parse() for incompatible types



    //        //Values Match

    //        // if values match the data type it is converted to, like in below 2 examples, its used as it is.


    //        //string num = "1234";
    //        //int j = Convert.ToInt32(num);
    //        //Console.WriteLine(j);

    //        //string str = "true";
    //        //bool b3 = Convert.ToBoolean(str);
    //        //Console.WriteLine(b3);


    //        //Values Dont Match or (Values Match but data type converted to is smaller)

    //        // if values dont match the data type it is converted to or match but is smaller, like in below 2 examples, it gives error and their are no alternatives to convert.

    //        // Values dont match
    //        //try
    //        //{
    //        //    string str2 = "frew";
    //        //    bool b4 = Convert.ToBoolean(str2);
    //        //    Console.WriteLine(b4);
    //        //}
    //        //catch (Exception)
    //        //{
    //        //    Console.WriteLine("The string could not be converted to boolean");
    //        //    //throw;
    //        //}

    //        // Values Match but data type converted to is smaller)
    //        //try
    //        //{
    //        //    string num2 = "1234";
    //        //    byte b2 = Convert.ToByte(num2);
    //        //    Console.WriteLine(b2);
    //        //}
    //        //catch (Exception)
    //        //{
    //        //    Console.WriteLine("The number could not be converted to byte");
    //        //    //throw;
    //        //}





    //    }
    //}



    //// ************************ Section 4 (Non Primitive Types) ************************


    //// Classes -----------

    //public class Person
    //{
    //    public string Name;

    //    public void Introduce()
    //    {
    //        Console.WriteLine("Hi my name is " + Name);
    //    }

    //}

    //public class calculator
    //{
    //    public int Add(int num1, int num2)
    //    {
    //        return num1 + num2;
    //    }
    //}

    //// IMP
    //// The below class is class with Main function.
    //// Thus it will run first and objects of this class and other classes are created in the Main function ONLY. 
    //class Program2
    //{
    //    public static void Main(string[] args)
    //    {

    //        Person person=new Person(); 
    //        // OR var person = new Person();
    //        person.Name = "RODMAN";
    //        person.Introduce();

    //        int number = 23;
    //        int number2 = 34;
    //        calculator calculator = new calculator();
    //        int answer= calculator.Add(number, number2);
    //        Console.WriteLine(answer);
    //    }
    //}


    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        //var john = new Person();
    //        //john.firstName = "John";
    //        //john.lastName = "Smith";
    //        //john.Introduce();

    //        //var calculator=new Calculator();
    //        //var result = calculator.Add(1, 2);
    //        //Console.WriteLine(result);


    ////Arrays -------------
    //        //int[] numbers = new int[3];
    //        //// OR  var numbers = new int[3];

    //        //numbers[0] = 1;

    //        //Console.WriteLine(numbers[0]);
    //        //Console.WriteLine(numbers[1]);
    //        //Console.WriteLine(numbers[2]);

    //        //var flags = new bool[3];
    //        //flags[0] = true;

    //        //Console.WriteLine(flags[0]);
    //        //Console.WriteLine(flags[1]);
    //        //Console.WriteLine(flags[2]);

    //        //var names = new string[3] { "Jack", "John", "Mary"
    //        //};

    ////Strings ------------

    //        //            string firstName = "Mosh";
    //        //            string lastName = "M";


    //        //            //string formatting
    //        //            string fullName = firstName + " " + lastName;
    //        //            Console.WriteLine(fullName);

    //        //            //OR
    //        //            string fullName2 = string.Format("{0} {1}", firstName, lastName);
    //        //            Console.WriteLine(fullName2);

    //        //            Console.WriteLine();


    //        //            //string join
    //        //            var integers = new int[3] { 1, 2, 3 };
    //        //            string listIntegers = string.Join(",", integers);
    //        //            Console.WriteLine(listIntegers);

    //        //            //Accessing string elements
    //        //            string name3 = "Moshh";
    //        //            char firstChar = name3[0];


    //        //            Console.WriteLine();
    //        //            ////

    //        //            //Escape characters \n  \t  \\  \'  \"
    //        //            string path1 = "c:\\projects\\project1\\folder1";
    //        //            Console.WriteLine(path1);

    //        //            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
    //        //            Console.WriteLine(text);


    //        //            // OR use verbatim string
    //        //            string path2 = @"c:\projects\project1\folder1";
    //        //            Console.WriteLine(path2);

    //        //            var textv = @"Hi John
    //        //Look into the following paths
    //        //c:\folder1\folder2
    //        //c:\folder3\folder4";
    //        //            Console.WriteLine(textv);


    //        //            Console.WriteLine();

    //        //            ////
    //        //            var firstName2 = "Moshhh";

    //        //            String lastName2 = "Hamedani";
    //        //            //OR
    //        //            string lastName3 = "Hamedanii";

    //        //            Console.WriteLine(firstName2);
    //        //            Console.WriteLine(lastName2);
    //        //            Console.WriteLine(lastName3);
    //    }
    //}

    //Enums -------------
    //public enum ShippingMethod
    //{
    //    RegularMail=1,
    //    RegisteredMail=2,
    //    ExpressMail=3
    //}

    //class Program
    //{

        //public static void Main(string[] args)
        //{
            //var method = ShippingMethod.ExpressMail;
            //Console.WriteLine((int)method); //casting/converting to integer value of name value pair ExpressMail=3

            //var methodID = 3;
            //Console.WriteLine((ShippingMethod)methodID); // casting/converting to name of the name value pair

            //Console.WriteLine(method.ToString());

            ////Parsing/converting string to Enum data type
            //// Enum.Parse(Type_of_Enum, string_input );
            //var methodName = "ExpressMail";
            //var shipMethod = Enum.Parse(typeof(ShippingMethod), methodName);
            //Console.WriteLine(shipMethod);


            ////Reference vs Value Type

            //// Two main data types --Structures and Classes

            //// Structures are value type and store value of data (Value type)

            //// Classes are reference type and store addresses (Reference Type)

            //// Primitive data types are structures(byte,short....decimal, bool, char) 
            //// whenever created or copied to other variable, a new memory allocated automatically

            //var a = 10;
            //var b = a; // new memory allocated to b with same value copied 
            //b+=1; 

            //Console.WriteLine(string.Format("a:{0} b:{0}", a, b));


            //// Non primitives like Arrays and Strings are classes (System.String) (System.Array)
            //// whenever created user needs to allocate memory manually using new keyword
            //// when copied to new variable say (array2), address is copied. So changes to array2 will affect array1 as both refer to same address.

            //var array1 = new int[3] { 1, 2, 3 };
            //var array2 = array1; //address copied

            //array2[0]= 0;

            //Console.WriteLine(string.Format("array1[0]:{0} array2[0]: {1}", array1[0], array2[0]));

            //// to avoid this we use new keyword while copying. (built-in copy functions to copy data)

            //var array3 = new int[3] { 4, 5, 6 };
            //var array4 = new int[array3.Length];
            //Array.Copy(array3, array4, array3.Length);

            //array4[0] = 400;

            //Console.WriteLine(string.Format("array3[0]:{0} array4[0]: {1}", array3[0], array4[0]));


        //}
    //}

    public class Person
    {
        public int age;
    }

    public class  Program
    {
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
        public static void Main(string[] args)
        {
            var number = 1;
            Increment(number); // it will increment a copy of the number variable inside the scope of Increment method with new memory location
            Console.WriteLine(number);
            //// no change 
            // if we want to save that new change, we take a return value from func/method and assign it to the variable
            //eg. 
            //int num = 45;
            //num = Increment(num); //change Increment to return type as
            //saves new value 55 into num variable

            //OR
            // declare the variable inside a class

            var person = new Person() { age=20};
            MakeOld(person);
            Console.WriteLine(person.age);
            // this changes the variable value as classes are reference type and thus the variable stored is passed as address
            //outputs 30

            //Note: static keyword in methods allows access of method without creating an object
        }
    }

}
