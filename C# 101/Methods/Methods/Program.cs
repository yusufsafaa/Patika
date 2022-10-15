using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(5, 92);
            int abc = Add3(64, 26);
            Console.WriteLine(abc);

            string name1 = "Yusuf Safa";
            Console.WriteLine(name1);     // Geçerli değişkeni ref yapısı kullanarak değiştirme !!
            namemethod(ref name1);        // Örneğin kredi durumlarında bazı müşterilere ek indirim falan olursa böyle değiştirilir.Alt örnekteki gibi
            Console.WriteLine(name1);     // çıktısı "Köksal" olur. Eğer ref kullanmasaydık "Yusuf Safa" olurdu.

            int credit1 = 20;
            Console.WriteLine("Normally our credit rate is 20 ,but your credit rate is {0} due to the fact that you are our private customer.", creditmethod(ref credit1));
                                               // Out da ref e benzer ama daha önceden değişkene değer atama zorunluluğu yoktur.
            Console.WriteLine(credit1);         // ancak methodun içinde değişkene değer atanması zorunludur !

            Console.WriteLine(multiply(5, 7,2));

            Console.WriteLine(infinitiveislem(1, 2, 3, 4, 5, 6, 7));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Method was called!");
        }

        static void Add2(int number1,int number2)
        {
            Console.WriteLine(number1 + number2);
        }       

        static int Add3(int number3, int number4=40) // Burada *son değişkene* bir default değer verebiliriz.
        {                                            // Yani eğer ona sayı değeri girilmezse default değerle hesaplanır.
            int sonuc = number3 + number4;           
            return sonuc;

            // Yukarıdaki iki satır olmadan direkt böyle de yapılabilirdi. |  return number1 + number2;
        }

        // Ref
        static void namemethod(ref string name1)
        {
            name1 = "Köksal";
           
        }

        // Example ref usage
        static int creditmethod(ref int credit1)
        {
            credit1 = 30;
            return credit1;
        }

        static int multiply(int number1,int number2)
        {
            return number1 * number2;
        }

        
        // Method Overloading
        static int multiply(int number1, int number2,int number3) // adı üstteki method ile aynı ve böyle kullanılabilir. 
        {                                                         // int multiply(int number1,int number2) kısmı methodun imzasıdır.
            return number1 * number2* number3;
        }

        // Params
        static int infinitiveislem(int number1,params int[] numbers)// params dizilere girer ve hesap makinesi gibi istediğimiz kadar sayı girmeye yarar.
        {                                                           // params son parametre olmak zorundadır ancak ondan önce istersek int tanımlayabiliriz
            return numbers.Sum()+ number1;
        }
    }
}
