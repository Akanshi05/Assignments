using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            //created demo directory
            if (!Directory.Exists("C:\\Demo"))
            {
                Directory.CreateDirectory("C:\\Demo");
            }

            //created demo1
            if (!Directory.Exists("C:\\Demo\\Demo1"))
            {
                Directory.CreateDirectory("C:\\Demo\\Demo1");
            }

            //created demo2
            if (!Directory.Exists("C:\\Demo\\Demo2"))
            {
                Directory.CreateDirectory("C:\\Demo\\Demo2");
            }

            //adding files in demo directory using file
            if (!File.Exists("C:\\Demo\\file1.txt"))
            {
                File.Create("C:\\Demo\\file1.txt");
            }

            //adding files in demo directory using fileInfo
            if (!File.Exists("C:\\Demo\\file2.txt"))
            {
                FileInfo fs = new FileInfo("C:\\Demo\\file2.txt");
                fs.Create();
            }

            //adding some text in files
            //string file = @"C:\Demo\file1.txt";
            //string secondFile = @"C:\Demo\file2.txt";

            // To write all of the text to the file
            // string text = "This is some text in file1";
            //string text2 = "This is some text in file2";
            //File.AppendAllText(file, text);
            //File.AppendAllText(secondFile, text2);
            //if (!File.Exists("C:\\Demo\\Demo2\\file3.txt"))
            //{
            //    File.Create("C:\\Demo\\Demo2\\file3.txt");
            //}



            //copy files to another folder
            //string sourcePath = @"C:\Demo\file2.txt";
            //string targetPath = @"C:\Demo\Demo2\file3.txt";
            //File.Copy(sourcePath, targetPath, true);

            Console.WriteLine("Get file Name in directory");
            string fileName1 = @"C:\Demo\Demo1";
            string[] fileName = Directory.GetFiles(fileName1);
            foreach (string fileName2 in fileName)
            {
                Console.WriteLine(fileName2);
                FileInfo file = new FileInfo(fileName2);
                DateTime dt = file.CreationTime;
                Console.WriteLine("Creation Time: " + dt);
            }



            if (File.Exists("C:\\Demo\\Demo2\\file3.txt"))
            {
                File.Delete("C:\\Demo\\Demo2\\file3.txt");
            }

        }
    }

}
