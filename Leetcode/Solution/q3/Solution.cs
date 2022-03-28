namespace Leetcode.Solution.q3;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0;
        int right = 0;
        Dictionary<char, int> window = new Dictionary<char, int>();

        int length = 0;

        while (right < s.Length)
        {
            char c = s[right];
            if (!window.ContainsKey(c))
            {
                window[c] = 1;
            }
            else
            {
                window[c]++;
            }

            while (window[c] == 2)
            {
                char d = s[left];
                if (window.ContainsKey(d))
                {
                    window[d]--;
                }
                left++;
            }

            length = Math.Max(length, right - left + 1);
            right++;
        }

        return length;
    }
}