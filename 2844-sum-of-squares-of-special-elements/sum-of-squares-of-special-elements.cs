public class Solution {
    public int SumOfSquares(int[] nums) {
        
        List<int> specials = new List<int>();
        int output = 0;
        for (int i = 0; i < nums.Length; i ++)
        {
            if (nums.Length % (i+1) == 0) specials.Add(nums[i]);
        }

        foreach (int i in specials)
        {
            output = output + (i * i);
        }

        return output;

    }
}