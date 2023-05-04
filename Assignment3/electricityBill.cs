using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class electricityBill
    {
        public static void checkBill(ref double billAmount,ref double surchargeAmount)
        {
            if (billAmount < 100)
            {
                billAmount = 100;
            }
            else if (billAmount > 400)
            {
                billAmount += ((15 / 100) * billAmount);
                surchargeAmount = ((15 / 100) * billAmount);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter unit consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());
            /*
             * upto 199	                                @1.20
                200 and above but less than 400	        @1.50
                400 and above but less than 600	        @1.80
                600 and above	                        @2.00
             */
            double billAmount = 0;
            double chargedUnit;
            double surchargeAmount = 0;

            if (units <= 199)
            {
                billAmount += (units * 1.20);
                chargedUnit = 1.20;
            }
            else if(units>=200 && units < 400)
            {
                billAmount += (units * 1.50);
                chargedUnit = 1.50;
            }
            else if(units>=400 && units < 600)
            {
                billAmount += (units * 1.80);
                chargedUnit = 1.80;
            }
            else
            {
                billAmount += (units * 2.00);
                chargedUnit = 2.00;
            }

            

            checkBill(ref billAmount,ref surchargeAmount);
            string bill = "";
            bill += "Customer IDNO " + id + "\n" + "Name " + name+"\n" +
                     "units consumed " + units+"\n" +
                     "Amount charges " + chargedUnit + " per unit : " +
                     billAmount + "\n";

            Console.WriteLine(bill);

        }
    }
}
