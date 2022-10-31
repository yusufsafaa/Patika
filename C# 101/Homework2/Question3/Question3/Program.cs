using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution of third question
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            sentence.ToLower();

            string vowels = "ıiuüoöae";

            int sentencelength = sentence.Count();

            List<char> vowelsList = new List<char>();
            for (int i = 0; i < sentencelength; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    if (!vowelsList.Contains(sentence[i]))
                    {
                        vowelsList.Add(sentence[i]);
                    }
                 
                }
            }

            Console.Write("Vowels in this sentence ===>  ");
            foreach (var item in vowelsList)
            {
                Console.Write(item+", ");
            }


            Console.ReadLine();
        }
    }
}
