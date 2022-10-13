using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game");
            Console.WriteLine("You need to guess the number between 0 and 100.");
            Console.Write("Please, write the number of guesses you want : ");
            int numberofguess = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int realnumber = random.Next(0, 100);

            for (int i = numberofguess; i > 0; i--)
            {
                Console.Write("Enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess==realnumber)
                {
                    Console.WriteLine("Congratulations, You Won!");
                    i = 0;
                }

                else if (guess>realnumber&&i>1)
                {
                    Console.WriteLine("Unfortunately, the number is smaller than your guess. Try again.");
                }

                else if (guess<realnumber&&i>1)
                {
                    Console.WriteLine("Unfortunately, the number is bigger than your guess. Try again.");
                }
                numberofguess--;
            }

            if (numberofguess==0)
            {
                Console.WriteLine("Game over! The number was {0}.",realnumber);
            }

            Console.ReadLine();
        }
    }
}
