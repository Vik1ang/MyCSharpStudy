﻿using System.Text;

namespace Leetcode.Solution.q6;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        int n = s.Length, r = numRows;
        if (r == 1 || r >= n)
        {
            return s;
        }

        StringBuilder[] mat = new StringBuilder[r];
        for (int i = 0; i < r; i++)
        {
            mat[i] = new StringBuilder();
        }

        for (int i = 0, x = 0, t = r*2 - 2; i < n; i++)
        {
            mat[x].Append(s[i]);
            if (i % t < r - 1)
            {
                ++x;
            }
            else
            {
                --x;
            }
        }

        StringBuilder sb = new StringBuilder();
        foreach (StringBuilder row in mat)
        {
            sb.Append(row);
        }

        return sb.ToString();
    }
}