using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // Files and Directory Classes NameSpace

namespace Files
{
    //************************* Section 9: Files *************************
    public class Program
    {
        public static void Main(string[] args)
        {

            ////File and FileInfo Class

            //var path = @"C:\Users\E272830\Desktop\God.jpg";
            ////File.Copy(@"C:\Users\E272830\Desktop\God.jpg", @"C:\Users\E272830\Desktop\Docs", true);

            //File.Delete(path);

            //if (File.Exists(path))
            //{
            //    //
            //}

            //var path2 = @"C:\Users\E272830\Desktop\text.txt";
            //var content = File.ReadAllText(path2);


            //var fileInfo = new FileInfo(path2);
            ////fileInfo.CopyTo("...");
            //fileInfo.Delete();

            //if (fileInfo.Exists)
            //{
            //    //
            //}

            /////////////////////////////////////////////////////////////////


            //////Directory and DirectoryInfo Class

            //Directory.CreateDirectory(@"C:\Users\E272830\Desktop\temp");


            //var files = Directory.GetFiles(@"C:\Users\E272830\Desktop", "*.jpg*", SearchOption.AllDirectories);

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //var directories = Directory.GetDirectories(@"C:\Users\E272830\Desktop", "*.*", SearchOption.AllDirectories);

            //foreach (var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //Console.WriteLine(Directory.Exists("C:\\Users\\E272830\\Desktop"));

            ////DirectoryInfo

            //var directoryInfo = new DirectoryInfo(@"C:\Users\E272830\Desktop");

            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();

            //Console.WriteLine(directoryInfo);

            /////////////////////////////////////////////////////////////////


            ////Path

            //var path = @"C:\Users\E272830\Desktop\God.jpg";

            //var dotIndex = path.IndexOf('.');
            //var extension = path.Substring(dotIndex);

            //Console.WriteLine("Extension: "+ Path.GetExtension(path));
            //Console.WriteLine("File Name: "+Path.GetFileName(path));
            //Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path));
            //Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

            /////////////////////////////////////////////////////////////////


            //----------------- Exercise 1: Section 9 -----------------

            //Q1
            // Write a program that reads a text file and displays the number of words.

            var path = @"C:\Users\E272830\Desktop\Docs\text.txt";

            Console.WriteLine(File.ReadAllText(path));

            //Q2
            //Write a program that reads a text file and displays the longest word in the file.

            var allText = File.ReadAllLines(path);

            int maxLen = int.MinValue;
            int maxPosn = 0;
            for (int i = 0; i < allText.Length;i++)
            {
                if (allText[i].Length > maxLen)
                {
                    maxLen = allText[i].Length;
                    maxPosn = i;
                }
            }

            Console.WriteLine("Max length word: " + allText[maxPosn]);
        }
    }
}