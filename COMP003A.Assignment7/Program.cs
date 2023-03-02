/*
2    * Author: Robert Leftridge
3    * Course: COMP-003A
4    * Purpose: Array and List Activity Lecture
5    * 
6    */

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter Section");

            string letter;
            Console.WriteLine("Please enter a letter: ");
            letter= Console.ReadLine();
            char lett = Convert.ToChar(letter);

            string word;
            Console.WriteLine("Please enter a word: ");
            word = Console.ReadLine();
            


            SectionSeparator("Array - IsPalindrome Section");





            SectionSeparator("List - Add section");

        }

        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".
            PadRight(50, '*'));
        }
        static int CharacterCounter(char characterinput, string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++) 
            {
                count++;
            }
            characterinput = char.ToLower(characterinput);
            word = word.ToLower();
            return count;
        }

        static bool IsPalindrome(string word)
        {
            if (word.Length <= 1)
                return true;
            else
            {
                if (word[0] != word[word.Length-1])
                    return false;
                else 
                    return IsPalindrome(word.Substring(1, word.Length-2));
            }
        }

        static void TraverseList(List<string>list)
        {

        }

        static void TraverseListReverse(List<string>list) 
        {

        }
    }
}