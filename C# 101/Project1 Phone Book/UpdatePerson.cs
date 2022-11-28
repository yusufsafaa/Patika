using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Phone_Book
{
    class UpdatePerson
    {
        public static void Update(List<People> personList)
        {
            Console.Write("Please enter name or surname who you want to update: ");
            string updatedname = Console.ReadLine().ToLower();

            bool control = false;
            while (!control)
            {
                foreach (People person in personList)
                {
                    if (person.Name.ToLower() == updatedname)
                    {
                        Console.Write("Please enter current number of "+person.Name+": ");
                        string number = Console.ReadLine();
                        person.Phone = number;
                        control = true;
                        break;
                    }
                    else if (person.Name.ToLower() == updatedname)
                    {
                        Console.Write("Please enter current number of "+person.Surname+": ");
                        string number = Console.ReadLine();
                        person.Phone = number;
                        control = true;
                        break;
                    }
                }

                if (!control)
                {
                    Console.WriteLine(" There is no person data according to your request. Please, make a choice.");
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
                        Console.Write("Please enter name or surname who you want to update: ");
                        updatedname = Console.ReadLine().ToLower();
                    }
                }

            }
        }
    }
}
