using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_and_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************DateTime***********************");
            // DateTime
            Console.WriteLine("DateTime.Now ".PadRight(45,'-')+">  " + DateTime.Now);
            Console.WriteLine("DateTime.Now.Date ".PadRight(45, '-') + ">  " + DateTime.Now.Date);
            Console.WriteLine("DateTime.Now.Day ".PadRight(45, '-') + ">  " + DateTime.Now.Day);
            Console.WriteLine("DateTime.Now.Month ".PadRight(45, '-') + ">  " + DateTime.Now.Month);
            Console.WriteLine("DateTime.Now.Year ".PadRight(45, '-') + ">  " + DateTime.Now.Year);
            Console.WriteLine("DateTime.Now.Hour ".PadRight(45, '-') + ">  " + DateTime.Now.Hour);
            Console.WriteLine("DateTime.Now.Minute ".PadRight(45, '-') + ">  " + DateTime.Now.Minute);
            Console.WriteLine("DateTime.Now.Second ".PadRight(45, '-') + ">  " + DateTime.Now.Second);
            Console.WriteLine("DateTime.Now.Millisecond ".PadRight(45, '-') + ">  " + DateTime.Now.Millisecond);
            Console.WriteLine("DateTime.Now.DayOfWeek ".PadRight(45, '-') + ">  " + DateTime.Now.DayOfWeek);
            Console.WriteLine("DateTime.Now.DayOfYear ".PadRight(45, '-') + ">  " + DateTime.Now.DayOfYear);

            Console.WriteLine();

            Console.WriteLine("DateTime.Now.ToLongDateString() ".PadRight(45, '-') + ">  " + DateTime.Now.ToLongDateString());
            Console.WriteLine("DateTime.Now.ToShortDateString() ".PadRight(45, '-') + ">  " + DateTime.Now.ToShortDateString());
            Console.WriteLine("DateTime.Now.ToLongTimeString() ".PadRight(45, '-') + ">  " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("DateTime.Now.ToShortTimeString() ".PadRight(45, '-') + ">  " + DateTime.Now.ToShortTimeString());

            Console.WriteLine();

            Console.WriteLine("DateTime.Now.AddDays(2) ".PadRight(45, '-') + ">  " + DateTime.Now.AddDays(2));
            Console.WriteLine("DateTime.Now.AddHours(3) ".PadRight(45, '-') + ">  " + DateTime.Now.AddHours(3));
            
            Console.WriteLine();

            Console.WriteLine("******************DateTime Format**********************");
            // DateTime Format
            Console.WriteLine("DateTime.Now.ToString('dd') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("dd"));
            Console.WriteLine("DateTime.Now.ToString('ddd') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("ddd"));
            Console.WriteLine("DateTime.Now.ToString('dddd') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("dddd"));

            Console.WriteLine("DateTime.Now.ToString('MM') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("MM"));
            Console.WriteLine("DateTime.Now.ToString('MMM') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("MMM"));
            Console.WriteLine("DateTime.Now.ToString('MMMM') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("MMMM"));

            Console.WriteLine("DateTime.Now.ToString('yy') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("yy"));
            Console.WriteLine("DateTime.Now.ToString('yyyy') ".PadRight(45, '-') + ">  " + DateTime.Now.ToString("yyyy"));
            
            Console.WriteLine();

            Console.WriteLine("******************Math Library**********************");
            // Math Library
            Console.WriteLine("Math.Abs(-53) ".PadRight(45, '-') + ">  " + Math.Abs(-53)); // absolute value.
            Console.WriteLine("Math.Sin(10) ".PadRight(45, '-') + ">  " + Math.Sin(10));
            Console.WriteLine("Math.Tan(10) ".PadRight(45, '-') + ">  " + Math.Tan(10));

            Console.WriteLine();

            Console.WriteLine("Math.Ceiling(22.3) ".PadRight(45, '-') + ">  " + Math.Ceiling(22.3)); // It prints the minimum integer value greater than 22.3
            Console.WriteLine("Math.Round(22.51) ".PadRight(45, '-') + ">  " + Math.Round(22.51));   // It rounds the number
            Console.WriteLine("Math.Floor(22.7) ".PadRight(45, '-') + ">  " + Math.Floor(22.7));   // It prints the maximum integer value smaller than 22.7

            Console.WriteLine();

            Console.WriteLine("Math.Min(2,6) ".PadRight(45, '-') + ">  " + Math.Min(2,6));
            Console.WriteLine("Math.Max(2,6) ".PadRight(45, '-') + ">  " + Math.Max(2,6));

            Console.WriteLine();

            Console.WriteLine("Math.Pow(3,4) ".PadRight(45, '-') + ">  " + Math.Pow(3,4));  // ==3^4
            Console.WriteLine("Math.Sqrt(64) ".PadRight(45, '-') + ">  " + Math.Sqrt(64));
            Console.WriteLine("Math.Log(9) ".PadRight(45, '-') + ">  " + Math.Log(9));
            Console.WriteLine("Math.Log10(100) ".PadRight(45, '-') + ">  " + Math.Log10(100));
            Console.WriteLine("Math.Exp(3) ".PadRight(45, '-') + ">  " + Math.Exp(3));
            

            Console.ReadLine();
        }
    }
}
