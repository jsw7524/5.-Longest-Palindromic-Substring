using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            bool[,] dp = new bool[s.Length + 1, s.Length + 1];
            int maxLength = 1;
            int palindromeStart = 0;
            int palindromeEnd = 0;

            for (int i = 0; i < s.Length; i++)
            {
                dp[i, i] = true;
                dp[i + 1, i] = true;
            }

            for (int j = 1; j < s.Length; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    if (s[i] == s[j] && true == dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;
                        if (j - i + 1 > maxLength)
                        {
                            maxLength = j - i + 1;
                            palindromeStart = i;
                            palindromeEnd = j;
                        }
                    }
                }
            }
            return s.Substring(palindromeStart, palindromeEnd - palindromeStart + 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Solution()).LongestPalindrome("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));


            Console.ReadKey();
        }
    }
}
