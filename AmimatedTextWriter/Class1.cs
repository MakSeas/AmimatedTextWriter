using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmimatedTextWriter
{
    public static class AnimatedTextWriter
    {
        public static bool enableAnimation = true;

        public static void WriteAnimatedText(string text, int intervalBetweenLetters, bool enter)
        {
            List<char> letters = new List<char>();

            for(int i = 0; i < text.Length; i++)
            {
                letters.Add(text[i]);
            }

            int k = 0;

            foreach(char letter in letters)
            {
                Console.Write(letter);

                if (enableAnimation)
                    Thread.Sleep(intervalBetweenLetters);

                if (enter)
                {
                    if (k == text.Length - 1)
                        Console.WriteLine();

                    k++;
                }
            }
        }
    }
       
}
