using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Arrays
{
    public class ArrayRunner
    {
        public static void StartArrayRunner()
        {
            Console.WriteLine("Arrays");
            //Question 1: Anagram Check
            Console.WriteLine("Anagram Check");
            var isAnagram = AnagramCheck.CheckAnagram("abc", "abd");
            Console.WriteLine("Anagram Check Result -" + isAnagram.ToString());

            //Question2: Array Pair Sum 
            Console.WriteLine("Array Pair Sum Unique Elements");
            var arrayPairs = ArrayPairSum.GetPairsSum(new List<int> { 1, 4, 0, 9, 8, 6, 3, 5, 7 }, 9);
            arrayPairs.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Array Pair Sum Duplicate Elements");
            var arrayPairs2 = ArrayPairSum.GetPairsSumDuplicate(new List<int> { 1, 1, 3, 1, 3 }, 4);
            arrayPairs2.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Find Missing Element");
            var missingElement = MissingElement.FindMissingElement(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 1, 2, 3, 4 });
            Console.WriteLine(missingElement);

            Console.WriteLine("Largest Contiguous sum");
            var largestSum = LargestContiguosSum.GetLargestContiguousSum(new List<int> { 1, 2, -1, 3, 4, 10, 10, -10, -1 });
            Console.WriteLine(largestSum);

            Console.WriteLine("String compression");
            var compressedString = StringCompression.CompressString("AAABBBBDDDSSSHHHHHSSSSSAAA");
            Console.WriteLine(compressedString);

            Console.WriteLine("Is unique characters");
            var isUnique = UniqueCharacter.IsUniqueCharacters("abcdefghijklmnopqrstuvwxyz");
            Console.WriteLine(isUnique);
        }
    }
}
