using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
             
            
            int number1 = 8; // It occupies 32 bit in RAM
            long number2 = 930219213123029; // It can be longer numbers than int variable and occupies 64 bit in RAM
            short number3 = 32767; // It occupies 16 bit in RAM.
            byte number4 = 255; // It's max value is 255 and occupies 8 bit in RAM.
            double number5 = 3.7; // It can take rational numbers value and occupies 64 bit in RAM.
            float number0 = 5.8f; // For rational numbers.It is obligated to put f in the end.
            decimal number6 = 20.25235235M; // It can take longer value than double variable. This is obligation to put M letter end of the number.
            var number7 = 5; // Var değişkeni neye atarsak türünü o yapar burada 5 e atadık ve number 7 int oldu. 
            number7 = 'A';
            int number8 = 'B'; // B harfinin sayı olarak karşılığının değerini aldı.
                        
            char letter1 = 'D';
            bool condition1 = false; // It can take only two value.These are true and false.

            int deneme1 = 69;  // It translates int to char value.
            var a = 653;
            a = 'C';

            DateTime dateTime = DateTime.Now; //It shows date information of that day.
            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH:mm");

            string str20 = "20";
            int int20 = 20;
            string newValue = str20 + int20.ToString();  // 2020

            int int21 = int20 + Convert.ToInt32(str20); // 40

            int int22 = int20 + int.Parse(str20); // 40 parse sadece stringi integer a çevirmek için kullanılır.

            Console.WriteLine("Number 1 is {0}", number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is "+number3);
            Console.WriteLine("{0} karakterinin sayı değeri = {1}", letter1,(int)letter1); // We can transform char to int in this way.
            Console.WriteLine(days.Friday);
            Console.WriteLine((int)days.Saturday);
            Console.WriteLine("{0} günü haftanın {1}. günüdür",days.Wednesday,(int)days.Wednesday);
            Console.WriteLine(number8);
            Console.WriteLine((char)deneme1);
            Console.WriteLine(a);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime2);
            Console.WriteLine(hour);
            Console.ReadLine();
        }

        
    }
    enum days
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
