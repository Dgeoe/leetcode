public class Solution
{
    public long MinSumSquareDiff(int[] nums1, int[] nums2, int k1, int k2)
    {
        long output = 0;
        long operations = (long)k1 + k2;
        List<int> holder = new List<int>();

        // find the differences
        for (int i = 0; i < nums1.Length; i++)
        {
            holder.Add(Math.Abs(nums1[i] - nums2[i]));
        }

        // sort from largest down
        holder.Sort((a, b) => b.CompareTo(a));

        for (int i = 0; i < holder.Count; i++)
        {
            int current = holder[i];
            int next = (i + 1 < holder.Count) ? holder[i + 1] : 0;
            long needed = (long)(current - next) * (i + 1);

            if (operations >= needed)
            {
                operations -= needed;

                if (next == 0)
                {
                    return 0;
                }
            }
            else
            {
                // remaining operations split between largest differences
                long reduceBy = operations / (i + 1);
                long extra = operations % (i + 1);

                for (int j = 0; j <= i; j++)
                {
                    holder[j] = current - (int)reduceBy;

                    if (j < extra)
                    {
                        holder[j]--;
                    }
                }

                break;
            }
        }

        // square eachother nd add 
        foreach (int i in holder)
        {
            output += (long)i * i;
        }

        return output;
    }
}