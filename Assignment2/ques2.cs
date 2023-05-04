using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ques2
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { 1, 4, 2 }, { 3, 6, 8 },{5,7,9} };
            int sum = 0;

            foreach(int num in arr)
            {
                sum += num;
            }

            //2nd type of loop
            //for(int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        sum += arr[i,j];
            //    }
            //}
            Console.WriteLine(sum);
        }
    }
}
