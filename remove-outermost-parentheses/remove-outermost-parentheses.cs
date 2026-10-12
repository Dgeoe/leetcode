public class Solution {
    public string RemoveOuterParentheses(string s) {
        //s has to be valid so we can just immediatly start popping brackets that dont add up
        int count = 0;
        int holder = 1;
        List<char> output = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                count ++;
            } 
            else 
            {
                count --;
            }

            if (count == 0)
            {
                while (holder < i)
                {
                    output.Add(s[holder]);
                    holder ++;
                }
                holder = i + 2;
            }
        }
        string final = new string(output.ToArray());
        return final;
    }
}