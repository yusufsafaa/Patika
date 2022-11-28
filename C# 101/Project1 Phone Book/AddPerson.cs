using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Phone_Book
{
    class AddPerson
    {
        public static void Add(List<People> personList)
        {
            Console.Write("Please Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please Enter Phone Number: ");
            string phone = Console.ReadLine();


            Console.WriteLine("*********************");

            People person = new People { Name = name, Surname = surname, Phone = phone };
            Book.personList.Add(person);
        }
    }
}
