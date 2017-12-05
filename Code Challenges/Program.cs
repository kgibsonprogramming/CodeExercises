using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord("fun&!! time"));
            Console.WriteLine(LongestWord("I love dogs"));
            Console.ReadLine();
        }

        public static string LongestWord(string sens)
        {
            int wordLength = 0;
            string longestWord = "";
            string[] inputSplit;
            StringBuilder sb = new StringBuilder();

            foreach (char c in sens)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }
            inputSplit = sb.ToString().Split(' ');

            foreach (string s in inputSplit)
            {
                if (s.Length > wordLength)
                {
                    longestWord = s;
                    wordLength = s.Length;
                }
            }

            return "The longest word is " + longestWord + " at " + wordLength + " characters.";
        }
    }
}
