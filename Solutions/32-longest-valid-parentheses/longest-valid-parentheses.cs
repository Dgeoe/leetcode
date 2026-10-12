public class Solution
{
    public int LongestValidParentheses(string s)
    {
        int[] newList = new int[s.Length + 1];
        int currentTop = 0;
        newList[0] = -1;

        int longest = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') newList[++currentTop] = i;
            else
            {
                currentTop--;

                if (currentTop < 0)
                {
                    currentTop = 0;
                    newList[currentTop] = i;
                }
                else longest = Math.Max(longest, i - newList[currentTop]);
            }
        }
        return longest;
    }
}