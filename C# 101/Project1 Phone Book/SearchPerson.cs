using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Phone_Book
{
    class SearchPerson
    {
        public static void Search(List<People> personList)
        {
            Console.WriteLine("Please, choose type that you want to make search.");
            Console.WriteLine("To make search according to name or surname: (1)");
            Console.WriteLine("To make search according to phone number: (2)");
            int subprocess = int.Parse(Console.ReadLine());

            if (subprocess == 1)
            {
                Console.WriteLine("Please, enter name or surname who you seek: ");
                string searchedname = Console.ReadLine();

                foreach (People person in personList)
                {
                    if (person.Name.ToLower() == searchedname)
                    {
                        Console.WriteLine("Name: " + person.Name);
                        Console.WriteLine("Surname: " + person.Surname);
                        Console.WriteLine("Phone Number: " + person.Phone);
                        break;
                    }

                    else if (person.Surname.ToLower() == searchedname)
                    {
                        Console.WriteLine("Name: " + person.Name);
                        Console.WriteLine("Surname: " + person.Surname);
                        Console.WriteLine("Phone Number: " + person.Phone);
                        break;
                    }
                }
            }
            else if (subprocess == 2)
            {
                Console.WriteLine("Please, enter phone number who you seek: ");
                string searchednumber = Console.ReadLine();

                foreach (People person in personList)
                {
                    if (person.Phone == searchednumber)
                    {
                        Console.WriteLine("Name: " + person.Name);
                        Console.WriteLine("Surname: " + person.Surname);
                        Console.WriteLine("Phone Number: " + person.Phone);
                        break;
                    }
                }
            }
        }
    }
}
