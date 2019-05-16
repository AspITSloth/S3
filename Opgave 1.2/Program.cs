using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =
            {
                "herp",
                "derp",
                "ferp",
                "lerp",
                "nerp"
            };

            while (true)
            {
                try
                {
                    Console.WriteLine(CapitalizedWords(words));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);                    
                }
                
                Console.WriteLine();

                Console.ReadKey(true);
            }
        }

        static string CapitalizedWords(string[] words)
        {
            string wordsToString = string.Empty;

            foreach (var word in words)
            {
                if (char.IsLetter(word[0]))
                {
                    wordsToString = wordsToString + word[0].ToString().ToUpper() + word.Substring(1) + " ";             
                }
                else
                {
                    throw new Exception("A word did not start with a letter");
                }
            }

            return wordsToString;
        }
    }
}
