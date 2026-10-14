public class Solution
{
    public string MaxSumOfSquares(int num, int sum)
    {
        //okay we will ensure the most possible 9s since its the largest possibility
        //my runtime is SO BAD so if this doesnt worki'm going to bed 
        if (sum > num * 9) return "";

        char[] output = new char[num];
        int numberNines = sum / 9;
        int remainder = sum % 9;
        Array.Fill(output, '0');

        for (int i = 0; i < numberNines; i++) output[i] = '9';

        if (numberNines < num && remainder > 0) output[numberNines] = (char)('0' + remainder);

        return new string(output);
    }
}