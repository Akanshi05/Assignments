using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class countDuplicate
    {
        public static void Main(string[] args)
        {
            string[] inp = (Console.ReadLine()).Split(" ");
            int[] arr = new int[inp.Length];
            for (int i = 0; i < inp.Length; i++)
            {
                arr[i] = Convert.ToInt32(inp[i]);
            }
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int,int>();
            for(int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                if (map.ContainsKey(key))
                {
                    map[key]++;
                }
                else
                {
                    map.Add(key, 1);
                }
                 
                
            }

            foreach(KeyValuePair<int,int> pair in map)
            {
                if(pair.Value >= 2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

}
