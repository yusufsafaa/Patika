using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Phone_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1) To Add New Phone Number");
            Console.WriteLine("(2) To Delete an Existing Phone Number");
            Console.WriteLine("(3) To Update an Existing Phone Number");
            Console.WriteLine("(4) To List Phone Book");
            Console.WriteLine("(5) To Search");
            Console.WriteLine("(0) Quit");

            Console.WriteLine("**********************");
            Console.Write("Please enter the process you want: ");
            int process = int.Parse(Console.ReadLine());
            Console.WriteLine("**********************");
            Book book = new Book();

            bool control = true;
            while (control)
            {
                switch (process)
                {
                    case 1:
                        AddPerson.Add(Book.personList);
                        break;
                    
                    case 2:
                        DeletePerson.Delete(Book.personList);
                        break;
                    
                    case 3:
                        UpdatePerson.Update(Book.personList);
                        break;

                    case 4:
                        WritePerson.Write(Book.personList);
                        break;

                    case 5:
                        SearchPerson.Search(Book.personList);
                        break;

                    case 0:
                        control = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number!");
                        break;
                }


                if (control)
                {
                    Console.Write("If you want to make another process, please enter: ");
                    process = int.Parse(Console.ReadLine());
                    Console.WriteLine("**********************");
                }
            }

            Console.ReadLine();
        }
    }
}
