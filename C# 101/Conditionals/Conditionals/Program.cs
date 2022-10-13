using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 101;
            if (number1 == 7)
            {
                Console.WriteLine("The number you entered is"+ number1);
            }
            else
            {
                Console.WriteLine("The number you entered is not" + number1);
            }

            int month = DateTime.Now.Month;
            
            
            switch (month)
            {
                case 3:    // ATTENTİON! Dont forget to put colon in the end.
                    Console.WriteLine("You are in March.");
                    break;

                case 10:
                    Console.WriteLine("You are in October");  
                    break;   // In switch loop we shouldn't forget to write "break" in the end.

                default:   // It means else.
                    Console.WriteLine("You are not in either March or October.");
                    break;
            }

            switch (month)
            {
                case 11:
                case 12:
                case 1:
                    Console.WriteLine("You are in Winter.");
                    break;

                case 2:
                case 3:
                case 4:
                    Console.WriteLine("You are in Spring.");
                    break;

                case 5:
                case 6:
                case 7:
                    Console.WriteLine("You are in Summer.");
                    break;

                default:
                    Console.WriteLine("You are in Autumn");
                    break;
            }






            Console.WriteLine(number1 == 7 ? "Number 1 is 7" : "Number 1 is not 7");     // SINGLE LİNE METHOD
            Console.ReadLine();
        }
    }
}
