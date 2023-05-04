using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class StringFunctions
    {
        public int FindCharacters(string str)
        {
            return str.Length;
        }

        public bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }

        public string ReverseSentence(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        public string ConvertUpperCase(string str)
        {
            return str.ToUpper();
        }

        public string ConvertLowerCase(string str)
        {
            return str.ToLower();
        }

        public string CombineTwoSentence(string str1,string str2)
        {
            string ans = String.Concat(str1,str2);
            return ans;
        }

        public string RemoveSpaces(string str)
        {
            return Regex.Replace(str, @"\s+", " ");
        }

        public int CountWords(string str)
        {

            int count = 1;
            foreach(char ch in str)
            {
                if(ch == ' ') count++;
            }
            return count;
        }

        public bool SearchSubString(string str, string substr)
        {
            return str.Contains(substr);
        }

        public int CountOcc(string str,string substr)
        {
            
            
            int count = str.ToLower().Split(substr.ToLower()).Length - 1;

            return count;
        }
    }
}
