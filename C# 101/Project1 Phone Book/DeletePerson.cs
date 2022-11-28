using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Phone_Book
{
    class DeletePerson
    {
        public static void Delete(List<People> personList)
        {
            Console.Write("Please enter name or surname who you want to delete: ");
            string deletedname = Console.ReadLine().ToLower();
            bool control = false;

            while (!control)
            {
                foreach (People person in personList)
                {
                    if (person.Name.ToLower() == deletedname)
                    {
                        Console.WriteLine(person.Name + " is being deleted, do you approve this?(y/n)");
                        char confirmation = char.Parse(Console.ReadLine());

                        if (confirmation == 'y')
                        {
                            personList.Remove(person);
                            Console.WriteLine(person.Name + " was deleted.");
                            control = true;
                            break;
                        }
                        else
                        {
                            control = true;
                        }
                    }

                    else if (person.Surname.ToLower() == deletedname)
                    {
                        Console.WriteLine(person.Name + " is being deleted, do you approve this?(y/n)");
                        char confirmation = char.Parse(Console.ReadLine());

                        if (confirmation == 'y')
                        {
                            personList.Remove(person);
                            Console.WriteLine(person.Surname + " was deleted.");
                            control = true;
                            break;
                        }
                        else
                        {
                            control = true;
                        }
                    }

                }

                if (!control)
                {
                    Console.WriteLine("There is no person data according to your request. Please, make a choice.");
                    Console.WriteLine("* To finish deleting : (1)");
                    Console.WriteLine("* To try again      : (2)");
                    int subprocess = int.Parse(Console.ReadLine());

                    if (subprocess == 1)
                    {
                        control = true;
                    }
                    else if (subprocess == 2)
                    {
                        control = false;
                        Console.Write("Please enter name or surname who you want to delete: ");
                        deletedname = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}
