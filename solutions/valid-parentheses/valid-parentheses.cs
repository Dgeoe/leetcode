public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> pairs = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            //Add Openings
            if (s[i] == '(') pairs.Push(s[i]);
            else if (s[i] == '[') pairs.Push(s[i]);
            else if (s[i] == '{') pairs.Push(s[i]);
            else
            {
                if (pairs.Count == 0) return false;
                
                //Else Compare Against Closings
                if (s[i] == ')' && pairs.Peek() == '(') pairs.Pop();
                else if (s[i] == ']' && pairs.Peek() == '[') pairs.Pop();
                else if (s[i] == '}' && pairs.Peek() == '{') pairs.Pop();
                else return false;
            }
        }

        if (pairs.Count == 0) return true;
        else return false;
    }
}