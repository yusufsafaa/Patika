using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Yusuf Safa"; //21
            string sentence2 = "I am a Computer Engineer."; //24

            // Length, Clone
            int result1 = sentence.Length; // Kaç karakterden oluştuğunu söyler.
            var result2 = sentence.Clone(); // Aynısından bir tane daha klonlayarak bir değişken oluşturur.Sonradan o değişken değişse de klon değişmez!

            // Startswith, Endswith
            bool result3 = sentence.StartsWith("My name"); // Belirtilen ifade ile başlayıp başlamadığını kontrol eder.
            bool result4 = sentence.EndsWith("B");  //Belirtilen ifade ile bitip bitmediğini kontrol eder.

            // IndexOf, LastIndexOf
            int result5 = sentence.IndexOf("is");  // Belirtilen ifadeyi aramaya yarar. Kaçıncı karakterden itibaren başladığını söyler.Eğer bulamazsa -1 döndürür!!
            int result6 = sentence.LastIndexOf(" "); // Yine aramaya yarar ancak aramaya sondan başlar.

            // Insert, Substring
            var result7 = sentence.Insert(1, "Hello "); // Cümleye 1. karakterden itibaren verilen ifadeyi ekle
            var result8 = sentence.Substring(5, 4); // 5. karakterden başlayıp 4 tane karakter al

            // ToLower, ToUpper
            string result9 = sentence.ToLower(); // Bütün karakterleri küçültmeye yarar.
            string result10 = sentence.ToUpper(); // Bütün karakterleri büyültmeye yarar.

            // Replace, Remove
            string result11 = sentence.Replace(" ", "-");  // Boşlukları çizgi ile değiştirmeye yarar.
            string result12 = sentence.Remove(2,2); // 2. karakterden başlayıp 2 tane karakteri atmaya yarar.

            // Concat
            string result13 = String.Concat(sentence, " Köksal"); // İlk parametredeki değişkene ikinci parametredeki ifadeyi ekler.

            // Compare, CompareTo
            int result14 = sentence.CompareTo(sentence2); // 0,1,-1 döndürür. Eğer ilk değişken ikincisine eşitse 0 döndürür. Birinci değişkenin karakter sayısı > 2. den ise 1 döndürür.
            int result15 = String.Compare(sentence, sentence2, true); // True dersek karşılaştırmada büyük küçük harf duyarsızdır.
            int result16 = String.Compare(sentence, sentence2, false); // Büyük küçük harf duyarlıdır.

            // Contains
            bool result17 = sentence.Contains(" "); // Belirtilen değişkenin içerisindeki istenilenin olup olmadığını kontrole yarar.

            // PadLeft, PadRight
            string result18 = sentence.PadRight(40) + sentence2; // Birinci değişkenin sonuna 40 karaktere tamamlayacak kadar boşluk ekle.
            string result19 = sentence.PadRight(40, '*') + sentence2; //Birinci değişkenin sonuna 40 karaktere tamamlayacak kadar '*' ekle.
            string result20 = sentence + sentence2.PadLeft(40);
            string result21 = sentence + sentence2.PadLeft(40, '#');

            // Split
            string[] array = sentence.Split(' '); // Değişkeni boşluklarla ayır ve dizi oluştur.
            foreach (var word in array)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(result18);
 
            Console.ReadLine();
        }
    }
}
