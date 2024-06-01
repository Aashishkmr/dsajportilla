using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Arrays
{
    public class ArrayPairSum
    {

        /// <summary>
        /// Given a list of unique integers and an integer k. Find all the pairs in list that sum up to k.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static List<(int, int)> GetPairsSum(IEnumerable<int> numbers, int sum)
        {

            var result = new List<(int, int)> ();
            var dict = new Dictionary<int, int>();

            foreach(var num in numbers)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(sum - num, num);
                }
                else
                {
                    result.Add((sum-num, num));
                    dict.Remove(num);
                }
            }
            return result;
        }

        public static List<(int, int)> GetPairsSumDuplicate(IEnumerable<int> numbers, int sum)
        {

            var result = new List<(int, int)>();
            var dict = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (dict.ContainsKey(sum - num) && dict[sum-num] > 0)
                {
                    result.Add((sum-num, num));
                    dict[sum - num]--;
                    continue;
                }
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }
            return result;
        }
    }
}
