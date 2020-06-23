using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        public static bool CheckAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            if (str1 == str2)
                return true;

            int charLength = 128;

            int[] counter = new int[charLength];

            for (int i = 0; i < str1.Length; i++)
            {
                counter[str1[i] - 'a']++;
                counter[str2[i] - 'a']--;
            }

            for (int c = 0; c < charLength; c++)
            {
                if (counter[c] != 0) return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string str1 = "abbcs";
            string str2 = "aaaaa";
            string str3 = "basbc";
            Console.WriteLine(CheckAnagram(str1,str2));
            Console.WriteLine(CheckAnagram(str1,str3));

        }
    }
}
