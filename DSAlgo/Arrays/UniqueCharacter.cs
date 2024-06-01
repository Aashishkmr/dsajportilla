using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Arrays
{
    public class UniqueCharacter
    {
        public static bool IsUniqueCharacters(string input)
        {
            var charCounts = new Dictionary<char, int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (charCounts.ContainsKey(input[i]))
                {
                    return false;
                }
                else
                {
                    charCounts[input[i]] = 1;
                }
            }
            return true;
        }
    }
}
