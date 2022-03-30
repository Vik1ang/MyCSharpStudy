namespace Leetcode.Solution.q5;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        string res = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            string s1 = Palindrome(s, i, i);
            string s2 = Palindrome(s, i, i + 1);

            res = res.Length > s1.Length ? res : s1;
            res = res.Length > s2.Length ? res : s2;
        }

        return res;
    }

    private string Palindrome(string s, int left, int right)
    {
        while (left >= 0 && right <s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return s.Substring(left + 1, right - left - 1);
    }
}