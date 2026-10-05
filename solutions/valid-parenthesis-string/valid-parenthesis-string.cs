public class Solution {
    public bool CheckValidString(string s) {
        int min = 0, max = 0;
        //if (s.Length < 2 && s[0] != '*') return false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') 
            {
                min++;
                max++;
            }
            else if (s[i] == ')') 
            {
                min--;
                max--;
            }
            else if (s[i] == '*') 
            {
                min--;
                max++;
            }

            if (min < 0) min = 0;
            if (max < 0) return false;

        }

        if (min == 0) return true;
        else return false;
    }
}