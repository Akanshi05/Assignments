using CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            CommonFunctions.NumericFunctions numericFunctions = new CommonFunctions.NumericFunctions();

            CommonFunctions.StringFunctions stringFunction = new CommonFunctions.StringFunctions();

            //Console.WriteLine(numericFunctions.Add(1, 2, 3));
            //numericFunctions.AllEven(10, 20);

            //List<int> ans = numericFunctions.TableOfNo(5);
            //foreach(int val in ans)
            //{
            //    Console.WriteLine(val);
            //}

            //List<List<int>> ans = numericFunctions.TableWithinRange(4, 6);
            //foreach(List<int> list in ans)
            //{
            //    foreach(int i in list)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(numericFunctions.Reverse(456));
            Console.WriteLine(stringFunction.CountOcc("tom is a cat tom is a cat tom is a cat","tom"));

        }
    }
}
