using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array List
            ArrayList arrayList = new ArrayList();  // Array'lerdeki gibi önceden belirlediğimiz sınıra uyma zorunluluğu yoktur.
            arrayList.Add("Samsun");                // Değişik veri tipleri bir arada tutulabilir. Ancak array de nasıl tanımlanmış ise o tutulurdu.
            arrayList.Add(55);
            arrayList.Add('A');

            // AddRange
            List<string> colors = new List<string>() {"red","blue","yellow","green"};  
            arrayList.AddRange(colors);                                                 // We can add more than one item at once with AddRange.

            
            
            
            // Dictionary
            Dictionary<int, string> teams = new Dictionary<int, string>();     // int==key , string==value
            teams.Add(1, "Manchester City");                                   // Keys must be unique.
            teams.Add(3, "Liverpool");
            teams.Add(2, "Chelsea");
            Console.WriteLine(teams[2]);
            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }
            
            // Contains
            Console.WriteLine(teams.ContainsKey(2));
            Console.WriteLine(teams.ContainsValue("Arsenal"));

            // Keys
            foreach (var item in teams.Keys)
            {
                Console.WriteLine(item);
            }
            // Items
            foreach (var item in teams.Values)
            {
                Console.WriteLine(item);
            }

            
            
            
            // Generic List
            List<int> numberList = new List<int>();
            numberList.Add(6);
            numberList.Add(3);
            numberList.Add(1);
            numberList.Add(8);

            // Count
            Console.WriteLine(numberList.Count);

            // Foreach and List.ForEach
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }

            numberList.ForEach(number => Console.WriteLine(number));  // Alternative ForEach syntax in one line

            // Removing item from list
            numberList.Remove(3);          // It removes number 3 from list.
            numberList.RemoveAt(2);        // It removes the number that is at second index.

            // Searching in List
            if (numberList.Contains(1))
            {
                Console.WriteLine("1 has found in the list.");
            }

            // Transforming Array to List
            string[] animalArray = new string[] { "dog", "cat", "horse", "cow" };
            List<string> animalList = new List<string>(animalArray);

            // Deleting all items
            animalList.Clear();

            // Assigning Class to List
            List<Countries> countryList = new List<Countries>();
            Countries country1 = new Countries { Name = "Turkey", Capital = "Ankara", Population = 80000000 };
            Countries country2 = new Countries { Name = "Germany", Capital = "Berlin", Population = 83000000 };
            countryList.Add(country1);
            countryList.Add(country2);
            countryList.Add(new Countries { Name = "France", Capital = "Paris", Population = 64000000 });

            foreach (Countries country in countryList)
            {
                Console.WriteLine("Country name: "+ country.Name);
                Console.WriteLine("Capital: "+ country.Capital);
                Console.WriteLine("Population: "+ country.Population);
                Console.WriteLine("--------------");
            }

            Console.ReadLine();
        }
    }

    class Countries
    {
        private string name;
        private string capital;
        private int population;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }
        public int Population
        {
            get { return population; }
            set { population = value; }
        }
    }
}
