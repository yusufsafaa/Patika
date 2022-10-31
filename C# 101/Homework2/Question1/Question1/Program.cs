using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solution of first question
            ArrayList numberList = new ArrayList();
            int counter = 0;
            while (counter < 20)
            {
                var number = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(number) < 0)
                    {
                        Console.WriteLine("Please enter a positive number!");
                    }
                    else
                    {
                        numberList.Add(number);
                        counter++;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please do not enter anything except number!");
                }
            }

            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                if (IsPrime(Convert.ToInt32(numberList[i])))
                {
                    primeNumbers.Add(numberList[i]);
                }
                else
                {
                    notPrimeNumbers.Add(numberList[i]);
                }
            }

            int totalprime = 0;
            foreach (var item in primeNumbers)
            {
                totalprime += Convert.ToInt32(item);
            }

            int totalnotprime = 0;
            foreach (var item in notPrimeNumbers)
            {
                totalnotprime += Convert.ToInt32(item);
            }


            primeNumbers.Sort();
            primeNumbers.Reverse();
            notPrimeNumbers.Sort();
            notPrimeNumbers.Reverse();

            Console.Write("Prime Numbers ====>  ");
            foreach (var item in primeNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.Write("Non Prime Numbers ====>  ");
            foreach (var item in notPrimeNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Number of prime numbers : " + primeNumbers.Count);
            Console.WriteLine("Number of non prime numbers : " + notPrimeNumbers.Count);

            int numberofprimenumbers = primeNumbers.Count;
            int numberofnotprimenumbers = notPrimeNumbers.Count;

            Console.WriteLine("Avarage of prime numbers : " + totalprime / numberofprimenumbers);
            Console.WriteLine("Avarage of non prime numbers : " + totalnotprime / numberofnotprimenumbers);

            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
