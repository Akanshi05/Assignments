using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public static class NumericFunctionsExtended
    {
        static NumericFunctions numeric;
        public static List<int> AllEven(this NumericFunctions numericFunction,int start,int end)
        {
            List<int> list = new List<int>();
            for(int i = start; i <= end; i++)
            {
                if(numeric.IsEven(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static List<int> AllOdd(this NumericFunctions numericFunction,int start,int end)
        {
            List<int> list = new List<int>();
            for(int i=start; i <= end; i++)
            {
                if(numeric.IsOdd(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static List<int> AllPrime(this NumericFunctions numericFunction,int start,int end)
        {
            List<int> list= new List<int>();   
            for(int i=start; i <= end; i++)
            {
                if (numeric.IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static List<int> TableOfNo(this NumericFunctions numericFunction,int num)
        {
            List<int> list = new List<int>();
            for(int i = 0; i <= 10; i++)
            {
                list.Add(num * i);
            }
            return list;
        }


        
        public static List<List<int>> TableWithinRange(this NumericFunctions numericFunction,int start,int end)
        {
            List<List<int>> list = new List<List<int>>();
            for(int i = start; i <= end; i++)
            {
                List<int> smallList = new List<int>();
                for (int j = 0; j <= 10; j++)
                {
                    smallList.Add(i * j);
                }
                list.Add(smallList);

            }
            return list;
        }

        public static int Reverse(this NumericFunctions numericFunction,int num)
        {
            string str = num.ToString();
            StringBuilder sb = new StringBuilder();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return Convert.ToInt32(sb.ToString());
        }

    }
}
