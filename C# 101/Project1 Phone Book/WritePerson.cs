using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Phone_Book
{
    class WritePerson
    {
        public static void Write(List<People> personList)
        {
            foreach (People person in personList)
            {
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Surname: " + person.Surname);
                Console.WriteLine("Phone: " + person.Phone);
                Console.WriteLine("-------------------------");
            }
        }
    }
}
