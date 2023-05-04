using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class eligibility
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the marks obtained in Physics");
            int phyMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry");
            int chemMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics");
            int mathMarks = Convert.ToInt32(Console.ReadLine());

            int total = phyMarks + chemMarks + mathMarks;
            Boolean cond1 = ((phyMarks>=55) && (chemMarks>=50) && (mathMarks>=65) && (total>=180));

            Boolean cond2 = (mathMarks + phyMarks) >= 140;

            if(cond1 || cond2)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible");
            }
        }
    }
}
