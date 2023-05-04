using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT1
{
    internal class ques3
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32((Console.ReadLine()));
            char op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(result(num1,num2, op));
            
        }

        static int result(int num1,int num2,char op)
        {
            if(op == '+')
            {
                return (num1 + num2);
            }
            else if(op ==  '-')
            {
                return (num1 - num2);
            }
            else if(op == '*')
            {
                return (num1 * num2);
            }
            else
            {
                return (num1 / num2);
            }
        }
    }
}
