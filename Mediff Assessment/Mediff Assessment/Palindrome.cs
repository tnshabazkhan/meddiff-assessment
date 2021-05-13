using System;
using System.Collections.Generic;
using System.Text;

namespace Mediff_Assessment
{
    public class Palindrome
    {
        public bool CheckForPalindrom(string word)
        {
            int reverseCounter = word.Length - 1;
            for (int i = 0; i < word.Length / 2; i++, reverseCounter--)
            {
                if (word[i] != word[reverseCounter])
                {
                    //this statement is just to print the output, not an actual part of the function
                    Console.WriteLine("String {0} is not a Palindrome", word);
                    return false;
                }
            }

            //this statement is just to print the output, not an actual part of the function
            Console.WriteLine("String {0} is a Palindrome", word);
            return true;
        }
    }
}
