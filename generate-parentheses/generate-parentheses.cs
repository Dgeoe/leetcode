public class Solution 
{
    public IList<string> GenerateParenthesis(int n) 
    {
        IList<string> output = new List<string>();
        char[] s = new char[n * 2];

        int holder = 0;
        int count = 0;

        Random r = new Random();

        // no of recursive valid combinations 
        int required = 1;

        for (int i = 0; i < n; i++)
        {
            required = required * 2 * (2 * i + 1) / (i + 2);
        }

        while (holder < required)
        {
            int x = r.Next(0, 2);

            if (x == 0) s[count] = ')';
            else s[count] = '(';

            count++;

            if (count == n * 2)
            {
                string result = new string(s);

                if (IsValid(result) && !output.Contains(result))
                {
                    output.Add(result);
                    holder++;
                }

                count = 0;
            }
        }

        return output;
    }

    bool IsValid(string s)
    {
        int count = 0;

        foreach (char c in s)
        {
            if (c == '(') count++;
            else count--;

            if (count < 0) return false;
        }

        return count == 0;
    }
}