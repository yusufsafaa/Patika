using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = new string[6] { "Turkey", "Germany", "Holland", "Sweden", "USA", "England" };
            
            foreach (var country in countries)
            {
                Console.WriteLine("The best country in the world is {0}", country);     // Forting the arrays with foreach loop
            }
            for (int i = 0; i <= countries.GetUpperBound(0); i++)          // Sorting the arrays with for loop
            {
                Console.WriteLine(countries[i]);
            }
            
            
            
            
            int number = 3;  // If the number had not provided the condition, nevertheless this loop would return one time.
            do               
            {
                Console.WriteLine(number);   // Do While loop
                number--;
            } while (number > 0);


            Counter();

            // IsPrimeNumber();
            
            

            Console.ReadLine();
        }

        static void IsPrimeNumber()      // Prime Number Application
        {
            Console.Write("Enter the number you wonder whether it is prime or not: ");
            int enterednumber = Convert.ToInt32(Console.ReadLine());
            
            bool result = true;
            for (int i = 2; i < enterednumber; i++)
            {

                if (enterednumber % i == 0)
                {
                    result = false;
                    i = enterednumber;
                }


            }

            if (result)
            {
                Console.WriteLine("This is a Prime Number");
            }
            else
            {
                Console.WriteLine("This is not a Prime Number");
            }


        }

        static void Counter()
        {
            Console.Write("Please enter a number: ");
            int number1 = int.Parse(Console.ReadLine());
            int sumofsingle = 0;
            int sumofeven = 0;
            
            for (int i = 1; i <= number1; i++)
            {
                if (i%2==0)
                {
                    sumofeven += i;
                }
                else
                {
                    sumofsingle += i;
                }
            }

            Console.WriteLine("Sum of single numbers is "+sumofsingle);
            Console.WriteLine("Sum of even numbers is " + sumofeven);

            // break, continue

            for (int i = 0; i <10 ; i++)
            {
                if (i==4)
                {
                    break;  // It interrupts after 3. It means we see 3 as a last number.
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    continue;  // It means we see all the numbers from 0 to 10 except 4.
                }
                Console.WriteLine(i);
            }

            // to print all the letter from a to z
            char letter1 = 'a';
            while (letter1<'z'+1)
            {
                Console.WriteLine(letter1);
                letter1++;
            }
        }
    }
}
