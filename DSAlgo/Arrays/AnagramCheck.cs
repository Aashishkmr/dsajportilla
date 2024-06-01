using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Arrays
{
    public class AnagramCheck
    {
        /// <summary>
        /// Given two strings check if they are anagram of each other. Ignore spaces for this.
        /// Anagrams have equal length and dame frequency of each letter in them
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool CheckAnagram(string str1, string str2)
        {
            str1 = str1.Replace(" ", "");
            str2 = str2.Replace(" ", "");
            
            if(str1.Length != str2.Length)
            {
                return false;
            }

            var charCounts = new Dictionary<char, int>();

            for (var i=0; i< str1.Length; i++)
            {
                if (charCounts.ContainsKey(str1[i]))
                {
                    charCounts[str1[i]]++;
                }
                else
                {
                    charCounts[str1[i]] = 1;
                }

                if (charCounts.ContainsKey(str2[i]))
                {
                    charCounts[str2[i]]--;
                }
                else
                {
                    charCounts[str2[i]] = -1;
                }
            }

            foreach(KeyValuePair<char,int> entry in charCounts)
            {
                if(entry.Value > 0 || entry.Value < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
