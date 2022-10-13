using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // This homework was given by Patika.dev
            
            
            // Atama ve İşlemli Atama
            int x = 5;
            int y = 6;

            y = y + 2;
            y += 2;  // üsttekinin kısa syntaxı

            x = x * 4;
            x *= 4;  //kısa syntax

            
            
            
            // Mantıksal Operatorler
            // &&, ||, !

            bool isTrue = true;
            bool isFalse = false;

            if (isTrue&&isFalse)
            {
                Console.WriteLine("is not working.");
            }

            if (isTrue || isFalse)
            {
                Console.WriteLine("working");
            }

            if (isTrue&& !isFalse)
            {
                Console.WriteLine("working");
            }

            
            
            // İlişkisel Operatorler
            // <,>,<=,>=,==,!=

            int number1 = 10;
            int number2 = 20;
            bool result = number1 != number2;
            Console.WriteLine(result); // Çıktı true

            
            
            // Aritmetik Operatorler
            // *,/,+,-
            
            int a = 35;
            int b = 7;
            int result2 = a / b;
            Console.WriteLine(result2); // Çıktı 5


            // Mod alma
            // %

            int c = a % 4;
            Console.WriteLine(c); // Çıktı 3
        }
    }
}
