using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Arrays
{
    public class StringCompression
    {
        public static string CompressString(string str)
        {
            var result = "";
            char ch = '\0';
            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(i == 0)
                {
                    ch = str[i];
                    count++;
                    continue;
                }
                if (char.Equals(str[i], str[i-1]))
                {
                    count++;
                }
                else
                {
                    result+= $"{ch}{count}";
                    ch = str[i];
                    count = 1;
                }
            }
            result += $"{ch}{count}"; 
            return result;
        }
    }
}
