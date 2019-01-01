using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUppercaseWordLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program finds the uppercase words in a string");
            string sentence = "LIFE isn't about waiting till the storm to PASS, it's about learning how to DANCE in the RAIN";

            var foundWord = Filter(sentence);

            Console.WriteLine("The upper case words are:");
            foreach (var word in foundWord)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();            
        }
        static IEnumerable <string> Filter (string sentence)
        {
            var upperWord = sentence.Split(' ')
                            .Where(x => String.Equals(x, x.ToUpper(),
                            StringComparison.Ordinal));
            return upperWord;
        }
    }
}
