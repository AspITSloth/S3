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
                Console.WriteLine(CapitalizedWords(words));
                Console.WriteLine();

                Console.ReadKey(true);
            }
        }

        static string CapitalizedWords(string[] words)
        {
            string wordsToString = string.Empty;

            foreach (var word in words)
            {
                wordsToString = wordsToString + word[0].ToString().ToUpper() + word.Substring(1) + " ";             
            }

            return wordsToString;
        }
    }
}
