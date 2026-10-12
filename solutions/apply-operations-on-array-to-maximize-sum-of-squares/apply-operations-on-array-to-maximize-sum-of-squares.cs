using System.Collections.Generic;

public class Solution
{
    public int MaxSum(IList<int> nums, int k)
    {
        long output = 0;
        List<int> holder = new List<int>();

        // choose 2 from nums 
        // set to binary and add or compare

        int[] results = new int[31];

        // Count how many numbers have each bit
        foreach (int num in nums)
        {
            for (int b = 0; b < 31; b++)
            {
                if ((num & (1 << b)) != 0)
                {
                    results[b]++;
                }
            }
        }

        for (int i = 0; i < k; i++)
        {
            int x = 0;

            for (int b = 0; b < 31; b++)
            {
                if (results[b] > 0)
                {
                    // add bit to x
                    x |= (1 << b);

                    // remove after use
                    results[b]--;
                }
            }

            holder.Add(x);
        }

        // take k from largest down
        // square each, add together, return output
        foreach (int i in holder)
        {
            output = (output + (long)i * i) % 1000000007;
        }

        return (int)output;
    }
}