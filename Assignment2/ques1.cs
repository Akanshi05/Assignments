using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ques1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = arr.Sum();
            Console.WriteLine(sum);
            int avg = sum/ arr.Length;
            Console.WriteLine(avg);
        }
    }
}
