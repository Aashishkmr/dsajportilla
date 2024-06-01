using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Arrays
{
    public class MissingElement
    {
        public static int? FindMissingElement(List<int> arr1, List<int> arr2)
        {
            if (arr1.Count == arr2.Count)
            {
                return null;
            }

            var countDict = new Dictionary<int, int>();
            for (var i = 0; i < arr1.Count; i++)
            {
                if (countDict.ContainsKey(arr1[i]))
                {
                    countDict[arr1[i]]++;
                }
                else
                {
                    countDict[arr1[i]] = 1;
                }

                if (i < arr2.Count)
                {
                    if (countDict.ContainsKey(arr2[i]))
                    {
                        countDict[arr2[i]]--;
                    }
                    else
                    {
                        countDict[arr2[i]] = -1;
                    }
                }
            }
            foreach (KeyValuePair<int, int> entry in countDict)
            {
                if (entry.Value > 0)
                {
                    return entry.Key;
                }
            }
            return null;
        }
    }
}
