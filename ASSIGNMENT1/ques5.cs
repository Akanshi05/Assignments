using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class ques5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for loop
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            //while loop
            int j = 0;
            while (j < arr.Length)
            {
                if (arr[j] % 2 == 0)
                {
                    Console.WriteLine(arr[j]);
                }
                j++;
            }

            //do-while loop
            int k = 0;
            do
            {
                if (arr[k] % 2 == 0)
                {
                    Console.WriteLine(arr[k]);
                }
                k++;

            } while (k < arr.Length);
        }

    }
    
}
