using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_and_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Yusuf Safa Köksal";
            bool checking = name.CheckSpaces();

            if (checking)
            {
                Console.WriteLine(name.Replacement());
            }

            Console.WriteLine(name.MakeUpperCase());

            int[] array = { 23, 52, 15, 74, 63, 97, 10 };
            array.SortArray();
            array.Write();

            Console.ReadLine();
        }

        // Recursive Method (Özyinelemeli Method)
        public static void X(int a = 1)
        {
            Console.WriteLine("Hello");
            if (a < 3)
            {
                X(++a);                        // Sonsuz döngüyü önlemek için a değerini bir arttırıp bir sonraki X methodunu öyle başlatıyoruz
            }                                  // Eğer a++ yazsaydık önce a yı aynen gönderirdi sonra değerini 1 arttırırdı. Yani stackoverflow olurdu.
            Console.WriteLine("World");
        }

        // Recursive Method Example
        public static int Add(int firstnumber, int lastnumber)  // girilen 2 sayı arasındaki 5 ve 5'in katı olan sayıların toplamını veren recursive method.
        {

            if (firstnumber % 5 == 0 && firstnumber < lastnumber)
            {
                return firstnumber + Add(++firstnumber, lastnumber);
            }
            else if (firstnumber % 5 != 0 && firstnumber < lastnumber)
            {
                return Add(++firstnumber, lastnumber);
            }
            return 0;  // geriye 0 döndürüyoruz çünkü toplama işlemine bir etkisi yok. Çarpma yapsaydık 1 döndürürdük.

        }

        // Factorial Calculation with Recursive Method
        public static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;           // geriye 1 döndürüyoruz çünkü çarpma işlemine herhangi bir etkisi yok.
            }

            return Factorial(n - 1) * n;
        }

        // Exponential Numbers Calculation with Recursive Method
        public static int Expo(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            return Expo(number, power - 1) * number;
        }
    }

    public static class Calculation
    {
        // Extension Method

        // Static bir class içerisinde static bir metot olarak yazılmalılar.
        // Extension metod da tanımlı parametrelerden sadece 1 tanesi this ile tanımlanabilir.

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");       // param string'i boşluk içeriyorsa true döndürür.
        }

        public static string Replacement(this string param)
        {
            return param.Replace(" ", "-");   // ilk parametreye değiştirmek istediğimiz karakteri,ikinciye ise neye değiştirmek istediğimizi yazıyoruz.
        }

        
        public static string RemoveWhiteSpace(this string param)
        {                                         
                                                  // Bu method üstteki Replacement methoduyla aynı işlevi görüyor.
            string[] array = param.Split(' ');    // önce diziyi boşluklarla ayırıp bir array oluşturuyoruz.
            return string.Join("-", array);       // sonra bu arrayi ilk parametreyi kullanarak bağlıyoruz.
        }
        
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void Write(this int[] param)
        {
            foreach (var number in param)
            {
                Console.Write(number+" ");
            }
        }
    }
}
