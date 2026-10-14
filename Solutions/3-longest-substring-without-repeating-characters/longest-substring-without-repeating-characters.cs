public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int output = 0;

        for (int start = 0; start < s.Length; start++)
        {
            HashSet<char> storage = new HashSet<char>();
            int count = 0;

            for (int i = start; i < s.Length; i++)
            {
                char c = s[i];

                if (storage.Contains(c)) break;

                storage.Add(c);
                count++;

                if (output < count) output = count;
            }
        }

        return output;
    }
}