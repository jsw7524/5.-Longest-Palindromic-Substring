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
            List<string> palindromes = new List<string>();
            for (int left = 0; left < s.Length; left++)
            {
                Console.WriteLine(" ");
                for (int right = left; right < s.Length; right++)
                {
                    int l = left;
                    int r = right;
                    while (r > l)
                    {
                        if (s[r] == s[l])
                        {
                            r--;
                            l++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (r <= l)
                    {
                        palindromes.Add(s.Substring(left, right - left + 1));
                        Console.WriteLine(s+ " Palindrome:" + s.Substring(left, right - left + 1));
                    }
                }
            }
            return palindromes.OrderByDescending(p => p.Length).First();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( (new Solution()).LongestPalindrome("baaaa"));
            Console.ReadKey();
        }
    }
}
