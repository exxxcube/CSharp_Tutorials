using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge
{
    internal class CodingSolution
    {        
        public static int DuplicateCount(string str)
        {                                    
            char[] a = str.ToLower().ToCharArray();
            var s = a.GroupBy(x => x).Select(group => new { Item = group.Key, Count = group.Count() })
                .Where(itemcount => itemcount.Count > 1).Count();                        
            return s;
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> q = new List<T>(iterable);            
            var a = q.Where((c, index) => index == 0 || !object.Equals(c, q[index - 1]));
            return a.Cast<T>();
        }
        public static string Rot13(string input)
        {
            StringBuilder sb = new StringBuilder(input);
            Dictionary<char, char> a = new Dictionary<char, char>
            {
                { 'A', 'N' }, { 'B', 'O' }, { 'C', 'P' }, { 'D', 'Q' },
                { 'E', 'R' }, { 'F', 'S' }, { 'G', 'T' }, { 'H', 'U' },
                { 'I', 'V' }, { 'J', 'W' }, { 'K', 'X' }, { 'L', 'Y' },
                { 'M', 'Z' }, { 'N', 'A' }, { 'O', 'B' }, { 'P', 'C' },
                { 'Q', 'D' }, { 'R', 'E' }, { 'S', 'F' }, { 'T', 'G' },
                { 'U', 'H' }, { 'V', 'I' }, { 'W', 'J' }, { 'X', 'K' },
                { 'Y', 'L' }, { 'Z', 'M' },
                { 'a', 'n' }, { 'b', 'o' }, { 'c', 'p' }, { 'd', 'q' },
                { 'e', 'r' }, { 'f', 's' }, { 'g', 't' }, { 'h', 'u' },
                { 'i', 'v' }, { 'j', 'w' }, { 'k', 'x' }, { 'l', 'y' },
                { 'm', 'z' }, { 'n', 'a' }, { 'o', 'b' }, { 'p', 'c' },
                { 'q', 'd' }, { 'r', 'e' }, { 's', 'f' }, { 't', 'g' },
                { 'u', 'h' }, { 'v', 'i' }, { 'w', 'j' }, { 'x', 'k' },
                { 'y', 'l' }, { 'z', 'm' }
            };
            for (int i = 0; i < sb.Length; i++)
            {                
                if (a.ContainsKey(sb[i]))
                {                    
                    sb[i] = Convert.ToChar(a[sb[i]]);
                }                
            }
            string newString = sb.ToString();
            return newString;
        }
        public static string Add(string a, string b)
        {
            BigInteger number1;
            BigInteger number2;
            if (BigInteger.TryParse(a, out number1) && BigInteger.TryParse(b, out number2))
            {                
                return (number1 + number2).ToString();                
            }
            return string.Empty;              
        }
        public static string GetReadableTime(int seconds)
        {
            //Write a function, which takes a non-negative integer (seconds) as
            //input and returns the time in a human-readable format (HH:MM:SS)

            //HH = hours, padded to 2 digits, range: 00 - 99
            //MM = minutes, padded to 2 digits, range: 00 - 59
            //SS = seconds, padded to 2 digits, range: 00 - 59
            //The maximum time never exceeds 359999 (99:59:59)

            //You can find some examples in the test fixtures.

            TimeSpan a = TimeSpan.FromSeconds(seconds);                                    
            return seconds <= 359999? 
                String.Format("{0:D2}:{1:D2}:{2:D2}", (int)a.TotalHours, a.Minutes, a.Seconds) : string.Empty;
        }
    }
}
