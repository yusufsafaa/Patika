using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution of second question
            int number;
            ArrayList numberList = new ArrayList(); 
            for (int i = 0; i < 20; i++)
            {
                number = int.Parse(Console.ReadLine());
                numberList.Add(number);
            }
            numberList.Sort();
            ArrayList lowNumbers = new ArrayList();
            ArrayList highNumbers = new ArrayList();
            for (int i = 0; i < 3; i++)
            {
                lowNumbers.Add(numberList[i]);
            }
            for (int i = 17; i < 20; i++)
            {
                highNumbers.Add(numberList[i]);
            }

            int totalhigh = 0;
            Console.Write("The biggest numbers are ");
            foreach (var item in highNumbers)
            {
                Console.Write(item + " ");
                totalhigh += Convert.ToInt32(item);
            }
            int highavarage = totalhigh/3;
            
            Console.WriteLine();

            int totallow = 0;
            Console.Write("The smallest numbers are ");
            foreach (var item in lowNumbers)
            {
                Console.Write(item+" ");
                totallow += Convert.ToInt32(item);
            }
            int lowavarage = totallow/3;

            Console.WriteLine();

            Console.WriteLine("Total of biggest numbers is "+totalhigh);
            Console.WriteLine("Total of smallest numbers is " + totallow);
            Console.WriteLine("Avarage of biggest numbers is " + highavarage);
            Console.WriteLine("Avarage of smallest numbers is "+lowavarage);

            Console.ReadLine();
        }
    }
}
