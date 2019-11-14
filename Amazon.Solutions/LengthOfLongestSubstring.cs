/*
给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。

输入: "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Amazon.Solutions
{
    public static partial class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var dict = new Dictionary<char, int>();
            var length = 0;
            for (int i = 0, j = 0; j < s.Length; j++)
            {
                if (dict.ContainsKey(s[j]))
                    i = Math.Max(dict[s[j]] + 1, i);
                //发现重复字符时不必从开始位置逐个后移，而是直接将起始位置移动到重复字符之后
                //因为重复字符之后的子串只是之前最长子串的子串

                length = Math.Max(j - i + 1, length);
                dict[s[j]] = j;
            }

            return length;
        }
    }
}