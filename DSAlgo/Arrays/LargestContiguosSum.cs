namespace DSAlgo.Arrays
{
    public class LargestContiguosSum
    {
        public static int GetLargestContiguousSum(List<int> input)
        {
            int maxSum = input[0];
            int currentSum = input[0];
            foreach(var num in input)
            {
                currentSum = Math.Max(currentSum+num, num);
                maxSum= Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }

        //public static (int,int) GetContiguousSumIndex(List<int> input)
        //{
        //    int maxSum = input[0];
        //    int currentSum = input[0];
        //    int start = 0, end = 0;
        //    for(var i=0; i<input.Count; i++)
        //    {
        //        if (input[i] > currentSum + input[i]) 
        //        {
        //            start = i;
        //            end = i;
        //            currentSum
        //        }
        //    }
        //}
    }
}
