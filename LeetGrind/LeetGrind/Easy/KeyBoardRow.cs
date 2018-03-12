using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetGrind.Easy
{
    public static class KeyBoardRow
    {
        // Given a List of words, return the words that can be typed using letters of 
        //alphabet on only one row's of American keyboard like the image below.
        //two



        public static string[] FindWords1(string[] words)
        {

            string[] top = new string[10] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p" };
            string[] mid = new string[9] { "a", "s", "d", "f", "g", "h", "j", "k", "l" };
            string[] bot = new string[7] { "z", "x", "c", "v", "b", "n", "m" };

            List<string> results = new List<string>();
            foreach (string word in words)
            {
                if (Check(word, top) || Check(word, mid) || Check(word, bot))
                {
                    results.Add(word);
                }
            }

            return results.ToArray();
        }

        public static bool Check(string word, string[] row)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!row.Contains(word[i].ToString().ToLower()))
                {
                    return false;
                }
            }

            return true;
        }





        //I did this one. 
        public static string[] FindWords2(string[] words)
        {
            var result = new List<string>();

            if (words.Length == 0) return result.ToArray();

            var keyboard = new HashSet<char>[3];
            keyboard[0] = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
            keyboard[1] = new HashSet<char>() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
            keyboard[2] = new HashSet<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };



            foreach (var word in words)
            {
                if (word == "") continue;
                var curRow = -1;

                foreach (var c in word)
                {
                    if (curRow == -1)
                    {
                        for (int i = 0; i < keyboard.Length; i++)
                        {
                            if (keyboard[i].Contains(char.ToLower(c)))
                            {
                                if (curRow == -1) curRow = i;
                            }
                        }
                    }
                    else
                    {
                        if (!keyboard[curRow].Contains(char.ToLower(c)))
                        {
                            curRow = -1;
                            break;
                        }
                    }
                }

                if (curRow != -1)
                {
                    result.Add(word);
                }
            }

            return result.ToArray();
        }



        //four
        public static string[] FindWords3(string[] words)
        {
            char[] row1Upper = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
            char[] row2Upper = { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
            char[] row3Upper = { 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

            int count = words.Length;
            for (int i = 0; i < words.Length; i++)
            {

                string word = words[i].ToUpper();
                char[] wordChars = word.ToCharArray();
                bool lettersInRow1 = false;
                bool lettersInRow2 = false;
                bool lettersInRow3 = false;
                for (int j = 0; j < wordChars.Length; j++)
                {
                    lettersInRow1 = row1Upper.Contains(wordChars[j]) || lettersInRow1;
                    lettersInRow2 = row2Upper.Contains(wordChars[j]) || lettersInRow2;
                    lettersInRow3 = row3Upper.Contains(wordChars[j]) || lettersInRow3;
                    if (lettersInRow1 && lettersInRow2) { words[i] = ""; count--; break; }
                    if (lettersInRow1 && lettersInRow3) { words[i] = ""; count--; break; }
                    if (lettersInRow2 && lettersInRow3) { words[i] = ""; count--; break; }
                }
            }
            string[] wordsInARow = new string[count];
            int newIndex = 0;
            for (int k = 0; k < words.Length; k++)
            {
                if (!String.IsNullOrEmpty(words[k]))
                {
                    wordsInARow[newIndex] = words[k];
                    newIndex++;
                }
            }
            return wordsInARow;
        }
    }
}
