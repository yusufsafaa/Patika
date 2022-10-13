using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try // we writes codes that we want to keep under control to this line.
            {
                Console.Write("Enter a number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The number you entered is "+number1);
            }
            catch (Exception ex) // if there is a differency from "try" line, this line works.
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            finally // whether there is an error or not this line always works. To write this line is not compulsory!!
            {
                Console.WriteLine("This sentence is always written.");
            }

            try
            {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("2334543050434379");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You did not entered any value.");
                Console.WriteLine(ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("You entered the value in wrong format.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("You either exceeded max value or entered very small value.");
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
