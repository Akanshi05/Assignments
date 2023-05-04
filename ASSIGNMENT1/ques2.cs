using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class ques2
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add, subtract, multiply, divide;

            result(num1, num2, out add, out subtract, out multiply, out divide);

            Console.WriteLine(add);
            Console.WriteLine(subtract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
        }

        static void result(int num1,int num2,out int add,out int subtract,
            out int multiply,out int divide)
        {
            add = num1 + num2;
            subtract = num1 - num2;
            multiply = num1 * num2;
            divide = num1 / num2;

        }
    }
}
