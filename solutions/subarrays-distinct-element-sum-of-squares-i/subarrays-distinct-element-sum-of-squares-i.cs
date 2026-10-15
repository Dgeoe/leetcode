public class Solution {
    public int SumCounts(IList<int> nums) 
    {
        int output = 0;
        //calcuate distinct values  
        //square and add

        for (int start = 0; start < nums.Count; start++)
        {
            HashSet<int> distincts = new HashSet<int>();

            for (int end = start; end < nums.Count; end++)
            {
                distincts.Add(nums[end]);

                int count = distincts.Count;
                output += count * count;
            }
        }
        return output;
    }
}