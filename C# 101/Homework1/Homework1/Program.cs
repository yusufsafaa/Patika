using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework4();
            Console.ReadLine();
        }


        static void Homework1()
        {
            // Question: In a console application, want from user to enter a positive number(n).
            //           After, want from the user to enter n positive numbers.
            //           Finally,print to the console even numbers that user entered  

            Console.Write("Please enter a positive number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You need to enter {0} positive numbers.", n);

            int[] numberarray = new int[n];
            
            for (int i = 1; i < n+1; i++)
            {
                
                Console.Write("Number {0}: ",i);
                numberarray[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Even numbers you entered: ");
            foreach (var number in numberarray)
            {
                if (number%2==0)
                {
                    Console.Write(" "+number+",");
                }
            }
        }

        static void Homework2()
        {
            // Question: In a console application, want from user to enter 2 positive numbers.(n,m)
            //           After, want from the user to enter n positive numbers.
            //           Finally,print the numbers that user entered, equal to m or divisible exactly in the console.

            Console.WriteLine("Please enter 2 positive numbers");
            Console.Write("First number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You need to enter {0} positive numbers.", n);

            int[] numberarray = new int[n];

            for (int i = 1; i < n + 1; i++)
            {

                Console.Write("Number {0}: ", i);
                numberarray[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var number in numberarray)
            {
                if (number==m)
                {
                    Console.WriteLine(number);
                }
                else if (number%m==0)
                {
                    Console.WriteLine(number);
                }
            }


        }

        static void Homework3()
        {
            // Question: In a console application, want from user to enter a positive number.(n)
            //           Then, want from the user to enter n words. 
            //           Finally, print the words that user entered from end to beginning.

            Console.Write("Please enter a positive number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("You need to enter 5 words.");

            string[] wordarray = new string[n];

            for (int i = 1; i < n+1; i++)
            {
                Console.Write("Word 1: ");
                wordarray[i - 1] = Console.ReadLine();
            }

            Array.Reverse(wordarray);

            foreach (var word in wordarray)
            {
                Console.WriteLine(word);
            }
        }

        static void Homework4()
        {
            // Question: In a console application, want from user to write a sentence.
            //           Print total words and total letters in the sentence to the console.

            Console.Write("Please enter a sentence: ");
            string sentence = Console.ReadLine();
            sentence=sentence.ToLower();

            int numberofcharacters = sentence.Count();

            string letters = "abcçdefgğhıijklmnoöprsştuüvyzxwq";

            int numberofletters = 0;
            for (int i = 0; i < numberofcharacters; i++)
            {
                if (letters.Contains(sentence[i]))
                {
                    numberofletters++;
                }
            }

            Console.WriteLine("Number of letters the sentence you entered: "+numberofletters);


            string[] words = sentence.Split(' ');

            Console.WriteLine("Number of words the sentence you entered: "+words.Length);
        }
    }
}
