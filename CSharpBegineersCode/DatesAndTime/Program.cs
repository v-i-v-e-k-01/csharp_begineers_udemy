//Section 7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTime
{
    internal class Program
    {
        // ***************************** Section 7: Working with Dates ***************************** 
        static void Main(string[] args)
        {

            ////DateTime

            //var dateTime = new DateTime(2024, 7, 16); //set date time acc to input
            //Console.WriteLine(dateTime);

            //var now=DateTime.Now; //set to current date time
            //Console.WriteLine(now);

            //var today = DateTime.Today;
            //Console.WriteLine(today); //set to current date 12:00AM

            //Console.WriteLine("Hour: "+now.Hour);
            //Console.WriteLine("Minute: "+now.Minute);

            //var tomorrow = now.AddDays(1);
            //var yesterday = now.AddDays(-1);

            //Console.WriteLine("LongDateString:  "+now.ToLongDateString());

            //Console.WriteLine("ShortDateString: "+now.ToShortDateString());

            //Console.WriteLine("LongTimeString: "+now.ToLongTimeString());

            //Console.WriteLine("ShortTimeString: "+now.ToShortTimeString());

            ////ToString()
            //Console.WriteLine("Display both date and time: "+ now.ToString());

            ////ToString() optionally takes format specifiers as input
            //Console.WriteLine("Time with customised format using format specifier: ");
            //Console.WriteLine(now.ToString("yy-mm-dd HH:mm tt"));

            //// format specifiers are m, M, d, t etc.



            ///////////////////////////////////////////////////////////////


            //TimeSpan -- represents length of time

            var timeSpan = new TimeSpan(1,0,0);
            Console.WriteLine(timeSpan);
            //TimeSpan(hour,minute,second);

            var timeSpan1= new TimeSpan(1,0,0);

            Console.WriteLine(timeSpan1);
            var timeSpan2= TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan2);

            var start=DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration:"+duration);

            //Properties
            Console.WriteLine("Minutes: "+timeSpan.Minutes);
            Console.WriteLine("Total Minutes: "+timeSpan.TotalMinutes); //convert hours to minutes and adds to minutes

            //Add
            Console.WriteLine("Add Example: "+timeSpan.Add(TimeSpan.FromMinutes(8)));

            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString"+timeSpan.ToString());
            Console.WriteLine("Parse: "+TimeSpan.Parse("01:02:03"));
        }
    }
}
