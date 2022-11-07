using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Yusuf Safa";
            employee1.Surname = "Köksal";
            employee1.No = 21011002;
            employee1.Department = "Computer Engineering";
            employee1.Write();

            Console.WriteLine("---------------------");

            Employee employee2 = new Employee("Ahmet Said", "Acer", 2103050, "Civil Engineering");
            employee2.Write();

            Console.ReadLine();
        }
    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int No;
        public string Department;


        // Constructor                                                          
        public Employee(string name, string surname, int no, string department) // Can't use any return type.  // It must  be defined as public  
        {                                                                       // It must be same name with class.
            this.Name = name;                                                   // If we trigger an object from a class, constructor runs before everything except STATIC constructor.
            this.Surname = surname;
            this.No = no;
            Department = department;        // We can write this way, too
        }

        public Employee() // If this constructor had not been written, there would be error in employee1.
        { 
        }

        public void Write()
        {
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Surname: " + Surname);
            Console.WriteLine("Employee No: " + No);
            Console.WriteLine("Employee Department: " + Department);
        }
    }
}
