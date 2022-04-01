using static System.Int32;

namespace Leetcode.Solution.q7;

public class Solution
{
    public int Reverse(int x)
    {
        int rev = 0;
        while (x != 0)
        {
            if (rev is < int.MinValue / 10 or > int.MaxValue / 10)
            {
                return 0;
            }
            int digit = x % 10;
            x /= 10;
            rev = rev * 10 + digit;
        }

        return rev;
    }
}