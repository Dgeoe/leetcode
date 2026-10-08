public class Solution
{
    public IList<string> RemoveInvalidParentheses(string input)
    {
        HashSet<string> answers = new HashSet<string>();
        int leftRemove;
        int rightRemove;

        FindRemovals(input, out leftRemove, out rightRemove);
        Redo(input, 0, "", 0, leftRemove, rightRemove, answers);

        return answers.ToList();
    }

    private void FindRemovals(string input, out int leftRemove, out int rightRemove)
    {
        leftRemove = 0;
        rightRemove = 0;

        foreach (char c in input)
        {
            if (c == '(')
            {
                leftRemove++;
            }
            else if (c == ')')
            {
                if (leftRemove > 0) leftRemove--;
                else rightRemove++;
            }
        }
    }

    private void Redo(string input, int pos, string currentAnswer, int balance, int leftRemove, int rightRemove, HashSet<string> answers)
    {
        if (pos == input.Length)
        {
            if (leftRemove == 0 && rightRemove == 0 && balance == 0) answers.Add(currentAnswer);

            return;
        }

        char c = input[pos];

        if (c == '(')
        {
            // Keep (
            Redo(input, pos + 1, currentAnswer + c, balance + 1, leftRemove, rightRemove, answers);

            // Remove (
            if (leftRemove > 0) Redo(input, pos + 1, currentAnswer, balance, leftRemove - 1, rightRemove, answers);
        }
        else if (c == ')')
        {
            // Keep ) only if we have ( already 
            if (balance > 0) Redo(input, pos + 1, currentAnswer + c, balance - 1, leftRemove, rightRemove, answers);

            // Remove )
            if (rightRemove > 0) Redo(input, pos + 1, currentAnswer, balance, leftRemove, rightRemove - 1, answers);
        }
        else
        {
            // Non Brackets
            Redo(input, pos + 1, currentAnswer + c, balance, leftRemove, rightRemove, answers);
        }
    }
}