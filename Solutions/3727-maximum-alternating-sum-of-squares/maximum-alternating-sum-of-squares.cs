public class Solution {
    public long MaxAlternatingSum(int[] nums) 
    {
        int[] arr = new int[nums.Length];
        long output = 0;
        int left = 0;
        int right = nums.Length - 1;
        //rearragnege to best fit pattern (largest every other) (negatives in between)
        //Ensure sort by largest value ignoring + or - notation 
        Array.Sort(nums, (a, b) => Math.Abs((long)a).CompareTo(Math.Abs((long)b)));

        for (int i = 0; i < arr.Length; i ++)
        {
            if (i % 2 == 0)
            {
                arr[i] = nums[right];
                right--;
            }
            else
            {
                arr[i] = nums[left];
                left++;
            }
        }
        //add and return

        for(int i = 0; i < arr.Length; i++)
        {
            long square = (long)arr[i] * arr[i];

            if (i % 2 == 0) output += square;
            else output -= square;
        }

        return output;
    }
}