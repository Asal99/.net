using System;
using System.Collections.Generic;

namespace Ncit_lab_asal1
{
    class StringManipulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string? input = Console.ReadLine();

            if (input != null)
            {
                // Print individual characters in reverse order
                Console.WriteLine("Individual characters in reverse order:");
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(input[i]);
                }

                // Display occurrence of individual characters
                Dictionary<char, int> charOccurrences = new Dictionary<char, int>();
                foreach (char c in input)
                {
                    if (charOccurrences.ContainsKey(c))
                        charOccurrences[c]++;
                    else
                        charOccurrences[c] = 1;
                }

                Console.WriteLine("Character Occurrences:");
                foreach (var kvp in charOccurrences)
                {
                    Console.WriteLine("'" + kvp.Key + "': " + kvp.Value + " times");
                }
            }
            else
            {
                Console.WriteLine("Input string is null.");
            }
        }
    }
}
