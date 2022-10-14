using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[3];
            cities[0] = "İstanbul";                                           //Type 1 for arrays
            cities[1] = "Ankara";
            cities[2] = "Samsun";

            string[] cities2 = new[] { "Samsun", "İstanbul", "Ankara" };        //Type 2 

            string[] cities3 = { "Ankara", "Samsun", "İstanbul" };            //Type 3 

            string[] cities4 = new string[3] { "Samsun", "Ankara", "İstanbul" };       //Type 4 
            cities4[2] = "Sinop";

            Console.WriteLine(cities4[2]);

            Console.WriteLine(new string('*',30));

            // Multidimensional Arrays
            string[,] teams = new string[3, 4]  // number 3 refers to leagues and number 4 refers to teams.
            {
                {"Beşiktaş ","Galatasaray ","Trabzonspor ","Fenerbahçe " },
                {"Arsenal","Chelsea","Man. City","Man. Utd." },                     
                {"Barcelona","Real Madrid","Atletico Madrid","Sevilla" }
            };

            for (int i = 0; i <= teams.GetUpperBound(0); i++)   
            {
                for (int j = 0; j <= teams.GetUpperBound(1); j++)  // number 1 refers to the first dimension.
                {
                    Console.WriteLine(teams[i,j]);
                }
                Console.WriteLine("---------");
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 30));
            Console.WriteLine();


            // Sort
            int[] numberarray = { 13, 52, 86, 32, 23, 5, 37, 69 };

            Console.WriteLine("****Unordered Array****");
            foreach (var number in numberarray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Array.Sort(numberarray);
            Console.WriteLine("****Ordered Array****");
            foreach (var number in numberarray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Clear
            Console.WriteLine("****Array Clear****");
            Array.Clear(numberarray, 3, 2);           // It clears two elements starting from third element.
            foreach (var number in numberarray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Reverse
            Console.WriteLine("****Array Reverse****");
            Array.Reverse(numberarray);
            foreach (var number in numberarray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // IndexOf
            Console.WriteLine("****Array IndexOf****");
            Console.WriteLine(Array.IndexOf(numberarray,52));      // It shows where the number 52 is
            Console.WriteLine();

            // Resize
            Console.WriteLine("****Array Resize****");
            Array.Resize<int>(ref numberarray, 9);
            numberarray[8] = 44;
            foreach (var number in numberarray)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Count
            Console.WriteLine("****Array Count****");
            int numberofelements = numberarray.Count();    // It shows the number of elements of array.
            Console.WriteLine(numberofelements);

            BubbleSorting();

            Console.ReadLine();
        }

        public static void BubbleSorting()
        {
            int[] array=new int[] { 8, 3, 5, 1, 7, 6 };
            int length = array.Length;

            Console.WriteLine("******* Array Without Sorting *******");
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            int temp = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("******* Array After Sorting *******");
            foreach (var number in array)
            {
                Console.Write(number+" ");
            }

        }
    }
}
