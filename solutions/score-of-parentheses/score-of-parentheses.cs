public class Solution {
    public int ScoreOfParentheses(string s) 
    {
        int finalValue = 0, opens = 0;
        for (int i = 0; i < s.Length; i ++)
        {
            if (s[i] == '(') opens ++;
            else
            {
                if (s[i - 1] == '(')
                {
                    int value = 1;

                    for (int j = 0; j < opens - 1; j++) value = value * 2;

                    finalValue = finalValue + value;
                }

                opens--;
            }
        }
        return finalValue;
    }
}