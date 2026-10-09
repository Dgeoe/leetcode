public class Solution {
    public int MinInsertions(string s) {
        int count = 0, brackets = 0;

        for (int i = 0; i <  s.Length; i++)
        {
            if (s[i] == '(') count ++;
            else
            {
                //if closed skipp
                if (i + 1 < s.Length && s[i + 1] == ')') i ++;
                else brackets ++;

                //check for unmatched openings
                if (count > 0) count --;
                else brackets ++; 
            }
        }
        
        //evey left needs 2 right 
        return brackets + (count * 2);
    }
}