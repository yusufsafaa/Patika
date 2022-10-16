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

            // Ref parameter
            string name1 = "Yusuf Safa";
            Console.WriteLine(name1);     // Geçerli değişkeni ref yapısı kullanarak değiştirme !!
            namemethod(ref name1);        // Örneğin kredi durumlarında bazı müşterilere ek indirim falan olursa böyle değiştirilir.Alt örnekteki gibi
            Console.WriteLine(name1);     // çıktısı "Köksal" olur. Eğer ref kullanmasaydık "Yusuf Safa" olurdu.

            // Ref parameter example
            int credit1 = 20;
            Console.WriteLine("Normally our credit rate is 20 ,but your credit rate is {0} due to the fact that you are our private customer.", creditmethod(ref credit1));
            Console.WriteLine(credit1);           // Out da ref e benzer ama daha önceden değişkene değer atama zorunluluğu yoktur.
                                                  // ancak methodun içinde değişkene değer atanması zorunludur !


            // Out parameter
            Console.WriteLine(Addition(34, 51, out int resultofaddition));
            
            
            // TryParse with out parameter 
            string number = "345";
            int outnumber;

            bool result = int.TryParse(number,out outnumber); // İlk parametreye parse etmek istediğimiz sayıyı ikinciye ise parse ettikten sonra alacağı değeri atıyoruz.

            if (result)
            {
                Console.WriteLine("Conversion is succesful!");
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }
                

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

        
        // Ref parameter
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

        // Out parameter
        static int Addition(int number1,int number2, out int result)
        {
            result = number1 + number2;
            return result;
        }


        
        // Method Overloading
        static int multiply(int number1, int number2,int number3) // adı üstteki method ile aynı ve böyle kullanılabilir. 
        {                                                         // multiply(int number1,int number2) kısmı methodun imzasıdır. 
            return number1 * number2* number3;                    // geri dönüş tipi methodun imzasına dahil değildir!
        }

        
        // Params
        static int infinitiveislem(int number1,params int[] numbers)// params dizilere girer ve hesap makinesi gibi istediğimiz kadar sayı girmeye yarar.
        {                                                           // params son parametre olmak zorundadır ancak ondan önce istersek int tanımlayabiliriz
            return numbers.Sum()+ number1;
        }
    }
}
