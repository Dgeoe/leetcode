public class Solution {

    public int MinAddToMakeValid(string s) {
        int opens = 0;
        int closes = 0;

        if (s == "") return 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                opens++;
            }
            else if (s[i] == ')')
            {
                if (opens > 0) opens--;
                else closes++;
            }
        }
        //if (opens == closes) return 0;
        return opens + closes;
    }
}