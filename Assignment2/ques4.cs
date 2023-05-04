using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ques4
    {
        static void Main(string[] args)
        {
            //column wise sum
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8,9 } };
            for(int col = 0; col < arr.GetLength(1); col++)
            {
                int sum = 0;
                for(int row = 0; row < arr.GetLength(0); row++)
                {
                    sum += arr[row,col];
                }
                Console.WriteLine("sum of this col is {0} ",sum);
            }
        }
    }
}
